using System;

Console.Write("완료 작업 수: ");
int Num_completed = int.Parse(Console.ReadLine());
Console.Write("전체 작업 수: ");
int Num_all = int.Parse(Console.ReadLine());


double Completion_rate = (double)Num_completed / Num_all;
double Integer_percentage = (int)(100 * Completion_rate);

Console.WriteLine($"진행 비율: {Completion_rate}");
Console.WriteLine($"정수 백분율: {Integer_percentage}%");