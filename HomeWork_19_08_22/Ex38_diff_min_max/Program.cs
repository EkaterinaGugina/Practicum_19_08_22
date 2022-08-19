// Задайте массив вещественных чисел. Найдите разницу между макс. и мин. элементами массива.
// [3 7 22 2 78] -> 76

double[] FillArray (double[] arr)           //задание массива c консоли  
{    
    Console.WriteLine("Введите элементы массива через Enter");
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = Convert.ToDouble(Console.ReadLine());
    }
    return arr;
}

void PrintArray (double[] arr)              //вывод на экран в квадр.скоб. через ","
{
    Console.Write("[");
    int length = arr.Length - 1;
    for (int i =0; i < length; i++)
    {
        Console.Write($"{arr[i]};  ");
    }
    Console.WriteLine($"{arr[length]}]");
}

double DiffMinMax(double[] arr)               // Подсчет разности максимального и минимального элементов массива
{
    int N = arr.Length - 1;
    for (int i = 0; i < N; i++)
    {
        int position_min = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[position_min])
                {
                    position_min = j;
                }
        }
        double min = arr[i];
        arr[i] = arr[position_min];
        arr[position_min] = min;
    }
    PrintArray(arr);
    return (arr[N] - arr[0]);
}
Console.Write("Введите размер массива, size = ");
int size = Convert.ToInt32(Console.ReadLine());
double[] arr38 = new double[size];
double[] array38 = FillArray(arr38);
double diff_min_max = DiffMinMax(arr38);
Console.WriteLine($"Разность между минимальным и максимальными значениями массива равна = {diff_min_max}");
