// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1000);
}

void PrintArray(int[] array)
{
    foreach (var item in array)
        Console.Write($"{item} ");
    Console.WriteLine();
}

int Sum(int[] array)
{
int sum = 0;
for (int i = 0; i < array.Length; i = i + 2)
{
    sum = sum + array[i];
}
return sum;
}

Console.Clear();
int[] array = new int[7];
FillArray(array);
PrintArray(array);
System.Console.WriteLine(Sum(array));