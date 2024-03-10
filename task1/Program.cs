// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void ShowDigits(int M, int N)
{
    if (N < M) return;
    ShowDigits(M,N - 1);
    Console.Write($"{N} ");
}

Console.WriteLine("Введите начало промежутка: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите окончание промежутка: ");
int N = Convert.ToInt32(Console.ReadLine());

ShowDigits(M,N);

