using System;

int boxes = int.Parse(Console.ReadLine());
int totalDefects = 0;
int defectiveBoxes = 0;

for  (int box = 1;  box <= boxes; box++)
{
    int items = int.Parse((Console.ReadLine()));
    int defects = 0;
    for (int item = 1;  item <= items; item++)
    {
        int result = int.Parse((Console.ReadLine()));
        if (result == 1)
        {
            defects++;
        }
    }
    totalDefects += defects;
    if (defects > 0)
    {
        defectiveBoxes++;
    }
    Console.WriteLine($"상자 {box}: 불량 {defects}");
}

Console.WriteLine($"전체 불량: {totalDefects}");
Console.WriteLine($"불량 상자: {defectiveBoxes}");