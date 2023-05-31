// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int Factorial(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            result *= i;
        }
    }
    return result;
}

int Start(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int number = Start("Введите целое положительное число");
if (number <= 0)
{
    Console.WriteLine("Вы ввели некорректное число");
    return;
}
Console.WriteLine(Factorial(number));
