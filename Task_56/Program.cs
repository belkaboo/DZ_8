// Задача 56: Задайте двумерный массив. 
// Напишите метод, который будет находить строку с наименьшей суммой элементов.

Console.Clear();
Console.WriteLine("Задача 56");
int[,] array56 = GenerateRandom2DArray();
Print2DArray(array56);
Console.Write("Строка с наименьшей суммой элементов - "); 
PrintArray(MinimalRow(array56));



int[] MinimalRow(int[,] array)
{
    int[] result = new int[1];
    int minSum = 0;
    int minRow = 1;

    for (int i = 0; i < array.GetLength(1); i++)
    {
        minSum += array[0, i];
    }

    int sumRow = 0;

    for (int i = 1; i < array.GetLength(0); i++)
    {
        sumRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow += array[i, j];
        }
        if (sumRow < minSum)
        {
            minSum = sumRow;
            minRow = i + 1;
        }
    }
    result[0] = minRow;
    return result;
}

int[,] GenerateRandom2DArray()
{
    Random random = new Random();
    int[,] array = new int[random.Next(2, 6), random.Next(2, 6)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }

        Console.WriteLine("]");
    }
    Console.WriteLine();
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}