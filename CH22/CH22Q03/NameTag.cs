using System;
using System.Collections.Generic;
using System.Text;

namespace CH22Q03
{
    internal class NameTag : IEditable
    {
        protected string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                }
            }
        }

        public NameTag(string name)
        {
            _name = name;
        }

        public virtual bool Replace(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return false;
            }


            text = text.Trim();
            if (text.Length < 1 || text.Length > 6)
            {
                return false;
            }


            if (_name == text)
            {
                return false;
            }

            _name = text;
            return true;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}