﻿Console.WriteLine("Введите первое число : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число : ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("max : ");
if (a<b){
    Console.WriteLine(b);
}else{
    Console.WriteLine(a);
}