// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
int SumOddArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i ++)
    {
        if (i % 2 != 0) sum += array[i];
    }
    return sum;
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
int sumOdd = SumOddArray(arr);
Console.Write($"Сумма элементов, стоящих на нечётных позициях равна {sumOdd}");