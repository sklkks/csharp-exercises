using System;

Console.Write("정수: ");
int a = int.Parse(Console.ReadLine());
Console.Write("실수: ");
double b = double.Parse(Console.ReadLine());

int wjd = Clamp(a, 0, 10);
double tlf = Clamp_(b, 0, 10);
double mix = Clamp_(a, 0.0, 2.5);

Console.WriteLine($"정수: {wjd}\n실수: {tlf:F2}\n혼합: {mix:F2}");

int Clamp(int value, int minimum, int maximum)
{
    if(value > maximum)
    {
        value = maximum;
    }
    if (value < minimum)
    {
        value = minimum;
    }

    return value;
}


double Clamp_(double value, double minimum, double maximum)
{
    if (value > maximum)
    {
        value = maximum;
    }
    if (value < minimum)
    {
        value = minimum;
    }

    return value;
}