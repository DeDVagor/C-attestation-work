﻿//задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int summa (int m, int n)
{
if ( m == n )
return n;
else return m + summa(m + 1, n);
}
Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N равна {summa(m,n)}");