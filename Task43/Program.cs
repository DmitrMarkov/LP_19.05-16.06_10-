// Задача 43: Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double pointX;
double pointY;

Console.WriteLine("Введите значения b1, k1, b2 и k2 одной строкой через пробел: ");

int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int k1 = arr[1];
int b1 = arr[3];
int k2 = arr[0];
int b2 = arr[2];

if (k1 == b1)
{
    Console.WriteLine("Прямые с такими параметрами паралельны");
}
else
{
    pointX = (double)(b2 - k2) / (k1 - b1);
    pointY = (double) k1 * (b2 - k2) / (k1 - b1) + k2;
    Console.WriteLine("Координаты точки пересечения двух прямых:");
    Console.WriteLine($"Х: {pointX:0.00}");
    Console.WriteLine($"Y: {pointY:0.00}");
}
