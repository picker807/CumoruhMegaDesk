
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MegaDesk_Picker
{
public class FileHandler
{
    private const string filePath = "..\\..\\quotes.json";

        public void SaveQuote(DeskQuote quote)
        {
            try
            {
                List<DeskQuote> quotes;

                if (File.Exists(filePath))
                {
                    // Read the existing JSON content from the file
                    string existingJson = File.ReadAllText(filePath);

                    // Deserialize the JSON content into a list of DeskQuotes
                    quotes = JsonConvert.DeserializeObject<List<DeskQuote>>(existingJson);
                }
                else
                {
                    // If the file doesn't exist, create an empty list
                    quotes = new List<DeskQuote>();
                }

                // Add the new quote to the list
                quotes.Add(quote);

                // Serialize the updated list to JSON
                string updatedJson = JsonConvert.SerializeObject(quotes);

                // Write the updated JSON content back to the file
                File.WriteAllText(filePath, updatedJson);

                MessageBox.Show("Quote saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while saving quote: {ex.Message}");
            }
        }
    

        public List<DeskQuote> LoadQuotes()
        {
            List<DeskQuote> quotes = new List<DeskQuote>();

            try
            {
                if (File.Exists(filePath))
                {
                    // Read the entire JSON content from the file
                    string json = File.ReadAllText(filePath);

                    // Deserialize the JSON into a list of DeskQuote objects
                    quotes = JsonConvert.DeserializeObject<List<DeskQuote>>(json);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while loading quotes: {ex.Message}");
            }
           // foreach (DeskQuote quote in quotes)
           // {
           //     MessageBox.Show(quote.CustomerName.ToString(), quote.TotalPrice.ToString());
           // }
            return quotes;
        }
    }
}