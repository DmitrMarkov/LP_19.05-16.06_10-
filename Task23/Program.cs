// Задача 23
// Напишите программу, которая принимает
// на вход число (N) и выдаёт таблицу
// кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите натуральное число:");
int num = Convert.ToInt32(Console.ReadLine());

SqrTable(num);

void SqrTable(int n)
{
    int count = 1;
    while (count <= n)
    {
        Console.WriteLine($"{count,3}" + " | " + $"{count * count * count,1}");
        count++;
    }
}
