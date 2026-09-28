using System;

Console.Write("문자열 입력:");
string input = Console.ReadLine();

bool success = bool.TryParse(input, out bool number);
int number_ = Convert.ToInt32(number);

Console.WriteLine($"변환 성공: {success}");
Console.WriteLine($"결과값: {input}");
Console.WriteLine($"결과의 숫자 표현: {number_}");