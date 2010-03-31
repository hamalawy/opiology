using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Opiology
{
    /// <summary>
    /// Converts one opioid to another (in milligrams)
    /// </summary>  
    public class OpioidConverter
    {
        #region Variables

        public enum Drug { Codeine, Diacetylmorphine, Fentanyl, Hydrocodone, Hydromorphone, Methadone, Morphine, Oxycodone, Oxymorphone };
        private readonly double[] ratio = { 6.67, 0.45, 10, 1, .25, .1, 1, .5, .33 };

        #endregion

        #region Methods

        /// <summary>
        /// Converts a drug to morphine based on it's ratio
        /// </summary>
        /// <param name="drug">The drug to convert to morphine</param>
        /// <param name="amount">The amount of the drug in milligrams</param>
        /// <returns>A double of the conversion result</returns>
        public double ConvertToMorphine(Drug drug, double amount) 
        {
            return Math.Round(amount / ratio[(int)drug], 2);
        } 

        /// <summary>
        /// Converts a drug from morphine based on it's ratio
        /// </summary>
        /// <param name="drug">The drug to convert from</param>
        /// <param name="amount">The amount of the drug in milligrams</param>
        /// <returns>A double of the conversion result</returns>
        public double ConvertFromMorphine(Drug drug, double amount)
        {
            return Math.Round(amount * ratio[(int)drug], 2);
        }

        /// <summary>
        /// Converts a drug to anothere drug based on their ratios
        /// </summary>
        /// <param name="from">The drug to convert from</param>
        /// <param name="to">The drug to convert to</param>
        /// <param name="amount">The amount of the drug to convert from in milligrams</param>
        /// <returns>A double of the conversion result</returns>
        public double Convert(Drug from, Drug to, double amount)
        {
            return ConvertFromMorphine(to, ConvertToMorphine(from, amount));
        }

        #endregion

    }
}
