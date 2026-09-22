using System;

Console.Write("현재 밝기: ");
int light = int.Parse(Console.ReadLine());

int Maxlight = 255;
int Minlight = 0;

int Min = Math.Abs(light - Minlight);
int Max = Math.Abs(light - Maxlight);

Console.WriteLine($"낮출 수 있는 양: {Min}");
Console.WriteLine($"높일 수 있는 양: {Max}");
