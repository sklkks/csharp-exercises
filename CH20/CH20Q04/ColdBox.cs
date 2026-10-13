using System;
using System.Collections.Generic;
using System.Text;

namespace CH20Q04
{
    internal class ColdBox : InsulatedBox
    {
        public readonly int CoolantVolume;
        public int AvailableVolume => Math.Max(0, InternalVolume - CoolantVolume);

        public ColdBox(int width, int length, int height, int insulation, int coolantVolume) : 
            base(width, length, height, insulation)
        {
            CoolantVolume = coolantVolume;
        }

        public bool Canstore(int volume)
        {
            return volume <= AvailableVolume;
        }
    }
}
