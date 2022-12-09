// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите метод, который будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

Console.Clear();
Console.WriteLine("Задача 60");
Console.WriteLine();
Print3DArray(CreateRandom3DArray(2, 2, 2)); // 2x2x2  - размер 3D массива по условиям задачи

int[,,] CreateRandom3DArray(int a, int b, int c)
{
    int[,,] array = new int[a, b, c];
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                int number = random.Next(10, 100);

                while (CheckContains(number, array))
                {
                    number = random.Next(10, 100);
                }
                array[i, j, k] = number;
            }
        }
    }
    return array;

}

bool CheckContains(int number, int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (number == array[i, j, k])
                {
                    return true;
                }
            }

        }
    }
    return false;
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[j, k, i]} ({j},{k},{i}) ");
            }
            Console.WriteLine();
        }
    }
}


int[] GenerateRandomUniqueNumbers(int quantity, int minValue, int maxValue) // возвращает массив заданной длины из уникальных рандомных чисел в заданных приделах. 
{
    int[] array = new int[quantity];
    if (minValue == 0 || maxValue == 0 || quantity > (maxValue - minValue) || maxValue <= minValue) return array;

    Random random = new Random();
    int number = 0;
    for (int i = 0; i < array.Length; i++)
    {
        number = random.Next(minValue, maxValue);
        while (array.Contains(number))
        {
            number = random.Next(minValue, maxValue);
        }
        array[i] = number;
    }

    return array;
}