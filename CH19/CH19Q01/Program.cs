using System;
using CH19Q01;

Proflie profile = new Proflie();

Console.Write("이름 대입 수: ");
int num = int.Parse(Console.ReadLine());

for (int i = 0; i < num; i++)
{
    
    Console.Write($"{i + 1}번째 이름: ");
    string name = Console.ReadLine();


    profile.name = name;

    Console.WriteLine($"[{profile.name}], 변경{profile.Changes}");
}

Console.Write("덧붙일 문자열: ");
string addStr = Console.ReadLine();

Console.WriteLine(profile.Describe(addStr));

