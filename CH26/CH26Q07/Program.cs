using CH26Q07;
using System;

Console.Write("계정 A 용량: ");
int capacityA = int.Parse(Console.ReadLine());
Console.Write("계정 B 용량: ");
int capacityB = int.Parse(Console.ReadLine());

AccountActions a = AccountActions.Create(capacityA);
AccountActions b = AccountActions.Create(capacityB);

Console.Write("명령 수: ");
int count = int.Parse(Console.ReadLine());

for(int i = 0; i < count; i++)
{
    Console.WriteLine($"{i + 1}번 명령: ");
    string[] parts = Console.ReadLine().Split(' ');
    AccountActions account = parts[0] == "A" ? a : b;

    switch (parts[1])
    {
        case "충전":
            account.Charge(int.Parse(parts[2]));
            break;
        case "사용":
            bool success = account.Spend(int.Parse(parts[2]));
            Console.WriteLine(success ? "사용 성공" : "사용 실패");
            break;
    }

    Console.WriteLine($"{parts[0]} 잔량: {account.Read}");
}