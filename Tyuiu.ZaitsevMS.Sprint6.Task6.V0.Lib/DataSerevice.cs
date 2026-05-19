using System.Collections.Generic;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZaitsevMS.Sprint6.Task6.V27.Lib
{
    public class DataService : ISprint6Task6V27
    {
        public string CollectTextFromFile(string text)
        {
            var result = new List<string>();

            using (var reader = new StringReader(text))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(new char[] { ' ', '\t', ',', '.', ';', ':', '!', '?' }, System.StringSplitOptions.RemoveEmptyEntries);
                    foreach (var word in words)
                    {
                        if (word.Contains("H"))
                            result.Add(word);
                    }
                }
            }

            return string.Join(" ", result);
        }
    }
}