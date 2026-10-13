using System;

namespace CH20Q01
{
    class Program
    {
        static void Main()
        {
            Console.Write("태그: ");
            string tag = Console.ReadLine();
            Console.Write("초기 본문: ");
            string fir_text = Console.ReadLine();
            Console.Write("새 본문: ");
            string new_text = Console.ReadLine();
            Console.Write("덧붙일 메모: ");
            string add = Console.ReadLine();

            TaggedRecord record = new TaggedRecord { Tag = tag, text = fir_text };

            Console.WriteLine(record.Formatted);

            record.text = new_text;
            Console.WriteLine(record.Formatted);

            record.AppendNote(add);
            Console.WriteLine(record.Formatted);
        }
    }

   
}