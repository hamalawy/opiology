using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Opiometrics
{
           
    public class OpioidConverter
    {
        public enum Drug { Codeine, Diacetylmorphine, Fentanyl, Hydrocodone, Hydromorphone, Methadone, Morphine, Oxycodone, Oxymorphone };
        private double[] ratio = { 6.67, 0.45, 10, 1, .25, .1, 1, .5, .33 };

        public double ConvertToMorphine(Drug drug, double amount) 
        {
            return Math.Round(amount / ratio[(int)drug], 2);
        } 

        public double ConvertFromMorphine(Drug drug, double amount)
        {
            return Math.Round(amount * ratio[(int)drug], 2);
        }

        public double Convert(Drug from, Drug to, double amount)
        {
            return ConvertFromMorphine(to, ConvertToMorphine(from, amount));
        }


    }
}
