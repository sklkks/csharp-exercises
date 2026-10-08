using CH17Q01;
using System;

RangeSetting range = new RangeSetting();

Console.Write("설정 요청 수: ");
int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    Console.WriteLine();
    Console.WriteLine($"[설정 요청 {i + 1}]");
    Console.Write("하한: ");
    int lower = int.Parse(Console.ReadLine());
    Console.Write("상한: ");
    int upper = int.Parse(Console.ReadLine());


    bool success = range.TrySet(lower, upper);
    Console.WriteLine($"{success}: {range.Lower}~{range.Upper}, 폭 {range.Width}");

}
Console.WriteLine($"최종: {range.Lower}~{range.Upper} ");

