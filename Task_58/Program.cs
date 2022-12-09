// Задача 58: Задайте две матрицы. 
// Напишите метод, который будет находить произведение двух матриц.

Console.Clear();
Console.WriteLine("Задача 58");
int[,] matrix1 = GenerateRandom2DArray(); // Для проверки присвоить эти значения из примера - {{2,4},{3,2}};
int[,] matrix2 = GenerateRandom2DArray(); // Для проверки присвоить эти значения из примера - {{3,4},{3,3}};

Print2DArray(matrix1);
Print2DArray(matrix2);

if (CheckMatrixForMultiple(matrix1, matrix2)) Print2DArray(MatrixMultiplication(matrix1, matrix2));

else Console.WriteLine("Ошибка! Матрицы нельзя перемножить, не корректный размер.");
return;

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }

    return resultMatrix;
}

bool CheckMatrixForMultiple(int[,] a, int[,] b)
{
    if (a.GetLength(1) == b.GetLength(0)) return true;
    return false;
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
