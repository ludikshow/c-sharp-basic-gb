// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.WriteLine("Homework #4");

int[] CreateRandomArray(int size=8, int minValue=0, int maxValue=100)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
    Console.WriteLine();
}

int[] myArray = CreateRandomArray();

ShowArray(myArray);