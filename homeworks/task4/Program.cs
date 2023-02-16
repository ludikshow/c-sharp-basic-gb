// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Homework #1");

Console.WriteLine("Введите первое число:");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число:");
int x3 = Convert.ToInt32(Console.ReadLine());

int maximum = Math.Max(x1, Math.Max(x2, x3));
Console.WriteLine($"math max = {maximum}");

int[] numbers = {x1, x2, x3};

int enum_max = Enumerable.Max(numbers);
Console.WriteLine($"enum max = {enum_max}");
