//*Задача 37: Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21*/

int[] arr(int size, int a, int b)   //заполнение массива
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(a, b + 1);
    }
    return array;
}

void Mult(int[] arr)
{
    for (int i = 0; i < arr.Length/2; i++)
    {
        Console.Write($" {arr[i]*arr[arr.Length-1-i]}");
    }
if(arr.Length % 2 != 0) Console.Write (arr[arr.Length/2]);
}

Console.Write("Введите размер массива, size = ");  //заполнение и печать массива
int size = Convert.ToInt32(Console.ReadLine());
int[] array37 = arr(size, 1, 10);
Console.WriteLine($"[{string.Join(" ", array37)}]");
Mult(array37);
