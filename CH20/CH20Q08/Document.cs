using System;
using System.Collections.Generic;
using System.Text;

namespace CH20Q06
{
    internal class Document
    {
        public string Title { get; }

        public Document(string title)
        {
            title = title.Trim();
            Title = title.Length == 0 ? "제목없음" : title;
        }
    }
}
