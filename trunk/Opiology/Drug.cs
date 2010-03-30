using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Opiometrics
{
   public class Drug
    {
            private String name;
            private List<Roa> routesOfAdministration = new List<Roa>();
            private int lD50; //LD50 in milligrams
            private int naiveOralDose;
            private int naiveIVDose;
            private String description;
            
			public string Name {
				get { return name; }
				set { name = value; }
			}
			public List<Roa> RoutesOfAdministration {
				get { return routesOfAdministration; }
			}
            public int LD50 {
				get { return lD50; }
				set { lD50 = value; }
			}
			public int NaiveOralDose {
				get { return naiveOralDose; }
				set { naiveOralDose = value; }
			}
            
			public int NaiveIVDose {
				get { return naiveIVDose; }
				set { naiveIVDose = value; }
			}
			public string Description {
				get { return description; }
				set { description = value; }
			}
            
            
            #region Constructors

            public Drug( String name)
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
