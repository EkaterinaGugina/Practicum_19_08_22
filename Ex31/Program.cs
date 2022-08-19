// Ex31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.


void FillArray (int[] arr)           //задание массива случ. числами 
{
    Console.WriteLine();
    Console.Write("[");
    int length = arr.Length - 1;
    for (int i =0; i < length; i++)
    {
        arr[i] = new Random().Next(-9, 10);
        Console.Write($"{arr[i]},  ");
    }
    arr[length] = new Random().Next(-9, 10);
    Console.Write($"{arr[length]}]");
}

void SumMinusPlus(int[] arr)                       // Подсчет чётных чисел в массиве
{
    int sum_minus = 0;
    int sum_plus = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sum_minus += arr[i];
        else sum_plus += arr[i]; 
    }
    Console.WriteLine($"сумма положительных элементов равна {sum_plus}, а сумма отрицательных равна {sum_minus}");
}

int[] arr31 = new int[12];
FillArray(arr31);
SumMinusPlus(arr31);
