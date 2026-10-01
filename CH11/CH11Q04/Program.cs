using System;

int row = int.Parse(Console.ReadLine());
int col = int.Parse(Console.ReadLine());

int[][] ww = new int[row][];

for (int i = 0; i < row; i++)
{
    ww[i] = new int[col];

    for (int j = 0; j < col; j++)
    {
        ww[i][j] = int.Parse(Console.ReadLine());
    }
}

int[][] ww2 = new int[col][];

for(int i = 0; i < col; i++)
{
    ww2[i] = new int[row];

    for (int j = 0;j < row; j++)
    {
        ww2[i][j] = ww[j][i];
        
    }
}
for(int i = 0; i < col; i++)
{

    for (int j = 0; j < row; j++)
    {
        Console.Write($"{ww2[i][j]} ");
    }
    Console.WriteLine();
}