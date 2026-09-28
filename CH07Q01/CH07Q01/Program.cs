using System;
Console.Write("");
int tnsqjs = int.Parse(Console.ReadLine());

Console.Write("");
int zkstn = int.Parse(Console.ReadLine());

int row = tnsqjs / zkstn + 1;
int col = tnsqjs % zkstn;

Console.WriteLine($"행: {row}"); 
Console.WriteLine($"열: {col}");