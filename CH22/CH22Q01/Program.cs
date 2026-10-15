using System;
using CH22Q01;

Console.Write("배열 원소 수: ");
int count = int.Parse(Console.ReadLine());
int[] values = new int[count];
for(int i = 0; i < count; i++)
{
    Console.WriteLine($"{i + 1} 번째 원소: ");
    values[i] = int.Parse(Console.ReadLine());
}

Console.Write("등차 자료 시작값: ");
int start = int.Parse(Console.ReadLine());
Console.Write("등차 자료 간격: ");
int step = int.Parse(Console.ReadLine());
Console.Write("등차 자료 개수: ");
int lenght = int.Parse(Console.ReadLine());


Console.Write("조회 위치: ");
int index = int.Parse(Console.ReadLine());

Show("배열", new ArrayView(values), index);
Show("등차", new SequenceView(start, step, lenght), index);
void Show(string name, IIntView view, int index)
{
    int sum = 0;
    int weighted = 0;

    for(int i = 0;i < view.Count; i++)
    {
        sum += view[i];
        weighted += view[i] * (i + 1);
    }

    Console.WriteLine($"{name}: 합계 {sum}, 가중 {weighted}, 조회 {view[index]}");
}