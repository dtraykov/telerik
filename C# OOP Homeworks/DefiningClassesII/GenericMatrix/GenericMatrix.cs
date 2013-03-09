using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMatrix
{
    public class GenericMatrix<T> where T : IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>, new()
    {
        private readonly int rows;
        private readonly int cols;
        private T[,] matrix;

        public GenericMatrix()
            : this(0, 0, new T[0, 0])
        {
        }

        public GenericMatrix(int rows, int cols)
            : this(rows, cols, new T[rows, cols])
        {
        }

        public GenericMatrix(int rows, int cols, T[,] matrix)
        {
            this.rows = rows;
            this.cols = cols;
            this.matrix = matrix;
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }
        }

        public T this[int row, int col]
        {
            get
            {
                if (row < 0 || row >= this.Rows || col < 0 || col >= this.Cols)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return this.matrix[row, col];
                }
            }

            set
            {
                if (row < 0 || row >= this.Rows || col < 0 || col >= this.Cols)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    this.matrix[row, col] = value;
                }
            }
        }

        public static GenericMatrix<T> operator +(GenericMatrix<T> leftMatrix, GenericMatrix<T> rightMatrix)
        {
            if ((leftMatrix.Rows != rightMatrix.Rows) || (leftMatrix.Cols != rightMatrix.Cols))
            {
                throw new FormatException("Adding (+) can't be applied on matrixes with diferent dimensions");
            }
            else
            {
                GenericMatrix<T> result = new GenericMatrix<T>(leftMatrix.Rows, leftMatrix.Cols);
                for (int row = 0; row < leftMatrix.Rows; row++)
                {
                    for (int col = 0; col < leftMatrix.Cols; col++)
                    {
                        result.matrix[row, col] = (dynamic)leftMatrix.matrix[row, col] + (dynamic)rightMatrix.matrix[row, col];
                    }
                }

                return result;
            }
        }

        public static GenericMatrix<T> operator -(GenericMatrix<T> leftMatrix, GenericMatrix<T> rightMatrix)
        {
            if ((leftMatrix.Rows != rightMatrix.Rows) || (leftMatrix.Cols != rightMatrix.Cols))
            {
                throw new FormatException("Substracting (-) can't be applied on matrixes with diferent dimensions");
            }
            else
            {
                GenericMatrix<T> result = new GenericMatrix<T>(leftMatrix.Rows, leftMatrix.Cols);
                for (int row = 0; row < leftMatrix.Rows; row++)
                {
                    for (int col = 0; col < leftMatrix.Cols; col++)
                    {
                        result.matrix[row, col] = (dynamic)leftMatrix.matrix[row, col] - (dynamic)rightMatrix.matrix[row, col];
                    }
                }

                return result;
            }
        }

        public static GenericMatrix<T> operator *(GenericMatrix<T> leftMatrix, GenericMatrix<T> rightMatrix)
        {
            if (leftMatrix.Cols != rightMatrix.Rows)
            {
                throw new FormatException("Multiplying  (*) can be applied on matrixes with dimensions like: Matrix one dim: ???xA matrix two dim: Ax??? ");
            }
            else
            {
                int rows = leftMatrix.Rows;
                int cols = rightMatrix.Cols;
                GenericMatrix<T> result = new GenericMatrix<T>(rows, cols);

                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        dynamic sum = 0;
                        for (int i = 0; i < cols; i++)
                        {
                            sum = sum + ((dynamic)leftMatrix.matrix[row, i] * (dynamic)rightMatrix.matrix[i, col]);
                        }

                        result.matrix[row, col] = sum;
                    }
                }

                return result;
            }
        }

        public static bool operator true(GenericMatrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if ((dynamic)matrix[row, col] == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool operator false(GenericMatrix<T> matrix)
        {
            return !true;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            for (int row = 0; row < this.Rows; row++)
            {
                for (int col = 0; col < this.Cols; col++)
                {
                    builder.Append(string.Format("{0,5}", this.matrix[row, col]));
                }

                builder.Append('\n');
            }

            return builder.ToString();
        }
    }
}
