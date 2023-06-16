// Задача 67: Напишите программу, которая 
// будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int EnterNumber(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumDigits(int num)
{
    if (num == 0) return 0;
    return num % 10 + SumDigits(num / 10);
}


int number = EnterNumber("Enter number: ");
Console.WriteLine("Sum numbers: ");
Console.WriteLine(SumDigits(number));