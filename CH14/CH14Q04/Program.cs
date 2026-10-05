using System;

Console.Write("문서 쪽 수: ");
int page_number = int.Parse(Console.ReadLine());

Console.Write("인쇄 부수: ");
int print_run = int.Parse(Console.ReadLine());

int basic = CalculatePrintCost(page_number);
int colors = CalculatePrintCost(page_number, color: true);
int total_color = CalculatePrintCost(page_number, color: true, copies: print_run);



Console.WriteLine($"기본: {basic}");
Console.WriteLine($"컬러 1부: {colors}원");
Console.WriteLine($"컬러 여러 부: {total_color}원");

int CalculatePrintCost(int pages, int copies = 1, bool color = false)
{
    int price = 50;

    if (color == true)
    {
        price = 200;
    }

    return pages * price * copies;
}