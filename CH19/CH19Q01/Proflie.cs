using System;
using System.Collections.Generic;
using System.Text;

namespace CH19Q01
{
    internal class Proflie
    {
        private string Name;
        public string name
        {
            get => Name;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) return;

                string trimmed = value.Trim();
                if (string.IsNullOrEmpty(trimmed)) return;

                if (Name != trimmed)
                {
                    Name = trimmed;
                    Changes++;
                }
            }
        }


        public int Changes { get; private set; } = 0;

        public string Describe(string add)
        {
            if (!string.IsNullOrEmpty(add))
            {
                name += " " + add;
            }
            return $"최종: [{Name}], 변경{Changes}";
        }
    }
}

