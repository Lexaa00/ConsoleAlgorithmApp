# ConsoleAlgorithmApp

# Optimal Binary Classification

This C# program finds the **optimal threshold** for a binary classification problem.  
Given a list of scores and their corresponding binary labels (`0` or `1`), it calculates the threshold that **maximizes the number of correctly classified elements**.

## How it works

- The program identifies all **unique scores** from the input list.
- For each score, it considers it as a potential **threshold**.
- Elements with a score **below the threshold** are classified as `0`, others as `1`.
- The threshold that results in the **highest number of correct predictions** is returned.

## Example

```csharp
List<int> scores = new List<int> { 2, 3, 5, 7, 11 };
string labels = "00111";

int result = Result.getOptimalClassification(scores, labels);
Console.WriteLine(result); // Output: 5
