// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Homework #4");

Console.WriteLine("Введите своё число A");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите своё число B");
int b = Convert.ToInt32(Console.ReadLine());

int result = 1;
int c = 1;
while (c <= b)
{
    result = result * a;
    c++;
}

Console.WriteLine(result);
