using System;

Console.Write("첫 요청 문자: ");
char first = char.Parse(Console.ReadLine());

Console.Write("첫 요청 행 수: ");
int row_1 = int.Parse(Console.ReadLine());

Console.Write("두 번째 요청 문자: ");
char second = char.Parse(Console.ReadLine());

Console.Write("두 번째 요청 행 수: ");
int row_2 = int.Parse(Console.ReadLine());

if (row_1 <= 0 || row_2 <= 0 )
{
    Console.WriteLine("출력 없음");
    return;
}


PrintSteps(first, row_1);
PrintSteps(second, row_2);

void PrintSteps(char symbol, int rows)
{
    for (int i = 1; i <= rows; i++)
    {

        Console.WriteLine(new string(symbol, i));
    }
}

