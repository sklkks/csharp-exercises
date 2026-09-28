using System;

Console.Write("입력: ");
string fir = Console.ReadLine();
int number = int.Parse(fir);

Console.Write("입력: ");
string sec = Console.ReadLine();

int price = Convert.ToInt32(sec);

int total = number * price;

Console.WriteLine($"수량: {fir}개");
Console.WriteLine($"결제액: {total}");