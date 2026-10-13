using System;
using System.Collections.Generic;
using System.Text;

namespace CH20Q01
{
    internal class TextRecord
    {    
        private string Text;

        public string text
        {
            get => Text;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    return;
                }

                string trimmed = value.Trim();

                if (trimmed.Length >= 1 && trimmed.Length <= 12)
                {
                    Text = trimmed;
                }
            }
        }

        protected static string MakeTag(string text)
        {
            return $"[{text}]";
        }
    }

    class TaggedRecord : TextRecord
    {
        public string Tag { get; set; }

        public string Formatted
        {
            get => $"{MakeTag(Tag)} {text}";
        }

        public void AppendNote(string note)
        {
            string result = text + " " + note;
            text = result;
        }
    }
}

