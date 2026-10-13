using System;

namespace CH20Q03
{
    internal class Booklet : PageDocument
    {
        public int Copies { get; }
        public int sheets => ((Pages + 1) / 2 )* Copies;

        public Booklet(int pages) : this(pages, 1)
        {

        }

        public Booklet(int pages, int copies) : base(pages)
        {
            Copies = Math.Clamp(copies, 1, 5);
        }
    }


}
