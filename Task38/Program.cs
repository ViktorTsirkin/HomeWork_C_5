/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine()!);

int[] array = GetArray(n, 0, 50); //в условии задачи не указан диапазон чисел, задал произвольный 
Console.WriteLine($"[{String.Join("; ", array)}]"); 

int GetMinimum = GetMin(array);
int GetMaximum = GetMax(array);
Console.WriteLine($"Разница между минимальныи и максимальным значениями элементов массива составляет {GetMaximum - GetMinimum}");

int [] GetArray(int size, int minValue, int maxValue) 
{
    int[] res = new int[size]; 
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1); 
    }
    return res;
}

int GetMin(int[] array)
{
    int minimum = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if (array[i] < minimum)
        {
            minimum = array[i];
        }
    }
    return minimum;
}

int GetMax(int[] array)
{
    int maximum = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if (array[i] > maximum)
        {
            maximum = array[i];
        }
    }
    return maximum;
}
