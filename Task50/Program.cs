//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите индекс строки массива: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите индекс столбца массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int rows = 4;
int columns = 4;
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j], 4} ");
        }
        Console.WriteLine();
    }
}

if (m < 0 | m > array.GetLength(0) - 1 | n < 0 | n > array.GetLength(1) - 1)
    {
        Console.WriteLine("Элемент не существует");
    }
else
    {
        Console.WriteLine($"Значение элемента массива = {array[m, n]}");
    }
