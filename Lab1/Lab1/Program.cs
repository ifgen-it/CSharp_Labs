using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Lab1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            bool exit;
            while (true)
            {
                Console.Clear();
                ShowMenu();
                exit = false;

                switch (char.ToLower(Console.ReadKey(true).KeyChar))
                {
                    case '1':
                        ShowAllTypeInfo(); 
                        break;
                    case '2':
                        Type t = SelectType();
                        if (t != null)
                        {
                            Console.WriteLine($"Selected typename: {t.Name}\n");
                            ShowTypeInfo(t);
                        }
                        break;
                    case '3':
                        InputTypename();   
                        break;
                    case '4':
                        ChangeConsoleParameters(); 
                        break;
                    case '0':
                        Console.WriteLine("0 - Exit\n");
                        exit = true;
                        break;
                    default:
                        break;
                }
                if (exit) break;
            }
            Console.WriteLine("End of program. Good bye!");
            Console.ReadKey();
        } 
    }
}
