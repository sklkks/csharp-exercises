using System;

Console.Write("기존 닉네임: ");
string name = Console.ReadLine();

Console.Write("새로운 닉네임: ");
string newname = Console.ReadLine();

string previousname = name;

Console.WriteLine($"변경 전: {previousname}");
Console.WriteLine($"변경 후: {newname}");
