using System;

Console.Write("정수 입력: ");
string input = Console.ReadLine();

int number = Convert.ToInt32(input);
bool status = Convert.ToBoolean(number);
int  standard = Convert.ToInt32(status);

Console.WriteLine($"상태: {status}");
Console.WriteLine($"표준 설정: {standard}");
Console.WriteLine($"원본과 일치: {number == standard}");
