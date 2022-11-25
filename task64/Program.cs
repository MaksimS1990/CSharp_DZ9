// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Программа выводит все натуральные числа в промежутке от N до 1. Выполняется с помощью рекурсии!");

Console.Write("Введите число n : ");
int n = int.Parse(Console.ReadLine()!);
int count = 1;

if (n < 0) Console.WriteLine("Некорректый ввод!");
else GetNumbersInterval(n, count);

void GetNumbersInterval(int n, int count)
{
    if (count < n)
    {
        GetNumbersInterval(n, count + 1);
    }
    if (count > 1) Console.Write(count + ", ");
    else Console.Write(count);
}