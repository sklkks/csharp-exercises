using System;

int n = int.Parse(Console.ReadLine());

int[] product = new int[n];
int[] preview = new int[n];

for (int i = 0; i < n; i++)
{
    int price = int.Parse(Console.ReadLine());
    product[i] = price;
    preview[i] = price;
}

int discount = int.Parse(Console.ReadLine());

int correction_num = int.Parse(Console.ReadLine()) - 1;
int correction_price = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    preview[i] = preview[i] - discount;

    if (preview[i] < 0)
    {
        preview[i] = 0;
    }
}

product[correction_num] = correction_price;


Console.Write("원본:");
for (int i = 0; i < n; i++)
{
    Console.Write($" {product[i]}");
}
Console.WriteLine();

Console.Write("미리보기:");
for (int i = 0; i < n; i++)
{
    Console.Write($" {preview[i]}");
}
Console.WriteLine();