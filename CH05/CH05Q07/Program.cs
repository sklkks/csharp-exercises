using System;

Console.Write("십의 자리: ");
int ten = int.Parse(Console.ReadLine());
Console.Write("일의 자리: ");
int one = int.Parse(Console.ReadLine());

char num = (char)(ten + '0');
char num2 = (char)(one + '0');

int num_int = ten * 10 + one;

Console.WriteLine($"번호 표기: {num}{num2}");
Console.WriteLine($"정수 값: {num_int}");