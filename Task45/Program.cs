// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] ArrayCopy(int[] arr)
{
    int[] newArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        newArr[i] = arr[i];
    }
    return newArr;
}

int[] CreateRndArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

int[] array = CreateRndArray(8, 4, 10);
PrintArray(array);
int[] newArray = ArrayCopy(array);
newArray[0] = 33;
PrintArray(newArray);