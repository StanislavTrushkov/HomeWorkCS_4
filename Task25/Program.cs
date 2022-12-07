// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
using System;
{
int Exp(int numA, int numB)
    {
            int result = 1;
        for(int i=1; i <= numB; i++)
        {
            result = result * numA;
        }
        return result;
    }

Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int Exponentiation = Exp(numA, numB);
Console.WriteLine($"Число {numA} в степени {numB} = " + Exponentiation);

    Console.ReadKey();
}