using System;

Console.Write("초기 재고: ");
int stock = int.Parse(Console.ReadLine());
Console.Write("철수의 요청 수량: ");
int chul_req = int.Parse(Console.ReadLine());
Console.Write("철수의 보유 금액: ");
int chul_money = int.Parse(Console.ReadLine());
Console.Write("영희의 요청 수량: ");
int young_req = int.Parse(Console.ReadLine());
Console.Write("영희의 보유 금액: ");
int young_money = int.Parse(Console.ReadLine());

bool chul_rent = chul_req >= 1 && stock >= chul_req && chul_money >= chul_req * 500;
int stock2 = chul_rent ? stock - chul_req : stock;
int c_money = chul_rent ? chul_money - chul_req * 500 : chul_money;

bool young_rent = young_req >= 1 && stock2 >= young_req && young_money >= young_req * 500;
int final_stock = young_rent ? stock2 - young_req : stock2;
int y_money = young_rent ? young_money - young_req * 500 : young_money;

int total_dep = (chul_rent ? chul_req * 500 : 0) + (young_rent ? young_req * 500 : 0);

Console.WriteLine($"철수 대여: {chul_rent} / 보유 금액: {c_money}");
Console.WriteLine($"영희 대여: {young_rent} / 보유 금액: {y_money}");
Console.WriteLine($"남은 재고: {final_stock}");
Console.WriteLine($"받은 보증금: {total_dep}");