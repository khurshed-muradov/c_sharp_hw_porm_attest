// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение M:");
        int M = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение N:");
        int N = int.Parse(Console.ReadLine());

        int result = SumNumbers(M, N);
        Console.WriteLine($"Сумма натуральных чисел от {M} до {N} = {result}");
    }

    static int SumNumbers(int M, int N)
    {
        if (M > N)
        {
            return 0; // Базовый случай, если M больше N, возвращаем 0
        }
        return M + SumNumbers(M + 1, N); // Рекурсивный вызов, добавляем текущее M и вызываем для M+1
    }
}
