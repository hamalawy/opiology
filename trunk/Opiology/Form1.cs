using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Opiology
{
    //TODO: Conform code with FxCop and StyleCop standards
    public partial class Form1 : Form
    {
        private string fileDirectory = "Data";
        private string moleculeDirectory = "molecules";
        public List<String> consoleText = new List<string>();
        private List<String> topics = new List<String>();
        private Dictionary<String, Imprint> imprintDict = new Dictionary<String, Imprint>();
        private Dictionary<String, Substance> drugDict = new Dictionary<string, Substance>();
        OpioidConverter oConverter = new OpioidConverter();
        private OpioidConverter.Drug convertFrom = OpioidConverter.Drug.Morphine;
        private OpioidConverter.Drug convertTo = OpioidConverter.Drug.Morphine;
        ImprintReader imprintReader;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<String> ls = new List<string>()  { "Morphine", "Diacetylmorphine", "Oxycodone", "Hydromorphone", "Oxymorphone", "Fentanyl", "Hydrocodone", "Codeine", "Dihydrocodeine", "Tramadol", "Methadone", "Buprenorphine" } ;
            Initialize();
            topicsListBox.Items.AddRange(ls.ToArray());
            Imprint i = new Imprint(PillType.Morphine);

            i.ImprintString = "foobar";

            imprintDict.Add(i.ImprintString, i);
        }

        private void Initialize()
        {
            LoadImprints(Path.Combine(fileDirectory, "imprints.xml"));
            LoadItems(Path.Combine(fileDirectory, "items.xml"));

            PopulateTypeComboBox();

            ConvertFromComboBox.Items.AddRange(Enum.GetNames(typeof(OpioidConverter.Drug)));
            ConvertToComboBox.Items.AddRange(Enum.GetNames(typeof(OpioidConverter.Drug)));
            ConvertFromComboBox.SelectedIndex = 0;
            ConvertToComboBox.SelectedIndex = 0;

            FilterComboBox.SelectedIndex = 0;  
        }

        #region DrugFacts
        public void LoadItems(string fileName)
        {
            SubstanceDataReader dataReader = new SubstanceDataReader();
            dataReader.GetSubstanceInfo(fileName);
            drugDict = dataReader.DrugDictionary;

        }
        private void SelectDrug(String drugname)
        {
            if (drugDict.ContainsKey(drugname))
            {
                Substance d = drugDict[drugname];
                NameLabel.Text = d.Name;
                PopulateRoa(d.Name);
                DescriptionTextBox.Text = d.Description;
                LD50Label.Text = "LD50: " + d.LD50.ToString() + "mg/kg";
                DosageOralLabel.Text = "Naive Oral: " + d.NaiveOralDose.ToString() + "mg";
                DosageIVLabel.Text = "Naive IV: " + d.NaiveIVDose.ToString() + "mg";

                Bitmap moleculePicture = new Bitmap(Path.Combine(Path.Combine(fileDirectory, moleculeDirectory), d.Name.ToLower() + "_molecule.png"));
                drugPicture.BackgroundImage = moleculePicture;
            }
        }
        private void PopulateRoa(String drugname)
        {
            if(drugDict.ContainsKey(drugname))
            {
                Dictionary<Roa, bool> roaInfo = drugDict[drugname].GetRoaInfo();
                
                Dictionary<Roa, Label> labelDictionary = new Dictionary<Roa, Label>() { {Roa.Inhalable, ROAInhalableLabel},
                {Roa.Insufflatable, ROAInsufflatableLabel}, {Roa.Intramuscular, ROAIMLabel}, {Roa.Intravenous, ROAIVLabel},
                {Roa.Oral, ROAOralLabel}, {Roa.Rectal, ROARectalLabel}, {Roa.Subcutaneous, ROASCLabel}, {Roa.Sublingual, ROASublingualLabel}};
                
                foreach (KeyValuePair<Roa, bool> roaKvp in roaInfo)
                {
                    labelDictionary[roaKvp.Key].ForeColor = roaKvp.Value ? Color.LimeGreen : Color.Red;
                }
        }
        }
        private void topicsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectDrug((String)topicsListBox.Items[topicsListBox.SelectedIndex]);
        }
        #endregion


        #region Pill Identification

        public void LoadImprints(string fileName)
        {
            imprintReader = new ImprintReader();
            imprintReader.GetItemInfo(fileName);
            imprintDict = imprintReader.ImprintDictionary;

        }
        public void PopulateTypeComboBox()
        {
            FilterComboBox.Items.AddRange(imprintReader.TypeList.ToArray());
            FilterComboBox.Items.Add("Morphine");
        }

        private Dictionary<String, Imprint> SearchPills(String searchstring)
        {
            String sanitizedString = searchstring.ToLower();
            Dictionary<String, Imprint> results = new Dictionary<String, Imprint>();
            string filterValue = FilterComboBox.Items[FilterComboBox.SelectedIndex].ToString();
            if (filterValue != string.Empty)
            {
                foreach (Imprint i in imprintDict.Values)
                {
                    if (i.Type.ToString() == filterValue)
                    {
                        if (!i.IsEmpty())
                        {
                            String tags = i.Manufacturer.ToLower() + " " + i.ImprintString + " " + i.Description + " " + i.Color + " " + i.Type.ToString();
                            if (tags.Contains(sanitizedString))
                            {
                                results.Add(i.ImprintString, i);
                            }
                        }
                    }
                }
            }
            if(filterValue == string.Empty)
            {
                foreach (Imprint i in imprintDict.Values)
                {
                        String tags = i.Manufacturer.ToLower() + " " + i.ImprintString + " " + i.Description + " " + i.Color + " " + i.Type.ToString();
                        if (tags.Contains(sanitizedString))
                        {
                            results.Add(i.ImprintString, i);
                        }
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

        private void SelectImprint(String imprintId)
        {
            if (imprintDict.ContainsKey(imprintId))
            {
                Imprint i = imprintDict[imprintId];
                ManufacturerLabel.Text = "Manufacturer: " + i.Manufacturer;
                TypeLabel.Text = "Type: " + i.Type.ToString();
                ImprintLabel.Text = "Imprint: " + i.ImprintString;
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
        
        private void FilterComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
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
            ImprintSearchTextBox.Text = String.Empty;
        }

        //TODO: Get rid of this method of filtering by adding filter values to the SearchPills method.
        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ImprintSearchTextBox.Text == string.Empty)
            {
                ImprintListBox.Items.Clear();
                foreach (Imprint i in imprintDict.Values)
                {
                    if (!i.IsEmpty())
                    {
                        if (i.Type.ToString() == (string)FilterComboBox.Items[FilterComboBox.SelectedIndex])
                        {
                            ImprintListBox.Items.Add(i.ImprintString);
                        }
                    }
                }
            }
            else
            {
                Dictionary<String, Imprint> searchResults = SearchPills(ImprintSearchTextBox.Text);
                if (searchResults != null)
                {
                    ImprintListBox.Items.Clear();
                    foreach (Imprint i in searchResults.Values)
                    {
                        if (!i.IsEmpty())
                        {
                            if (i.Type.ToString() == (string)FilterComboBox.Items[FilterComboBox.SelectedIndex])
                            {
                                ImprintListBox.Items.Add(i.ImprintString);
                            }
                        }
                    }
                }

            }
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
        private void ConversionSourceTextbox_TextChanged(object sender, EventArgs e)
        {
            CalculateConversion();
        }

        #endregion



    }
    
}
