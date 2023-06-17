// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите неотрицательное число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите неотрицательное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 0 || n < 0)
{
    Console.WriteLine("Необходимы неотрицательные значения!");
    return;
}

Console.WriteLine(AkkermanFunction(m, n));

int AkkermanFunction(int m, int n)
{
    if (m == 0) return (n + 1);
    if (n == 0) return AkkermanFunction(m - 1, 1);
    return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}