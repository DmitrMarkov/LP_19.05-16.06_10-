// Задача 60. Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно
// выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
// 34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)

int[,,] Create3DRndInt(int rows, int columns, int depth, int min, int max)
{
    int[,,] matrix = new int[rows, columns, depth];
    int num = 10;
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = num++;
            }
        }
    }
    return matrix;
}

bool checkMatrix(int x, int y, int z)
{
    if ((x * y * z <= 90) == true)
    {
        return true;
    }
    else return false;
}

void Print3DMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k],6}" + "(" + i + ", " + j + ", " + k + ")");
            }
        }
        Console.WriteLine();
    }

}

Console.WriteLine("Введите размер массива: ");
string[] numbers = Console.ReadLine().Split();
int x = int.Parse(numbers[0]);
int y = int.Parse(numbers[1]);
int z = int.Parse(numbers[2]);
if (checkMatrix(x, y, z) == true)
{
    Print3DMatrix(Create3DRndInt(x, y, z, 0, 1));
}
else
    Console.WriteLine("Невозможно создать массив.");