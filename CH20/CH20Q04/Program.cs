using System;
using CH20Q04;

Console.Write("외부 가로: ");
int width = int.Parse(Console.ReadLine());

Console.Write("외부 세로: ");
int length = int.Parse(Console.ReadLine());

Console.Write("외부 높이: ");
int height = int.Parse(Console.ReadLine());

Console.Write("단열재 두께: ");
int insulation = int.Parse(Console.ReadLine());

Console.Write("냉각재 부피: ");
int coolant = int.Parse(Console.ReadLine());

Console.Write("물건 부피: ");
int volume = int.Parse(Console.ReadLine());

ColdBox box = new ColdBox(width, length, height, insulation, coolant);


Console.WriteLine($"외부 {box.ExternalVolume}, 내부 {box.InternalVolume}, 사용 가능{box.AvailableVolume}");
Console.WriteLine($"보관 가능: {box.Canstore(volume)}");