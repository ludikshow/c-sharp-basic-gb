// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите количество элементов массива:");
string value = Console.ReadLine();
int lenght = Convert.ToInt32(value);

int[] array = new int[lenght];

for (int i = 0; i < array.Length; i++)
{
  Console.WriteLine($"Введите {i + 1}й элемент массива:");
  array[i] = Convert.ToInt32(Console.ReadLine());
}

int count = 0;

for (int i = 0; i < array.Length; i++)
{
  if (array[i] > 0)
  {
    count = count + 1;
  }
}

Console.WriteLine("Количество числе больше 0 = " + count);

