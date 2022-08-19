// Ex32: ЗНапишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

void PrintArray (int[] arr)              //вывод на экран в "[  ]" через пробел
{
    Console.Write("[");
    Console.Write(string.Join(" ", arr));
    Console.WriteLine("]");
}

int[] FillArray (int[] arr)           //задание массива случ. числами 
{
    int length = arr.Length - 1;
    for (int i =0; i <= length; i++)
    {
        arr[i] = new Random().Next(-9, 10);
    }
    return arr;
}

void Invers(int[] arr)                     //замена на противоположные
{
    Console.WriteLine();
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
        Console.Write($" {arr[i]}");
    }
    Console.WriteLine("]");
}

Console.Write("Введите размер массива, size = ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array32 = new int[size];
array32 = FillArray(array32);
PrintArray(array32);
Console.WriteLine();
Invers(array32);
