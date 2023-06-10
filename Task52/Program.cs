// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
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

void arithmeticMean(int[,] matrix)
{
    double[] mean = new double[4];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double result = 0.0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            result += matrix[j, i];
        }
        mean[i] = Math.Round((Convert.ToDouble(result / matrix.GetLength(0)) / 1), 1);
    }
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < (mean.Length - 1); i++) Console.Write(mean[i] + "; ");
    Console.Write(mean[mean.Length - 1] + ".");
}

int[,] array2d = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2d);
arithmeticMean(array2d);
