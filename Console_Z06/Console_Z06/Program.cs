using System;

namespace Console_Z06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("| Работа с массивами.");
            bool repit = true;
            while(repit == true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("| Одномерный массив");
                    Console.ResetColor();

                    Console.WriteLine("| Введите размер N одномерного массива.");
                    Console.Write("| N : ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    if (n < 1)
                        throw new Exception("Размер массива не может быть меньше 1!");
                    int[] odnomer = new int[n];

                    read(odnomer);
                    print(odnomer);

                    Console.WriteLine("|---------------------------------------");
                    Console.WriteLine("| Cумма элементов, кратных 9: {0}.", sum(odnomer));
                    Console.WriteLine("|---------------------------------------");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("| Двумерный массив");
                    Console.ResetColor();

                    Console.WriteLine("| Введите размер N M двумерного массива.");
                    Console.Write("| N : ");
                    int nD = Convert.ToInt32(Console.ReadLine());
                    Console.Write("| M : ");
                    int mD = Convert.ToInt32(Console.ReadLine());

                    if (nD < 1 || mD < 1)
                        throw new Exception("Размер массива не может быть меньше 1!");
                    int[,] dvymer = new int[nD, mD];

                    read(dvymer, nD, mD);
                    print(dvymer, nD, mD);

                    Console.WriteLine("|---------------------------------------");
                    Console.WriteLine("| Cумма элементов, кратных 9: {0}.", sum(dvymer, nD, mD));
                    rep(out repit);
                }
                catch (FormatException)
                {
                    Console.WriteLine("|---------------------------------------");
                    Console.WriteLine("| Некорректный ввод данных!");
                    rep(out repit);
                }
                catch(Exception e)
                {
                    Console.WriteLine("|---------------------------------------");
                    Console.WriteLine($"| {e.Message}");
                    rep(out repit);
                }
            }
        }
        static void read(int[] odnomer)
        {
            Console.WriteLine("|---------------------------------------");
            Console.WriteLine("| Заполните массив целыми числами.");
            for (int i = 0; i < odnomer.Length; i++)
            {
                Console.Write("| : ");
                odnomer[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void read(int[,] dvymer, int nD, int mD)
        {
            Console.WriteLine("|---------------------------------------");
            Console.WriteLine("| Заполните массив целыми числами.");
            for (int i = 0; i < nD; i++)
            {
                for (int j = 0; j < mD; j++)
                {
                    Console.Write("| : ");
                    dvymer[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        static void print(int[] odnomer)
        {
            Console.WriteLine("|---------------------------------------");
            Console.WriteLine("| Полученный массив:");
            Console.Write("|");
            for (int i = 0; i < odnomer.Length; i++)
            {
                Console.Write(" {0}", odnomer[i]);
            }
            Console.WriteLine();
        }
        static void print(int[,] dvymer, int nD, int mD)
        {
            Console.WriteLine("|---------------------------------------");
            Console.WriteLine("| Полученный массив:");
            for (int i = 0; i < nD; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < mD; j++)
                {
                    Console.Write(String.Format("{0,4}", dvymer[i, j]));
                }
                Console.WriteLine();
            }
        }
        static int sum(int[] odnomer)
        {
            int sumOdnomer = 0;
            for (int i = 0; i < odnomer.Length; i++)
            {
                if (odnomer[i] % 9 == 0)
                {
                    sumOdnomer += odnomer[i];
                }
            }
            return sumOdnomer;
        }
        static int sum(int[,] dvymer, int nD, int mD)
        {
            int sumDvymer = 0;
            for (int i = 0; i < nD; i++)
            {
                for (int j = 0; j < mD; j++)
                {
                    if (dvymer[i, j] % 9 == 0)
                    {
                        sumDvymer += dvymer[i, j];
                    }
                }
            }
            return sumDvymer;
        }
        static void rep(out bool repit)
        {
            Console.WriteLine("| Попробовать снова? Да / Нет");
            Console.Write("| : ");
            string repitTxT = Convert.ToString(Console.ReadLine());

            if (repitTxT == "Да")
            {
                repit = true;
                Console.WriteLine("|----------------------------------");
            }
            else if (repitTxT == "Нет")
                repit = false;
            else
            {
                Console.WriteLine("|----------------------------------");
                Console.WriteLine("| Некорректный ввод данных!");
                repit = false;
            }
        }
    }
}