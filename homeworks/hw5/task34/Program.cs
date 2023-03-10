// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// Console.WriteLine("Введите количество элементов массива:");
// int a = Convert.ToInt32(Console.ReadLine());
// int[] randomArray = new int[a];

// void mas(int a)
// {
// for (int i = 0; i < a; i++)
// {
// randomArray[i] = new Random().Next(99,999);
// Console.WriteLine(randomArray[i] ++);
// }

// }

// int kol(int[] randomArray)
// {
// int kol = 0;
// for (int i = 0; i < randomArray.Length; i++)
// {
// if (randomArray[i] % 2 == 0)
// kol = kol + 1;
// }
// return kol;
// }

// mas(a);
// Console.WriteLine($"Количество чётных чисел в массиве: {kol(randomArray)}");


Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int count = 0;

for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0)
count++;

Console.WriteLine($"Количество чётных чисел в массиве: {count}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}