using System;

Console.Write("요약 최대 길이: ");
int length = int.Parse(Console.ReadLine());

Console.Write("문장 수: ");
int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    Console.Write($"{i + 1}번째 문장: ");
    string input = Console.ReadLine();

    string normalized = NormalizeSpaces(input);
    string summation = Shorten(normalized, length);

    Console.WriteLine($"전체: [{normalized}]");
    Console.WriteLine($"요약: [{summation}]");
}

string NormalizeSpaces(string text)
{
    if (string.IsNullOrWhiteSpace(text))
    {
        return "";
    }
    string[] words = text.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    return string.Join(" ", words);
}

string Shorten(string text, int len)
{
    if (text.Length <= len)
    {
        return text;
    }
    return text.Substring(0, len - 3) + "...";
}