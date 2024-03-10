// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int AccermanCalc(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AccermanCalc(m - 1, 1);
    else return AccermanCalc(m - 1, AccermanCalc(m, n - 1));
}

int InputArg()
{
    int arg = Convert.ToInt32(Console.ReadLine());

    if (arg >= 0) return arg;
    else
    {
        Console.WriteLine("Число должно быть неотрицательным");
        return InputArg();
    }
}

Console.WriteLine("Введите число m для функции Аккермана:");
int m = InputArg();

Console.WriteLine("Введите число n для функции Аккермана:");
int n = InputArg();

Console.Write($"Значение функции Аккермана для чисел {m} и {n} равно {AccermanCalc(m, n)}");