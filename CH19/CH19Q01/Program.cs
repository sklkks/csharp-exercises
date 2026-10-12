using System;

Proflie profile = new Proflie();

Console.Write("이름 대입 수: ");
int num = int.Parse(Console.ReadLine());

Proflie[] profiles = new Proflie[num];

for (int i = 0; i < num; i++)
{
    profiles[i] = new Proflie();
    Console.Write($"{i + 1}번째 이름: ");
    string name = Console.ReadLine();


    profiles[i].Name = name;

    Console.WriteLine($"{name}, 변경{profiles[i].Changes}");
}

class Proflie
{
    private int num;
    public string Name;


    public int Changes { get; private set; }


    public int Num
    {
        get { return num; }
        set
        {
            if (value < 0) num = 0;
            else num = value;
        }
    }

    public string Describe(string add)
    {
        Name += add;
        return $"최종: [{Name}], 변경{Changes}";
    }


}

