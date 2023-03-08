//Задание 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//В итоге получается вот такой массив:

//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7

int[,] RowsToColumns(int[,] array)
{
    if(array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("Row and column count mismatch");
        return array;
    }
    else
    {
        for (int i = 0; i < array.GetLength(0) - 1; i++)
        {
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                int temp = array[i, j];
                array[i,j] = array[j,i];
                array[j,i] = temp;
            }
        }
    }
    return array;
}

Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minimal value of array element");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value of array element");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] array = Create2DRandomArray(columns, rows, minValue, maxValue);
Show2DArray(array);
Show2DArray(RowsToColumns(array));
