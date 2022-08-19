// Ex36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19,        [-4, -6, 89, 6] -> 0

void FillArray (int[] arr)    //задание массива случ.числами и вывод его на экран в квадр.скоб. через пробел
{
    for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(-99, 100);
    Console.Write($"[{string.Join("  ", arr)}]");
}
void SumNotMod2(int[] arr)    // Подсчет суммы элементов, стоящих на нечётных позициях в массиве
{
    Console.WriteLine();
    int sum = 0;
    for (int i = 1; i < arr.Length; i+=2)
    {
        sum += arr[i];
    }
    Console.WriteLine($"Сумма элементов на нечетных позициях равна {sum}");
}
Console.Write("Введите размер массива, size = ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr36 = new int[size];
FillArray(arr36);
SumNotMod2(arr36);
