using System;
string command = Console.ReadLine();
string file = Console.ReadLine();

int ww = int.Parse(file);

if (command == "파일")
{
    Console.WriteLine($"출처: {command}");
}
else
{
    Console.WriteLine($"출처: 파일");
}


if (ww >= 1 && ww <= 100)
{
    Console.WriteLine($"설정값: {ww}");
}
else
{
    ww = 20;
    Console.WriteLine($"설정값: {ww}");
}
