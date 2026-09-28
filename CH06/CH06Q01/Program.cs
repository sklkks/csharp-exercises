using System;

Console.Write("한 줄 입력: ");
int code = Convert.ToChar(Console.ReadLine());
char c = (char)(code + 1);

int code_d = code - code + 1; 

Console.WriteLine($"다음 구역: {c}");
Console.WriteLine($"코드 차이: {code_d}");