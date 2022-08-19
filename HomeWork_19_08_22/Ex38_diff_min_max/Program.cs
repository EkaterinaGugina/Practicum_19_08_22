// Задайте массив вещественных чисел. Найдите разницу между макс. и мин. элементами массива.

void PrintArray (double[] arr)              //вывод на экран в "[  ]" через ";"
{
    Console.Write("[");
    int length = arr.Length - 1;
    for (int i =0; i < length; i++) Console.Write($"{arr[i]};  ");
    Console.WriteLine($"{arr[length]}]");
}

double[] FillArray (double[] arr)           //задание массива c консоли  
{    
    Console.WriteLine("Введите элементы массива через Enter");
    int length = arr.Length;
    for (int i = 0; i < length; i++) arr[i] = Convert.ToDouble(Console.ReadLine());
    PrintArray(arr);
    return arr;
}

void DiffMinMax(double[] arr)               // Нахождение позиций мин. и макс. эл-тов и подсчет разности между макс. и миним.
{
    int N = arr.Length - 1;
    int pos_min = 0;
    int pos_max = 0;
    for (int i = 1; i <= N; i++)
    {
        if (arr[i] < arr[pos_min]) pos_min = i;
        else if (arr[i] > arr[pos_max])  pos_max = i;
    }
Console.WriteLine($"Разность между минимальным и максимальными значениями массива = {arr[pos_max] - arr[pos_min]}");        
}  

Console.Write("Введите размер массива, size = ");
int size = Convert.ToInt32(Console.ReadLine());
double[] arr38 = new double[size];
arr38 = FillArray(arr38);
DiffMinMax(arr38); 
