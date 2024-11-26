/*  1
static void Hello32()
{
    for (var i = 0; i < 32; i++)
    {
        Console.WriteLine("Hello World");
    }
}

Hello32();

Console.ReadLine();
 */



/*   2
static void kvadrat(int square)
{
    Console.WriteLine($"{square * square}");
}

kvadrat(5);

Console.ReadLine(); */



/*   3
static double Multi(double a, double b)
{
    return a * b;
}

double result = Multi(3.5, 2.0);
Console.WriteLine($"Resultatet är: {result}");
Console.ReadLine(); */



static double RightTriangleArea(double basLengd, double hight)
{
    return (basLengd * hight) / 2;
}

double basLengd = 5.0;
double hight = 3.0;

double area = RightTriangleArea(basLengd, hight);
Console.WriteLine($"Arean av den rätvinkliga triangeln är: {area}");
Console.ReadLine();
