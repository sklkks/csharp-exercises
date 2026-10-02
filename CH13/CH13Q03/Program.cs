using System;

Console.Write("원본 문자열: "); //AB12-3456
string str = Console.ReadLine();
char[] new_str = str.ToCharArray();

int number = 0;
int count = 0;

foreach (char new_strs in new_str)
{
    if (char.IsDigit(new_strs))
    {
        number++;
        if (number <= 2)
        {
            continue;
        }
        for (int i = 0; count < number - 2; i++)
        {
            if (char.IsDigit(new_str[i]))
            {
                count++;
                new_str[i] = '*';
            }
        }
    }

}

Console.WriteLine($"원본: [{str}]");
Console.WriteLine($"결과: [{new string(new_str)}]");