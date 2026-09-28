using System;

double num = Convert.ToDouble(Console.ReadLine());
string str = Convert.ToString(num);

double half = num / 2;
double number = half + 1;

string s_half = Convert.ToString(half);
string string_ = s_half + 1;

Console.WriteLine($"숫자 타입: {num.GetType()}");
Console.WriteLine($"문자열 타입: {str.GetType()}");
Console.WriteLine($"숫자 계산: {number}");
Console.WriteLine($"문자열 연결: {string_}");