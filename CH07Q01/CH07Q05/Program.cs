using System;

Console.Write("");
int items = int.Parse(Console.ReadLine());

Console.Write("");
int bundle = int.Parse(Console.ReadLine());

bool div = bundle != 0 && (items % bundle == 0);

Console.WriteLine($"나누기 가능: {div}");