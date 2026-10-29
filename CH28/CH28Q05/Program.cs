using System;
using System.Collections.Generic;

HashSet<string> required = ReadSet("필요");
HashSet<string> owned = ReadSet("보유");
HashSet<string> forbidden = ReadSet("금지");

HashSet<string> usalbe = new HashSet<string>(owned);
usalbe.ExceptWith(forbidden);

HashSet<string> ready = new HashSet<string>(required);
ready.IntersectWith(usalbe);

HashSet<string> missing = new HashSet<string>(required);
missing.ExceptWith(owned);

Print("완료", ready);
Print("부족", missing);

Console.WriteLine($"필요 {ready.Count}, 보유{missing.Count}");
static void Print(string label, HashSet<string> values)
{
    List<string> sorted = new List<string>(values);
    sorted.Sort();
    Console.WriteLine($"{label}: [{string.Join(", ", sorted)}]");
}
static HashSet<string> ReadSet(string label)
{
    HashSet<string> values = new HashSet<string>();
    Console.Write($"{label} 품목 수: ");
    int count = int.Parse(Console.ReadLine());

    for(int i = 0; i < count; i++)
    {
        Console.Write($"{label} 품목 {i + 1}코드: ");
        values.Add( Console.ReadLine());
    }
    return values;
}
