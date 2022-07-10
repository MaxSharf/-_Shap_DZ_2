using System;
using System.Text;


namespace С_Shap_DZ_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program1();
            //Program2();
            //Program3();
            //Program4();
            Program5();
            //Program6();
            //Program7();
            Console.OutputEncoding = Encoding.Unicode;
            Console.ReadKey(true);
        }
        static Random random = new Random();

        

            public static int EnterInt32(string prompt)
            {
                while (true)
                {
                    Console.Write(prompt);
                    string str = Console.ReadLine();
                    if (int.TryParse(str, out int value))
                    {
                        return value;
                    }
                    Console.WriteLine("\t\tError!!!");
                }
            }

            static void Program1()
            {
                int n = 5;
                int[] Data = new int[n];
                int i = 0;
                int j = 0;
                int min = 0;
                Console.WriteLine("Enter 5 digits array:");
                while (i < n)
                {
                    Data[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    i++;
                }
                for (i = 0; i < n; i++)
                {
                    Console.WriteLine(Data[i]);
                }
                Array.Sort(Data);
                int max = int.MinValue;
                foreach (int a in Data)
                {
                    if (a > max)
                    {
                        max = a;

                    }
                }
                Console.WriteLine($"Max:{max}");

                int minimum = int.MaxValue;
                foreach (int b in Data)
                {
                    if (b < minimum)
                    {
                        minimum = b;
                    }
                }
                Console.WriteLine($"Min:{minimum}");

                int dabl = 0;

                for (i = 0; i < Data.Length; i++)
                    if (Data[i] % 2 == 0)
                    {
                        dabl += Data[i];
                    }

                Console.WriteLine($"Dabl:{dabl}");


                int summ = 0;
                for (i = 0; i < Data.Length; i++)
                    summ += Data[i];
                Console.WriteLine($"Summ:{summ}");
                //--------------------------------------
                //--------------------------------------
                Random rnd = new Random();
                double[,] arr = new double[3, 4];
                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        arr[i, j] = rnd.NextDouble() * 100;
                        Console.WriteLine(arr[i, j]);
                    }
                    Console.WriteLine();
                }

                double maximum = double.MinValue;
                foreach (double c in arr)
                {
                    if (c > maximum)
                    {
                        maximum = c;

                    }
                }
                Console.WriteLine($"Max:{maximum}");

                double minimumm = double.MaxValue;
                foreach (double d in arr)
                {
                    if (d < minimumm)
                    {
                        minimumm = d;
                    }
                }
                Console.WriteLine($"Min:{minimumm}");

                double dabll = 0;

                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        if (arr[i, j] % 2 == 0)

                            dabll += arr[i, j];

                    }
                }
                Console.WriteLine($"Dabl:{dabll}");

                double summm = 0;
                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        summm += arr[i, j];
                    }
                }
                Console.WriteLine($"Summ:{summm}");

           
double sumstolb = 0;
                if (j % 2 != 0)
                {
                    for (i = 0; i < 3; i++)
                    {
                        sumstolb += arr[i, j];
                    }
                }
                Console.WriteLine($"Sum nechetnih stolb:{sumstolb}");
            }

    static void Program2()
            {
            // Console.Write("Введите конец диапазона от 1 до : ");
            //int end = int.Parse(Console.ReadLine());
            //int j = 1;
            //for (int i = 1; i <= end; i += j)
            //{
            //    Console.Write("{0} ", i);
            //    j = i - j;
            //}
            int size = 5;
            int[,] arr = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                arr[i,j] = random.Next(-100, 100);
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("{0 , 7}", arr[i, j]);
                }
                Console.WriteLine();
            }
            int sum, minX = 0, maxX = 0, minY = 0, maxY= 0;
            int min = arr[0, 0];
            int max = arr[0, 0];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if(min > arr[i, j])
                    {
                        min = arr[i, j];
                        minX = j;
                        minY = i;
                    }
                    if(max < arr[i, j])
                    {
                        max = arr[i, j];
                        maxX =j;
                        maxY = i;
                    }



                }

            }
  
            Console.WriteLine($" min index X({minX}),\n min index Y({minY}),\n max index X({maxX}),\n max index Y({maxY}).");

        }




        static void Program3()
        {
            const string alfabet = "АБВГДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЪЮЯ";
            Console.Write("Введіть текст: ");
            var text = Console.ReadLine();
            Console.Write("Введіть ключ: ");
            var k = Convert.ToInt32(Console.ReadLine());

            var fullAlfabet = alfabet + alfabet.ToLower();
            var letterQty = fullAlfabet.Length;
            var retVal = "";
            for (int i = 0; i < text.Length; i++)
            {
                var c = text[i];
                var index = fullAlfabet.IndexOf(c);
                if (index < 0)
                {
                    retVal += c.ToString();
                }
                else
                {
                    var codeIndex = (letterQty + index + k) % letterQty;
                    retVal += fullAlfabet[codeIndex];
                }
            }

  
        Console.WriteLine("Введене повідомлення : {0}", text);
            Console.WriteLine("Розшифроване повідомлення : {0}", retVal);
            //Console.ReadLine();



        }
        static void Fill2D(double[,] arr, double size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    arr[i, j] = random.Next(-50, 100);
            }

        }
        static void Print2D(double[,] arr, double size)
        {
            Console.WriteLine("--------Виведення матриці----------");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("{0 , 7}", arr[i, j]);
                }
                Console.WriteLine();
            }


        }

        static void MnoginaNaChislo(double[,] arr , double size , int chislo)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                   arr[i, j] *= chislo;
                }
            }
            
        }


        static void MatrixSum(double[,] arr1, double[,] arr2 , int size)
        {
            double[,] arr3 = new double[size, size];

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    arr3[row, col] = arr1[row, col] + arr2[row, col];
                }
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("{0 , 7}", arr3[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void MatrixMno(double[,] arr1, double[,] arr2, int size)
        {
            double[,] arr3 = new double[size, size];

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    arr3[row, col] = arr1[row, col] * arr2[row, col];
                }
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("{0 , 7}", arr3[i, j]);
                }
                Console.WriteLine();
            }
        }


        static void Program4()
        {
            // string a1 = "1", a2 = "2", a3 = "3";
            int size;
         

            size = EnterInt32("Введіть розмір масива-> ");

            double[,] arr1 = new double[size, size];
            double[,] arr2 = new double[size, size];

            Fill2D(arr1, size);
            Print2D(arr1, size);
            Fill2D(arr2, size);
            Print2D(arr2, size);


            //Console.WriteLine("Виберіть операцію : \n  1 - Помножити матрицю на число \n  2 - Множення матриць \n  3 - Добуток матриць");
            //int a = EnterInt32("Виберіть операцію : \n  1 - Помножити матрицю на число \n  2 - Множення матриць \n  3 - Добуток матриць  \n");

            int n = EnterInt32("\nВведіть число на яке хочете помножити -> ");
            MnoginaNaChislo(arr1, size , n);
            Print2D(arr1, size);

            Console.WriteLine("--------------2 Завдання -----------------");
            MatrixSum(arr1,arr2, size);
            Console.WriteLine("--------------3 Завдання -----------------");
            MatrixMno(arr1, arr2, size);
        }




        static void Program5()
        {
            int k = 2;
            int? Result = null;
            string? ArithmeticExpretion = null;
            Console.Write("Enter arithmetic expression: ");
            ArithmeticExpretion = Console.ReadLine();
            string[] subs = ArithmeticExpretion.Split('-', '+');
            int[] ArrayDigit = new int[ArithmeticExpretion.Length + 10];
            Result = int.Parse(subs[0]);
            for (int i = 1; i < subs.Length; i++)
            {
                ArrayDigit[k] = int.Parse(subs[i]);
                k += 2;
            }
            for (int i = 1; i < ArithmeticExpretion.Length; i++)
            {
                if (ArithmeticExpretion[i] == '+')
                {
                    Result += ArrayDigit[i + 1];
                }
                else if (ArithmeticExpretion[i] == '-')
                {
                    Result -= ArrayDigit[i + 1];
                }
            }
            Console.WriteLine($"Result {Result}");
        }



        static void Program7()
        {
            int AmountOfLine = 0;
            StringBuilder stringBuilder = new StringBuilder();
            int CounterPeplace = 0;
            Console.Write("Enter word for replace: ");
            string? WordForReplace = Console.ReadLine();
            Console.Write("Enter amount of line: ");
            AmountOfLine = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter text: ");
            for (int i = 0; i < AmountOfLine; i++)
            {
                string? Temp = Console.ReadLine();
                stringBuilder.AppendLine(Temp);
                if (Temp.Contains(WordForReplace))
                {
                    CounterPeplace++;
                }
            }
            stringBuilder.Replace(WordForReplace, "***");
            Console.Write("New text: ");
            Console.Write(stringBuilder.ToString());
            Console.Write($"change statistics: {CounterPeplace}");

        }





        //--------------Кінець програми----------------
    }
}