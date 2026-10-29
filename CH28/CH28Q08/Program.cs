using CH28Q08;
using System;

WaitingRoom room = new WaitingRoom();

Console.Write("명령 수: ");
int count = int.Parse(Console.ReadLine());
for(int i = 0; i < count; i++)
{
    Console.Write($"{i + 1}번 명령: ");
    string[] parts = Console.ReadLine().Split(' ');
    switch (parts[0])
    {
        case "접수":
            Console.WriteLine(room.Register(parts[1]) ? "접수" : "중복");
            break;

        case "취소":
            Console.WriteLine(room.Cancel(parts[1]) ? "취소" : "취소 실패");
            break;
        case "호출":
            Console.WriteLine(room.Call(out string name) ? $"호출: {name}" : "대기 없음");
            break;
    }
}
Console.WriteLine($"대기: [{room.Pending()}]");