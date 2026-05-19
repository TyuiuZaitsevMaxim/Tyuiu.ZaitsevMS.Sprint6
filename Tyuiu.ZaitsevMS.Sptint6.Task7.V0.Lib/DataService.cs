using System.Collections.Generic;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZaitsevMS.Sprint6.Task7.V3.Lib
{
    public class DataService : ISprint6Task7V3
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path)
                .Where(l => !string.IsNullOrWhiteSpace(l))
                .ToArray();

            int rows = lines.Length;
            int cols = lines[0].Split(',').Length;
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] parts = lines[i].Split(',');
                for (int j = 0; j < cols; j++)
                {
                    int val = int.Parse(parts[j].Trim());
                    if (j == 0 && val % 2 == 0)
                        matrix[i, j] = -1;
                    else
                        matrix[i, j] = val;
                }
            }

            return matrix;
        }

        public void SaveToCsv(string path, int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            var lines = new List<string>();

            for (int i = 0; i < rows; i++)
            {
                var row = new List<string>();
                for (int j = 0; j < cols; j++)
                    row.Add(matrix[i, j].ToString());
                lines.Add(string.Join(",", row));
            }

            File.WriteAllLines(path, lines);
        }
    }
}