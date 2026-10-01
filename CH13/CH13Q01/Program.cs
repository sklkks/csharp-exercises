using System;

string code = Console.ReadLine();

int length = code.Length;

string upper = code;
string text = upper.ToUpper()
    .Trim()
.PadLeft(7, '0')
.Replace("-", "");

Console.WriteLine($"원본: [{code}]");
Console.WriteLine($"코드: [{text}]");