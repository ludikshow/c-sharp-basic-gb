// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Homework #2");

Console.WriteLine("Введите своё число:");
string str_number = Console.ReadLine();


int number = Convert.ToInt32(str_number);

int x1 = number / 10 % 10;

Console.WriteLine(x1);

