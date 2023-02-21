// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Homework #2");

Console.WriteLine("Введите своё число:");
string str_number = Console.ReadLine();

if (str_number.Length < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine(str_number[2]);
}
