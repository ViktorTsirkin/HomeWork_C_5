/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine()!);

int[] array = GetArray(n, 100, 999); 
Console.WriteLine($"[{String.Join("; ", array)}]"); 

int HowMany = HowManyEven(array);
Console.WriteLine($"Количество четных элементов массива составляет {HowMany} шт.");

int [] GetArray(int size, int minValue, int maxValue) 
{
    int[] res = new int[size]; 
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1); 
    }
    return res;
}

int HowManyEven(int[] array)
{
    int q = 0; //Счетчик количества элементов
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            q++;
        }
    }
    return q;
}