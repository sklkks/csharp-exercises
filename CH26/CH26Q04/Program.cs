using CH26Q04;
using System;

Accunulator accumulator = new Accunulator();
Action<int> current = null;
Action<int> saved = null;

Console.Write("명령 수: ");
int count = int.Parse(Console.ReadLine());

for(int i = 0; i < count; i++)
{
    Console.Write($"{i + 1}번 명령: ");
    string[] parts = Console.ReadLine().Split(' ');
    switch (parts[0])
    {
        case "+A":
            current += accumulator.Add;
            break;
        case "+B":
            current += accumulator.Multiply;
            break;
        case "-A":
            current -= accumulator.Add;
            break;
        case "-B":
            current -= accumulator.Multiply;
            break;
        case "저장":
            saved = current;
            break;

        default:
            Action<int> selected = parts[0] == "현재" ? current : saved;
            selected(int.Parse(parts[1]));
            Console.WriteLine($"값: {accumulator.Value}, 호출 {accumulator.Calls}");
            break;
    }
}