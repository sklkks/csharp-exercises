using System;
using System.Collections.Generic;
using System.Text;

class Calibrator
{
    public int Offest { get; set; }

    public Calibrator(int correction)
    {
        Offest = correction;
    }

    public int Adjust(int offset) => offset + Offest;
    
}