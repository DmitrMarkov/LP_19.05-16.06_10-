// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите натуральное число");
int num = Convert.ToInt32(Console.ReadLine());

SqrTable(num);

void SqrTable(int n)
{
    int count = 1;
    while (count <= n)
    {
        Console.WriteLine($"{count,3 } {count*count,4}");
        count++;
  }
}