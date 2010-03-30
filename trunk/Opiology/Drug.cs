using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Opiometrics
{
   public class Drug
    {
            public String Name;
            public List<ROA> RoutesOfAdministration = new List<ROA>();
            public int LD50; //LD50 in milligrams
            public int NaiveOralDose;
            public int NaiveIVDose;
            public String Description;

            #region Constructors

            public Drug( String name)
            {
                this.Name = name;
            }

            public Dictionary<ROA, bool> GetROAInfo()
            {
                Dictionary<ROA, bool> roaInfo = new Dictionary<ROA, bool>();
                foreach(ROA r in Enum.GetValues(typeof(ROA)))
                {
                    if (RoutesOfAdministration.Contains(r))
                    {
                        roaInfo.Add(r, true);
                    }
                    else
                    {
                        roaInfo.Add(r, false);
                    }
                }
                return roaInfo;
            }
            #endregion

        
    }
}
