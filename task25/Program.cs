// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int Result(int digit1, int digit2)
{
    int result = 1;
    for (int i = 1; i <= digit2; i++)
    {
        result = result * digit1;
    }
    return result;
}
    
int num1 = Prompt("Type number A: ");
int num2 = Prompt("Type number B: ");
int res = Result(num1, num2);
Console.WriteLine($"{num1}, {num2} -> " + res);
