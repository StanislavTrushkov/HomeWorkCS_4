// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
using System;
{
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int sum(int num)
{

    int counter = Convert.ToString(num).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        advance = num - num % 10;
        result = result + (num - advance);
        num = num / 10;
    }
    return result;
}

int sumNum = sum(num);
Console.WriteLine($"Сумма цифр числа {num}: " + sumNum);

    Console.ReadKey();
}