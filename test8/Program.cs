



//Console.Write("Введите четверти =  ");
//int quater = Convert.ToInt32(Console.ReadLine());
//if (quater == 1)
//{
//    Console.Write("Точка лежит в x> 0  y >0");
//}
//else if (quater == 2)
//{
//    Console.Write("Точка лежит x< 0  y >0");
//}
//else if (quater == 3)
//{
//    Console.Write("Точка лежит в x< 0  y <0");
//}
//if (quater == 4)
//{
//    Console.Write("Точка лежит в x> 0  y <0");
//}

string [] quaters ={
    "x>0 y>0",
    "x<0 y>0",
    "x<0 y<0",
    "x>0 y<0"
};
Console.Write("Введите четверти =  ");
int quater = Convert.ToInt32(Console.ReadLine());
if (quater>= 1 && quater <=4)
{
    Console.WriteLine(quaters[quater - 1]);
}
else{
    Console.WriteLine("Неправильные номер четверти");
    
}