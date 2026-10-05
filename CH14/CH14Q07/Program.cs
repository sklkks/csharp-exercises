using System;

Console.Write("사용자명 수: ");
int count = int.Parse(Console.ReadLine());
string[] names = new string[count];

for (int i = 0; i < count; i++)
{
    Console.Write($"{i + 1}번째 사용자명: ");
    names[i] = Console.ReadLine();
}

int allowed_count = 0;

foreach (string name in names)
{
    bool isValid = IsValidName(name);
    if (isValid)
    {
        allowed_count++;
    }
    string status = isValid ? "허용" : "거부";
    Console.WriteLine($"[{name}]: {status}");
}

Console.WriteLine($"허용 수: {allowed_count}");

bool IsValidName(string text)
{
    if (string.IsNullOrEmpty(text) || text.Length < 3 || text.Length > 8)
    {
        return false;
    }

    if (!char.IsLetter(text[0]))
    {
        return false;
    }

    for (int i = 1; i < text.Length; i++)
    {
        char c = text[i];
        if (!char.IsLetter(c) && !char.IsDigit(c) && c != '_')
        {
            return false;
        }
    }

    return true;
}