using System;

int n = int.Parse(Console.ReadLine());
string[] name = new string[n];
int[] first_score = new int[n];
int[] second_score = new int[n];
int[] improved = new int[n];

for (int i = 0; i < n; i++)
{
    name[i] = Console.ReadLine();
    first_score[i] = int.Parse(Console.ReadLine());
    second_score[i] = int.Parse(Console.ReadLine());

    improved[i] = second_score[i] - first_score[i];

    if (improved[i] > 0)
    {
        Console.WriteLine($"{name[i]}: +{improved[i]}");
    }
}

int high_prove = 0;
for (int i = 0; i < n; i++)
{
    if (improved[i] > high_prove)
    {
        high_prove = improved[i];
    }
}

if (high_prove <= 0)
{
    Console.WriteLine("최고 향상: 없음");
}
else
{
    Console.Write("최고 향상:");
    for (int i = 0; i < n; i++)
    {
        if (improved[i] == high_prove)
        {
            Console.Write($" {name[i]}");
        }
    }
    Console.WriteLine();

}