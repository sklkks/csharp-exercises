using System;

int row = int.Parse(Console.ReadLine());
int col = int.Parse(Console.ReadLine());
int count = 0;
bool found = false;
int target_row = 0;
int target_col = 0;

for (int i = 0; i < row; i++)
{

    for (int j = 0; j < col; j++)
    {
        int seat = int.Parse(Console.ReadLine());
        count++;

        if (seat == 0)
        {
            target_row = i + 1;
            target_col = j + 1;
            found = true;
            break;
        }
    }
    if (found)
    {
        break;
    }
}
if (found)
    {
        Console.WriteLine($"빈 좌석: {target_row}행 {target_col}열");
    }
    else
    {
        Console.WriteLine("빈 좌석 없음");
    }

    Console.WriteLine($"검사 칸: {count}");
