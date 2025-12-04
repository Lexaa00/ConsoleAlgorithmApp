using System;
using System.Collections.Generic;

class Result
{
    public static int getOptimalClassification(List<int> scores, string labels)
    {
        int n = scores.Count;
        List<int> uniqueScores = new List<int>();

        for (int i = 0; i < n; i++)
            if (!uniqueScores.Contains(scores[i]))
                uniqueScores.Add(scores[i]);

        uniqueScores.Sort();

        int maxCorrect = 0;

        foreach (var threshold in uniqueScores)
        {
            int correctCount = 0;

            for (int i = 0; i < n; i++)
            {
                string predictedLabel = scores[i] < threshold ? "0" : "1";
                string actualLabel = labels[i].ToString();

                if (predictedLabel == actualLabel)
                    correctCount++;
            }

            if (correctCount > maxCorrect)
                maxCorrect = correctCount;
        }

        return maxCorrect;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        List<int> scores = new List<int> { 2, 3, 5, 7, 11 };
        string labels = "00111";

        int result = Result.getOptimalClassification(scores, labels);

        Console.WriteLine(result);

        Console.ReadKey();
    }
}

