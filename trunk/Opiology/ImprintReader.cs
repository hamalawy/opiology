using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Drawing;
namespace Opiology
{
    /// <summary>
    /// Reads imprint data
    /// </summary>
    public class ImprintReader
    {

        private Dictionary<string, Imprint> imprintDictionary = new Dictionary<string, Imprint>();
        
		public Dictionary<string, Imprint> ImprintDictionary
		{
			get { return this.imprintDictionary; }
			set { this.imprintDictionary = value; }
		}
		
        private List<String> typeList = new List<String>();
		public List<string> TypeList
		{
			get { return this.typeList; }
			set { this.typeList = value; }
		}
        
        /// <summary>
        /// Reads imprint information from an XML file and adds it to the imprintDictionary
        /// </summary>
        /// <param name="fileName">The XML file to parse</param>
        public void GetItemInfo(string fileName)
        {
            XmlDocument document = new XmlDocument();
            document.Load(fileName);

            foreach (XmlNode node in document.GetElementsByTagName("imprint"))
            {
                Imprint d;
                string type = node.Attributes["type"].InnerText;
                d = new Imprint(type);
                foreach (XmlAttribute attr in node.Attributes)
                {
                    switch (attr.Name.ToLower())
                    {
                        case "type":
                            d.Type = (PillType)Enum.Parse(typeof(PillType), node.Attributes["type"].InnerText);
                            break;
                        case "manufacturer":
                            d.Manufacturer = (node.Attributes["manufacturer"].InnerText.Contains("Pharmaceuticals"))
                                ? node.Attributes["manufacturer"].InnerText.Replace("Pharmaceuticals", "")
                                : d.Manufacturer = node.Attributes["manufacturer"].InnerText;
                            break;
                        case "imprint":
                            d.ImprintString = node.Attributes["imprint"].InnerText;
                            break;
                        case "strength":
                            d.Strength = double.Parse(node.Attributes["strength"].InnerText);
                            break;
                        case "color":
                            d.Color = node.Attributes["color"].InnerText;
                            break;
                        case "shape":
                            d.Shape = node.Attributes["shape"].InnerText;
                            break;
                        case "otheringredient":
                            d.OtherIngredient = node.Attributes["otheringredient"].InnerText;
                            break;
                        case "otheringredientstrength":
                            d.OtherIngredientStrength = double.Parse(node.Attributes["otheringredientstrength"].InnerText);
                            break;
                        case "apap":
                            d.Apap = int.Parse(node.Attributes["apap"].InnerText);
                            break;
                    }
                }
                if (node.HasChildNodes)
                {
                    foreach (XmlNode attrNode in node.ChildNodes)
                    {
                       d.Description = attrNode.InnerText;

                    }
                }
                string imgFileName = d.ImprintString.ToLower().Replace(" ", "-");
                String imagePath = Path.Combine(Path.Combine(Path.Combine("Data", "imprints"), d.Type.ToString()), imgFileName + ".jpg");
                if (File.Exists(imagePath))
                {
                    d.PillImage = new Bitmap(imagePath);
                }
                else
                {
                    d.PillImage = new Bitmap(Path.Combine(Path.Combine("Data", "imprints"), "default.jpg"));
                }

                imprintDictionary.Add(d.Type.ToString() + " " + d.ImprintString, d);

                if (!typeList.Contains(d.Type.ToString()))
                {
                    typeList.Add(d.Type.ToString()); //If the typelist doesn't already contain the type, then add it
                }
            }

            typeList.Sort((x, y) => String.Compare(x, y)); //Sort typelist alphabetically for use in the GUI
        }
    }
}
