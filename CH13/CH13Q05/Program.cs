using System;

Console.Write("경로 수: ");
int num = int.Parse(Console.ReadLine());

string[] files = new string[num];
int count = 0;

for (int i = 0; i < num; i++)
{
    Console.Write($"{i + 1}번 경로: ");
    string input = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(input))
        continue;

    string path = input.Trim();
    if (string.IsNullOrEmpty(path))
        continue;

    int last = path.LastIndexOf('\\');
    string fileName = (last != -1) ? path.Substring(last + 1) : path;

    if (string.IsNullOrEmpty(fileName))
        continue;

    if (fileName.StartsWith("~"))
        continue;

    int lastDot = fileName.LastIndexOf('.');
    if (lastDot == -1)
        continue;

    string ext = fileName.Substring(lastDot);
    if (!ext.Equals(".log", StringComparison.OrdinalIgnoreCase))
        continue;

    string nameWithoutExt = fileName.Substring(0, lastDot);
    if (nameWithoutExt.Length >= 1)
    {
        files[count] = fileName;
        count++;
    }
}
for (int i = 0; i < count; i++)
{
    Console.WriteLine($"파일: {files[i]}");
}
Console.WriteLine($"개수: {count}");
