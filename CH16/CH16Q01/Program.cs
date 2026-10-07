using CH16Q01;
using System;
using System.Diagnostics.Metrics;

Course am_capacity = new Course();
Console.Write("오전 강좌 정원: ");
am_capacity.Capacity = int.Parse(Console.ReadLine());

Console.Write("오전 현재 신청 인원: ");
am_capacity.Enrolled = int.Parse(Console.ReadLine());

Course pm_capacity = new Course();
Console.Write("오후 강좌 정원: ");
pm_capacity.Capacity = int.Parse(Console.ReadLine());

Console.Write("오후 현재 신청 인원: ");
pm_capacity.Enrolled = int.Parse(Console.ReadLine());

Console.Write("오전 추가 신청 정원: ");
int am_add = int.Parse(Console.ReadLine());

Console.Write("오후 추가 신청 정원: ");
int pm_add = int.Parse(Console.ReadLine());


Console.WriteLine($"오전: {am_capacity.TryEnroll(am_add)}, 잔여: {am_capacity.GetRemaining()}");
Console.WriteLine($"오후: {pm_capacity.TryEnroll(pm_add)}, 잔여: {pm_capacity.GetRemaining()}");
Console.WriteLine($"잔여 합계: {}");

