using System;

Console.Write("받는 사람: ");
string name = Console.ReadLine();
Console.Write("주소: ");
string add = Console.ReadLine();
Console.Write("상자: ");
string box = Console.ReadLine();
int boxbox = int.Parse(box);

Console.WriteLine($"받는 사람: {name}");
Console.WriteLine($"주소: {add}");
Console.WriteLine($"상자: {boxbox}");
Console.WriteLine($"배송비: {boxbox * 3000}원");