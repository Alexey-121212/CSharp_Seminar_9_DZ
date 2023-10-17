// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 1 | n < 1)
{
    Console.WriteLine("Ошибочный ввод, введенные числа не натуральные");
    return;
}

if (m > n)
{
    Console.WriteLine(CalcSumBetweenNums(n, m));
}
else
{
    Console.WriteLine(CalcSumBetweenNums(m, n));
}

// Methods

static int CalcSumBetweenNums(int mi, int ni)
{
    if (ni > mi)
    {
        return ni + CalcSumBetweenNums(mi, ni - 1);
    }
    else
        return ni;
}
