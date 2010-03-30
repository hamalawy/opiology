using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Opiometrics
{
    public enum Roa
    {
        Oral,
        Inhalable,
        Insufflatable,
        Intravenous,
        Intramuscular,
        Subcutaneous,
        Sublingual,
        Rectal
    }
    public enum PillType
    {
        Codeine,
        Fentanyl,
        Hydrocodone,
        Hydromorphone,
        Morphine,
        Oxycodone,
        Oxymorphone
    }
    public enum PillShape
    {
        Capsule,
        Round,
        Oblong
    }

}
