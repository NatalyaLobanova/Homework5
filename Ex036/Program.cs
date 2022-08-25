﻿// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] numbers = new int [7];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int sum = 0;
int i = 1;
while (i < numbers.Length)
{
    sum = sum + numbers[i];
    i = i+2;
}
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {sum}");

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}

void PrintArray(int[]array)
{
    Console.WriteLine("[{0}]", string.Join(", ", array));
}
