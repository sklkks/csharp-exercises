using System;

int conform = 0;
int count = 0;

for (int i = 0; i < 3; i++)
{
    string num = Console.ReadLine();
    bool number = int.TryParse(num, out int qty);

    if (!number)
    {
        Console.WriteLine("정수 필요");
        count++;
        continue;
    }

    if (qty >= 1 && qty <= 10)
    {
        conform = qty;
        count++;
        break;
    }
    else
    {
        Console.WriteLine("범위 오류");
        count++;
        continue;
    }
}

Console.WriteLine($"확정 번호: {conform}");
Console.WriteLine($"시도 수: {count}");