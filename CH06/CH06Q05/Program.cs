using System;

Console.Write("첫 메모: ");
char ABC = (char)Console.Read();
string memo = Console.ReadLine();

Console.Write("수량: ");
int quantity = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"표식: {ABC}");
Console.WriteLine($"메모: [{memo}]");
Console.WriteLine($"수량: {quantity}");