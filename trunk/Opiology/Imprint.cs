using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace Opiometrics
{
    public class Imprint
    {
            public String Manufacturer;
            public PillType Type;
            public String imprint;
            public int Strength;
            public String Color;
            public PillShape Shape;
            public bool Scored = false;
            public String Description;
            public Bitmap PillImage;

            #region Constructors

            public Imprint(PillType type)
            {
                this.Type = type;
            }
            #endregion
    }
}
