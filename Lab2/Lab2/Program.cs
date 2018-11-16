using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    partial class Program
    {
        private static Dictionary<string, Matrix> mBase;

        static void Main(string[] args)
        {
            #region test1
            //Console.WriteLine("begin");
            //double[,] Arr1 = new double[4, 6];

            //for (int i = 0; i < Arr1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < Arr1.GetLength(1); j++)
            //    {
            //        Console.Write(Arr1[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            //storage of matixes
            mBase = new Dictionary<string, Matrix>();

            Console.WriteLine("Welcome to the Matrix!");
            ShowIntro();
            bool exit = false;
            while (true)
            {
                exit = false;
                try
                {
                    #region test2
                    /*
                    Matrix m1 = new Matrix(2, 3);
                    double[,] ar1 = new double[5, 5];

                    Random rnd = new Random();
                    for (int i = 0; i < ar1.GetLength(0); i++)
                    {
                        for (int j = 0; j < ar1.GetLength(1); j++)
                        {

                            ar1[i, j] = i;

                        }
                    }
                    Matrix m2 = (Matrix)ar1;
                    Console.WriteLine("Matrix m2:\nRows: {0}\nCols: {1}\nSize: {2}",
                        m2.Rows, m2.Cols, m2.Size);
                    Console.WriteLine();
                    Console.WriteLine("m2 is squared: " + m2.IsSquared() + "\n");
                    Console.WriteLine("m2 is empty: " + m2.IsEmpty() + "\n");
                    Console.WriteLine("m2 is unity: " + m2.IsUnity() + "\n");
                    Console.WriteLine("m2 is diagonal: " + m2.IsDiagonal() + "\n");
                    Console.WriteLine("m2 is symmetric: " + m2.IsSymmetric() + "\n");

                    m2.Print();

                    Matrix m3 = new Matrix(5, 5);
                    for (int i = 0; i < m3.Rows; i++)
                    {
                        for (int j = 0; j < m3.Cols; j++)
                        {
                            m3[i, j] = j;
                        }
                    }
                    Console.WriteLine();
                    m3.Print();

                    double t = m3.Trace();

                    Console.WriteLine("Trace: " + t);

                    Console.WriteLine("m3:" + m3.ToString() + "END");

                    Matrix m4 = Matrix.GetUnity(3);

                    m4.Print();

                    string srcM = "   11   10 14    , 7.2 8 6, 5 4.9 3";
                    Console.WriteLine("This string will parse into Matrix:\n" + srcM + "\n");

                    bool res = Matrix.TryParse(srcM, out Matrix m5);
                    Console.WriteLine();

                    if(res)
                        m5.Print();
                    else
                        Console.WriteLine("Cannot parse matrix");
                    */
                    #endregion

                    Console.Write("\n>");
                    string sInput = Console.ReadLine().Trim();
                    switch (sInput)
                    {
                        case "help":
                            Console.Clear();
                            ShowIntro();
                            break;

                        case "exit":
                            exit = true;
                            Console.Write("Good bye! Press any key to exit..");
                            break;

                        case "show":
                            PrintMBase();
                            break;

                        default:
                            if (ParseInput(sInput))
                            {

                            }
                            else
                            {
                                Console.WriteLine("Incorrect command");
                            }

                            break;
                    }
                }
                catch (MatrixException e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
                if (exit) break;
            }

            Console.ReadKey();
        }
    }
}
