using System;

Console.Write("");
string before = Console.ReadLine();

Console.Write("");
string Current = Console.ReadLine();

Console.Write("");
string block = Console.ReadLine();

bool detail = !(before == Current);

Console.WriteLine($"내용 변경: {detail}");
Console.WriteLine($"알림 발생: {!(Convert.ToBoolean(block))}");