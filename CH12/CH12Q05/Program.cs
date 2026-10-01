using System;

Console.Write("항목 수:");
int count = int.Parse(Console.ReadLine());

string[] identifiers = new string[count];
int[] quantities = new int[count];

int width = 4;

for(int i = 0; i < count; i++)
{
    Console.WriteLine();
    Console.WriteLine($"[항목 {i + 1}]");
    Console.Write("식별자: ");
    identifiers[i] = Console.ReadLine();
    Console.Write("수량: ");
    quantities[i] = int.Parse(Console.ReadLine());

    if (identifiers[i].Length > width)
    {
        width = identifiers[i].Length;
    }
}

string format = $"|{{0,-{width}}}|{{1,10}}|";
string border = new string('-', width + 10 + 3);

Console.WriteLine(border);
Console.WriteLine(format, "ID", "COUNT");

for (int i = 0; i < count; i++)
{
    Console.WriteLine(format, identifiers[i], quantities[i]);
}
Console.WriteLine(border);