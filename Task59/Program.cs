// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

int[,] CreateFillMatrix(int m, int n, int min, int max)
{
    int[,] arr = new int[m, n];
    var rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
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

int[] FindMin(int[,] matr)
{
    int[] minIndexes = new int[2];
    int minElem = matr[0, 0];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (minElem > matr[i, j])
            {
                minElem = matr[i, j];
                minIndexes[0] = i;
                minIndexes[1] = j;
            }
        }
    }
    return minIndexes;
}

int[,] RemoveRowCol(int[] indexes, int[,] matr)
{
    int rows = matr.GetLength(0) - 1;
    int columns = matr.GetLength(1) - 1;
    int[,] newMatr = new int[rows, columns];

    int m = 0;
    for (int i = 0; i < rows; i++)
    {
        if (m == indexes[0]) m++;
        int n = 0;

        for (int j = 0; j < columns; j++)
        {
            if (n == indexes[1]) n++;

            newMatr[i, j] = matr[m, n];
            n++;
        }
        m++;
    }
    return newMatr;
}

int[,] matrix = CreateFillMatrix(4, 4, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();

int[] minIndexes = FindMin(matrix);
int[,] newMatr = RemoveRowCol(minIndexes, matrix);
PrintMatrix(newMatr);