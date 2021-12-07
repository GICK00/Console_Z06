using System;

namespace Console_Z06_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("| Работа с массивами.");
            bool repit = true;
            while (repit == true)
            {
                try
                {
                    Console.WriteLine("| Введите размер N двумерного массива.");
                    Console.Write("| N : ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    if (n < 1)
                        throw new Exception("Размер массива не может быть меньше 1!");
                    int[,] mas = new int[n, n];
                    int[] mas2 = new int[n];

                    read(mas, n);
                    print(mas, n);
                    plus(mas, mas2, n);
                    print(mas2, n);
                    
                    Console.WriteLine("|---------------------------------------");
                    rep(out repit);
                }
                catch (FormatException)
                {
                    Console.WriteLine("|---------------------------------------");
                    Console.WriteLine("| Некорректный ввод данных!");
                    rep(out repit);
                }
                catch (Exception e)
                {
                    Console.WriteLine("|---------------------------------------");
                    Console.WriteLine($"| {e.Message}");
                    rep(out repit);
                }
            }
        }
        static void read(int[,] dvymer, int n)
        {
            Console.WriteLine("|---------------------------------------");
            Console.WriteLine("| Заполните массив целыми числами.");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("| : ");
                    dvymer[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        static void print(int[,] mas, int n)
        {
            Console.WriteLine("|---------------------------------------");
            Console.WriteLine("| Полученный массив:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("|");
                for (int j = 0; j < n; j++)
                {
                    Console.Write(String.Format("{0,4}", mas[i, j]));
                }
                Console.WriteLine();
            }
        }
        static void print(int[] mas2, int n)
        {
            Console.WriteLine("|---------------------------------------");
            Console.WriteLine("| Полученный массив:");
            Console.Write("|");
            for (int i = 0; i < n; i++)
            {
                Console.Write(" {0}", mas2[i]);
            }
            Console.WriteLine();
        }
        static void plus(int[,] mas, int[] mas2, int n)
        {
            for (int i = 0; i < n; i++)
            {
                int plus = 0;
                for (int j = 0; j < n; j++)
                {
                    if (mas[j, i] > plus)
                    {
                        plus = mas[j, i];
                        break;
                    }
                }
                mas2[i] = plus;
            }
        }
        static void rep(out bool repit)
        {
            Console.WriteLine("| Попробовать снова? Да / Нет");
            Console.Write("| : ");
            string repitTxT = Convert.ToString(Console.ReadLine());

            if (repitTxT == "Да")
            {
                repit = true;
                Console.WriteLine("|---------------------------------------");
            }
            else if (repitTxT == "Нет")
                repit = false;
            else
            {
                Console.WriteLine("|---------------------------------------");
                Console.WriteLine("| Некорректный ввод данных!");
                repit = false;
            }
        }
    }
}
