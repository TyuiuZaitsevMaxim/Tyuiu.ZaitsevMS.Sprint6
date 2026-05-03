namespace Tyuiu.ZaitsevMS.Sprint6.Task3.V0.Lib
{
    public class DataService
    {
        public int GetCountZero(int[,] matrix)
        {
            int count = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
