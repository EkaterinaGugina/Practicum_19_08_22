// Ex36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19,        [-4, -6, 89, 6] -> 0

void FillArray (int[] arr)           //задание массива случ. числами и вывод их на экран в квадр.скоб. через ","
{
    Console.WriteLine();
    Console.Write("[");
    int length = arr.Length - 1;
    for (int i =0; i < length; i++)
    {
        arr[i] = new Random().Next(-99, 100);
        Console.Write($"{arr[i]},  ");
    }
    arr[length] = new Random().Next(-99, 100);
    Console.WriteLine($"{arr[length]}]");
}
void SumNotMod2(int[] arr)                       // Подсчет суммы элементов, стоящих на нечётных позициях в массиве
{
    Console.WriteLine();
    int sum = 0;
    for (int i = 1; i < arr.Length; i+=2)
    {
        sum = sum + arr[i];
    }
    Console.WriteLine($"Сумма элементов на нечетных позициях равна {sum}");
}
Console.Write("Введите размер массива, size = ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr36 = new int[size];
FillArray(arr36);
SumNotMod2(arr36);
