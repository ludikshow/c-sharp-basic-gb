// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Homework #1");

Console.WriteLine("Введите своё число:");
int x1 = Convert.ToInt32(Console.ReadLine());
int c = 1;

Console.WriteLine("Вывод четных чисел:");
while (c <= x1)
{
    if (c % 2 == 0)
    {
        Console.Write(c + ", ");
    }
    
    c = c + 1;
}

Console.WriteLine("Всё");
