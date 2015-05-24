﻿namespace Task8To10_Matrix
{
    using System;
    using System.Text;
    public class Matrix<T>    
        where T : struct , IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        //FIELDS
        private int rows;
        private int columns;
        private T[,] matrix;


        //PROPERTIES
        public int Rows
        {
            get { return rows; }
        }
        public int Columns
        {
            get { return columns; }
        }
        public T this[int row, int column]
        {
            get
            {
                if (row >= 0 && row < rows && column >= 0 && column < columns)
                {
                    return matrix[row, column];
                }
                else
                {
                    throw new ArgumentException(String.Format("Cell ({0}, {1}) is invalid.", row, column));
                }
            }
            set
            {
                if (row >= 0 && row < rows && column >= 0 && column < columns)
                {
                    matrix[row, column] = value;
                }
                else
                {
                    throw new ArgumentException(String.Format("Cell ({0}, {1}) is invalid.", row, column));
                }
            }
        }
        //CONSTRUCTORS

        public Matrix(int rows, int cols)
        {
            if (rows <= 0 || cols <= 0)
            {
                throw new ArgumentException("Matrix dimensions must be positive integers.");
            }

            this.rows = rows;
            this.columns = cols;
            this.matrix = new T[rows, cols];
        }

        public Matrix(T[,] value)
        {
            if (value == null || value.GetLength(0) == 0 || value.GetLength(1) == 0)
            {
                throw new ArgumentException("The two-dimensional initialization array must contain at least one item.");
            }

            this.rows = value.GetLength(0);
            this.columns = value.GetLength(1);
            matrix = (T[,])value.Clone();
        }

        //METHODS
        public void AddNumber(T element, int row, int col)
        {
            matrix[row, col] = element;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    sb.Append(matrix[i, j] + " ");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }


        //PREDEFINING OPERATORS
        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.rows != m2.rows || m1.columns != m2.columns)
            {
                throw new ArgumentException("Matrices must have the same dimensions.");
            }

            try
            {
                Matrix<T> result = new Matrix<T>(m1.rows, m1.columns);

                for (int row = 0; row < result.rows; row++)
                {
                    for (int col = 0; col < result.columns; col++)
                    {
                        checked
                        {
                            result[row, col] = (dynamic)m1[row, col] + m2[row, col];
                        }
                    }
                }

                return result;
            }
            catch (OverflowException ex)
            {
                throw new ArgumentException("Addition resulted in an overflow.", ex);
            }
        }

        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.rows != m2.rows || m1.columns != m2.columns)
            {
                throw new ArgumentException("Matrices must have the same dimensions.");
            }

            try
            {
                Matrix<T> result = new Matrix<T>(m1.rows, m1.columns);

                for (int row = 0; row < result.rows; row++)
                {
                    for (int col = 0; col < result.columns; col++)
                    {
                        checked
                        {
                            result[row, col] = (dynamic)m1[row, col] - m2[row, col];
                        }
                    }
                }

                return result;
            }
            catch (OverflowException ex)
            {
                throw new ArgumentException("Addition resulted in an overflow.", ex);
            }
        }
        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            if (first.Columns == second.Rows && (first.Rows > 0 && second.Columns > 0 && first.Columns > 0))
            {
                Matrix<T> final = new Matrix<T>(first.Rows, second.Columns);
                for (int i = 0; i < final.Rows; i++)
                {
                    for (int j = 0; j < final.Columns; j++)
                    {
                        final[i, j] = (dynamic)0;
                        for (int k = 0; k < first.Columns; k++)
                        {
                            checked
                            {
                                final[i, j] = final[i, j] + (dynamic)first[i, k] * second[k, j];
                            }
                        }
                    }
                }
                return final;
            }
            else
            {
                throw new ArgumentException("Row on the first matrix and col on the second matrix, are with different size, multiplication cannot be done.");
            }
        }

        public static Boolean operator false(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    if ((dynamic)matrix[i, j] == 0)
                    {
                        return false;
                        break;
                    }
                }
            }
            return true;
        }
        public static Boolean operator true(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    if ((dynamic)matrix[i, j] == 0)
                    {
                        return false;
                        break;
                    }
                }
            }
            return true;
        }
    }
    }
}
