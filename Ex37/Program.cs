//*Задача 37: Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21*/

int[] arr(int num, int x, int y)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(x, y + 1);
    }
    return array;
}
void Mult(int[] arr)
{
    for (int i = 0; i < arr.Length/2; i++)
    {
        Console.Write($" {arr[i]*arr[arr.Length-1-i]} ");
    }
if(arr.Length % 2 != 0) Console.Write (arr[arr.Length/2]);
}

int[] array33 = arr(5, 1, 15);
Console.WriteLine(string.Join(" ", array33));
Mult(array33);
