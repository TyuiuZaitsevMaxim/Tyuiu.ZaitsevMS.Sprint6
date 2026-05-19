using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZaitsevMS.Sprint6.Task3.V19.Lib
{
    public class DataService : ISprint6Task3V19
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int lastCol = cols - 1;

            int[,] result = new int[rows, cols];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    result[i, j] = matrix[i, j];

            for (int i = 0; i < rows - 1; i++)
            {
                for (int k = 0; k < rows - 1 - i; k++)
                {
                    if (result[k, lastCol] > result[k + 1, lastCol])
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            int tmp = result[k, j];
                            result[k, j] = result[k + 1, j];
                            result[k + 1, j] = tmp;
                        }
                    }
                }
            }

            return result;
        }
    }
}