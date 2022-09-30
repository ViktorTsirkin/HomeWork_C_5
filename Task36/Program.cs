/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine()!);

int[] array = GetArray(n, 0, 99); //в условии задачи не указан диапазон чисел, задал произвольный 
Console.WriteLine($"[{String.Join("; ", array)}]"); 

int GetSum = GetSumOdd(array);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна {GetSum}");

int [] GetArray(int size, int minValue, int maxValue) 
{
    int[] res = new int[size]; 
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1); 
    }
    return res;
}

int GetSumOdd(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if ((i + 1) % 2 == 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}