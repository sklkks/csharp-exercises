using System;
using System.Drawing;

Console.Write("문서 쪽 수: ");
int page_number = int.Parse(Console.ReadLine());

Console.Write("인쇄 부수: ");
int print_run = int.Parse(Console.ReadLine());

int basic = CalculatePrintCost(page_number, color);
int colors = CalculatePrintCost(page_number, color);
int total_color = CalculatePrintCost(colors, color);


black + 50;
color + 200;


Console.WriteLine($"기본: {basic}");
Console.WriteLine($"컬러 1부: {colors}원");
Console.WriteLine($"컬러 여러 부: {total_color}원");

int CalculatePrintCost(int pages, int copies = 1, bool color = false)
{
    return (pages * color);
}