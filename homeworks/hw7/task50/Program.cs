// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] create2DRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] new2DArray = new int[rows,columns];
    for(int i = 0; i < rows; i++)
    {
        for( int j = 0; j < columns; j++)
        {
            new2DArray[i,j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return new2DArray;
}

void print2DRandomArray(int[,] array)
{
    for( int i = 0; i < array.GetLength(0); i++)
    {
        for( int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine("");

    }
}


int[,] result = new int[6, 6];
result = create2DRandomArray(6, 6, 0, 10);

print2DRandomArray(result);

Console.WriteLine("Введите row:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите column:");
int n = Convert.ToInt32(Console.ReadLine());

if (m <= 6 && n <= 6)
{
    Console.WriteLine(result[m - 1, n - 1]);
}
else
{
    Console.WriteLine("Такого числа нет!");
}
