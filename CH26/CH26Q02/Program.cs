using System;

Console.Write("최초 보정값: ");
int initialCorrection = int.Parse(Console.ReadLine());

Console.Write("새 객체 보정값: ");
int newCorrection = int.Parse(Console.ReadLine());

Console.Write("원래 객체의 새 보정값: ");
int originalNewCorrection = int.Parse(Console.ReadLine());

Console.Write("측정값: ");
int measurement = int.Parse(Console.ReadLine());

Calibrator calibrator = new Calibrator(initialCorrection);

Console.WriteLine("처음: " + calibrator.Adjust(measurement));
Func<int, int> Funcs = calibrator.Adjust;

Calibrator original = calibrator;
original.Correction = originalNewCorrection;

calibrator = new Calibrator(newCorrection);

Console.WriteLine("보관: " + Funcs(measurement));
Console.WriteLine("현재: " + calibrator.Adjust(measurement));

class Calibrator
{
    public int Correction { get; set; }

    public Calibrator(int correction)
    {
        Correction = correction;
    }

    public int Adjust(int measurement)
    {
        return measurement + Correction;
    }
}