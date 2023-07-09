// Задайте массив. Напишите программу, которая определяет
// присутствует ли заданное число в массиве

// =======================
int[] CreateRndArray(int size, int min, int max)
{
    int[] rndArray = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < rndArray.Length; i ++)
    {
        rndArray[i] = rnd.Next(min, max + 1);
    }
    return rndArray;
}
// =======================
void PrintArray(int[] array, string sep = " ")
{
    for (int i = 0; i < array.Length; i ++)
    {
        if (i == 0) Console.Write($"[{array[i]}{sep} ");
        else if (i < array.Length - 1) Console.Write($"{array[i]}{sep} ");
        else Console.Write($"{array[i]}]");
    }
}
// =======================
int FindElemInArray(int[] array, int elem)
{
    int result = 0;
    for (int i = 0; i < array.Length; i ++)
    {
        if (array[i] == elem) result += 1;
    }
    return result;
}
// =======================

Console.Write("Введите размерность массива :");
int arrSize = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите нижнюю границу чисел массива :");
int arrMinNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите верхнюю границу чисел массива :");
int arrMaxNum = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateRndArray(arrSize, arrMinNum, arrMaxNum);
PrintArray(arr, ",");

//
Console.WriteLine();
Console.Write("Введите число для поиска в массиве :");
int num = Convert.ToInt32(Console.ReadLine());

int findElemInArray = FindElemInArray(arr, num);

if (findElemInArray == 0)
{
    Console.WriteLine($"В массиве НЕТ числа {num}");
}
else if (findElemInArray == 1)
{
    Console.WriteLine($"В массиве ЕСТЬ одно число {num}");
}
else Console.WriteLine($"В массиве ЕСТЬ число {num}, и таких чисел {findElemInArray}");