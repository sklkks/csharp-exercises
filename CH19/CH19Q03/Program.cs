using System;
using CH19Q03;

Console.Write("초기 항목 수: ");
int initialItemCount = int.Parse(Console.ReadLine());
Console.Write("바꿀 열 수: ");
int newColumns = int.Parse(Console.ReadLine());
Console.Write("바꿀 항목 수: ");
int newItemCount = int.Parse(Console.ReadLine());
Console.WriteLine();

GridLayout grid = new GridLayout { ItemCount = initialItemCount };
int initialRows = grid.Rows;

Console.WriteLine($"초기: {grid.Rows}행, 빈칸 {grid.EmptySlots}");
grid.Columns = newColumns;
Console.WriteLine($"열 변경: {grid.Rows}행, 빈칸 {grid.EmptySlots}");
grid.ItemCount = newItemCount;
Console.WriteLine($"개수 변경: {grid.Rows}행, 빈칸 {grid.EmptySlots}");
Console.WriteLine($"저장한 행 수: {initialRows}");