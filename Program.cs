Console.WriteLine("Введите длину а");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите длину b");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите длину c");
double c = Convert.ToDouble(Console.ReadLine());
if (a == b && b == c)
{
    Console.WriteLine("Треугольник равнобедренный");
}
else
{
    Console.WriteLine("треугольник не равнобедренный");
}

