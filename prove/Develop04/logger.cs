using System;
using System.IO;

public static class Logger
{
    private const string LogFileName = "log.txt";

    public static void Log(string message)
    {
        using (StreamWriter writer = File.AppendText(LogFileName))
        {
            writer.WriteLine($"{DateTime.Now}: {message}");
        }
    }

    public static void LoadLog()
    {
        if (File.Exists(LogFileName))
        {
            string[] logLines = File.ReadAllLines(LogFileName);
            Console.WriteLine("\nLog File Activity:");
            foreach (string line in logLines)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("\nLog File is empty.");
        }

        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }
}
