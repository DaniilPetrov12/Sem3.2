//Console.WriteLine(Math.Pow(12,2));//возведение в квадрат
//Console.WriteLine(Math.Sqrt(144));// извлечение квадратного корня
//Console.WriteLine(Math.Round(12.022565, 3));// округление числа




double Distantion2D(double x1, double y1, double x2, double y2)
{
return Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)), 2);
}

System.Console.WriteLine("Введите координату x точки A");
double x1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату y точки A");
double y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату x точки B");
double x2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату y точки B");
double y2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Distantion2D(x1, y1, x2, y2));