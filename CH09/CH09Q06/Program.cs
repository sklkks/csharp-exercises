using System;

int rows = int.Parse(Console.ReadLine());
int cols = int.Parse(Console.ReadLine());

if (rows < 0 && rows > 6)
{
    Console.WriteLine("행 수는 0~6");
}

else if (cols < 1 && cols > 6)
{
    Console.WriteLine("열 수는 1~6");
}
else
{
    int count = 0;


    for (int i = 0; i < rows; i++)
    {
        string line = "";

        for (int j = 0; j < cols; j++)
        {
            if ((i + j) % 2 == 0)
            {
                line = line + "#";
                count = count + 1;
            }
            else
            {
                line = line + ".";
            }
        }

        Console.WriteLine(line);
    }

    Console.WriteLine("# 개수: " + count);
}