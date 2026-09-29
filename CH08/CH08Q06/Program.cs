using System;

Console.Write("식권 종류: ");
string type = Console.ReadLine();

Console.Write("인원 수: ");
int num = int.Parse(Console.ReadLine());

int bundleSize;

switch (type)
{
    case "single":
        bundleSize = 1;
        break;

    case "pair":
        bundleSize = 2;
        break;

    case "family":
        bundleSize = 4;
        break;

    default:
        Console.WriteLine("지원하지 않는 종류");
        return;
}

int total = (num + bundleSize - 1) / bundleSize;
int ska = (total * bundleSize) - num;

Console.WriteLine($"묶음 수: {total}");
Console.WriteLine($"남는 식권: {ska}");