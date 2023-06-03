// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size, int min, int max)
{
    Random rnd = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

int EnterNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] arr)
{
    Console.WriteLine("");
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

int findEvenNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i <= arr.Length - 1; i++)
    {
        if (i % 2 != 0)
        {
            count += arr[i];
        }
    }

    return count;
}

int numElArr = EnterNumber("Введите количество элементов массива: ");
int[] arr = CreateArrayRndInt(numElArr, -100, 100);
PrintArray(arr);
Console.WriteLine(findEvenNum(arr));