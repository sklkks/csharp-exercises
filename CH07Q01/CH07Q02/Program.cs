using System;

Console.Write("");
int guswo = int.Parse(Console.ReadLine());

Console.Write("");
int charge = int.Parse(Console.ReadLine());

Console.Write("");
int pay = int.Parse(Console.ReadLine());

Console.Write("");
int ghksqnf = int.Parse(Console.ReadLine());

decimal ghksqnfdor = (pay / 100) * ghksqnf;
decimal total = (guswo + charge -pay) + ghksqnfdor;


Console.WriteLine($"환불액: {ghksqnfdor}");
Console.WriteLine($"최종 잔액: {total}");