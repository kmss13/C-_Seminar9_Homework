// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 9
//m = 3, n = 2->A(m, n) = 29

int ReadInt(string message)             
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int number1 = ReadInt("Введите первое число: ");
int number2 = ReadInt("Введите второе число: ");
Console.Write($"Функция Аккермана равна {akkerman(number1, number2)} ");

int akkerman(int m, int n)
{
if (m == 0)
{
return n + 1;
}
if (n == 0 && m > 0)
    {
        return akkerman(number1 - 1, 1);
    }
    return (akkerman(number1 - 1, akkerman(number1, number2 - 1)));
}
