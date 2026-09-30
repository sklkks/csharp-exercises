using System;

string status = Console.ReadLine();
int balance = int.Parse(Console.ReadLine());
string command = Console.ReadLine();

const int price = 3000;
string result = string.Empty;

switch (command)
{
    case "pay":
        if (status != "접수")
        {
            result = "결제할 수 없는 상태";
        }
        else if (balance < price)
        {
            result = "잔액 부족";
        }
        else
        {
            balance = price;
            status = "결제";
            result = "결제 완료";
        }
        break;

    case "ship":
        if (status == "결제")
        {
            status = "발송";
            result = "발송 완료";
        }
        else
        {
            result = "발송할 수 없는 상태";
        }
        break;

    case "cancel":
        switch (status)
        {
            case "접수":
                status = "취소";
                result = "접수 취소";
                break;

            case "결제":
                balance += price;
                status = "취소";
                result = "결제 취소 및 환불";
                break;

            case "발송":
                result = "발송 후 취소 불가";
                break;

            case "취소":
                result = "이미 취소됨";
                break;

            default:
                result = "알 수 없는 명령";
                break;
        }
        
        
        break;

    default:
        result = "알 수 없는 명령";
        break;
}

Console.WriteLine(result);
Console.WriteLine("상태: " + status);
Console.WriteLine("잔액: " + balance);