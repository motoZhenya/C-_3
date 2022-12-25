// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите первую координату первой точки ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите вторую координату первой точки ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите третью координату первой точки ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите первую координату второй точки ");
int y = int.Parse(Console.ReadLine()!);
Console.Write("Введите вторую координату второй точки ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите третью координату второй точки ");
int y2 = int.Parse(Console.ReadLine()!);

// double A = Math.Pow(y-x, 2); 
// double B = Math.Pow(y1-x1, 2); 
// double С = Math.Pow(y2-x2, 2); 
double ABC = Math.Sqrt(Math.Pow(y-x, 2)+Math.Pow(y1-x1, 2)+Math.Pow(y2-x2, 2));
Console.WriteLine(ABC);
