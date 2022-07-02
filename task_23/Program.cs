// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу кубов чисел от 1 до N.
namespace Array
{
class Program
{
public static void Main(string[] args)
{
Console.Write("Введите целое число: ");
Console.WriteLine();
int n = Convert.ToInt32(Console.ReadLine());


for (int i = 1; i <= n; i++)
{
   PrintCube(i);
}

void PrintCube(int x)
{
    //  int value = n;
    //  int power = 3;     
     Console.WriteLine(x * x * x);
}
}
}
}