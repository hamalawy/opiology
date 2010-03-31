using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Opiology
{
    public class Imprint
    {
            #region Variables

            private string manufacturer;
            private PillType type;
            private string imprintString;
            private int strength;
            private string color;
            private PillShape shape;
            private bool scored = false;
            private string description;
            private Bitmap pillImage;

            #endregion
			
            #region Constructors

            /// <summary>
            /// Creates a new Imprint object with the given PillType
            /// </summary>
            /// <param name="type">The type of the pill</param>
            public Imprint(PillType type)
            {
                this.type = type;
            }
            #endregion

            #region Properties

            public string Manufacturer
            {
                get { return this.manufacturer; }
                set { this.manufacturer = value; }
            }

            public PillType Type
            {
                get { return this.type; }
                set { this.type = value; }
            }

            public string ImprintString
            {
                get { return this.imprintString; }
                set { this.imprintString = value; }
            }

            public int Strength
            {
                get { return this.strength; }
                set { this.strength = value; }
            }

            public string Color
            {
                get { return this.color; }
                set { this.color = value; }
            }

            public PillShape Shape
            {
                get { return this.shape; }
                set { this.shape = value; }
            }

            public bool Scored
            {
                get { return this.scored; }
                set { this.scored = value; }
            }

            public string Description
            {
                get { return this.description; }
                set { this.description = value; }
            }

            public Bitmap PillImage
            {
                get { return this.pillImage; }
                set { this.pillImage = value; }
            }
        #endregion

            #region Methods

            /// <summary>
            /// Check to see if an imprint contains the most important information
            /// </summary>
            /// <returns>True if the Imprint has no manufacturer, imprint, or strength. False otherwise.</returns>
            public bool IsEmpty()
            {
                return (this.manufacturer == null
                    || this.imprintString == null
                    || this.strength == 0
                    || this.color == null
                    || this.description == null
                    || this.shape == PillShape.None
                    || this.type == PillType.None);
            }

            #endregion
    }
}
