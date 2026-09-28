using System;

Console.Write("");
int fir_start = int.Parse(Console.ReadLine());

Console.Write("");
int fir_colsed = int.Parse(Console.ReadLine());

Console.Write("");
int sec_start = int.Parse(Console.ReadLine());

Console.Write("");
int sec_colsed = int.Parse(Console.ReadLine());

bool a = fir_start < fir_colsed;
bool b = sec_start < sec_colsed;

bool clash = fir_colsed <= sec_start ? false : true;

int overlapping_time = sec_start - fir_colsed;

Console.WriteLine($"예약 겹침: {clash}");
Console.WriteLine($"겹친 시간: {Math.Abs(overlapping_time)}");