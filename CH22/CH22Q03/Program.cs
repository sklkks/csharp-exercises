using System;
using CH22Q03;

object[] index =
{
    new NameTag("철수"),
    new Locker("잠금"),
    new LockableNameTag("영희"),
    null
};


Console.Write("요청 수: ");
int count = int.Parse(Console.ReadLine());

for(int i = 0; i < count; i++)
{
    Console.WriteLine($"[요청 {i + 1}]");
    Console.Write("동작: ");
    string st = Console.ReadLine();
    Console.Write("대상 번호: ");
    int num = int.Parse(Console.ReadLine());

    bool result = false;
    object target = (num >= 0 && num < index.Length) ? index[num] : null;

    if (st == "편집")
    {
        Console.Write("새 이름: ");

       string newName = Console.ReadLine();

        if (target is IEditable editableTarget)
        {
            result = editableTarget.Replace(newName);
        }
    }

    else if (st == "잠금")
    {
        if (target is ILockable lockableTarget)
        {
            result = lockableTarget.Lock();
        }
    }

    Console.WriteLine($"{result}: {index[0]} / {index[1]} / {index[2]}");
}

Console.WriteLine($"최종: {index[0]} / {index[1]} / {index[2]}");
