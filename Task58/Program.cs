// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],6}");
        }
        Console.WriteLine();
    }
}

bool checkPossibilityOfMultiplication(int rowMatrix1, int columnMatrix2)
{
    if (rowMatrix1 == columnMatrix2) return true;
    else
    {
        Console.WriteLine("Матрицы нельзя перемножить!");
        return false;
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] matrixProduct(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            resultMatrix[i, j] = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return resultMatrix;
}

int rows1 = ReadInt("Введите количество строк матрицы 1: ");
int columns1 = ReadInt("Введите количество столбцов метрицы 1: ");

int rows2 = ReadInt("Введите количество строк матрицы 2: ");
int columns2 = ReadInt("Введите количество столбцов метрицы 2: ");
Console.WriteLine();

int[,] matrix1 = CreateMatrix(rows1, columns1, 1, 10);
int[,] matrix2 = CreateMatrix(rows2, columns2, 1, 10);

if (rows1 != 0 & rows2 != 0 & columns1 != 0 & columns2 != 0)
{
    if (checkPossibilityOfMultiplication(columns1, rows2) == true)
    {
        PrintMatrix(matrix1);
        Console.WriteLine();
        PrintMatrix(matrix2);

        Console.WriteLine();
        Console.WriteLine("Результирующая матрица будет:");
        Console.WriteLine();

        PrintMatrix(matrixProduct(matrix1, matrix2));
    }
}
else Console.WriteLine("Матрицы нельзя перемножить!");




