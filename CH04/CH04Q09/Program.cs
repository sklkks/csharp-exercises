using System;

Console.Write("전체 면적: ");
double area = double.Parse(Console.ReadLine());
Console.Write("비워 둘 테두리 폭: ");
double width = double.Parse(Console.ReadLine());

double side = Math.Sqrt(area);
double inside = Math.Round(side - (width * 2), 2);
double using_area = Math.Round(inside * inside, 2);

Console.WriteLine($"안쪽 한 변: {inside}m");
Console.WriteLine($"사용 면적: {using_area}㎡");