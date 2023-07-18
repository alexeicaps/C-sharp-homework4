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


// int SymbolCountNumber(int num1);
// {
//     int count = 0;
//     while (num1 > 0)
//     {
//         num1 = num1 / 10;
//         count++;
//     }
//     return count;
// }

// void SumSymbolNumber(int a, int len)
// {
//     int sum = 0;
//     for (int i = 0; i <= len; i++)
//     {

//     }
// }