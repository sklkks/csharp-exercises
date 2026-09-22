using System;

Console.Write("가로 픽셀 수: ");
int rk = int.Parse(Console.ReadLine());
Console.Write("세로 픽셀 수: ");
int tp = int.Parse(Console.ReadLine());
Console.Write("길이 확대 비율: ");
int ghkr = int.Parse(Console.ReadLine());



int pixel = rk * tp * ghkr;

Console.Write($"확대 후 픽셀 수: {pixel}");
Console.Write($"추가 메모리: {}바이트");