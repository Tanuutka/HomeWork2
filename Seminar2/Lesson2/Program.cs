﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine());

if (number < 100 && number > - 100)
{
  Console.Write("третьей цифры нет: ");
}
else
{
   while (number > 999 || number < -999) 
   {
    number = number/10;
   }
 
 Console.Write("третья цифра равна: "+ Math.Abs(number)%10);
}

