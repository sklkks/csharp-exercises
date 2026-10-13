using System;

namespace CH20Q03
{
    internal class PageDocument
    {
        public int Pages { get; }

        public PageDocument(int pages)
        {
            if (pages >= 1 && pages <= 20)
            {

                Pages = Math.Clamp(pages, 1, 20);
            }
        }

    }
}
