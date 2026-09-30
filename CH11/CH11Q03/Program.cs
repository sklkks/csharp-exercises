using System;


int products = int.Parse(Console.ReadLine());
int[] product = new int[products];
int[] preview = new int[products];

for (int i = 0; i < products; i++)
{
    int price = int.Parse(Console.ReadLine());
int discount = int.Parse(Console.ReadLine());
int correction_num = int.Parse(Console.ReadLine());
int correction_price = int.Parse(Console.ReadLine());

Console.WriteLine($"원본: {product}");
Console.WriteLine($"미리보기: {preview}");
