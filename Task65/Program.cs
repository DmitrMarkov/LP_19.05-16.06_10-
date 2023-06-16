// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int EnterNumber(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void NumbersMN(int m, int n)
{
    if (m > n)
    {
        Console.Write($"{m}, ");
        NumbersMN(m - 1, n);
    }
    else if (m < n)
    {
        Console.Write($"{m}, ");
        NumbersMN(m + 1, n);
    }
    else Console.Write($"{m} ");
}

int numberM = EnterNumber("Enter number M: ");
int numberN = EnterNumber("Enter number N: ");
NumbersMN(numberM, numberN);