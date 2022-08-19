// Задайте массив вещественных чисел. Найдите разницу между макс. и мин. элементами массива.
// [3 7 22 2 78] -> 76

void FillArray (double[] arr)           //задание массива c консоли и вывод их на экран
{    
    Console.WriteLine("Введите элементы массива через Enter");
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = Convert.ToDouble(Console.ReadLine());
        Console.Write($"{arr[i]},  ");
    }
}
void DiffMinMax(double[] arr)                       // Подсчет разности максимального и минимального элементов массива
{
    Console.WriteLine();
    int N = arr.Length - 1;
    for (int i = 0; i < N; i++)
    {
        int position_min = i;
        for (int j = i + 1; i < arr.Length; i++)
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
    return (arr[length] - arr[0]);
}
Console.Write("Введите размер массива, size = ");
int size = Convert.ToInt32(Console.ReadLine());
double[] arr38 = new double[size];
FillArray(arr36);
SumNotMod2(arr36);
