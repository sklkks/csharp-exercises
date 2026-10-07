using System;
using CH16Q03;

Memo dnjs = new Memo();
Console.Write("원본 메모: ");
dnjs.Text = Console.ReadLine();
Console.Write("원본 수정 번호: ");
dnjs.Revision = int.Parse(Console.ReadLine());

Memo chdks = CopyMemo(dnjs);
Console.Write("초안의 새 내용: ");
chdks.Edit(Console.ReadLine());


Console.WriteLine($"원본: [{dnjs.Text}] / {dnjs.Revision}");
Console.WriteLine($"초안: [{chdks.Text}] / {chdks.Revision}");
Console.WriteLine($"같은 객체: {dnjs.Text == chdks.Text}");

Memo CopyMemo(Memo source)
{
    Memo mem = new Memo();
    mem.Text = source.Text;
    mem.Revision = source.Revision;
    return mem;
}