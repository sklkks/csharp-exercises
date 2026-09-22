using System;

Console.Write("상품 단가: ");
decimal price = decimal.Parse(Console.ReadLine());
Console.Write("구매 수량: ");
decimal tnfid = decimal.Parse(Console.ReadLine());
Console.Write("할인율: ");
decimal gkfdls = decimal.Parse(Console.ReadLine());

decimal taxRate = 0.02m;


decimal rufwp = price * tnfid * (1 - gkfdls) ;

decimal wjrflq = rufwp * taxRate;

Console.WriteLine($"결제액: {Math.Round(rufwp, 2)}");
Console.WriteLine($"적립액: {Math.Round(wjrflq, 2)}");