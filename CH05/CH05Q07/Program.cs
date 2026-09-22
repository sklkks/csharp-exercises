using System;

Console.Write("십의 자리: ");
char tensChar = Console.ReadLine()[0];
Console.Write("일의 자리: ");
char onesChar = Console.ReadLine()[0];

string label = $"{tensChar}{onesChar}";
int int_value = (tensChar - '0') * 10 + (onesChar - '0');

Console.WriteLine($"번호 표기: {label}");
Console.WriteLine($"정수 값: {int_value}");