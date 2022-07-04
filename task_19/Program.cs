// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

namespace Array
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите пятизначное число: ");
            Console.WriteLine();
            int n = Convert.ToInt32(Console.ReadLine());
            
            if (n % 10 == n / 10000 & (n / 10) % 10 == (n / 1000) % 10)
            {
                Console.WriteLine("Введенное число - палиндром");
            }
            else
            {
                Console.WriteLine("Введенное число -  НЕ палиндром");
            }
        }
    }
}