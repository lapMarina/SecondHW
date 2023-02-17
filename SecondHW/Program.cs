using System;

namespace SecondHW
{
    class Program
    {
        static void FirstTask() 
        {
            Console.WriteLine("Введите трехзначное число");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n >= 100 && n < 1000)
            {
                n = n / 10;
                Console.WriteLine(n % 10);
            }
            else
                Console.WriteLine("Число должно быть трехзначным от 100 до 999");
        }

        static void SecondTask() 
        {
            Console.WriteLine("Введите число");
            string input = Console.ReadLine();
            int n = Convert.ToInt32(input);
            if (n >= 100)
                Console.WriteLine(input[2]);
            else
                Console.WriteLine("третьей цифры нет");
        }
        static void ThirdTask()
        {
            Console.WriteLine("Введите номер дня недели");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0 && n < 8)
            {
                if (n > 5)
                    Console.WriteLine("да");
                else
                    Console.WriteLine("нет");
            }
            else
                Console.WriteLine("В неделе 7 дней, введи число от 1 до 7");
        }
        static void Main(string[] args)
        {
            //FirstTask();
            //SecondTask();
            ThirdTask();
        }
    }
}
