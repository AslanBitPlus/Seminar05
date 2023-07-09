// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// =======================
double[] CreateRndArrayDouble(int size, int min, int max)
{
    double[] rndArray = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < rndArray.Length; i ++)
    {
        double num = rnd.NextDouble() * (max - min) * min; 
        rndArray[i] = Math.Round(num, 1);
    }
    return rndArray;
}
// =======================
void PrintArray(double[] array, string sep = " ")
{
    for (int i = 0; i < array.Length; i ++)
    {
        if (i == 0) Console.Write($"[{array[i]}{sep} ");
        else if (i < array.Length - 1) Console.Write($"{array[i]}{sep} ");
        else Console.Write($"{array[i]}]");
    }
}
// =======================
double DifferenceMaxMinArray(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i ++)
    {
        if (array[i] < min ) min = array[i];
        if (array[i] > max ) max = array[i];
    }
    return max - min;
}
// =======================

Console.Write("Введите размерность массива :");
int arrSize = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите нижнюю границу чисел массива :");
int arrMinNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите верхнюю границу чисел массива :");
int arrMaxNum = Convert.ToInt32(Console.ReadLine());

double[] arr = CreateRndArrayDouble(arrSize, arrMinNum, arrMaxNum);
PrintArray(arr, ";");

Console.WriteLine();
double difference = Math.Round(DifferenceMaxMinArray(arr), 1);
Console.Write($"Разница между максимальным и минимальным элементов массива равна {difference}");