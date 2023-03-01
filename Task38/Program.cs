// // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.Clear();
int[] Array = GetArray(5, 0, 100);
Console.Write($"[{String.Join(", ", Array)}]");
Console.Write($" -> {Max(Array) - Min(Array)}");
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
int Max (int[] array)
{
    int max = array[0];
        for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];      
    }
    return max;    
}
int Min (int[] Array)
{
    int min = Array[0];
        for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] < min) min = Array[i];      
    }
    return min;    
}
