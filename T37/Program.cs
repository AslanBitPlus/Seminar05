// Найждите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве

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
int[] NewArray(int[] array, int size)
{
    
    int[] result = new int[size];

    for (int i = 0; i < result.Length; i ++)
    {
        if (i != array.Length - 1 - i)
            result[i] = array[i] * array[array.Length - 1 - i];
        else
            result[i] = array[i];     
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

int newArrSize = 0;
if (arrSize % 2 == 0) newArrSize = arrSize / 2;
else newArrSize = arrSize / 2 + 1;

// Console.Write($"Размерность нового массива :{newArrSize}");
Console.WriteLine();
int[] newArr = NewArray(arr, newArrSize);
PrintArray(newArr, ",");
