using System;

namespace Console_Z06_2
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
                    Console.WriteLine("| Введите размер N одномерного массива.");
                    Console.Write("| N : ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    if (n < 1)
                        throw new Exception("Размер массива не может быть меньше 1!");
                    int[] odnomer = new int[n];

                    read(odnomer);
                    print(odnomer, max(odnomer));                    

                    Console.WriteLine("| Номер максимального элемента: " + max(odnomer));
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
        static void print(int[] odnomer, int numberMax)
        {
            Console.WriteLine("|---------------------------------------");
            Console.WriteLine("| Полученный массив:");
            Console.Write("| Номер --->");
            for (int i = 1; i <= odnomer.Length; i++)
            {
                if (numberMax == i)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(String.Format("{0,4}", i));
                    Console.ResetColor();
                }
                else
                    Console.Write(String.Format("{0,4}", i));
            }
            Console.WriteLine();

            Console.Write("| Элемент ->");
            for (int i = 0; i < odnomer.Length; i++)
            {
                Console.Write(String.Format("{0,4}", odnomer[i]));
            }
            Console.WriteLine();
        }
        static int max(int[] odnomer)
        {
            int max = 0, numberMax = 0;
            for (int i = 0; i < odnomer.Length; i++)
            {
                if (odnomer[i] > max)
                {
                    max = odnomer[i];
                    numberMax = i + 1;
                }
            }
            return numberMax;
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
