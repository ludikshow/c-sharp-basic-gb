String my_name; // Выделение памяти для переменной (строчное значение)


Console.WriteLine("Введите своё имя:");
my_name = Console.ReadLine();

Console.WriteLine("Введите своё число:");
int x1 = Convert.ToInt32(Console.ReadLine());

if (my_name == "Vasya")
{
    Console.WriteLine("Привет, дурак " + my_name);
}
else
{
    Console.WriteLine("Привет, " + my_name);
}


int c = 1;
while (c <= x1)
{
    Console.WriteLine("Пока!");
    c = c + 1;
}
