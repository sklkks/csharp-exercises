using System;

Console.Write("상품 종류 수: ");
int count = int.Parse(Console.ReadLine());

int[] price = new int[count];
int[] quantities = new int[count];

for (int i = 0; i < count; i++)
{
    Console.WriteLine();
    Console.WriteLine($"[상품 {i+1}]");
    Console.Write("단가: ");
    price[i] = int.Parse(Console.ReadLine());
    Console.Write("수량: ");
    quantities[i] = int.Parse(Console.ReadLine());
}

Console.Write("방문 수령 여부: ");
bool pickup = bool.Parse(Console.ReadLine());


decimal subtotal = GetSubtotal(price, quantities);
decimal rate_payable = GetPayable(subtotal, "정률", pickup);
decimal fixed_price = GetPayable(subtotal, "정액", pickup);

Console.WriteLine($"상품 합계: {subtotal:N}원");
Console.WriteLine($"정률 합계: {rate_payable:N}원");
Console.WriteLine($"정액 합계: {fixed_price:N}원");
Console.WriteLine($"선택: {(rate_payable < fixed_price ? "정률" : "정액")}");
decimal GetSubtotal(int[] prices, int[] quantities)
{
    decimal total = 0;
    for (int i = 0; i < price.Length; i++)
    {
        total += price[i] * quantities[i];
    }

    return total;
}

decimal GetDiscount(decimal subtotal, string coupon)
{
    switch (coupon)
    {
        case "정률":
            return subtotal * 0.1m;
        case "정액":
            return subtotal >= 10000 ? 2000 : 0;
    } 
    return 0;
}

decimal GetShipping(decimal afterDiscount, bool pickup = false)
{
    if(pickup || afterDiscount == 0 || afterDiscount >= 20000)
    {
        return 0;
    }
    return 3000;
}

decimal GetPayable(decimal subtotal, string coupon, bool pickup)
{
    decimal afterdiscount = subtotal - GetDiscount(subtotal, coupon);

    return afterdiscount + GetShipping(afterdiscount, pickup);
}