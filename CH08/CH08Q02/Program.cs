using System;

bool sksqkd = bool.Parse(Console.ReadLine());
int dhseh = int.Parse(Console.ReadLine());

if (dhseh <= 18)
{
    sksqkd = true;
}

else if (dhseh >= 22)
{
    sksqkd = false;
}
Console.WriteLine($"난방 켜짐: {sksqkd}");