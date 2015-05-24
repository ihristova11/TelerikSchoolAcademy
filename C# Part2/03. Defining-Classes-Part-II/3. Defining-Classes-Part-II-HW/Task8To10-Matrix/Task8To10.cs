namespace Task8To10_Matrix
{
    using System;
    public class Task8To10
    {
        static void Main()
        {
            //CREATING TWO MATRICES
            Matrix<int> mat1 = new Matrix<int>(3, 5);
            Matrix<int> mat2 = new Matrix<int>(3, 5);

            //FILLING THE MATRICES WITH NUMBERS
            for (int i = 0; i < mat1.Rows; i++)
            {
                for (int j = 0; j < mat1.Columns; j++)
                {
                    mat1.AddNumber(i + j, i, j);
                }
            }
            for (int i = 0; i < mat1.Rows; i++)
            {
                for (int j = 0; j < mat1.Columns; j++)
                {
                    mat2[i, j] = i + j;
                }
            }

            //PRINTING
            Console.WriteLine(mat1.ToString());
            Console.WriteLine(mat2.ToString());
                      
            Console.WriteLine((mat1 + mat2).ToString());
            Console.WriteLine((mat1 - mat2).ToString());
            Console.WriteLine(mat1==mat2);
            
        }
        }
    }
}
