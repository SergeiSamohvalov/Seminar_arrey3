// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

namespace Array
{
    class Program
    {
        public static void Main(string[] args)
        {
            Double x1 = 0; 
            Double x2 = 0;
            Double y1 = 0;
            Double y2 = 0;
            Double z1 = 0;
            Double z2 = 0;
            Double distance = 0;  
            
            
            Console.Write("Введите координаты x1: ");
            Console.WriteLine();
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты x2: ");
            Console.WriteLine();
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты y1: ");
            Console.WriteLine();
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты y2: ");
            Console.WriteLine();
            y2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты z1: ");
            Console.WriteLine();
            z1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты z2: ");
            Console.WriteLine();
            z2 = Convert.ToDouble(Console.ReadLine());
            
            void PrintDistance(double distance)
            {

            distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
                Console.WriteLine($"Расстояние между двумя точками в пространстве равно: {distance}");
                Console.WriteLine();
            }

             PrintDistance(distance);  
        } 
    }
}