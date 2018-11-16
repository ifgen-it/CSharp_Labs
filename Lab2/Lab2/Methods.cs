using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    partial class Program
    {
        public static void ShowIntro()
        {
            Console.WriteLine("\n====== Intro ======\n");
            Console.WriteLine("In this program you can make evaluations with matrixes.\n" +
                "To make any operation use corresponding command\nor help-command to show all commands.\n" +
                "\n" +
                "General commands:\n\n" +
                "help - show this Intro with all commands\n" +
                "exit - exit of the program\n" +
                "show - show all matrixes in memory\n" +
                "\n" +
                "Commands for creation matrixes:\n\n" +
                "m1 = 1 2 3, 4 5 6, 7 8 9 - create matrix (3 x 3)\n" +
                "m2 = 11 - create matrix (1 x 1)\n" +
                "m3 = 1.1 2.2 3.3, 4 5 6 - create matrix (2 x 3)\n" +
                "m4 = m1 + m3 - addition of matrixes, which must have equal dimensions\n" +
                "m4 = m1 - m3 - subtraction of matrixes, which must have equal dimensions\n" +
                "m4 = m1 * m3 - multiplication of matixes, number of columns 1st matrix\n" +
                "               must be equal to number of rows 2nd matrix\n" +
                "m4 = 6.6 * m3 - multiplication matrix and double value number\n" +
                "\n" +
                "Get properties of matrix:\n\n" +
                "m1.Size\n" +
                "m1.Rows\n" +
                "m1.Cols\n" +
                "m1.IsSquared\n" +
                "m1.IsEmpty\n" +
                "m1.IsUnity\n" +
                "m1.IsDiagonal\n" +
                "m1.IsSymmetric\n" +
                "\n" +
                "Additional commands:\n\n" +
                "m1.Transpose\n" +
                "m1.Trace\n" +
                "m1.ToString\n");
        }

        public static bool ParseInput(string sInput)
        {
            try
            {

                if (sInput.Contains("="))
                {
                    string[] terms = sInput.Split('=');
                    if (terms.Length != 2) return false;

                    string lValue = terms[0].Trim();
                    if (lValue.Contains(' '))
                        return false;

                    string rValue = terms[1].Trim();

                    // Addition
                    if (rValue.Contains('+'))
                    {
                        string[] AddTerms = rValue.Split('+');
                        if (AddTerms.Length != 2) return false;

                        if (mBase.ContainsKey(AddTerms[0].Trim()) && mBase.ContainsKey(AddTerms[1].Trim()))
                        {
                            Matrix m3 = mBase[AddTerms[0].Trim()] + mBase[AddTerms[1].Trim()];
                            AddToBase(lValue, m3);
                            Console.WriteLine("matrix calculation completed..");
                            return true;
                        }
                        else return false;

                    }
                    // Subtraction
                    else if (rValue.Contains('-'))
                    {
                        string[] AddTerms = rValue.Split('-');
                        if (AddTerms.Length != 2) return false;

                        if (mBase.ContainsKey(AddTerms[0].Trim()) && mBase.ContainsKey(AddTerms[1].Trim()))
                        {
                            Matrix m3 = mBase[AddTerms[0].Trim()] - mBase[AddTerms[1].Trim()];
                            AddToBase(lValue, m3);
                            Console.WriteLine("matrix calculation completed..");
                            return true;
                        }
                        else return false;

                    }
                    // Multiplication
                    else if (rValue.Contains('*'))
                    {
                        string[] AddTerms = rValue.Split('*');
                        if (AddTerms.Length != 2) return false;

                        if (mBase.ContainsKey(AddTerms[0].Trim()) && mBase.ContainsKey(AddTerms[1].Trim()))
                        {
                            Matrix m3 = mBase[AddTerms[0].Trim()] * mBase[AddTerms[1].Trim()];
                            AddToBase(lValue, m3);
                            Console.WriteLine("matrix calculation completed..");
                            return true;
                        }
                        else if (double.TryParse(AddTerms[0].Trim(),out double DblTerm0) )
                        {
                            Matrix m3 = DblTerm0 * mBase[AddTerms[1].Trim()];
                            AddToBase(lValue, m3);
                            Console.WriteLine("matrix calculation completed..");
                            return true;
                        }
                        else if (double.TryParse(AddTerms[1].Trim(), out double DblTerm1))
                        {
                            Matrix m3 = mBase[AddTerms[0].Trim()] * DblTerm1;
                            AddToBase(lValue, m3);
                            Console.WriteLine("matrix calculation completed..");
                            return true;
                        }
                        else return false;

                    }
                    
                    else
                    {
                        // rValue = string of Matrix
                        if (Matrix.TryParse(rValue, out Matrix m))
                        {
                            AddToBase(lValue, m);
                            Console.WriteLine("matrix created ({0} X {1})..", m.Rows, m.Cols);
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    string lValue = sInput.Trim();
                    if (lValue.Contains(' ')) return false;

                    if (lValue.Contains('.'))
                    {
                        string[] terms = sInput.Split('.');
                        if (terms.Length != 2) return false;

                        string matrixName = terms[0].Trim();
                        if (matrixName.Contains(' ')) return false;
                        if (mBase.ContainsKey(matrixName) == false) return false;

                        string matrixMethod = terms[1].Trim().ToLower();

                        switch (matrixMethod)
                        {
                            case "issquared":
                                Console.WriteLine(mBase[matrixName].IsSquared());
                                return true;
                            case "isempty":
                                Console.WriteLine(mBase[matrixName].IsEmpty());
                                return true;
                            case "isunity":
                                Console.WriteLine(mBase[matrixName].IsUnity());
                                return true;
                            case "isdiagonal":
                                Console.WriteLine(mBase[matrixName].IsDiagonal());
                                return true;
                            case "issymmetric":
                                Console.WriteLine(mBase[matrixName].IsSymmetric());
                                return true;
                            case "size":
                                Console.WriteLine(mBase[matrixName].Size);
                                return true;
                            case "rows":
                                Console.WriteLine(mBase[matrixName].Rows);
                                return true;
                            case "cols":
                                Console.WriteLine(mBase[matrixName].Cols);
                                return true;
                            case "transpose":
                                mBase[matrixName] = mBase[matrixName].Transpose();
                                Console.WriteLine("matrix transposed..");
                                return true;
                            case "trace":
                                Console.WriteLine(mBase[matrixName].Trace());
                                return true;
                            case "tostring":
                                Console.WriteLine(mBase[matrixName].ToString());
                                return true;
                            default:
                                return false;
                        }
                    }
                    else if (mBase.ContainsKey(lValue))
                    {
                        mBase[lValue].Print();
                        return true;
                    }
                    else
                        return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return false;
            }

        }

        public static void AddToBase(string lValue, Matrix m)
        {
            mBase[lValue] = new Matrix(m);
        }

        public static void PrintMBase()
        {
            if (mBase == null || mBase.Count == 0)
            {
                Console.WriteLine("There is no matrixes in memory");
                return;
            }
            Console.WriteLine("\nAll matrixes:");
            foreach(var matrix in mBase)
            {
                Console.WriteLine("\n" + matrix.Key + ":");
                matrix.Value.Print();
            }
        }
    }
}
