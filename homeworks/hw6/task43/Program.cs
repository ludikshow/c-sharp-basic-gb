// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
double[] FindCross(double[] firstLine, double[] secondLine)
{
  double[] coord = new double[2];
  coord[0] = (firstLine[1] - secondLine[1]) / (secondLine[0] - firstLine[0]);
  coord[1] = firstLine[1] * coord[0] + firstLine[1];
  return coord;
}

// Первая прямая
double[] line1 = new double[2];
Console.WriteLine("Введите коэфициент для прямой 1:");
line1[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите константу для прямой 1:");
line1[1] = Convert.ToDouble(Console.ReadLine());


// Вторая прямая
double[] line2 = new double[2];
Console.WriteLine("Введите коэфициент для прямой 2:");
line2[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите константу для прямой 2:");
line2[1] = Convert.ToDouble(Console.ReadLine());

 