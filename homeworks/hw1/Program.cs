//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Homework #1");

Console.WriteLine("Введите первое число:");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int x2 = Convert.ToInt32(Console.ReadLine());

if (x1 > x2)
{
    Console.WriteLine("max = " + x1);
    Console.WriteLine("min = " + x2);
}
else
{
    Console.WriteLine($"max = {x2}, min = {x1}");
}
