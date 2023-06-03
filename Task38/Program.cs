// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным
// и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

double[] CreateArrayRndDouble(int size, int min, int max, int round = 2)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, round);
    }
    return arr;
}

int EnterNumber()
{
    Console.WriteLine("Введите количество элементов массива: ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArrayDouble(double[] arr, string sep = ",")
{
    Console.WriteLine("");
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.WriteLine($"{arr[i]}]");
    }
}

double findDifOfNum(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i <= arr.Length - 2; i++)
    {
        if (arr[i + 1] < min) min = arr[i + 1];
        if (arr[i + 1] > max) max = arr[i + 1];
    }
    return Math.Round(max - min, 2); ;
}

int numElArr = EnterNumber();
double[] arr = CreateArrayRndDouble(numElArr, -100, 100);
PrintArrayDouble(arr);
Console.WriteLine(findDifOfNum(arr));