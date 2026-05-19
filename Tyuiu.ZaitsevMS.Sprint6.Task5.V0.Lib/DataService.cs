using System.Collections.Generic;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZaitsevMS.Sprint6.Task5.V29.Lib
{
    public class DataService : ISprint6Task5V29
    {
        public double[] LoadFromDataFile(string path)
        {
            var lines = File.ReadAllLines(path);
            var result = new List<double>();

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string normalized = line.Trim().Replace(',', '.');

                if (double.TryParse(normalized, NumberStyles.Any, CultureInfo.InvariantCulture, out double val))
                {
                    if (val >= 10)
                        result.Add(System.Math.Round(val, 3));
                }
            }

            return result.ToArray();
        }
    }
}