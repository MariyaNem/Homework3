//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите кооридинаты: ");
Console.Write("Ax: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Ay: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Az: ");
int az = Convert.ToInt32(Console.ReadLine());
Console.Write("Bx: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("By: ");
int by = Convert.ToInt32(Console.ReadLine());
Console.Write("Bz: ");
int bz = Convert.ToInt32(Console.ReadLine());

double result = Math.Round(Coordinate(ax, ay, az, bx, by, bz), 2, MidpointRounding.ToZero);
Console.WriteLine(result);

double Coordinate(int ax1, int ay2, int az3, int bx1, int by2, int bz3)
{
    double coordinate = Math.Sqrt(Math.Pow((bx1 - ax1), 2) + Math.Pow((by2 - ay2), 2) + Math.Pow((bz3 - az3), 2));
    return coordinate;
}
