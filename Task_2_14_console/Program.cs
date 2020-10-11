using System;
//14.Проверить, образуют ли элементы целочисленного массива размера N 
//геометрическую прогрессию.Если да, то вывести знаменатель прогрессии, если нет — вывести 0.
namespace Task_2_14_console
{
    class Program
    {
        static void Main(string[] args)
        {
            bool temp = true;
            int n = 3;
            while (temp)
            {
              
               Console.WriteLine("Введите размер массива: ");
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if (n < 2)
                    {
                        throw new Exception("Amount >3");
                    }
                    temp = false;
                }
                catch (Exception e)
                {
                    if (e.Message == "Input sting was not in a correct fortmat.")
                    {
                        Console.WriteLine("Enter an integer number");
                    }
                    else Console.WriteLine(e.Message);

                }
            }

                int[] arr = new int[n];
                FillRand(arr);
                ShowArr(arr);
                Console.WriteLine("Знаменатель прогресии (если равен 0 - не гп): " + IsProgressiv(arr));
            
        }

        static double IsProgressiv(int[] arr)
        {
            double q = (double)arr[1] / (double)arr[0];
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] * q != arr[i + 1]) return 0; 
            }
            return q;
        } 

        static void FillRand(int[] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 10);
            }
        }

        static void ShowArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
