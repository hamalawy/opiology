using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Opiometrics
{
    //TODO: Conform code with FxCop and StyleCop standards
    public partial class Form1 : Form
    {
        private string fileDirectory = "Data";
        private string moleculeDirectory = "molecules";
        public List<String> consoleText = new List<string>();
        private List<String> topics = new List<String>();
        private Dictionary<String, Imprint> imprintDict = new Dictionary<String, Imprint>();
        private Dictionary<String, Drug> drugDict = new Dictionary<string, Drug>();
        OpioidConverter oConverter = new OpioidConverter();
        private OpioidConverter.Drug convertFrom = OpioidConverter.Drug.Morphine;
        private OpioidConverter.Drug convertTo = OpioidConverter.Drug.Morphine;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<String> ls = new List<string>()  { "Morphine", "Diacetylmorphine", "Oxycodone", "Hydromorphone", "Oxymorphone", "Fentanyl", "Hydrocodone", "Codeine", "Dihydrocodeine", "Tramadol", "Methadone", "Buprenorphine" } ;
            Initialize();
            topicsListBox.Items.AddRange(ls.ToArray());

        }

        private void Initialize()
        {
            LoadImprints(Path.Combine(fileDirectory, "imprints.xml"));
            LoadItems(Path.Combine(fileDirectory, "items.xml"));

            ConvertFromComboBox.Items.AddRange(Enum.GetNames(typeof(OpioidConverter.Drug)));
            ConvertToComboBox.Items.AddRange(Enum.GetNames(typeof(OpioidConverter.Drug)));
            ConvertFromComboBox.SelectedIndex = 0;
            ConvertToComboBox.SelectedIndex = 0;
        }

        #region DrugFacts
        public void LoadItems(string filename)
        {
            DataReader dataReader = new DataReader();
            dataReader.GetItemInfo(filename);
            drugDict = dataReader.drugDictionary;

        }
        private void SelectDrug(String drugname)
        {
            if (drugDict.ContainsKey(drugname))
            {
                Drug d = drugDict[drugname];
                NameLabel.Text = d.Name;
                PopulateROA(d.Name);
                DescriptionTextBox.Text = d.Description;
                LD50Label.Text = "LD50: " + d.LD50.ToString() + "mg/kg";
                DosageOralLabel.Text = "Naive Oral: " + d.NaiveOralDose.ToString() + "mg";
                DosageIVLabel.Text = "Naive IV: " + d.NaiveIVDose.ToString() + "mg";

                Bitmap b = new Bitmap(Path.Combine(Path.Combine(fileDirectory, moleculeDirectory), d.Name.ToLower() + "_molecule.png"));
                drugPicture.BackgroundImage = b;
            }
        }
        private void PopulateROA(String drugname)
        {
            if(drugDict.ContainsKey(drugname))
            {
            Dictionary<ROA, bool> roaInfo = drugDict["Morphine"].GetROAInfo();
            foreach (KeyValuePair<ROA, bool> kvp in roaInfo)
            {
                switch (kvp.Key)
                {
                    case ROA.Inhalable:
                        if (roaInfo[kvp.Key] == true)
                        {
                            ROAInhalableLabel.ForeColor = Color.LimeGreen;
                        }
                        else
                        {
                            ROAInhalableLabel.ForeColor = Color.Red;
                        }
                        break;
                    case ROA.Insufflatable:
                        if (roaInfo[kvp.Key] == true)
                        {
                            ROAInsufflatableLabel.ForeColor = Color.LimeGreen;
                        }
                        else
                        {
                            ROAInsufflatableLabel.ForeColor = Color.Red;
                        }
                        break;
                    case ROA.Intramuscular:
                        if (roaInfo[kvp.Key] == true)
                        {
                            ROAIMLabel.ForeColor = Color.LimeGreen;
                        }
                        else
                        {
                            ROAIMLabel.ForeColor = Color.Red;
                        }
                        break;
                    case ROA.Intravenous:
                        if (roaInfo[kvp.Key] == true)
                        {
                            ROAIVLabel.ForeColor = Color.LimeGreen;
                        }
                        else
                        {
                            ROAIVLabel.ForeColor = Color.Red;
                        }
                        break;
                    case ROA.Oral:
                        if (roaInfo[kvp.Key] == true)
                        {
                            ROAOralLabel.ForeColor = Color.LimeGreen;
                        }
                        else
                        {
                            ROAOralLabel.ForeColor = Color.Red;
                        }
                        break;
                    case ROA.Rectal:
                        if (roaInfo[kvp.Key] == true)
                        {
                            ROARectalLabel.ForeColor = Color.LimeGreen;
                        }
                        else
                        {
                            ROARectalLabel.ForeColor = Color.Red;
                        }
                        break;
                    case ROA.Subcutaneous:
                        if (roaInfo[kvp.Key] == true)
                        {
                            ROASCLabel.ForeColor = Color.LimeGreen;
                        }
                        else
                        {
                            ROASCLabel.ForeColor = Color.Red;
                        }
                        break;
                    case ROA.Sublingual:
                        if (roaInfo[kvp.Key] == true)
                        {
                            ROASublingualLabel.ForeColor = Color.Red;
                        }
                        else
                        {
                            ROASublingualLabel.ForeColor = Color.Red;
                        }
                        break;

                }
            }
        }
        }
        private void topicsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectDrug((String)topicsListBox.Items[topicsListBox.SelectedIndex]);
        }
        #endregion


        #region Pill Identification
        //TODO: Use LINQ for imprint and imprint search filtering
        public void LoadImprints(string filename)
        {
            ImprintReader imprintReader = new ImprintReader();
            imprintReader.GetItemInfo(filename);
            imprintDict = imprintReader.imprintDictionary;

        }
        private void SelectImprint(String imprintId)
        {
            if (imprintDict.ContainsKey(imprintId))
            {
                Imprint i = imprintDict[imprintId];
                ManufacturerLabel.Text = "Manufacturer: " + i.Manufacturer;
                TypeLabel.Text = "Type: " + i.Type.ToString();
                ImprintLabel.Text = "Imprint: " + i.imprint;
                StrengthLabel.Text = "Strength: " + i.Strength + "mg";
                ShapeLabel.Text = "Shape: " + i.Shape.ToString().ToLower();
                ColorLabel.Text = "Color: " + i.Color;
                DescriptionLabel.Text = "Description: " + i.Description;
                pictureBox1.BackgroundImage = i.PillImage;
            }
        }

        private void ImprintListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectImprint((String)ImprintListBox.Items[ImprintListBox.SelectedIndex]);
        }
        
        private Dictionary<String, Imprint> SearchPills(String searchstring)
        {
            String sanitizedString = searchstring.ToLower();
            Dictionary<String, Imprint> results = new Dictionary<String, Imprint>();
            foreach (Imprint i in imprintDict.Values)
            {
                String tags = i.Manufacturer.ToLower() + " " + i.imprint + " " + i.Description + " " + i.Color + " " + i.Type.ToString();
                if (tags.Contains(sanitizedString))
                {
                    results.Add(i.imprint, i);
                }
            }
            if (results.Count > 0)
            {
                return results;
            }
            else
            {
                return null;
            }
        }

        private void ImprintSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            Dictionary<String, Imprint> searchResults = SearchPills(ImprintSearchTextBox.Text);
            if (searchResults != null)
            {
                ImprintListBox.Items.Clear();
                ImprintListBox.Items.AddRange(searchResults.Keys.ToArray());
            }
            else
            {
                ImprintListBox.Items.Clear();
            }

        }

        private void ImprintSearchTextBox_Click(object sender, EventArgs e)
        {
            ImprintSearchTextBox.Text = "";
        }
        #endregion

        #region Conversion

        private String ConvertOpioid(OpioidConverter.Drug from, OpioidConverter.Drug to, double amount)
        {
            String result = oConverter.Convert(from, to, amount).ToString();
            return result;
        }

        private void ConversionSourceTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 ; //Don't let anything but numbers and the delete key through
        }

        private void ConvertFromComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            convertFrom = (OpioidConverter.Drug)Enum.Parse(typeof(OpioidConverter.Drug), (String)ConvertFromComboBox.Items[ConvertFromComboBox.SelectedIndex]);
            CalculateConversion();
        }

        private void ConvertToComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            convertTo = (OpioidConverter.Drug)Enum.Parse(typeof(OpioidConverter.Drug), (String)ConvertToComboBox.Items[ConvertToComboBox.SelectedIndex]);
            CalculateConversion();
        }

        private void CalculateConversion()
        {
            FromUnitLabel.Text = (convertFrom == OpioidConverter.Drug.Fentanyl) ? "mcg" : "mg";
            ToUnitLabel.Text = (convertTo == OpioidConverter.Drug.Fentanyl) ? "mcg" : "mg";
            StringBuilder rSB = new StringBuilder();
            if (ConversionSourceTextbox.Text != String.Empty)
            {
                ConversionToTextBox.Text = ConvertOpioid(convertFrom, convertTo, double.Parse(ConversionSourceTextbox.Text));

                ResultLabel.Text = ConversionSourceTextbox.Text + FromUnitLabel.Text + " of " + convertFrom.ToString() + System.Environment.NewLine + " is approximately equal to " + System.Environment.NewLine + ConversionToTextBox.Text + ToUnitLabel.Text + " of " + convertTo.ToString();
            }

        }

        #endregion

        private void ConversionSourceTextbox_TextChanged(object sender, EventArgs e)
        {
            CalculateConversion();
        }


    }
    
}
