// Ex34: Задайте массив заполненный случайными положительными трёхзначными числами.  
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void FillArraySize3 (int[] arr)           //задание массива случ. трехзн.числами и вывод их на экран в квадр.скоб. через ","
{
    Console.WriteLine();
    Console.Write("[");
    int length = arr.Length - 1;
    for (int i =0; i < length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
        Console.Write($"{arr[i]},  ");
    }
    arr[length] = new Random().Next(100, 1000);
    Console.WriteLine($"{arr[length]}]");
}

void Mod2(int[] arr)                                    // Подсчет чётных чисел в массиве
{
    Console.WriteLine();
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Число четных чисел в массиве равно {count}");
}

Console.Write("Введите размер массива, size = ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr34 = new int[size];
FillArraySize3(arr34);
Mod2(arr34);
