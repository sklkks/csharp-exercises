using System;

string options = Console.ReadLine();
int price = 0;

switch (options)
{
    case"box":
        price += 300;
        break;

    case "gift":
        price += 500;
        goto case "box";
        
    case "old":
        Console.WriteLine("이전 옵션 변경");
        goto default;
        
    default:
        price += 100;
        break;
}

Console.WriteLine($"포장비: {price}");