// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76

double[] numbers = new double[5];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

double max = numbers[0];
double min = numbers[0];

for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] > max) 
    {
        max = numbers[i];
    }    
    else if (numbers[i] < min) 
    {  
        min = numbers[i];
    } 
}

double result = max - min;
Console.WriteLine($"Разница между максимальным {max} и минимальным {min} элементами: {result}");

void FillArrayRandomNumbers(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(1, 100));
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();    
}