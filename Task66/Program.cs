// Задача 66: Задайте значения M и N. Напишите программу, которая
// найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m <= 0 || n <= 0)
{
    Console.WriteLine("Необходимы натуральные значения!");
    return;
}

if (m < n) Console.WriteLine(rangeNaturalNumbers(m, n));
else Console.WriteLine(rangeNaturalNumbers(n, m));

int rangeNaturalNumbers(int m, int n)
{
    if (m == n) return m;
    else return m + rangeNaturalNumbers(m + 1, n);
}