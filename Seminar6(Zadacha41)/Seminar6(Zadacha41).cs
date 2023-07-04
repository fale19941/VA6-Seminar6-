Console.Clear();
int[] InputNum(int size, int[] arr)                                            // ввод размера массива и его элементов
{
    Console.WriteLine("Введите числа массива: ");
    //int m = int.TryParse(Console.ReadLine(), out var number);
    //int[] array = new int[m];
    
    for(int index = 0; index < size; index++)
    {
        arr[index] = int.Parse(Console.ReadLine()!);
    }
    return arr;
}

void PrintArray(int[] arr)                                          // распечатки массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int CountPositive(int[] array)                                      // подсчет положительных элементов массива
{
    int count = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] > 0) count = count + 1;
    }
    return count;
}

Console.WriteLine("Введите количество чисел M: ");
int m = int.Parse(Console.ReadLine()!);
int[] array = new int[m]; 

InputNum(m, array);
Console.WriteLine();
PrintArray(array);
int count = CountPositive(array);
Console.WriteLine($" --> {count}  положительных элементов(-a).");
