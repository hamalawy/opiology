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
    public partial class SplashScreen : Form
    {
        int elapsedTime;

        bool acceptedEULA = false;
        string iniFilePath = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "settings.ini";

        public SplashScreen()
        {
            InitializeComponent();
            closeTimer.Start();
            loadTimer.Start();

        }

        private void closeTimer_Tick(object sender, EventArgs e)
        {
            elapsedTime += 100;
            if (elapsedTime >= 1000)
            {
                closeTimer.Enabled = false;
                MPIniReadWrite.MultiplatformIni iniSettings = new MPIniReadWrite.MultiplatformIni(iniFilePath);
                acceptedEULA = bool.Parse(iniSettings.ReadString("Settings", "AcceptedEULA", "false"));

                this.Hide();
                if (acceptedEULA == false)
                {
                    TermsForm termsForm = new TermsForm();
                    termsForm.Show();
                }
                else
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
                this.Hide();
            }
        }

        private void loadTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05D;
            }
            if (this.Opacity == 1)
            {
                loadTimer.Enabled = false;
            }
        }
    }
}
