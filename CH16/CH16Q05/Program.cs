using CH16Q05;
using System;

Rate p = new Rate();
Console.Write("초기 단가: ");
p.UnitPrice = int.Parse(Console.ReadLine());


Console.Write("공유 요금표 변경 단가: ");
int sharedChangePrice = int.Parse(Console.ReadLine());

Rate n = new Rate();
Console.Write("영희의 새 요금표 단가: ");
n.UnitPrice = int.Parse(Console.ReadLine());

Rate t  = new Rate();
Console.Write("공유 요금표 최종 단가: ");
t.UnitPrice = int.Parse(Console.ReadLine());

Subscriber c_use = new Subscriber();
c_use.Rate = p;
Console.Write("철수 사용량: ");
c_use.Usage = int.Parse(Console.ReadLine());

Subscriber y_use = new Subscriber();
y_use.Rate = p;
Console.Write("영희 사용량: ");
y_use.Usage = int.Parse(Console.ReadLine());

c_use.Name = "철수";
y_use.Name = "영희";

Console.WriteLine($"초기: {c_use.Name} {c_use.GetCharge()}, {y_use.Name} {y_use.GetCharge()}");

p.UnitPrice = sharedChangePrice;
Console.WriteLine($"공유 수정: {c_use.Name} {c_use.GetCharge()}, {y_use.Name} {y_use.GetCharge()}");

y_use.Rate = n;
Console.WriteLine($"영희 교체: {c_use.Name} {c_use.GetCharge()}, {y_use.Name} {y_use.GetCharge()}");

p.UnitPrice = t.UnitPrice;
Console.WriteLine($"기존 요금 수정: {c_use.Name} {c_use.GetCharge()}, {y_use.Name} {y_use.GetCharge()}");
