// FileHelper.cs
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class FileHelper
{
    private const string FilePath = "deskQuotes.json";

    public static void SaveQuote(DeskQuote quote)
    {
        try
        {
            string json = JsonConvert.SerializeObject(quote);

            // Check if the file exists
            if (!File.Exists(filePath))
            {
                // Create the file if it doesn't exist
                using (FileStream fs = File.Create(filePath))
                {
                    // No need to write anything initially
                }
            }

            using (StreamWriter writer = File.AppendText(FilePath))
            {
                writer.WriteLine(json);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error while saving quote: {ex.Message}");
        }
    }

    public static List<DeskQuote> LoadQuotes()
    {
        List<DeskQuote> quotes = new List<DeskQuote>();

        try
        {
            if (File.Exists(FilePath))
            {
                using (StreamReader reader = File.OpenText(FilePath))
                {
                    string json;
                    while ((json = reader.ReadLine()) != null)
                    {
                        DeskQuote quote = JsonConvert.DeserializeObject<DeskQuote>(json);
                        quotes.Add(quote);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error while loading quotes: {ex.Message}");
        }

        return quotes;
    }
}
