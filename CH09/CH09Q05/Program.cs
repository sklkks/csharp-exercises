using System;

int number;
int attempts = 0;
bool isVaild = false;

do
{
    string input = Console.ReadLine();
    attempts++;

    bool isParsed = int.TryParse(input, out number);

    isVaild = isParsed && number >= 1 && number <= 5;

    if (!isParsed)
    {
        Console.WriteLine("정수 필요");
    }

    else if (!isVaild)
    {
        Console.WriteLine("번호는 1~5");
    }
    
} while (!isVaild);

Console.WriteLine($"확정 번호: {number}");
Console.WriteLine($"입력 횟수: {attempts}");