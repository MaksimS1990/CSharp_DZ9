// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Программа задаёт значения M и N. Находит сумму натуральных элементов в промежутке от M до N.");

Console.Write("Введите число M : ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N : ");
int N = int.Parse(Console.ReadLine()!);

if (M <= 0 && N <= 0)
Console.WriteLine("Ошибка ввода! Введите положительное число!");
else if (M > N)
Console.WriteLine("Ошибка ввода! N должно быть больше M!");
else
Console.WriteLine($"Сумма чисел от M до N ={GetSumDigitsMN(M, N)}");

int GetSumDigitsMN(int M, int N)
{
    if (M == N) return M;
    return M + GetSumDigitsMN(M + 1, N);
}