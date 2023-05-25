// Задача 10: Напишите программу, которая принимает
// на вход трёхзначное число и на выходе показывает
// вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите целое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{
    int secondDigit = (number % 100) / 10;
    Console.WriteLine($"{secondDigit} является второй цифрой числа {number}");
}   
else
{
    Console.WriteLine("Неверное число.");
}
