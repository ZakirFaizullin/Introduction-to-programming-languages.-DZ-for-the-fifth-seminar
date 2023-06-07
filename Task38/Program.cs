// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().NextDouble() + new Random().Next(1000);
}

void PrintArray(double[] array)
{
    foreach (var item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}

double MaxArray(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    return max;
}

double MinArray(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    return min;
}



Console.Clear();
double[] array = new double[5];
FillArray(array);
PrintArray(array);
double diff = MaxArray(array) - MinArray(array);
System.Console.WriteLine($"Максимальное число: {MaxArray(array)}");
System.Console.WriteLine($"Минимальное число: {MinArray(array)}");
System.Console.WriteLine($"Разница: {diff}");