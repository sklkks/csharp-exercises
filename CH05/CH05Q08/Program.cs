using System;

Console.Write("전체 금액: ");
decimal totalamount = decimal.Parse(Console.ReadLine());
Console.Write("인원수: ");
int person_count = int.Parse(Console.ReadLine());

int per_person = (int)(totalamount / person_count);
decimal total_pay = per_person * person_count;
decimal remaining_amount = totalamount - total_pay;


Console.WriteLine($"1인당 지급: {per_person}원");
Console.WriteLine($"총 지급: {total_pay}원");
Console.WriteLine($"남은 금액: {remaining_amount}원");