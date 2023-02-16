// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Homework #1");

Console.WriteLine("Введите своё число:");
int x1 = Convert.ToInt32(Console.ReadLine());

if (x1 % 2 == 0)
{
    Console.WriteLine($"да");
}
else
{
    Console.WriteLine($"нет");
}
