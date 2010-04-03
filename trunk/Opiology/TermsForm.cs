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
    public partial class TermsForm : Form
    {
        MPIniReadWrite.MultiplatformIni iniSettings;
        string iniFilePath = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "settings.ini";

          
        public TermsForm()
        {
            InitializeComponent();
        }

        private void TermsForm_Load(object sender, EventArgs e)
        {
            // When the textbox is loaded, it automatically has all of the text in it 
            // selected for some reason. Couldn't find a solution, so here is a quick fix.
            TermsTextBox.Select(TermsTextBox.Text.Length, TermsTextBox.Text.Length);
            
        }

        private void TermsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            iniSettings = new MPIniReadWrite.MultiplatformIni(iniFilePath);
            iniSettings.WriteString("Settings", "AcceptedEULA", "true");
            iniSettings.Flush();
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
