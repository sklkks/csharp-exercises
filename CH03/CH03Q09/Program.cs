using System;

int a_warehouse = int.Parse(Console.ReadLine());
int b_warehouse = int.Parse(Console.ReadLine());
int atob = int.Parse(Console.ReadLine());
int btoa = int.Parse(Console.ReadLine());

int atob1 = a_warehouse - atob; 
int atob2 = b_warehouse + atob;
int btoa1 = atob1 + btoa;
int btoa2 = atob2 - btoa;

Console.WriteLine($"시작: A {a_warehouse}개 / B {b_warehouse}개");
Console.WriteLine($"A→B: A {atob1}개 / B {atob2}개");
Console.WriteLine($"B→A: A {btoa1}개 / B {btoa2}개");
Console.WriteLine($"총 재고: {btoa1 + btoa2}개");
