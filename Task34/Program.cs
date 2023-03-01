// // Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Clear();
int[] Array1 = GetArray(7, 100, 1000);
Console.Write($"[{String.Join(", ", Array1)}]");
Console.Write($" -> {GetCountElements(Array1)}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
int GetCountElements(int[] Array1)
{
    int count = 0;
    foreach (var item in Array1)
    {
        if (item % 2 == 0) count++;
    }
    return count;
}