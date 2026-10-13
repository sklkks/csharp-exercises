using System;
using System.Collections.Generic;
using System.Text;

namespace CH20Q06
{
    internal class Report : Document
    {
        public CaptionFormatter Formatter { get; set; }
        public Report(string title, CaptionFormatter formatter) : base(title) 
        {
            Formatter = formatter;
        }
        public string Render()
        {
            return Formatter == null ? Title : Formatter.Format(Title);
        }
    }
}
