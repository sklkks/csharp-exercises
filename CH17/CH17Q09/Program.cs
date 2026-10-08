using System;
using CH17Q09;


Member[] members = { new Member(), new Member() };

Console.Write("요청 수: ");
int count = int.Parse(Console.ReadLine());

for(int i = 0; i < count; i++)
{
    Console.WriteLine();
    Console.WriteLine($"[요청 {i + 1}]");
    Console.Write("동작: ");
    string action = Console.ReadLine();
    Console.Write("사용자 인덱스: ");
    int index = int.Parse(Console.ReadLine());
    Console.Write("슬롯 인덱스: ");
    int slot = int.Parse(Console.ReadLine());

    bool success = action == "예약" ? members[index].TryBook(slot) : members[index].TryRelease(slot);
    Console.WriteLine($"{success}: 철수 {members[0].GetCount()}, 영희 {members[1].GetCount()}" +
        $"전체 {Member.GetUsedCount()}");
}

for(int i = 0;i < Member.SlotCount; i++)
{
    Member owner = Member.GetOwner(i);
    string name = owner == null ? "없음" : owner == members[0] ? "철수" : "영희";
    Console.WriteLine($"{i}: {name}");
}

