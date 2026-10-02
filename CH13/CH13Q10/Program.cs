using System;
using System.Text;

Console.Write("초기 문서:");
string input = Console.ReadLine();
StringBuilder document = new StringBuilder(input);

Console.Write("명령 수: ");
int count = int.Parse(Console.ReadLine());

for(int i = 0; i < count; i++)
{
    Console.Write($"{i + 1}번 명령: ");
    input = Console.ReadLine();

    string[] parts = input.Split('|');
    string command = parts[0].Trim().ToLower();
    bool valid = false;

    if (command == "append" && parts.Length == 2)
    {
        document.Append(parts[1]);
        valid = true;
    }
    else if (command == "insert" && parts.Length == 3)
    {
        if (int.TryParse(parts[1].Trim(), out int position) &&
            position >= 0 && position <= document.Length)
        {
            document.Insert(position, parts[2]);
            valid = true;

        }
    }
    else if (command == "remove" && parts.Length == 3)
    {
        if (int.TryParse(parts[1].Trim(), out int position) &&
            int.TryParse(parts[2].Trim(), out int length) &&
            position >= 0 && position <= document.Length &&
            length >= 0 && length <= document.Length - position)
        {
            document.Remove(position, length);
            valid = true;
        }
    }


    else if (command == "replace" && parts.Length == 3)
    {
        document.Replace(parts[1], parts[2]);
        valid = true;
    }

    else if (command == "clear" && parts.Length == 1)
    {
        document.Clear();
        valid = true;
    }

    Console.WriteLine(valid ? "완료" : "오류");
}

Console.WriteLine($"문서: [{document.ToString()}]");
Console.WriteLine($"길이: {document.Length}");
