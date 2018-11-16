using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public struct mInfo
    {
        public int count;
        public int min;
        public int max;
    }

    partial class Program
    {
        struct MyStruct
        {
            int x;
            int y;
        }

        public static Type SelectType()
        {
            Console.WriteLine("2 - Select type from the list\n");

            Console.WriteLine(@"Select type from the list below:

        1 - uint
        2 - int
        3 - long
        4 - float
        5 - double
        6 - char
        7 - string
        8 - MyClass
        9 - MyStruct
        0 - Return to main menu

");
            Type t = null;
            bool exit;
            while (true)
            {
                exit = true;
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        t = typeof(uint);
                        break;
                    case '2':
                        t = typeof(int);
                        break;
                    case '3':
                        t = typeof(long);
                        break;
                    case '4':
                        t = typeof(float);
                        break;
                    case '5':
                        t = typeof(double);
                        break;
                    case '6':
                        t = typeof(char);
                        break;
                    case '7':
                        t = typeof(string);
                        break;
                    case '8':
                        t = typeof(Program);
                        break;
                    case '9':
                        t = typeof(MyStruct);
                        break;
                    case '0':
                        t = null;
                        break;
                    default:
                        exit = false;
                        break;
                }
                if (exit) break;
            }
            return t;
        }

        public static Type GetAppropriateType(string askType)
        {
            Type t = null;
            switch (askType)
            {
                case "char":
                    t = typeof(char);
                    break;
                case "int":
                    t = typeof(int);
                    break;
                case "long":
                    t = typeof(long);
                    break;
                case "float":
                    t = typeof(float);
                    break;
                case "double":
                    t = typeof(double);
                    break;
                case "string":
                    t = typeof(string);
                    break;
                default:
                    t = null;
                    break;
            }
            return t;
        }

        public static void ChangeConsoleParameters()   
        {
            bool exit = false;
            while (true)
            {

                Console.WriteLine("4 - Console parameters\n");
                const int MinCol = 0;
                const int MaxCol = 15;
                Console.WriteLine(@"Use number to choose color:
            0 - Black      
            1 - DarkBlue
            2 - DarkGreen
            3 - DarkCayan
            4 - DarkRed
            5 - DarkMagenta
            6 - DarkYellow
            7 - Gray
            8 - DarkGray
            9 - Blue
            10 - Green
            11 - Cayan
            12 - Red
            13 - Magenta
            14 - Yellow
            15 - White

");
                int BackColor = 0, ForeColor = 0;

                Console.WriteLine("Select number for background color: ");
                string TempBackColor = Console.ReadLine();
                Console.WriteLine("Select number for foreground color: ");
                string TempForeColor = Console.ReadLine();

                if (int.TryParse(TempBackColor, out BackColor) && int.TryParse(TempForeColor, out ForeColor))
                {
                                        
                    if (BackColor < MinCol || BackColor > MaxCol || ForeColor < MinCol || ForeColor > MaxCol)
                    {
                        Console.WriteLine("Typed numbers are out of range\nPress any key to continue..");
                    }
                    else if (BackColor == ForeColor)
                    {
                        Console.WriteLine("Background color and foreground color cannot be the same\nPress any key to continue..");
                    }
                    else
                    {
                        Console.BackgroundColor = (ConsoleColor)BackColor;
                        Console.ForegroundColor = (ConsoleColor)ForeColor;
                        Console.Clear();
                        Console.WriteLine("Colors changed. Press any key to continue..");
                        Console.ReadKey();
                        exit = true;
                    }
                }
                else
                {
                    Console.WriteLine("You typed not numeric values\nPress any key to continue..");
                }
                if (exit) break;
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static void ShowTypeInfo(Type t)
        {
            char SymValType = t.IsValueType ? '+' : '-';

            MemberInfo[] Members = t.GetMembers();
            MethodInfo[] Methods = t.GetMethods();
            FieldInfo[] Fields = t.GetFields();
            PropertyInfo[] Properties = t.GetProperties();
            

            string[] FieldsNames = new string[Fields.Length];
            for (int i = 0; i < Fields.Length; i++)
            {
                FieldsNames[i] = Fields[i].Name;
            }
            string sFieldsNames = String.Join(", ", FieldsNames);
            sFieldsNames = sFieldsNames.Equals("") ? "-" : sFieldsNames;

            string[] PropertiesNames = new string[Properties.Length];
            for (int i = 0; i < Properties.Length; i++)
            {
                PropertiesNames[i] = Properties[i].Name;
            }
            string sPropertiesNames = String.Join(", ", PropertiesNames);
            sPropertiesNames = sPropertiesNames.Equals("") ? "-" : sPropertiesNames;

            Console.WriteLine($@"Type info: {t}
    
    Value type:             {SymValType}
    Namespace:              {t.Namespace}
    Assembly:               {t.Assembly.GetName().Name}
    Number of members:      {Members.Length}
    Number of methods:      {Methods.Length}
    Number of properties:   {Properties.Length}
    Number of fields:       {Fields.Length}
    List of fields:         {sFieldsNames}
    List of properties:     {sPropertiesNames}
");
            Console.WriteLine($@"Type '1' for additional information about methods of type {t.Name}:
Type '0' to return into main menu:
");
            bool exit;
            while (true)
            {
                exit = true;
                switch (char.ToLower(Console.ReadKey(true).KeyChar))
                {
                    case '1':
                        ShowTypeMethodsInfo(t);
                        break;
                    case '0':
                        // Return to main menu
                        break;
                    default:
                        exit = false;
                        break;
                }
                if (exit) break;
            }
        }

        public static void ShowTypeMethodsInfo(Type t) 
        {
            MethodInfo[] Methods = t.GetMethods();
            string[] MethodsNames = new string[Methods.Length];
            for (int i = 0; i < Methods.Length; i++)
            {
                MethodsNames[i] = Methods[i].Name;
            }
            string sMethodsNames = String.Join(", ", MethodsNames);
            sMethodsNames = sMethodsNames.Equals("") ? "-" : sMethodsNames;

            Console.WriteLine($@"
    List of all methods:    {sMethodsNames}");

            Console.WriteLine($"\nMethods of type {t.Name}:\n");
            var Dic = new Dictionary<string, mInfo>();
            foreach (var meth in Methods)
            {
                if (Dic.ContainsKey(meth.Name))
                {

                    int ParamNum = meth.GetParameters().Length;
                    int Min = Dic[meth.Name].min;
                    int Max = Dic[meth.Name].max;
                    int Count = Dic[meth.Name].count + 1;
                    if (ParamNum < Min)
                        Min = ParamNum;
                    if (ParamNum > Max)
                        Max = ParamNum;
                    Dic[meth.Name] = new mInfo() { count = Count, min = Min, max = Max };
                }
                else
                {
                    int Min, Max;
                    Min = Max = meth.GetParameters().Length;
                    Dic[meth.Name] = new mInfo() { count = 1, min = Min, max = Max };
                }
            }
            string outMethod = "Method";
            string outParamsCount = "Parameters";
            string outOverloads = "Overloads";
            Console.WriteLine("{0,-30}{1,-15}{2,-10}",
                       outMethod, outParamsCount, outOverloads);
            for (int i = 0; i < 55; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            foreach (var p in Dic)
            {
                string parNum = p.Value.min.ToString();
                if (p.Value.min != p.Value.max)
                    parNum += ".." + p.Value.max;

                Console.WriteLine("{0,-30}{1,-15}{2,-10}",
                    p.Key, parNum, p.Value.count);
            }

            Console.WriteLine("\nPress any key to return back into menu");
            Console.ReadKey();

        }

        public static void ShowAllTypeInfo()
        {
            Console.WriteLine("1 - Common types information\n");

            Assembly myAsm = Assembly.GetExecutingAssembly();
            Type[] myAsmTypes = myAsm.GetTypes();
            Console.WriteLine("My assembly has {0} types:", myAsmTypes.Length);

            string[] myAsmTypesNames = new string[myAsmTypes.Length];
            for (int i = 0; i < myAsmTypes.Length; i++)
            {
                myAsmTypesNames[i] = myAsmTypes[i].Name;
            }
            string sMyAsmTypesNames = string.Join(", ", myAsmTypesNames);
            Console.WriteLine(sMyAsmTypesNames);

            // Referenced assemblies
            #region Properties init
            int refAsmsNum = 0;
            int allTypesNum = 0;
            int RefTypesCount = 0;
            int ValTypesCount = 0;
            int InterTypesCount = 0;

            Type MaxCntMethType = null;
            int MaxCntMethTypeNums = 0;

            MethodInfo MaxLenNameMeth = null;
            int MaxLenNameMethNum = 0;

            MethodInfo MaxCntParMeth = null;
            int MaxCntParMethNum = 0;
            #endregion

            Assembly[] refAssemblies = AppDomain.CurrentDomain.GetAssemblies();
            refAsmsNum = refAssemblies.Length;
            List<Type> allTypes = new List<Type>();
            
            foreach (Assembly Asm in refAssemblies)
            {
                allTypes.AddRange(Asm.GetTypes());                  
            }
            allTypesNum = allTypes.Count;

            foreach (var t in allTypes)
            {
                if (t.IsClass)
                {
                    RefTypesCount++;
                }
                if (t.IsValueType)
                {
                    ValTypesCount++;
                }
                if (t.IsInterface)
                {
                    InterTypesCount++;
                }
                //MaxCntMethType
                if(t.GetMethods().Length > MaxCntMethTypeNums)
                {
                    MaxCntMethType = t;
                    MaxCntMethTypeNums = t.GetMethods().Length;
                }

                //MaxLenNameMeth & MaxCntParMeth
                MethodInfo[] TempMethods = t.GetMethods();
                foreach (var m in TempMethods)
                {
                    if(m.Name.Length > MaxLenNameMethNum)
                    {
                        MaxLenNameMethNum = m.Name.Length;
                        MaxLenNameMeth = m;
                    }

                    //MaxCntParMeth
                    if(m.GetParameters().Length > MaxCntParMethNum)
                    {
                        MaxCntParMethNum = m.GetParameters().Length;
                        MaxCntParMeth = m;
                    }
                }
            }

            Console.WriteLine($@"
        Referenced assemblies:              {refAsmsNum}
        Ref assemblies sum types:           {allTypesNum}
        Referenced types:                   {RefTypesCount}
        Value types:                        {ValTypesCount}
        Interface types:                    {InterTypesCount}
        Max count methods type:             {MaxCntMethType.Name}
        Max length name method:             {MaxLenNameMeth.Name}
        Max count parameters method:        {MaxCntParMeth.Name}
 ");


            Console.WriteLine("\nPress any key to return back into menu");
            Console.ReadKey();
        }

        public static void ShowMenu()
        {
            Console.WriteLine(@"Information about types:

    1 - Common types information
    2 - Select type from the list
    3 - Input typename
    4 - Console parameters
    0 - Exit
    ");
       }

        public static void InputTypename()
        {
            Console.WriteLine("3 - Input typename\n");
            
            string askType = Console.ReadLine().ToLower();

            Type t1 = GetAppropriateType(askType);
            if (t1 != null)
            {
                ShowTypeInfo(t1);
            }
            else
            {
                Console.WriteLine("Your type was not recognized. Press any key to return back into menu");
                Console.ReadKey();
            }
        }
        
    }
}