// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int[] CreateRandomArray(int lowBound, int highBound, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(lowBound, highBound + 1);
    }
    return array;
}

void PrintArray(int[] array, int index = 0)
{
    if (index > array.Length - 1)
    {
        Console.WriteLine();
        return;
    }
    else
    {
        Console.Write($"{array[index]} ");
        PrintArray(array, index + 1);
        Console.Write($"{array[index]} ");
    }
}

Console.WriteLine("Введите минимальное число в массиве: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное число в массиве: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(min, max, size);

PrintArray(array);