using System;

Console.Write("행 수: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("열 수: ");
int columns = int.Parse(Console.ReadLine());
Console.Write("예약 요청 수: ");
int requests = int.Parse(Console.ReadLine());

bool[,] seats = new bool[rows, columns];

for (int request = 0; request < requests; request++)
{
    Console.WriteLine();
    Console.WriteLine($"[예약 요청 {request + 1}]");

    Console.Write("행 번호: ");
    int row_num = int.Parse(Console.ReadLine());
    Console.Write("열 번호: ");
    int first_num = int.Parse(Console.ReadLine());
    Console.Write("인원: ");
    int people = int.Parse(Console.ReadLine());

    if (row_num < 1 || row_num > seats.GetLength(0) ||
        first_num < 1 || first_num > seats.GetLength(1) ||
        people < 1 || first_num + people - 1 > seats.GetLength(1))
    {
        Console.WriteLine("범위 오류");
        continue;
    }

    int row = row_num - 1;
    int start = first_num - 1;
    bool available = true;

    for (int colum = start; colum < start + people; colum++)
    {
        if (seats[row, colum])
        {
            available = false;
            break;
        }
    }
    if (!available)
    {
        Console.WriteLine("예약 불가");
        continue;
    }
    for (int colum = start; colum < start + people; colum++)
    {
        seats[row, colum] = true;
    }
    Console.WriteLine("예약 완료");
}

int reserved = 0;
for (int row = 0; row < seats.GetLength(0); row++)
{
    for (int colum = 0; colum < seats.GetLength(1); colum++)
    {
        Console.Write(seats[row, colum] ? "X" : "O");
        if (seats[row, colum])
        {
            ++reserved;
        }
    }
    Console.WriteLine();
}
Console.WriteLine($"예약 좌석: {reserved}");


