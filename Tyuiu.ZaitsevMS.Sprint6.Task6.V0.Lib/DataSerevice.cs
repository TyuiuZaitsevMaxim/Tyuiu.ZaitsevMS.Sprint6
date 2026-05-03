using System.Collections.Generic;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZaitsevMS.Sprint6.Task6.V0.Lib
{
    public class DataService : ISprint6Task6V0
    {
        public string CollectTextFromFile(string text)
        {
            var result = new List<string>();
            using (var reader = new StringReader(text))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains("**"))
                        result.Add(line);
                }
            }
            return string.Join("\r\n", result);
        }
    }
}