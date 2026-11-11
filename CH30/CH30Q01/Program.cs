using System;
using System.Collections.Generic;
using System.Linq;
Console.Write("정수 개수: ");
int count = int.Parse(Console.ReadLine());

for(int i = 0; i < count; i++)
{
    Console.Write($"{i+1}번째 정수: ");
    int num = int.Parse(Console.ReadLine());
}
Console.Write("요청 수: ");
int cc = int.Parse(Console.ReadLine());

for(int i = 0;i < cc; i++)
{
    Console.Write($"{i + 1}번 요청 열거자: ");
    string aa = Console.ReadLine();
    Console.Write($"{aa}: {n}");
}

class SomeClass
{   

    private int[] values;

    public IEnumerator<int> GetEnumerator()
    {
        yield return
                
    }

}