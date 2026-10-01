using System;

Console.Write("받는 사람 이름: ");
string name = Console.ReadLine();

Console.Write("보관 여부: ");
string custody = Console.ReadLine();

Console.Write("메모 본문: ");
string memo = Console.ReadLine();

switch (custody)
    {
        case "true":
        custody = "Archive";
        break;

        case "false":
        custody = ($"\"C:\\폴더\\{name}\\note.txt\"");
        break;
}


    


    Console.WriteLine($"받는사람: \"{name}\"");
Console.WriteLine($"저장: {custody}");
Console.WriteLine($"본문: {memo}");
