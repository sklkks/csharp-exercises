using System;
using CH20Q06;

Console.WriteLine("첫 보고서 제목: ");
string fir = Console.ReadLine();
Console.WriteLine("두 번째 보고서 제목: ");
string sec =Console.ReadLine();

Console.WriteLine("최초 표시 폭: ");
int firWidth = int.Parse(Console.ReadLine());
Console.WriteLine("변경할 표시 폭: ");
int nextWidth = int.Parse(Console.ReadLine());

CaptionFormatter shared = new CaptionFormatter("#", firWidth);
Report first = new Report(fir, shared);
Report second = new Report(sec, shared);

Console.WriteLine($"초기: {first.Render()} / {second.Render()}");
shared.Width = nextWidth;
Console.WriteLine($"공유 변경: {first.Render()} / {second.Render()}");

first.Formatter = new CaptionFormatter("!", 1);
Console.WriteLine($"서식 변경: {first.Render()} / {second.Render()}");

first.Formatter = null;
Console.WriteLine($"서식 없음: {first.Render()} / {second.Render()}");