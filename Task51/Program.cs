// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] CreateFillMatrix(int m, int n)
{
    int[,] arr = new int[m, n];
    var rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = rnd.Next(1, 10);
        }
    }
    return arr;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],4}");
        }

        Console.WriteLine();
    }
}

int SumElementsMainDiagonal(int[,] arr)
{
    int min = Math.Min(arr.GetLength(0), arr.GetLength(1));
    int sum = 0;
    for (int i = 0; i < min; i++)
    {
        sum += arr[i, i];
    }
    return sum;
}

int[,] array = CreateFillMatrix(4, 4);
PrintMatrix(array);
Console.WriteLine();
int sumElem = SumElementsMainDiagonal(array);
Console.WriteLine($"Sum: {sumElem}");
