using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace CH22Q03
{
    internal class LockableNameTag : NameTag, ILockable
    {
        private bool _isLocked = false;

        public LockableNameTag(string name) : base(name) { }

        public bool Lock()
        {
            if (_isLocked) return false;
            _isLocked = true;
            return true;
        }

        public override bool Replace(string text)
        {
            if (_isLocked) return false;
            return base.Replace(text);
        }

        public override string ToString()
        {
            return $"{Name},{_isLocked}";
        }
    }
}