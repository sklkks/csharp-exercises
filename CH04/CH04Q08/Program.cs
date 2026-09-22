using System;

Console.Write("가로 픽셀 수: ");
int width = int.Parse(Console.ReadLine());
Console.Write("세로 픽셀 수: ");
int length = int.Parse(Console.ReadLine());
Console.Write("길이 확대 비율: ");
int enlargement = int.Parse(Console.ReadLine());



int memory = width * length * 4;
int scale = (int)Math.Pow(enlargement, 2);
int enl_pixel = memory * scale;
int addedMemory = enl_pixel - memory;
int pixel = width * length * scale;

Console.WriteLine($"확대 후 픽셀 수: {pixel}");
Console.WriteLine($"추가 메모리: {addedMemory}바이트");