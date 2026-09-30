using System;

int items = int.Parse(Console.ReadLine());
int pag = int.Parse(Console.ReadLine());

int i = 0;
while (items > 0)
    if (items >= 0 && items <= 50 && pag >= 1 && pag <= 10)
    {
        {
        int pag1 = Math.Min(items, pag);
        items -= pag1;

        if (items <= 0)
        {
            items = 0;
        }
        i++;
        Console.WriteLine($"{i}회 {pag1}개 / 남음: {items}");
    }
}
Console.WriteLine($"포장 횟수: {i}");