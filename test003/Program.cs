// напишите программу которая будет принемать два числа и выводить является ли второе число кратным первому.
//Если нет то выводит остаток от деления
// например 34, 5 -> не кратно, остаток 4
Console.Write("Введите первое число = ");
int number1=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите первое число = ");
int number2 = Convert.ToInt32(Console.ReadLine());

int mod = number1 % number2;

if (mod == 0)

{
Console.Write("Кратно");
}
else{
    Console.Write($" не Кратно, остаток {mod}");
}