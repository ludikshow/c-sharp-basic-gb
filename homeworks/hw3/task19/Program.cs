// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Homework #3");

Console.WriteLine("Введите своё число:");
string str_number = Console.ReadLine();

if (str_number.Length == 5)
{
    int number = Convert.ToInt32(str_number);
    int x1 = number / 10000;
    int x2 = number / 1000 % 10;
    int x3 = number / 100 % 10;
    int x4 = number / 10 % 10;
    int x5 = number / 1 % 10;

    if (x1 == x5 && x2 == x4)
    {
        Console.WriteLine($"{number} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - не Палиндром");
    }
}
else
{
    Console.WriteLine("Вы ввели не пятизначное число...(");
}
