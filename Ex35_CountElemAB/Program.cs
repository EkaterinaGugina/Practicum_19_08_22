/*Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/

int[] arr(int size, int a, int b)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++) array[i] = new Random().Next(a, b + 1);
    return array;
}

void SeachElemFromAB(int[] arr, int A, int B)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > A && arr[i] < B)
        count++;
    }
    Console.WriteLine($"Количество элементов из этого промежутка здесь ровно {count}");

}

Console.Write("Введите размер массива, size = ");  //заполнение и печать массива
int size = Convert.ToInt32(Console.ReadLine());
int[] array35 = arr(size, -101, 200);
Console.WriteLine($"[{string.Join(" ", array35)}]");

Console.Write("Введите границы отрезка [А, В] для поиска, A = ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("B = ");
int B = Convert.ToInt32(Console.ReadLine());
SeachElemFromAB(array35, A, B);
