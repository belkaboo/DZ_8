// Задача 54: Задайте двумерный массив. Напишите метод, который упорядочит по убыванию элементы каждой строки двумерного массива. 
// И продемонстрируйте его работу.


Console.Clear();
Console.WriteLine("Задача 54");

int[,] array54 = GenerateRandom2DArray();
Console.WriteLine("Исходный массив");
Print2DArray(array54);
SortRows(array54);
Console.WriteLine("Отсортированный массив");
Print2DArray(array54);

int[,] SortRows(int[,] array)
{
    int[,] sortedArray = new int[array.GetLength(0), array.GetLength(1)];
    int tmp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {

                if (array[i, j] < array[i, k])
                {
                    tmp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = tmp;
                }
            }
        }

    }
    return sortedArray;
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