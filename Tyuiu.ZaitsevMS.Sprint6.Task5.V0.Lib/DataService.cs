using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZaitsevMS.Sprint6.Task5.V0.Lib
{
    public class DataService : ISprint6Task5V0
    {
        public double[] LoadFromDataFile(string path)
        {
            var lines = File.ReadAllLines(path);

            var result = new List<double>();

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                // Нормализуем: заменяем запятую на точку для единого парсинга
                string normalized = line.Trim().Replace(',', '.');

                if (double.TryParse(normalized, NumberStyles.Any, CultureInfo.InvariantCulture, out double val))
                {
                    if (val > 0)
                        result.Add(val);
                }
            }

            return result.ToArray();
        }
    }
}