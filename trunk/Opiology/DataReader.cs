using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Globalization;
namespace Opiometrics
{
    public class DataReader
    {

        public Dictionary<String, Drug> drugDictionary = new Dictionary<String, Drug>();

        public void GetItemInfo(string fileName)
        {
            XmlDocument document = new XmlDocument();
            document.Load(fileName);

            foreach (XmlNode node in document.GetElementsByTagName("drug"))
            {
                Drug d;
                String name = node.Attributes["name"].InnerText;
                d = new Drug(name);
                foreach (XmlAttribute attr in node.Attributes)
                {
                    switch (attr.Name.ToLower(CultureInfo.CurrentCulture))
                    {
                        case "name":
                            d.Name = node.Attributes[attr.Name].InnerText;
                            break;
                    }
                }
                if (node.HasChildNodes)
                {
                        foreach (XmlNode attrNode in node.ChildNodes)
                        {
                            if (attrNode.Attributes != null &&
                                attrNode.Attributes.Count > 0 &&
                                attrNode.Attributes["key"] != null &&
                                attrNode.Attributes["value"] != null)
                            {
                                string value = attrNode.Attributes["value"].InnerText;
                                switch (attrNode.Attributes["key"].InnerText.ToLower())
                                {
                                #region ROAParse
                                   case "oral":
                                            if(value == "1")
                                                d.RoutesOfAdministration.Add(ROA.Oral);
                                        break;
                                    case "intravenous":
                                            if(value == "1")
                                                d.RoutesOfAdministration.Add(ROA.Intravenous);
                                        break;
                                    case "intramuscular":
                                            if(value == "1")
                                                d.RoutesOfAdministration.Add(ROA.Intramuscular);
                                        break;
                                    case "subcutaneous":
                                            if(value == "1")
                                                d.RoutesOfAdministration.Add(ROA.Subcutaneous);
                                        break;
                                    case "inhalable":
                                            if(value == "1")
                                                d.RoutesOfAdministration.Add(ROA.Inhalable);
                                            break;
                                    case "insufflatable":
                                            if (value == "1")
                                                d.RoutesOfAdministration.Add(ROA.Insufflatable);
                                            break;
                                    case "sublingual":
                                            if (value == "1")
                                                d.RoutesOfAdministration.Add(ROA.Sublingual);
                                            break;
                                    case "rectal":
                                            if(value == "1")
                                                d.RoutesOfAdministration.Add(ROA.Rectal);
                                        break;
                                 #endregion
                                    case "ld50":
                                        d.LD50 = int.Parse(value);
                                        break;
                                    case "naiveoraldose":
                                        d.NaiveOralDose = int.Parse(value);
                                        break;
                                    case "naiveivdose":
                                        d.NaiveIVDose = int.Parse(value);
                                        break;
                                    case "description":
                                        d.Description = value;
                                        break;
                                    #region commented
                                    //case "article":
                                    //    info.Article = value;
                                    //    break;
                                    //case "plural":
                                    //    info.PluralName = value + ' ';
                                    //    break;
                                    //case "description":
                                    //    info.Description = '\n' + value;
                                    //    break;
                                    //case "weight":
                                    //    info.Weight = Double.Parse(value) / 100.0;
                                    //    break;
                                    //case "showcount":
                                    //    info.ShowCount = UInt16.Parse(value) != 0;
                                    //    break;
                                    //case "armor":
                                    //    info.Armor = UInt16.Parse(value);
                                    //    break;
                                    //case "defense":
                                    //    info.Defense = UInt16.Parse(value);
                                    //    break;
                                    //case "extradef":
                                    //    info.ExtraDefense = Int16.Parse(value);
                                    //    break;
                                    //case "attack":
                                    //    info.Attack = UInt16.Parse(value);
                                    //    break;
                                    //case "rotateto":
                                    //    info.RotateTo = UInt16.Parse(value);
                                    //    break;
                                    //case "moveable":
                                    //    info.IsMoveable = UInt16.Parse(value) != 0;
                                    //    break;
                                    //case "blockprojectile":
                                    //    info.IsProjectileBlocking = UInt16.Parse(value) != 0;
                                    //    break;
                                    //case "allowpickupable":
                                    //    info.IsPickupable = UInt16.Parse(value) != 0;
                                    //    break;
                                    //case "floorchange":
                                    //    switch (value.ToLower())
                                    //    {
                                    //        case "up":
                                    //            info.FloorChange = FloorChangeDirection.Up;
                                    //            break;
                                    //        case "down":
                                    //            info.FloorChange = FloorChangeDirection.Down;
                                    //            break;
                                    //        case "north":
                                    //            info.FloorChange = FloorChangeDirection.North;
                                    //            break;
                                    //        case "south":
                                    //            info.FloorChange = FloorChangeDirection.South;
                                    //            break;
                                    //        case "west":
                                    //            info.FloorChange = FloorChangeDirection.West;
                                    //            break;
                                    //        case "east":
                                    //            info.FloorChange = FloorChangeDirection.East;
                                    //            break;
                                    //    }
                                    //    break;
                                    //case "containersize":
                                    //    info.Volume = Byte.Parse(value);
                                    //    break;
                                    //case "fluidsource":
                                    //    info.FluidSource = (Fluid)Enum.Parse(typeof(Fluid), value, true);
                                    //    break;
                                    //case "readable":
                                    //    info.IsReadable = UInt16.Parse(value) != 0;
                                    //    break;
                                    //case "writeable":
                                    //    info.IsWriteable = UInt16.Parse(value) != 0;
                                    //    break;
                                    //case "maxtextlen":
                                    //    info.MaxTextLength = UInt16.Parse(value);
                                    //    break;
                                    //case "writeonceitemid":
                                    //    info.WriteOnceItemId = UInt16.Parse(value);
                                    //    break;
                                    //case "weapontype":
                                    //    info.WeaponType = (WeaponType)Enum.Parse(typeof(WeaponType), value, true);
                                    //    break;
                                    //case "slottype":
                                    //    switch (value.ToLower())
                                    //    {
                                    //        case "head":
                                    //            info.SlotType = SlotType.Head;
                                    //            break;
                                    //        case "body":
                                    //            info.SlotType = SlotType.Armor;
                                    //            break;
                                    //        case "legs":
                                    //            info.SlotType = SlotType.Legs;
                                    //            break;
                                    //        case "feet":
                                    //            info.SlotType = SlotType.Feet;
                                    //            break;
                                    //        case "backpack":
                                    //            info.SlotType = SlotType.Back;
                                    //            break;
                                    //        case "two-handed":
                                    //            info.SlotType = SlotType.TwoHanded;
                                    //            break;
                                    //        case "necklace":
                                    //            info.SlotType = SlotType.Neck;
                                    //            break;
                                    //        case "ring":
                                    //            info.SlotType = SlotType.Ring;
                                    //            break;
                                    //    }
                                    //    break;
                                    //case "ammotype":
                                    //    var shootType = (ProjectileType)Enum.Parse(typeof(ProjectileType), value, true);
                                    //    info.AmmoType = shootType.GetAmmoType();
                                    //    break;
                                    //case "shoottype":
                                    //    info.ProjectileType = (ProjectileType)Enum.Parse(typeof(ProjectileType), value, true);
                                    //    break;
                                    //case "effect":
                                    //    switch (value)
                                    //    {
                                    //        case "redspark":
                                    //            info.Effect = Effect.RedSpark;
                                    //            break;
                                    //        case "bluebubble":
                                    //            info.Effect = Effect.BlueRings;
                                    //            break;
                                    //        case "poff":
                                    //            info.Effect = Effect.Puff;
                                    //            break;
                                    //        case "yellowspark":
                                    //            info.Effect = Effect.YellowSpark;
                                    //            break;
                                    //        case "explosionarea":
                                    //            info.Effect = Effect.ExplosionArea;
                                    //            break;
                                    //        case "explosion":
                                    //            info.Effect = Effect.ExplosionDamage;
                                    //            break;
                                    //    }
                                    //    break;
                                    //case "transformequipto":
                                    //    info.TransformEquipTo = ushort.Parse(value);
                                    //    break;
                                    //case "transformdequipto":
                                    //    info.TransformDequipTo = ushort.Parse(value);
                                    //    break;
                                    //case "showduration":
                                    //    info.ShowDuration = int.Parse(value) != 0;
                                    //    break;
                                    //case "charges":
                                    //    info.Charges = int.Parse(value);
                                    //    break;
                                    //case "showcharges":
                                    //    info.ShowCharges = int.Parse(value) != 0;
                                    //    break;
                                    #endregion
                                }
                            }
                        }
                    }
                

               this.drugDictionary.Add(d.Name, d);
            }

        }
    }
}
