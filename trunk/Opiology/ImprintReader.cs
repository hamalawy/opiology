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

        private Dictionary<String, Imprint> imprintDictionary = new Dictionary<String, Imprint>();
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
                                        d.ImprintString = value.ToLower();
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
                String imagePath = Path.Combine(Path.Combine("Data", "imprints"), d.ImprintString + ".jpg");
                if (File.Exists(imagePath))
                {
                    d.PillImage = new Bitmap(imagePath);
                }
                else
                {
                    d.PillImage = new Bitmap(Path.Combine(Path.Combine("Data", "imprints"), "default.jpg"));
                }

                imprintDictionary.Add(d.ImprintString, d);

                if (!typeList.Contains(d.Type.ToString()))
                {
                    typeList.Add(d.Type.ToString()); //If the typelist doesn't already contain the type, then add it
                }
            }

            typeList.Sort((x, y) => String.Compare(x, y)); //Sort typelist alphabetically for use in the GUI
        }
    }
}
