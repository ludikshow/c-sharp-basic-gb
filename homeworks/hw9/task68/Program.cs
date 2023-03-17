// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите два полфункции Аккерманаожительных числа: M и N.");
int m = InputInt("Введите M: ");
int n = InputInt("Введите N: ");
Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}


static int Akkerman(int n, int m)
{
  if ((n == 1) && (m == 1))
    return 1;
  else
    if (n > 1)
      return Akkerman(n - 1, m) + m;
    else
      return Akkerman(n, m - 1) + 1;
}
