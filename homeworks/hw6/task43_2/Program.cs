// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
double[] line1;
double[] line2;
double[] line3;
double[] line4;

const int COEF = 0;
const int CONSTANT = 1;


double[] FindCross(double[] firstLine, double[] secondLine)
{
  double[] coord = new double[2];
  coord[0] = (firstLine[CONSTANT] - secondLine[CONSTANT]) / (secondLine[COEF] - firstLine[COEF]);
  coord[1] = firstLine[CONSTANT] * coord[COEF] + firstLine[CONSTANT];
  return coord;
}

double Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}

double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[COEF] = Prompt($"Введите коэфициент для прямой {numberOfLine}:");
    lineData[CONSTANT] = Prompt($"Введите константу для прямой {numberOfLine}:");
    return lineData;
}

// Первая прямая
line1 = InputLineData(1);
line2 = InputLineData(2);

line3 = InputLineData(3);
line4 = InputLineData(4);

double[] result = FindCross(line1, line2);
double[] result2 = FindCross(line3, line4);

Console.WriteLine($"Пересечение прямых 1 и 2 в коориданте [{result[0]}, {result[1]}]");

Console.WriteLine($"Пересечение прямых 3 и 4 в коориданте [{result2[0]}, {result2[1]}]");
