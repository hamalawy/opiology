using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Drawing;
namespace Opiometrics
{
    public class ImprintReader
    {

        public Dictionary<String, Imprint> imprintDictionary = new Dictionary<String, Imprint>();

        public void GetItemInfo(string fileName)
        {
            XmlDocument document = new XmlDocument();
            document.Load(fileName);

            foreach (XmlNode node in document.GetElementsByTagName("pill"))
            {
                Imprint d;
                PillType type = (PillType)Enum.Parse(typeof(PillType), node.Attributes["type"].InnerText);
                d = new Imprint(type);
                foreach (XmlAttribute attr in node.Attributes)
                {
                    switch (attr.Name.ToLower())
                    {
                        case "name":
                            d.Type = (PillType)Enum.Parse(typeof(PillType), node.Attributes["type"].InnerText);
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
                                case "manufacturer":
                                    d.Manufacturer = value;
                                    break;
                                case "imprint":
                                        d.imprint = value.ToLower();
                                    break;
                                case "strength":
                                    d.Strength = int.Parse(value);
                                    break;
                                case "color":
                                    d.Color = value;
                                    break;
                                case "shape":
                                    if(value == "round")
                                        d.Shape = PillShape.Round;
                                    if(value == "capsule")
                                        d.Shape = PillShape.Capsule;
                                    if(value == "oblong")
                                        d.Shape = PillShape.Oblong;
                                    break;
                                case "scored":
                                    if (value == "1")
                                        d.Scored = true;
                                    if(value == "0")
                                        d.Scored = false;
                                    break;
                                case "description":
                                    d.Description = value;
                                    break;
                                
                            }
                        }
                    }
                }
                String imagePath = Path.Combine(Path.Combine("Data", "imprints"), d.imprint + ".jpg");
                if (File.Exists(imagePath))
                {
                    d.PillImage = new Bitmap(imagePath);
                }
                else
                {
                    d.PillImage = new Bitmap(Path.Combine(Path.Combine("Data", "imprints"), "default.jpg"));
                }

                imprintDictionary.Add(d.imprint, d);
                
            }

        }
    }
}
