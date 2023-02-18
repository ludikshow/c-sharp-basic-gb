// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Homework #2");

Console.WriteLine("Введите день недели:");
int x1 = Convert.ToInt32(Console.ReadLine());

if (x1 == 6 || x1 == 7)
{
    Console.WriteLine($"да");
}
else
{
    Console.WriteLine($"нет");
}
