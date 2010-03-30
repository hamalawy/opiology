namespace Opiometrics
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.topicsListBox = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ConversionToTextBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ConvertToComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ConvertFromComboBox = new System.Windows.Forms.ComboBox();
            this.ConversionSourceTextbox = new System.Windows.Forms.TextBox();
            this.FromUnitLabel = new System.Windows.Forms.Label();
            this.ToUnitLabel = new System.Windows.Forms.Label();
            this.drugPicture = new System.Windows.Forms.PictureBox();
            this.DosageGroupBox = new System.Windows.Forms.GroupBox();
            this.LD50Label = new System.Windows.Forms.Label();
            this.DosageIVLabel = new System.Windows.Forms.Label();
            this.DosageOralLabel = new System.Windows.Forms.Label();
            this.ROAGroupBox = new System.Windows.Forms.GroupBox();
            this.ROASublingualLabel = new System.Windows.Forms.Label();
            this.ROARectalLabel = new System.Windows.Forms.Label();
            this.ROAInsufflatableLabel = new System.Windows.Forms.Label();
            this.ROAInhalableLabel = new System.Windows.Forms.Label();
            this.ROASCLabel = new System.Windows.Forms.Label();
            this.ROAIMLabel = new System.Windows.Forms.Label();
            this.ROAIVLabel = new System.Windows.Forms.Label();
            this.ROAOralLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ShapeLabel = new System.Windows.Forms.Label();
            this.StrengthLabel = new System.Windows.Forms.Label();
            this.ImprintLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ImprintSearchTextBox = new System.Windows.Forms.TextBox();
            this.ImprintListBox = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ConversionResultLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drugPicture)).BeginInit();
            this.DosageGroupBox.SuspendLayout();
            this.ROAGroupBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // topicsListBox
            // 
            this.topicsListBox.FormattingEnabled = true;
            this.topicsListBox.Location = new System.Drawing.Point(49, 9);
            this.topicsListBox.Name = "topicsListBox";
            this.topicsListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.topicsListBox.Size = new System.Drawing.Size(510, 43);
            this.topicsListBox.TabIndex = 0;
            this.topicsListBox.SelectedIndexChanged += new System.EventHandler(this.topicsListBox_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(49, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(568, 423);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.drugPicture);
            this.tabPage1.Controls.Add(this.DosageGroupBox);
            this.tabPage1.Controls.Add(this.ROAGroupBox);
            this.tabPage1.Controls.Add(this.DescriptionTextBox);
            this.tabPage1.Controls.Add(this.NameLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(560, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ResultLabel);
            this.groupBox3.Controls.Add(this.ConversionResultLabel);
            this.groupBox3.Controls.Add(this.ConversionToTextBox);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.ConversionSourceTextbox);
            this.groupBox3.Controls.Add(this.FromUnitLabel);
            this.groupBox3.Controls.Add(this.ToUnitLabel);
            this.groupBox3.Location = new System.Drawing.Point(311, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(243, 172);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opioid Converssion";
            // 
            // ResultLabel
            // 
            this.ResultLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(55, 113);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ResultLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ResultLabel.Size = new System.Drawing.Size(5, 13);
            this.ResultLabel.TabIndex = 8;
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ConversionToTextBox
            // 
            this.ConversionToTextBox.Enabled = false;
            this.ConversionToTextBox.Location = new System.Drawing.Point(144, 43);
            this.ConversionToTextBox.MaxLength = 4;
            this.ConversionToTextBox.Name = "ConversionToTextBox";
            this.ConversionToTextBox.Size = new System.Drawing.Size(69, 20);
            this.ConversionToTextBox.TabIndex = 3;
            this.ConversionToTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.ConvertToComboBox);
            this.groupBox5.Location = new System.Drawing.Point(123, 66);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox5.Size = new System.Drawing.Size(118, 44);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "To";
            // 
            // ConvertToComboBox
            // 
            this.ConvertToComboBox.FormattingEnabled = true;
            this.ConvertToComboBox.Location = new System.Drawing.Point(6, 15);
            this.ConvertToComboBox.Name = "ConvertToComboBox";
            this.ConvertToComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ConvertToComboBox.Size = new System.Drawing.Size(102, 21);
            this.ConvertToComboBox.TabIndex = 1;
            this.ConvertToComboBox.SelectedIndexChanged += new System.EventHandler(this.ConvertToComboBox_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.ConvertFromComboBox);
            this.groupBox4.Location = new System.Drawing.Point(2, 66);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox4.Size = new System.Drawing.Size(118, 44);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "From";
            // 
            // ConvertFromComboBox
            // 
            this.ConvertFromComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ConvertFromComboBox.FormattingEnabled = true;
            this.ConvertFromComboBox.Location = new System.Drawing.Point(10, 15);
            this.ConvertFromComboBox.Name = "ConvertFromComboBox";
            this.ConvertFromComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ConvertFromComboBox.Size = new System.Drawing.Size(102, 21);
            this.ConvertFromComboBox.TabIndex = 0;
            this.ConvertFromComboBox.SelectedIndexChanged += new System.EventHandler(this.ConvertFromComboBox_SelectedIndexChanged);
            // 
            // ConversionSourceTextbox
            // 
            this.ConversionSourceTextbox.Location = new System.Drawing.Point(10, 43);
            this.ConversionSourceTextbox.MaxLength = 4;
            this.ConversionSourceTextbox.Name = "ConversionSourceTextbox";
            this.ConversionSourceTextbox.Size = new System.Drawing.Size(69, 20);
            this.ConversionSourceTextbox.TabIndex = 0;
            this.ConversionSourceTextbox.Text = "10";
            this.ConversionSourceTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ConversionSourceTextbox.TextChanged += new System.EventHandler(this.ConversionSourceTextbox_TextChanged);
            this.ConversionSourceTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConversionSourceTextbox_KeyPress);
            // 
            // FromUnitLabel
            // 
            this.FromUnitLabel.AutoSize = true;
            this.FromUnitLabel.Location = new System.Drawing.Point(79, 47);
            this.FromUnitLabel.Name = "FromUnitLabel";
            this.FromUnitLabel.Size = new System.Drawing.Size(21, 13);
            this.FromUnitLabel.TabIndex = 5;
            this.FromUnitLabel.Text = "mg";
            // 
            // ToUnitLabel
            // 
            this.ToUnitLabel.AutoSize = true;
            this.ToUnitLabel.Location = new System.Drawing.Point(213, 47);
            this.ToUnitLabel.Name = "ToUnitLabel";
            this.ToUnitLabel.Size = new System.Drawing.Size(21, 13);
            this.ToUnitLabel.TabIndex = 6;
            this.ToUnitLabel.Text = "mg";
            // 
            // drugPicture
            // 
            this.drugPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.drugPicture.Location = new System.Drawing.Point(179, 6);
            this.drugPicture.Name = "drugPicture";
            this.drugPicture.Size = new System.Drawing.Size(100, 96);
            this.drugPicture.TabIndex = 4;
            this.drugPicture.TabStop = false;
            // 
            // DosageGroupBox
            // 
            this.DosageGroupBox.Controls.Add(this.LD50Label);
            this.DosageGroupBox.Controls.Add(this.DosageIVLabel);
            this.DosageGroupBox.Controls.Add(this.DosageOralLabel);
            this.DosageGroupBox.Location = new System.Drawing.Point(6, 156);
            this.DosageGroupBox.Name = "DosageGroupBox";
            this.DosageGroupBox.Size = new System.Drawing.Size(273, 48);
            this.DosageGroupBox.TabIndex = 3;
            this.DosageGroupBox.TabStop = false;
            this.DosageGroupBox.Text = "Dosage";
            // 
            // LD50Label
            // 
            this.LD50Label.AutoSize = true;
            this.LD50Label.Location = new System.Drawing.Point(186, 16);
            this.LD50Label.Name = "LD50Label";
            this.LD50Label.Size = new System.Drawing.Size(76, 13);
            this.LD50Label.TabIndex = 2;
            this.LD50Label.Text = "LD50: 0mg/kg";
            // 
            // DosageIVLabel
            // 
            this.DosageIVLabel.AutoSize = true;
            this.DosageIVLabel.Location = new System.Drawing.Point(105, 16);
            this.DosageIVLabel.Name = "DosageIVLabel";
            this.DosageIVLabel.Size = new System.Drawing.Size(74, 13);
            this.DosageIVLabel.TabIndex = 1;
            this.DosageIVLabel.Text = "Naive IV: 0mg";
            // 
            // DosageOralLabel
            // 
            this.DosageOralLabel.AutoSize = true;
            this.DosageOralLabel.Location = new System.Drawing.Point(6, 16);
            this.DosageOralLabel.Name = "DosageOralLabel";
            this.DosageOralLabel.Size = new System.Drawing.Size(83, 13);
            this.DosageOralLabel.TabIndex = 0;
            this.DosageOralLabel.Text = "Naive Oral: 0mg";
            // 
            // ROAGroupBox
            // 
            this.ROAGroupBox.Controls.Add(this.ROASublingualLabel);
            this.ROAGroupBox.Controls.Add(this.ROARectalLabel);
            this.ROAGroupBox.Controls.Add(this.ROAInsufflatableLabel);
            this.ROAGroupBox.Controls.Add(this.ROAInhalableLabel);
            this.ROAGroupBox.Controls.Add(this.ROASCLabel);
            this.ROAGroupBox.Controls.Add(this.ROAIMLabel);
            this.ROAGroupBox.Controls.Add(this.ROAIVLabel);
            this.ROAGroupBox.Controls.Add(this.ROAOralLabel);
            this.ROAGroupBox.Location = new System.Drawing.Point(6, 100);
            this.ROAGroupBox.Name = "ROAGroupBox";
            this.ROAGroupBox.Size = new System.Drawing.Size(273, 52);
            this.ROAGroupBox.TabIndex = 2;
            this.ROAGroupBox.TabStop = false;
            this.ROAGroupBox.Text = "Routes of Administration";
            // 
            // ROASublingualLabel
            // 
            this.ROASublingualLabel.AutoSize = true;
            this.ROASublingualLabel.ForeColor = System.Drawing.Color.Red;
            this.ROASublingualLabel.Location = new System.Drawing.Point(154, 29);
            this.ROASublingualLabel.Name = "ROASublingualLabel";
            this.ROASublingualLabel.Size = new System.Drawing.Size(63, 13);
            this.ROASublingualLabel.TabIndex = 7;
            this.ROASublingualLabel.Text = "Sublingually";
            this.toolTip1.SetToolTip(this.ROASublingualLabel, "(under the tongue)");
            // 
            // ROARectalLabel
            // 
            this.ROARectalLabel.AutoSize = true;
            this.ROARectalLabel.ForeColor = System.Drawing.Color.Red;
            this.ROARectalLabel.Location = new System.Drawing.Point(219, 29);
            this.ROARectalLabel.Name = "ROARectalLabel";
            this.ROARectalLabel.Size = new System.Drawing.Size(38, 13);
            this.ROARectalLabel.TabIndex = 6;
            this.ROARectalLabel.Text = "Rectal";
            this.toolTip1.SetToolTip(this.ROARectalLabel, "(administered rectally)");
            // 
            // ROAInsufflatableLabel
            // 
            this.ROAInsufflatableLabel.AutoSize = true;
            this.ROAInsufflatableLabel.ForeColor = System.Drawing.Color.Red;
            this.ROAInsufflatableLabel.Location = new System.Drawing.Point(154, 16);
            this.ROAInsufflatableLabel.Name = "ROAInsufflatableLabel";
            this.ROAInsufflatableLabel.Size = new System.Drawing.Size(64, 13);
            this.ROAInsufflatableLabel.TabIndex = 5;
            this.ROAInsufflatableLabel.Text = "Insufflatable";
            this.toolTip1.SetToolTip(this.ROAInsufflatableLabel, "(snorted)");
            // 
            // ROAInhalableLabel
            // 
            this.ROAInhalableLabel.AutoSize = true;
            this.ROAInhalableLabel.ForeColor = System.Drawing.Color.Red;
            this.ROAInhalableLabel.Location = new System.Drawing.Point(219, 16);
            this.ROAInhalableLabel.Name = "ROAInhalableLabel";
            this.ROAInhalableLabel.Size = new System.Drawing.Size(50, 13);
            this.ROAInhalableLabel.TabIndex = 4;
            this.ROAInhalableLabel.Text = "Inhalable";
            this.toolTip1.SetToolTip(this.ROAInhalableLabel, "(smoked/vaporized)");
            // 
            // ROASCLabel
            // 
            this.ROASCLabel.AutoSize = true;
            this.ROASCLabel.ForeColor = System.Drawing.Color.Red;
            this.ROASCLabel.Location = new System.Drawing.Point(72, 29);
            this.ROASCLabel.Name = "ROASCLabel";
            this.ROASCLabel.Size = new System.Drawing.Size(76, 13);
            this.ROASCLabel.TabIndex = 3;
            this.ROASCLabel.Text = "Subcutaneous";
            this.toolTip1.SetToolTip(this.ROASCLabel, "(injected under the skin)");
            // 
            // ROAIMLabel
            // 
            this.ROAIMLabel.AutoSize = true;
            this.ROAIMLabel.ForeColor = System.Drawing.Color.Red;
            this.ROAIMLabel.Location = new System.Drawing.Point(72, 16);
            this.ROAIMLabel.Name = "ROAIMLabel";
            this.ROAIMLabel.Size = new System.Drawing.Size(70, 13);
            this.ROAIMLabel.TabIndex = 2;
            this.ROAIMLabel.Text = "Intramuscular";
            this.toolTip1.SetToolTip(this.ROAIMLabel, "(injected into a muscle)");
            // 
            // ROAIVLabel
            // 
            this.ROAIVLabel.AutoSize = true;
            this.ROAIVLabel.ForeColor = System.Drawing.Color.Red;
            this.ROAIVLabel.Location = new System.Drawing.Point(6, 29);
            this.ROAIVLabel.Name = "ROAIVLabel";
            this.ROAIVLabel.Size = new System.Drawing.Size(63, 13);
            this.ROAIVLabel.TabIndex = 1;
            this.ROAIVLabel.Text = "Intravenous";
            this.toolTip1.SetToolTip(this.ROAIVLabel, "(injected into a vein)");
            // 
            // ROAOralLabel
            // 
            this.ROAOralLabel.AutoSize = true;
            this.ROAOralLabel.ForeColor = System.Drawing.Color.Red;
            this.ROAOralLabel.Location = new System.Drawing.Point(6, 16);
            this.ROAOralLabel.Name = "ROAOralLabel";
            this.ROAOralLabel.Size = new System.Drawing.Size(26, 13);
            this.ROAOralLabel.TabIndex = 0;
            this.ROAOralLabel.Text = "Oral";
            this.toolTip1.SetToolTip(this.ROAOralLabel, "(taken by mouth)");
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.DescriptionTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DescriptionTextBox.Location = new System.Drawing.Point(6, 210);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ReadOnly = true;
            this.DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescriptionTextBox.Size = new System.Drawing.Size(273, 100);
            this.DescriptionTextBox.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(20, 33);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(86, 31);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(560, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pill Identification";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(248, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 166);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DescriptionLabel);
            this.groupBox1.Controls.Add(this.ColorLabel);
            this.groupBox1.Controls.Add(this.ShapeLabel);
            this.groupBox1.Controls.Add(this.StrengthLabel);
            this.groupBox1.Controls.Add(this.ImprintLabel);
            this.groupBox1.Controls.Add(this.TypeLabel);
            this.groupBox1.Controls.Add(this.ManufacturerLabel);
            this.groupBox1.Location = new System.Drawing.Point(245, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 182);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pill Info";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(16, 104);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(66, 13);
            this.DescriptionLabel.TabIndex = 5;
            this.DescriptionLabel.Text = "Description: ";
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(16, 78);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(37, 13);
            this.ColorLabel.TabIndex = 4;
            this.ColorLabel.Text = "Color: ";
            // 
            // ShapeLabel
            // 
            this.ShapeLabel.AutoSize = true;
            this.ShapeLabel.Location = new System.Drawing.Point(16, 91);
            this.ShapeLabel.Name = "ShapeLabel";
            this.ShapeLabel.Size = new System.Drawing.Size(44, 13);
            this.ShapeLabel.TabIndex = 3;
            this.ShapeLabel.Text = "Shape: ";
            // 
            // StrengthLabel
            // 
            this.StrengthLabel.AutoSize = true;
            this.StrengthLabel.Location = new System.Drawing.Point(16, 52);
            this.StrengthLabel.Name = "StrengthLabel";
            this.StrengthLabel.Size = new System.Drawing.Size(53, 13);
            this.StrengthLabel.TabIndex = 2;
            this.StrengthLabel.Text = "Strength: ";
            // 
            // ImprintLabel
            // 
            this.ImprintLabel.AutoSize = true;
            this.ImprintLabel.Location = new System.Drawing.Point(16, 65);
            this.ImprintLabel.Name = "ImprintLabel";
            this.ImprintLabel.Size = new System.Drawing.Size(44, 13);
            this.ImprintLabel.TabIndex = 2;
            this.ImprintLabel.Text = "Imprint: ";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(16, 39);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(37, 13);
            this.TypeLabel.TabIndex = 1;
            this.TypeLabel.Text = "Type: ";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(16, 26);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(76, 13);
            this.ManufacturerLabel.TabIndex = 0;
            this.ManufacturerLabel.Text = "Manufacturer: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.ImprintSearchTextBox);
            this.groupBox2.Controls.Add(this.ImprintListBox);
            this.groupBox2.Location = new System.Drawing.Point(18, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 345);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pill Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Type Filter";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(32, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(102, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // ImprintSearchTextBox
            // 
            this.ImprintSearchTextBox.Location = new System.Drawing.Point(32, 19);
            this.ImprintSearchTextBox.Name = "ImprintSearchTextBox";
            this.ImprintSearchTextBox.Size = new System.Drawing.Size(103, 20);
            this.ImprintSearchTextBox.TabIndex = 5;
            this.ImprintSearchTextBox.Text = "Enter search term";
            this.ImprintSearchTextBox.TextChanged += new System.EventHandler(this.ImprintSearchTextBox_TextChanged);
            this.ImprintSearchTextBox.Click += new System.EventHandler(this.ImprintSearchTextBox_Click);
            // 
            // ImprintListBox
            // 
            this.ImprintListBox.FormattingEnabled = true;
            this.ImprintListBox.Location = new System.Drawing.Point(17, 127);
            this.ImprintListBox.Name = "ImprintListBox";
            this.ImprintListBox.Size = new System.Drawing.Size(103, 212);
            this.ImprintListBox.TabIndex = 2;
            this.ImprintListBox.SelectedIndexChanged += new System.EventHandler(this.ImprintListBox_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(560, 397);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Clinic Directories";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(560, 397);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Chemistry";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(560, 397);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Law";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // ConversionResultLabel
            // 
            this.ConversionResultLabel.AutoSize = true;
            this.ConversionResultLabel.Location = new System.Drawing.Point(7, 123);
            this.ConversionResultLabel.Name = "ConversionResultLabel";
            this.ConversionResultLabel.Size = new System.Drawing.Size(0, 13);
            this.ConversionResultLabel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 517);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.topicsListBox);
            this.Name = "Form1";
            this.Text = "Opiology";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drugPicture)).EndInit();
            this.DosageGroupBox.ResumeLayout(false);
            this.DosageGroupBox.PerformLayout();
            this.ROAGroupBox.ResumeLayout(false);
            this.ROAGroupBox.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox topicsListBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox ROAGroupBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label ROASCLabel;
        private System.Windows.Forms.Label ROAIMLabel;
        private System.Windows.Forms.Label ROAIVLabel;
        private System.Windows.Forms.Label ROAOralLabel;
        private System.Windows.Forms.Label ROARectalLabel;
        private System.Windows.Forms.Label ROAInsufflatableLabel;
        private System.Windows.Forms.Label ROAInhalableLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox DosageGroupBox;
        private System.Windows.Forms.Label DosageOralLabel;
        private System.Windows.Forms.Label DosageIVLabel;
        private System.Windows.Forms.Label LD50Label;
        private System.Windows.Forms.PictureBox drugPicture;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label ROASublingualLabel;
        private System.Windows.Forms.ListBox ImprintListBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ImprintSearchTextBox;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label StrengthLabel;
        private System.Windows.Forms.Label ImprintLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label ShapeLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox ConversionSourceTextbox;
        private System.Windows.Forms.TextBox ConversionToTextBox;
        private System.Windows.Forms.Label ToUnitLabel;
        private System.Windows.Forms.Label FromUnitLabel;
        private System.Windows.Forms.ComboBox ConvertFromComboBox;
        private System.Windows.Forms.ComboBox ConvertToComboBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ConversionResultLabel;
    }
}

