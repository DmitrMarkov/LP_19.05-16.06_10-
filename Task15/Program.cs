// Задача 15: Напишите программу, которая 
// принимает на вход цифру, обозначающую день
// недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int resualt = Convert.ToInt32(value);
    return resualt;
}
bool Isweekend(int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}

bool ValidateWeekday(int number)
{
    if (number > 0 && number <= 7)
    {    
        return true;
    } 
    Console.WriteLine("Некорректный ввод");
    return false;
}
int weekDay = Prompt("Введите число, соответствующее дню недели:");
if (ValidateWeekday(weekDay))
{
    if (Isweekend(weekDay))
    {
    Console.WriteLine("Выходной день");
    }
    else
    {
    Console.WriteLine("Рабочий день"); 
    }
}