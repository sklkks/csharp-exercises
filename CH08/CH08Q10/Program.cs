using System;


string wn = Console.ReadLine();
int wks = int.Parse(Console.ReadLine());
string command = Console.ReadLine();

switch (wn)
{
    case "pay":
        if (wks >= 3000)
        {
            wks = wks - 3000;
            Console.WriteLine($"결제 완료");
        }
        else if (wks < 3000)
        {
            Console.WriteLine($"잔액 부족");
        }
        else
        {
            Console.WriteLine($"결제할 수 없는 상태");
        }
        break;
    case "ship":
       
            Console.WriteLine($"발송 완료"); 
        else
        {

        }
        break;
    case "cancel":
        Console.WriteLine($"결제 취소 및 환불");
        break;
}




Console.WriteLine($"상태: {}");
Console.WriteLine($"잔액: {}");