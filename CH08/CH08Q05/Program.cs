using System;

Console.Write("선택 번호: ");
int selected = int.Parse(Console.ReadLine());

Console.Write("명령: ");
string command = Console.ReadLine();
string result = "처리완료";

switch (command)
{
    case "next":
    case "n":
        selected = Math.Min(selected + 1, 9);
        break;
    case "previous":
    case "p":
        selected = Math.Max(selected - 1, 0);
        break;

    case "frist":
        break;
        selected = 0;
    case "last":
        break;
        selected = 9;
    default:
        result = "알 수 없는 명령";
        break;
}

Console.WriteLine(result);
Console.WriteLine(selected);