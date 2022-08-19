// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] arr(int size, int a, int b)             //"создание" массива
{
   int[] array = new int[size];
   for(int i = 0; i < size; i++) array[i] = new Random().Next(a, b + 1);
   return array;
}

void SeachElem (int[] arr, int elem)          //поиск элемента
{
bool label = false;
for (int i = 0; i < arr.Length; i++) if (arr[i] == elem) label = true;
if (label) Console.WriteLine($"да, элемент {elem} в массиве есть");
else Console.WriteLine($"элемента {elem} в массиве нет");
}

Console.Write("Введите размер массива, size = ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array33 = arr(size, -9, 9);
Console.WriteLine($"[{string.Join(" ", array33)}]");
Console.Write("Введите элемент (число) для поиска его в массиве, elem = ");
int elem = Convert.ToInt32(Console.ReadLine());
SeachElem(array33, elem);
