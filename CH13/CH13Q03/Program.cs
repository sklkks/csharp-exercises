using System;

Console.Write("원본 문자열: "); //AB12-3456
string phone = Console.ReadLine();
char[] notes = phone.ToCharArray();


int number = 0;
int count = 0;

foreach (char note in notes)
{
    if (char.IsDigit(note))
    {
        number++;
        if (number <= 2)
        {
            continue;
        }
        for (int i = 0; count < number - 2; i++)
        {
            if (char.IsDigit(notes[i]))
            {
                count++;
                notes[i] = '*';
            }
        }
    }
}

Console.WriteLine($"원본: [{phone}]");
Console.WriteLine($"결과: [{new string(notes)}]");