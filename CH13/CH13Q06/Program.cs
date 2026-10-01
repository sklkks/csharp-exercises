using System;

Console.Write("본문: ");
string text = Console.ReadLine();

Console.Write("검색어: ");
string search = Console.ReadLine();

int[] positions = new int[text.Length];
int count = 0;
int start= 0;


while(true)
{
    start = text.IndexOf(search, start);

    if (start == -1)
        break;

    positions[count] = start;
    count++;

    start++;
}

for(int i=0; i<count; i++)
{
    Console.WriteLine($"위치: {positions[i]}");
}
Console.WriteLine($"개수: {count}");