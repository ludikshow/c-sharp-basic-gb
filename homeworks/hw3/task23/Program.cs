// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Homework #3");

int result;

Console.WriteLine("Введите своё число:");
int n = Convert.ToInt32(Console.ReadLine());

int c = 1;
while (c <= n)
{
    result = c * c * c;
    Console.Write(Convert.ToString(result) + " ");
    c = c + 1;
}

Console.WriteLine("\nThe end");
