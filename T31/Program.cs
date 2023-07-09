// Задайте массив из 12 элементов, заполненный случайными числами
// из промежутка [-9, 9]. Найдите сумму отрицательных и положительных
// элементов массива
// Например в массиве [3, 9 -8, 1, 0, -7, 2, -1, 8, -3, -1, 6] сумма 
// положительных чисел равна 29, сумма отрицательных равна -20.

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
int[] GetSumNegPosEleme(int[] arr)
{
    int sumPositive = 0;
    int sumNegative = 0;
    for (int i = 0; i < arr.Length; i ++)
    {
        if (arr[i] < 0) sumNegative += arr[i];
        else sumPositive += arr[i];
    }
    return new int[] {sumNegative, sumPositive};
}


Console.Write("Введите размерность массива :");
int arrSize = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите нижнюю границу чисел массива :");
int arrMinNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите верхнюю границу чисел массива :");
int arrMaxNum = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateRndArray(arrSize, arrMinNum, arrMaxNum);
PrintArray(arr, ",");

int[] sumNegPosEleme = GetSumNegPosEleme(arr);
Console.WriteLine();
Console.WriteLine($"Сумма отрицательных элементов массива: {sumNegPosEleme[0]}");
Console.WriteLine($"Сумма положительных элементов массива: {sumNegPosEleme[1]}");

