﻿// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и
// выдаёт номер строки с наименьшей суммой
// элементов: 1 строка

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

void NumberRowMinSumElements(int[,] matrix)
{
    int minRows = 0;
    int minSumRows = 0;
    int sumRows = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minRows += matrix[0, i];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) sumRows += matrix[i, j];
        if (sumRows < minRows)
        {
            minRows = sumRows;
            minSumRows = i;
        }
        sumRows = 0;
    }
    Console.Write($"Наименьшая сумма элементов: {minSumRows + 1} строка ");
}

int[,] matrix = CreateMatrix(4, 4, 1, 25);
Console.WriteLine();
PrintMatrix(matrix);
NumberRowMinSumElements(matrix);