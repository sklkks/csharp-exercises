using System;

Feature[] devices =
{
    Feature.Print | Feature.Scan,//(Feature)3,
    Feature.Print | Feature.Color,//(Feature)5,
    Feature.Color | Feature.Network,//(Feature)10,
    Feature.Print | Feature.Color | Feature.Scan | Feature.Network,//(Feature)15,
    Feature.None//(Feature)0
};

Console.Write("모두 필요한 기능 마스크: ");
Feature required = (Feature)int.Parse(Console.ReadLine());

Console.Write("하나 이상 필요한 기능 마스크: ");
Feature any = (Feature)int.Parse(Console.ReadLine());

Console.Write("금지 기능 마스크: ");
Feature forbidden = (Feature)int.Parse(Console.ReadLine());

string matched = string.Empty;
for(int i = 0; i < devices.Length; i++)
{
    Feature current = devices[i];

    bool allPresent = (current & required) == required;
    bool anyPresent = any == Feature.None || (current & any) != Feature.None;
    bool nonePresent = (current & forbidden) == Feature.None;
    if(allPresent && anyPresent && nonePresent)
    {
        if(matched.Length > 0)
        {
            matched += ", ";
        }
        matched += i;
    }
}

Console.WriteLine($"선택: [{matched}]");

[Flags]
enum Feature
{
    None = 0,
    Print = 1 << 0,
    Scan = 1 << 1,
    Color = 1 << 2,
    Network = 1 << 3
}