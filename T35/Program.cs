// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат
// в отрезке [10, 99]

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
int FindElemInArray(int[] array, int minElem, int maxElem)
{
    int result = 0;
    for (int i = 0; i < array.Length; i ++)
    {
        if (array[i] >= minElem && array[i] <= maxElem) result += 1;
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


Console.WriteLine();
Console.Write("Введите нижнюю границу чисел для поиска в массиве :");
int arrMinElem = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите верхнюю границу чисел для поиска в массиве :");
int arrMaxElem = Convert.ToInt32(Console.ReadLine());

int findElem = FindElemInArray(arr, arrMinElem, arrMaxElem);
if (findElem == 0)
{
    Console.WriteLine($"В массиве НЕТ числа из отрезка [{arrMinElem}, {arrMaxElem}]");
}
else Console.WriteLine($"В массиве ЕСТЬ  {findElem} чисел из отрезка [{arrMinElem}, {arrMaxElem}]");
