void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}
    
int[] array = new int[10];

FillArray(array);

Console.WriteLine(array[0]);

int Add2Num(int x1, int x2)
{
    return x1 + x2;
}

int num1 = 1;
int num2 = 8;

Console.WriteLine(Add2Num(num1, num2));
