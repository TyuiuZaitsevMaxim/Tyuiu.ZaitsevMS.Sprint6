using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZaitsevMS.Sptint6.Task7.V0.Lib
{
    public class DataService : ISprint6Task7V0
    {
        public int[,] GetMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    result[i, j] = (j == 2 && matrix[i, j] == 0) ? 1 : matrix[i, j];

            return result;
        }

        public int[,] LoadFromCsv(string path)
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
                    matrix[i, j] = int.Parse(parts[j].Trim());
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