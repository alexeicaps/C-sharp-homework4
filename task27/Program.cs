// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int DrawNumbers(int value)
{
    int result = 0;
    while(value > 0)
    {
        result = result + value % 10;
        value = value / 10;
    }
    return result;
}

int N = Prompt("Введите число: ");
Console.WriteLine($"Сумма цифр числа {N} -> " + DrawNumbers(N));
