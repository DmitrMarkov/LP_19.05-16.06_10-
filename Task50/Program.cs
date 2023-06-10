// Задача 50. Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение этого элемента
//  или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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

void elementOfArray(int rows, int columns, int[,] matrix)
{
    if (rows < matrix.GetLength(0))
    {
        if (columns < matrix.GetLength(1))
        {
            Console.Write(matrix[rows, columns]);
        }
        else Console.Write("Такого элемента в массиве нет");
    }
    else Console.Write("Такого элемента в массиве нет");
}

int[,] array2d = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2d);
Console.Write("Введите позицию элемента в строке: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию элемента в столбце: ");
int columns = Convert.ToInt32(Console.ReadLine());
elementOfArray(rows, columns, array2d);
