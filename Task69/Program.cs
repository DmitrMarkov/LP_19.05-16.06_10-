// Задача 69: Напишите программу, которая 
// на вход принимает два числа A и B, и
// возводит число А в целую степень B с 
// помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int EnterNumber(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Exponentiation(int number, int exp)
{
    if (exp == 0) return 1;
    return number * Exponentiation(number, exp - 1);
}

int Exponentiation1(int number, int exp)
{
    return exp == 0 ? 1 : number * Exponentiation(number, exp - 1);
}
int number = EnterNumber("Введите целое число: ");
int exp = EnterNumber("Введите степень числа: ");
Console.WriteLine($"{exp} степень числа {number} = {Exponentiation1(number, exp)}");