// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите X координату 1й точки: ");
int xa1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y координату 1й точки: ");
int ya1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z координату 1й точки: ");
int za1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите X координату 2й точки: ");
int xb2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y координату 2й точки: ");
int yb2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z координату 2й точки: ");
int zb2 = Convert.ToInt32(Console.ReadLine());

double Dist3d(int xa, int ya, int za, int xb, int yb, int zb)
{
    double dx = xa - xb;
    double dy = ya - yb;
    double dz = za - zb;
    return Math.Sqrt(dx * dx + dy * dy + dz * dz);
}

double result = Dist3d(xa1, ya1, za1, xb2, yb2, zb2);
Console.WriteLine($"A({xa1},{ya1},{za1}); B ({xb2},{yb2},{zb2}) -> {Math.Round(result, 2)}");