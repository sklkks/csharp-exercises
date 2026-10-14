using System;
using CH21Q10;

Question[] questions =
{
    new WordQuestion("blue"),
    new RangeQuestion(10, 20),
    new WordQuestion("yes")
};

Console.Write("제출 수: ");
int count = int.Parse(Console.ReadLine());
for(int i = 0; i < count; i++)
{
    Console.WriteLine();
    Console.WriteLine($"[제출 {i + 1}]");
    Console.Write("질문 번호: ");
    int index = int.Parse(Console.ReadLine());

    Console.Write("답안: ");
    string answer = Console.ReadLine();
    
    questions[index].Submit(answer);
    bool accepted = questions[index].Submit(answer);
    Console.WriteLine($"처리: {accepted}: {questions[index]}");
}

foreach(Question question in questions)
{
    Console.WriteLine($"{question}");
}
