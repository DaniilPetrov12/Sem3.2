

void QuatersFind(int x, int y)
{
if (x> 0 && y >0)
{
    Console.Write ("Точка лежит в первой четверти");
}
else if (x< 0 && y >0)
{
    Console.Write ("Точка лежит во второй четверти");
}
else if (x< 0 && y <0)
{
    Console.Write ("Точка лежит в третей четверти");
}if (x> 0 && y <0)
{
    Console.Write ("Точка лежит в четверой четверти");
}
}


Console.Write ("Введите координату X ");
int x =Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите координату Y ");
int y =Convert.ToInt32(Console.ReadLine());

QuatersFind(x,y);

