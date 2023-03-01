// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Clear();
int[] Array = GetArray(4, -100, 100);
Console.Write($"[{String.Join(", ", Array)}]");
Console.Write($" -> {SumEvenPosition(Array)}");
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
int SumEvenPosition (int[] Array)
{
    int result = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (i % 2 == 1) result += Array[i];
    }
    return result;
}