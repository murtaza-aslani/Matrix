using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    class Program
    {
        static void Main()
        {
            // تعریف ماتریس
            double[,] matrix = new double[,] { { 1, 2 }, { 3, 4 } };

            // محاسبه دیترمینانت
            double determinant = CalculateDeterminant(matrix);

            // چاپ نتیجه
            Console.WriteLine("Determinant: " + determinant);
            Console.ReadLine();
        }

        static double CalculateDeterminant(double[,] matrix)
        {
            double determinant = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            return determinant;
        }
    }
}
