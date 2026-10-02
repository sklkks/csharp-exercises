using System;


Console.Write("초기 잔액: ");
int balance = int.Parse(Console.ReadLine());

Console.Write("첫 조정액: ");
int f_amount = int.Parse(Console.ReadLine());

Console.Write("두 번째 조정액: ");
int s_amount = int.Parse(Console.ReadLine());


int f_balance = ApplyChange(balance, f_amount); 

//if (f_balance < 0) 
//{
//    f_balance = 0; 
//}

int s_balance = ApplyChange(f_balance, s_amount);

//if (s_balance < 0)
//{
//    s_balance = 0;
//}

Console.WriteLine($"초기: {balance}");
Console.WriteLine($"첫 조정 후: {f_balance}");
Console.WriteLine($"최종: {s_balance}");

int ApplyChange(int current, int change)
{
    return Math.Max(0, current + change);
}