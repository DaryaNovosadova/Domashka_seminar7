int rows = 3;
int columns = 3;
float[,] array = GetArray(rows, columns, -10, 20);
PrintArray(array);

float[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    float[,] result = new float[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(float[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j], 5} ");
        }
        Console.WriteLine();
    }
}
