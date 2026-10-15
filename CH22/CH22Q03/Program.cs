using System;
using CH22Q03;

object[] vv =
{
    new NameTag("철수"),
    new NameTag(""),
    new Locker("잠금")
};


Console.Write("요청 수: ");
int count = int.Parse(Console.ReadLine());

for(int i = 0; i < count; i++)
{
    Console.WriteLine($"[요청 {i + 1}]");
    Console.Write("동작: ");
    string st = Console.ReadLine();
    if(st == "편집")
    {
        Console.Write("대상 번호: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("새 이름: ");
        string _newname = Console.ReadLine();
        Console.WriteLine($"{vv.()}: {vv}");
    }
    
    if(st == "잠금")
    {
        Console.Write("대상 번호: ");
        int num = int.Parse(Console.ReadLine());

    }
    
}
