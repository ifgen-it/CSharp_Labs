using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Matrix
    {
        private double[,] data;
        public Matrix(int nRows, int nCols)
        {
            if (nRows <= 0 || nCols <= 0)
            {
                throw new MatrixException("Matrix was not constructed.Incorrect paremeters for constructor");
            }

            this.data = new double[nRows, nCols];
        }
        public Matrix(double[,] initData)
        {
            if (initData == null)
                throw new MatrixException("Matrix was not constructed. Null value in the paremeter");
            int nRows = initData.GetLength(0);
            int nCols = initData.GetLength(1);
            this.data = new double[nRows, nCols];
            for (int i = 0; i < nRows; i++)
            {
                for (int j = 0; j < nCols; j++)
                {
                    data[i, j] = initData[i, j];
                }
            }
        }
        public Matrix(Matrix other)
        {
            
            this.data = new double[other.Rows, other.Cols];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    data[i, j] = other[i, j];
                }
            }
        }

        public int Rows
        {
            get
            {
                return data.GetLength(0);
            }
        }
        public int Cols
        {
            get
            {
                return data.GetLength(1);
            }
        }

        public int? Size
        {
            get
            {
                if (this.Rows == this.Cols)
                {
                    return this.Rows;
                }
                else return null;
            }
        }

        public double this[int i, int j]
        {
            get
            {
                if (i < 0 || i >= this.Rows || j < 0 || j >= this.Cols)
                {
                    throw new MatrixException("Incorrect indexes of matrix: out of bounds");
                }
                return data[i, j];
            }
            set
            {
                if (i < 0 || i >= this.Rows || j < 0 || j >= this.Cols)
                {
                    throw new MatrixException("Incorrect indexes of matrix: out of bounds");
                }
                data[i, j] = value;
            }
        }


        public void Print()
        {
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    Console.Write("{0,-3} ",this[i,j]);
                }
                Console.WriteLine();
            }
        }

        public bool IsSquared()
        {
            if (this.Rows == this.Cols)
                return true;
            else
                return false;
        }

        public bool IsEmpty()
        {
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    if (this.data[i, j] != 0)
                        return false;
                }
            }
            return true;
        }

        public bool IsUnity()
        {
            if (this.Rows != this.Cols)
            {
                return false;
            }

            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    if (i == j)
                    {
                        if (this.data[i, j] != 1) return false;
                    }
                    else
                    {
                        if (this.data[i, j] != 0) return false;
                    }
                }
            }
            return true;

        }

        public bool IsDiagonal()
        {
            if (this.Rows != this.Cols)
            {
                return false;
            }

            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    if (i != j)
                    {
                        if (this.data[i, j] != 0) return false;
                    }
                }
            }
            return true;
        }

        public bool IsSymmetric()
        {
            if (this.Rows != this.Cols)
            {
                return false;
            }

            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = i + 1; j < this.Cols; j++)
                {
                    if (this.data[i, j] != this.data[j, i]) return false;
                }
            }
            return true;

        }

        public static Matrix operator+(Matrix m1, Matrix m2)
        {
            if(m1.Rows != m2.Rows || m1.Cols != m2.Cols)
            {
                throw new MatrixException("Cannot make addition. Matrixes has different dimensions");
            }

            Matrix m3 = new Matrix(m1.Rows, m1.Cols);
            for (int i = 0; i < m3.Rows; i++)
            {
                for (int j = 0; j < m3.Cols; j++)
                {
                    m3[i, j] = m1[i, j] + m2[i, j];
                }
            }
            return m3;

        }

        public static Matrix operator-(Matrix m1, Matrix m2)
        {
            if (m1.Rows != m2.Rows || m1.Cols != m2.Cols)
            {
                throw new MatrixException("Cannot make addition. Matrixes has different dimensions");
            }

            Matrix m3 = new Matrix(m1.Rows, m1.Cols);
            for (int i = 0; i < m3.Rows; i++)
            {
                for (int j = 0; j < m3.Cols; j++)
                {
                    m3[i, j] = m1[i, j] - m2[i, j];
                }
            }
            return m3;

        }

        public static Matrix operator*(Matrix m1, double d)
        {
            Matrix m2 = new Matrix(m1.Rows, m1.Cols);
            for (int i = 0; i < m2.Rows; i++)
            {
                for (int j = 0; j < m2.Cols; j++)
                {
                    m2[i, j] = m1[i, j] * d;
                }
            }
            return m2;
        }

        public static Matrix operator*(double d, Matrix m1)
        {
            return m1 * d;
        }

        public static Matrix operator*(Matrix m1, Matrix m2)
        {
            if (m1.Cols != m2.Rows )
            {
                throw new MatrixException("Cannot multiply matrixes. They not mathched for this operation: m1.Cols != m2.Rows.");
            }

            Matrix m3 = new Matrix(m1.Rows, m2.Cols);
            for (int i = 0; i < m3.Rows; i++)
            {
                for (int j = 0; j < m3.Cols; j++)
                {
                    //Multiplication
                    for (int k = 0; k < m1.Cols; k++)
                    {
                        m3[i, j] += m1[i, k] * m2[k, j];
                    }

                }
            }
            return m3;
        }

        public static explicit operator Matrix(double[,] arr)
        {
            return new Matrix(arr);
        }

        public Matrix Transpose()
        {
            Matrix m2 = new Matrix(this.Cols, this.Rows);
            for (int i = 0; i < m2.Rows; i++)
            {
                for (int j = 0; j < m2.Cols; j++)
                {
                    m2[i, j] = data[j, i];
                }
            }
            return m2;
        }

        public double Trace()
        {
            if (!this.IsSquared())
            {
                throw new MatrixException("Cannot evaluate trace of not square matrix");
            }
            double t = 0;
            for (int i = 0; i < this.Rows; i++)
            {
                t += data[i, i];
            }
            return t;
        }

        public override string ToString()
        {
            string res = "";
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    res += data[i, j];
                    if (i == Rows - 1 && j == Cols - 1) res += "";
                    else if (j == Cols - 1) res += ", ";
                    else res += " ";  
                }
            }
            return res;
        }

        public static Matrix GetUnity(int Size)
        {
            Matrix m1 = GetEmpty(Size);
            for (int i = 0; i < Size; i++)
            {
                m1[i, i] = 1;
            }
            return m1;
        }

        public static Matrix GetEmpty(int Size)
        {
            if (Size <= 0)
            {
                throw new MatrixException("Incorrect Size of matrix");
            }
            return new Matrix(Size, Size);
        }

        public static Matrix Parse(string s)
        {
            if (s == null)
                throw new FormatException("Cannot parse string that is null");
            string[] sRows = s.Split(',');
            int numRows = sRows.Length;
            int numCols = 0;
            Matrix m1 = null;

            for (int i = 0; i < numRows; i++)
            {
                string tempRow = sRows[i];
                string[] tempElems = tempRow.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (i == 0)
                {
                    numCols = tempElems.Length;
                    m1 = new Matrix(numRows, numCols);
                }
                else
                {
                    if (tempElems.Length != numCols)
                        throw new FormatException("Cannot parse: different count of elements in rows");
                }
                for (int j = 0; j < numCols; j++)
                {
                    double tempRes = 0;
                    bool res = double.TryParse(tempElems[j], NumberStyles.Any, new CultureInfo("en-US"), out tempRes);
                    if (res)
                    {
                        m1[i, j] = tempRes;
                    }
                    else
                    {
                        throw new FormatException("Cannot parse: incorrect value type of elements in string");
                    }
                    
                }
            }

            return m1;
        }
       
        public static bool TryParse(string s, out Matrix m)
        {
            m = null;
            try
            {
                m = Matrix.Parse(s);
            }
            catch
            {
                m = null;
            }
            if (m != null)
                return true;
            else
                return false;
        }

    }   // endMatrix

    class MatrixException : Exception
    {
        public MatrixException(string Msg) : base(Msg) { }

    }

}
