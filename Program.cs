Console.WriteLine("Введите конечное число");
int x = Convert.ToInt32(Console.ReadLine());
double z = 0;
for (int i = 0; i <= x; i++)
{
    z = +z + Math.Pow(-1, i) * i;
    Console.WriteLine(z);
}

    

