using System;

class SecondTask
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Коэффициент a:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Коэффициент b:");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Коэффициент c:");
        double c = Convert.ToDouble(Console.ReadLine());

        SolveEquation(a, b, c);
    }

    static void SolveEquation(double a, double b, double c)
    {
        if (a != 0) 
        {
            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"Уравнение имеет два!!! различных корня: x1 = {x1}, x2 = {x2}");
            }
            else if (discriminant == 0) 
            {
                double x = -b / (2 * a);               
                Console.WriteLine($"Уравнение имеет лишь один корень: x = {x}");
            }
            else
            {
                Console.WriteLine("Нет действительных корней(((");
            }
        }
        else if (b != 0) 
        {
            double x = -c / b;
            Console.WriteLine($"Уравнение имеет лишь один корень: x = {x}");
        }
        else 
        {
            if (c == 0)
            {
                Console.WriteLine("Уравнение имеет бесконеееееееечно много решений (0 = 0).");
            }
            else
            {
                Console.WriteLine("Уравнение не имеет решений(((");
            }
        }
    }
}