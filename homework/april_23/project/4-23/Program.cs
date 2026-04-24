using System;
using System.IO;

class Program
{
    static void Main()
    {
        string specialFilePath = GetValidFilePath("What is the file path for today's special?");
        string logFilePath = GetValidFilePath("What is the file path for the fishmonger's log?");

        Console.WriteLine("Where do you want to save the result?");
        string outputPath = Console.ReadLine();

        // Read special fish name
        string specialName = File.ReadAllText(specialFilePath).Trim().ToLower();

        // Read log file lines
        string[] fishLog = File.ReadAllLines(logFilePath);

        int specialCount = 0;
        int totalCount = fishLog.Length;

        // Count occurrences of the special fish
        foreach (string fish in fishLog)
        {
            if (fish.Trim().ToLower() == specialName)
            {
                specialCount++;
            }
        }

        // Prepare output text
        string output = 
            $@"Today's special is {specialName}
Total {specialName} caught: {specialCount}
Total fish caught: {totalCount}";

        // Write to output file
        try
        {
            File.WriteAllText(outputPath, output);
            Console.WriteLine("File written successfully!");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error writing file: " + e.Message);
        }
    }

    // Method to repeatedly ask for a valid file path
    static string GetValidFilePath(string prompt)
    {
        while (true)
        {
            Console.WriteLine(prompt);
            string path = Console.ReadLine();

            try
            {
                // Try to open file to confirm it exists
                using (FileStream fs = File.OpenRead(path))
                {
                    return path;
                }
            }
            catch
            {
                Console.WriteLine("File not found. Please try again.");
            }
        }
    }
}