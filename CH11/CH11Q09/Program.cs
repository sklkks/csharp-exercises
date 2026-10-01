using System;

int n = int.Parse(Console.ReadLine());
int[] warehouse = new int[n];
int movement = 0;
int dif = 0;


for (int i = 0; i < n; i++)
{
    Console.Write($"{i + 1}번 창고 초기 재고: ");
    warehouse[i] = int.Parse(Console.ReadLine());
}

Console.Write("이동 요청 수: ");
int w = int.Parse(Console.ReadLine());
int[] move = new int[w];

for (int i = 0; i < w; i++)
{
    Console.WriteLine($"[이동요청 {i + 1}]");

    Console.Write("출발 창고 번호: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("도착 창고 번호: ");
    int b = int.Parse(Console.ReadLine());

    movement = int.Parse(Console.ReadLine());
    move[i] = movement;

    if (n < 1 || n > 10 || a == b || i < 0 || i > 20)
    {
        Console.WriteLine("요청 오류");
        continue;
    }

    dif = warehouse[a - 1] - movement;

    if (dif >= 0)
    {
        warehouse[a - 1] -= movement;
        warehouse[b - 1] += movement;
        Console.WriteLine("이동 완료");
    }
    else
    {
        Console.WriteLine("재고 부족");
    }
}
