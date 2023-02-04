// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84; A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.Write("Enter Point's A coordinats X:  ");
double AX = double.Parse(Console.ReadLine());
System.Console.Write("Enter Point's A coordinats Y:  ");
double AY = double.Parse(Console.ReadLine());
System.Console.Write("Enter Point's A coordinats Z:  ");
double AZ = double.Parse(Console.ReadLine());

System.Console.Write("Enter Point's B coordinats X:  ");
double BX = double.Parse(Console.ReadLine());
System.Console.Write("Enter Point's B coordinats Y:  ");
double BY = double.Parse(Console.ReadLine());
System.Console.Write("Enter Point's B coordinats Z:  ");
double BZ = double.Parse(Console.ReadLine());

double C1 = AY - BY;
double C2 = AX - BX;
double C3 = AZ - BZ;

double result = (C1 * C1) + (C2 * C2) + (C3 * C3);
double result2 = Math.Sqrt(result);

System.Console.WriteLine(result2);
