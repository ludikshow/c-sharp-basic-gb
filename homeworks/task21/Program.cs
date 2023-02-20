// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Homework #3");

double x1, y1, z1;
double x2, y2, z2;

Console.WriteLine("Введите координату X первой точки");
x1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату Y первой точки");
y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату Z первой точки");
z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату X второй точки");
x2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату Y второй точки");
y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату Z второй точки");
z2 = Convert.ToDouble(Console.ReadLine());


double FindDistance3D(double xx1, double xx2, double yy1, double yy2, double zz1, double zz2)
{
    double res = Math.Sqrt(Math.Pow(xx2 - xx1, 2) + Math.Pow(yy2 - yy1, 2) + Math.Pow(zz2 - zz1, 2));
    return res;
}

double result = FindDistance3D(x1, x2, y1, y2, z1, z2);
Console.WriteLine("The distance is:");
Console.WriteLine(Math.Round(result, 2));
