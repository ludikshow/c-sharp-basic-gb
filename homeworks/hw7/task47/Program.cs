// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

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

Console.WriteLine("Введите m:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите n:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] result = new int[m, n];
result = create2DRandomArray(m, n, 0, 10);
print2DRandomArray(result);
