// Напишите программу которая принимает на вход и проверяет, кратно оно одновеременно 7 и 23
Console.Write("Введите первое число = ");
int number1=Convert.ToInt32(Console.ReadLine());
int mod1 = number1 % 7;
int mod2 = number1 % 23;
if(mod1 == 0)
{
    Console.Write("да");
}
else if(mod2 == 0)
{
    
    Console.Write("да");
}
else {
Console.Write("нет");
}