// <copyright file="AssemblyInfo.cs">
// Copyright (c) 2010 All Right Reserved
// </copyright>
// <author>C Patton</author>
// <email>hopesfall@gmail.com</email>
// <date>03-30-2010</date>
// <summary>Contains assembly information.</summary>

namespace Opiology
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	/// <summary>
	/// 
	/// </summary>
   public class Substance
    {
            private string name;
            private List<Roa> routesOfAdministration = new List<Roa>();
            private int lethalDosage; // LD50 in milligrams
            private int naiveOralDose;
            private int naiveIVDose;
            private string description;
            
            /// <summary>
            /// Name of the substance
            /// </summary>
            public string Name
            {
                get { return this.name; }
                
                set { this.name = value; }
            }
            /// <summary>
            /// Which routes of administration this substance has
            /// </summary>
            public List<Roa> RoutesOfAdministration
            {
                get { return this.routesOfAdministration; }
            }
            /// <summary>
            /// The lethal dosage for 50% of the population (in rats)
            /// </summary>
            public int LD50
            {
                get { return this.lethalDosage; }
                set { this.lethalDosage = value; }
            }
            /// <summary>
            /// The average oral dosage for an opioid-naive individual
            /// </summary>
            public int NaiveOralDose
            {
                get { return this.naiveOralDose; }
                set { this.naiveOralDose = value; }
            }
            /// <summary>
            /// The average intravenous dosage for an opioid-naive individual
            /// </summary>
            public int NaiveIVDose
            {
                get { return this.naiveIVDose; }
                set { this.naiveIVDose = value; }
            }
            /// <summary>
            /// A description of the substance
            /// </summary>
            public string Description
            {
                get { return this.description; }
                set { this.description = value; }
            }
            
            
            #region Constructors

            public Substance( String name)
            {
                this.name = name;
            }

            public Dictionary<Roa, bool> GetRoaInfo()
            {
                Dictionary<Roa, bool> RoaInfo = new Dictionary<Roa, bool>();
                foreach(Roa r in Enum.GetValues(typeof(Roa)))
                {
                    if (routesOfAdministration.Contains(r))
                    {
                        RoaInfo.Add(r, true);
                    }
                    else
                    {
                        RoaInfo.Add(r, false);
                    }
                }
                return RoaInfo;
            }
            #endregion

        
    }
}
