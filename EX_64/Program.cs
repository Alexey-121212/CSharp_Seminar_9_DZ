// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.WriteLine("Введите натуральное число N:");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 1)
{
    Console.WriteLine("Ошибка ввода, число не натуральное");
    return;
}

PrintNums(n);

// Methods

static void PrintNums(int n)
{
    if (n > 0)
    {
        Console.Write(n + " ");
        PrintNums(n - 1);
    }
}
