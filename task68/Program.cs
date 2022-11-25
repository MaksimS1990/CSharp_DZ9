// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Программа вычисления функции Аккермана с помощью рекурсии!");

Console.Write("Введите число M : ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N : ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(FunctionOfAkkerman(M, N));

int FunctionOfAkkerman(int M, int N)
{
    if (M == 0) return N + 1;
    if (M > 0 && N == 0) return FunctionOfAkkerman(M -1, 1);
    if (M > 0 && N > 0) return FunctionOfAkkerman(M -1, FunctionOfAkkerman(M, N - 1));
    return FunctionOfAkkerman(M, N);
}