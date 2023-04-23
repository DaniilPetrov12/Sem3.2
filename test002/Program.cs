// Напишите программу , которая берет случайное трехзгачное число и удаляет цифру по середина
// Например 756->76

int number = new Random().Next(100,1000);
Console.WriteLine($"Случайное число:{number}");
int digit1 = number/100;
int digit2 = number%100;
int digit3 = digit2%10;
Console.WriteLine($"Случайное число:{number}, равно :{digit1}{digit3}");