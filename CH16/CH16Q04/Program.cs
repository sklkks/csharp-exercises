using CH16Q04;
using System;


Console.Write("객체 수: ");
int num = int.Parse(Console.ReadLine());

Token[] token = new Token[num];
for(int i = 0; i < num; i++)
{
    token[i] = new Token();
    Console.WriteLine($"[객체 인덱스 {i}]");
    Console.Write("이름: ");
    token[i].Name = Console.ReadLine();
    Console.Write("값: ");
    token[i].Value = int.Parse(Console.ReadLine());
}

Console.Write("참조 수: ");
int requestCount = int.Parse(Console.ReadLine());
Token[] referencedTokens = new Token[requestCount];

for (int i = 0; i < requestCount; i++)
{
    Console.Write($"{i + 1}번째 참조의 객체 인덱스: ");
    int index = int.Parse(Console.ReadLine());
    referencedTokens[i] = token[index];
}

int distinctCount = 0;
int totalSum = 0;

for(int i = 0;i < referencedTokens.Length; i++)
{
    bool isFirst = true;
    for(int j = 0; j < i; j++)
    {
        if (referencedTokens[i] == referencedTokens[j])
        {
            isFirst = false;
            break;
        }
    }
    if (isFirst)
    {
        Console.WriteLine($"{referencedTokens[i].Name}:{referencedTokens[i].Value}");
        distinctCount++;
        totalSum += referencedTokens[i].Value;
    }
}

Console.WriteLine($"객체 수: {distinctCount}, 합계: {totalSum}");