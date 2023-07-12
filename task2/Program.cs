// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15-> 120
// M = 4; N = 8-> 30


void FromMToN(int m, int n)
{
    Console.Write(SumMN(m - 1, n));
}


int SumMN(int m, int n)
{
    int result = m;
    if (m == n)
    {
        return 0;
    }

    m++;
    result = m + SumMN(m, n);
    return result;
}

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
FromMToN(number1, number2);
