// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine());

if ((number >99 && number <= 999) || (number >= -999 && number <-99))
{
    Console.Write("Вторая цифра равна: "+ (Math.Abs(number)/10)%10);
}
else 
{
    Console.Write("Введенное число не трехзначное");
}

