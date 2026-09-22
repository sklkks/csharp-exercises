using System;

Console.Write("상품 단가: ");
decimal price = decimal.Parse(Console.ReadLine());
Console.Write("구매 수량: ");
decimal quantity = decimal.Parse(Console.ReadLine());
Console.Write("할인율: ");
decimal discount = decimal.Parse(Console.ReadLine());

decimal taxRate = 0.02m;


decimal payment = price * quantity * (1 - discount) ;

decimal accumulation = payment * taxRate;

Console.WriteLine($"결제액: {Math.Round(payment, 2)}");
Console.WriteLine($"적립액: {Math.Round(accumulation, 2)}");