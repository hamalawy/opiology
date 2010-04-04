namespace Opiology
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.topicsListBox = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.generalInfoTab = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextSizeDecButton = new System.Windows.Forms.Button();
            this.TextSizeIncButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ConversionResultLabel = new System.Windows.Forms.Label();
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
            this.pillIdTab = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PIDDescTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.ShapeLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.StrengthLabel = new System.Windows.Forms.Label();
            this.APAPLabel = new System.Windows.Forms.Label();
            this.ImprintLabel = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.ImprintSearchTextBox = new System.Windows.Forms.TextBox();
            this.ImprintListBox = new System.Windows.Forms.ListBox();
            this.prepTab = new System.Windows.Forms.TabPage();
            this.clinicDirTab = new System.Windows.Forms.TabPage();
            this.chemistryTab = new System.Windows.Forms.TabPage();
            this.emergencyTab = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.generalInfoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drugPicture)).BeginInit();
            this.DosageGroupBox.SuspendLayout();
            this.ROAGroupBox.SuspendLayout();
            this.pillIdTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // topicsListBox
            // 
            this.topicsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topicsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topicsListBox.FormattingEnabled = true;
            this.topicsListBox.HorizontalScrollbar = true;
            this.topicsListBox.ItemHeight = 15;
            this.topicsListBox.Location = new System.Drawing.Point(26, 11);
            this.topicsListBox.MultiColumn = true;
            this.topicsListBox.Name = "topicsListBox";
            this.topicsListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.topicsListBox.ScrollAlwaysVisible = true;
            this.topicsListBox.Size = new System.Drawing.Size(699, 47);
            this.topicsListBox.TabIndex = 0;
            this.topicsListBox.SelectedIndexChanged += new System.EventHandler(this.topicsListBox_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.generalInfoTab);
            this.tabControl1.Controls.Add(this.pillIdTab);
            this.tabControl1.Controls.Add(this.prepTab);
            this.tabControl1.Controls.Add(this.clinicDirTab);
            this.tabControl1.Controls.Add(this.chemistryTab);
            this.tabControl1.Controls.Add(this.emergencyTab);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(758, 488);
            this.tabControl1.TabIndex = 2;
            // 
            // generalInfoTab
            // 
            this.generalInfoTab.Controls.Add(this.textBox1);
            this.generalInfoTab.Controls.Add(this.pictureBox2);
            this.generalInfoTab.Controls.Add(this.label3);
            this.generalInfoTab.Controls.Add(this.TextSizeDecButton);
            this.generalInfoTab.Controls.Add(this.TextSizeIncButton);
            this.generalInfoTab.Controls.Add(this.groupBox3);
            this.generalInfoTab.Controls.Add(this.topicsListBox);
            this.generalInfoTab.Controls.Add(this.drugPicture);
            this.generalInfoTab.Controls.Add(this.DosageGroupBox);
            this.generalInfoTab.Controls.Add(this.ROAGroupBox);
            this.generalInfoTab.Controls.Add(this.DescriptionTextBox);
            this.generalInfoTab.Controls.Add(this.NameLabel);
            this.generalInfoTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalInfoTab.Location = new System.Drawing.Point(4, 24);
            this.generalInfoTab.Name = "generalInfoTab";
            this.generalInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.generalInfoTab.Size = new System.Drawing.Size(750, 460);
            this.generalInfoTab.TabIndex = 0;
            this.generalInfoTab.Text = "General Info";
            this.generalInfoTab.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(407, 249);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 178);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Warning: this is a beta version meant only to be tested.\r\n\r\n\r\nDO NOT, I repeat, D" +
                "O NOT UNDER ANY CIRCUMSTANCE TAKE THESE CONVERSION VALUES TO BE TRUE.";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(651, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(95, 390);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Description";
            // 
            // TextSizeDecButton
            // 
            this.TextSizeDecButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextSizeDecButton.Location = new System.Drawing.Point(359, 295);
            this.TextSizeDecButton.Name = "TextSizeDecButton";
            this.TextSizeDecButton.Size = new System.Drawing.Size(23, 26);
            this.TextSizeDecButton.TabIndex = 7;
            this.TextSizeDecButton.Text = "-";
            this.TextSizeDecButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TextSizeDecButton.UseVisualStyleBackColor = true;
            this.TextSizeDecButton.Click += new System.EventHandler(this.TextSizeDecButton_Click);
            // 
            // TextSizeIncButton
            // 
            this.TextSizeIncButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextSizeIncButton.Location = new System.Drawing.Point(333, 295);
            this.TextSizeIncButton.Name = "TextSizeIncButton";
            this.TextSizeIncButton.Size = new System.Drawing.Size(23, 26);
            this.TextSizeIncButton.TabIndex = 6;
            this.TextSizeIncButton.Text = "+";
            this.TextSizeIncButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TextSizeIncButton.UseVisualStyleBackColor = true;
            this.TextSizeIncButton.Click += new System.EventHandler(this.TextSizeIncButton_Click);
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
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(401, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(246, 174);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opioid Conversion";
            // 
            // ResultLabel
            // 
            this.ResultLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(55, 114);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ResultLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ResultLabel.Size = new System.Drawing.Size(5, 13);
            this.ResultLabel.TabIndex = 8;
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ConversionResultLabel
            // 
            this.ConversionResultLabel.AutoSize = true;
            this.ConversionResultLabel.Location = new System.Drawing.Point(7, 123);
            this.ConversionResultLabel.Name = "ConversionResultLabel";
            this.ConversionResultLabel.Size = new System.Drawing.Size(0, 13);
            this.ConversionResultLabel.TabIndex = 7;
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
            this.drugPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.drugPicture.Location = new System.Drawing.Point(241, 66);
            this.drugPicture.Name = "drugPicture";
            this.drugPicture.Size = new System.Drawing.Size(120, 120);
            this.drugPicture.TabIndex = 4;
            this.drugPicture.TabStop = false;
            // 
            // DosageGroupBox
            // 
            this.DosageGroupBox.Controls.Add(this.LD50Label);
            this.DosageGroupBox.Controls.Add(this.DosageIVLabel);
            this.DosageGroupBox.Controls.Add(this.DosageOralLabel);
            this.DosageGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DosageGroupBox.Location = new System.Drawing.Point(28, 239);
            this.DosageGroupBox.Name = "DosageGroupBox";
            this.DosageGroupBox.Size = new System.Drawing.Size(354, 50);
            this.DosageGroupBox.TabIndex = 3;
            this.DosageGroupBox.TabStop = false;
            this.DosageGroupBox.Text = "Dosage";
            // 
            // LD50Label
            // 
            this.LD50Label.AutoSize = true;
            this.LD50Label.Location = new System.Drawing.Point(239, 16);
            this.LD50Label.Name = "LD50Label";
            this.LD50Label.Size = new System.Drawing.Size(76, 13);
            this.LD50Label.TabIndex = 2;
            this.LD50Label.Text = "LD50: 0mg/kg";
            // 
            // DosageIVLabel
            // 
            this.DosageIVLabel.AutoSize = true;
            this.DosageIVLabel.Location = new System.Drawing.Point(129, 16);
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
            this.ROAGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ROAGroupBox.Location = new System.Drawing.Point(28, 183);
            this.ROAGroupBox.Name = "ROAGroupBox";
            this.ROAGroupBox.Size = new System.Drawing.Size(354, 54);
            this.ROAGroupBox.TabIndex = 2;
            this.ROAGroupBox.TabStop = false;
            this.ROAGroupBox.Text = "Routes of Administration";
            // 
            // ROASublingualLabel
            // 
            this.ROASublingualLabel.AutoSize = true;
            this.ROASublingualLabel.ForeColor = System.Drawing.Color.Red;
            this.ROASublingualLabel.Location = new System.Drawing.Point(195, 29);
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
            this.ROARectalLabel.Location = new System.Drawing.Point(283, 29);
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
            this.ROAInsufflatableLabel.Location = new System.Drawing.Point(195, 16);
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
            this.ROAInhalableLabel.Location = new System.Drawing.Point(283, 16);
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
            this.ROASCLabel.Location = new System.Drawing.Point(91, 29);
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
            this.ROAIMLabel.Location = new System.Drawing.Point(91, 16);
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
            this.DescriptionTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DescriptionTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(26, 325);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ReadOnly = true;
            this.DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescriptionTextBox.Size = new System.Drawing.Size(356, 114);
            this.DescriptionTextBox.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(31, 101);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(86, 31);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // pillIdTab
            // 
            this.pillIdTab.Controls.Add(this.pictureBox3);
            this.pillIdTab.Controls.Add(this.pictureBox1);
            this.pillIdTab.Controls.Add(this.groupBox1);
            this.pillIdTab.Controls.Add(this.groupBox2);
            this.pillIdTab.Location = new System.Drawing.Point(4, 24);
            this.pillIdTab.Name = "pillIdTab";
            this.pillIdTab.Padding = new System.Windows.Forms.Padding(3);
            this.pillIdTab.Size = new System.Drawing.Size(750, 460);
            this.pillIdTab.TabIndex = 1;
            this.pillIdTab.Text = "Pill ID";
            this.pillIdTab.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = global::Opiology.Properties.Resources.sidebar;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(651, 65);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(95, 390);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(254, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 166);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PIDDescTextBox);
            this.groupBox1.Controls.Add(this.DescriptionLabel);
            this.groupBox1.Controls.Add(this.ShapeLabel);
            this.groupBox1.Controls.Add(this.TypeLabel);
            this.groupBox1.Controls.Add(this.ManufacturerLabel);
            this.groupBox1.Controls.Add(this.StrengthLabel);
            this.groupBox1.Controls.Add(this.APAPLabel);
            this.groupBox1.Controls.Add(this.ImprintLabel);
            this.groupBox1.Controls.Add(this.ColorLabel);
            this.groupBox1.Location = new System.Drawing.Point(233, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 264);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pill Info";
            // 
            // PIDDescTextBox
            // 
            this.PIDDescTextBox.Location = new System.Drawing.Point(11, 144);
            this.PIDDescTextBox.Multiline = true;
            this.PIDDescTextBox.Name = "PIDDescTextBox";
            this.PIDDescTextBox.Size = new System.Drawing.Size(206, 104);
            this.PIDDescTextBox.TabIndex = 6;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(8, 126);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(75, 15);
            this.DescriptionLabel.TabIndex = 5;
            this.DescriptionLabel.Text = "Description: ";
            // 
            // ShapeLabel
            // 
            this.ShapeLabel.AutoSize = true;
            this.ShapeLabel.Location = new System.Drawing.Point(8, 93);
            this.ShapeLabel.Name = "ShapeLabel";
            this.ShapeLabel.Size = new System.Drawing.Size(49, 15);
            this.ShapeLabel.TabIndex = 3;
            this.ShapeLabel.Text = "Shape: ";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(8, 33);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(39, 15);
            this.TypeLabel.TabIndex = 1;
            this.TypeLabel.Text = "Type: ";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(8, 18);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(86, 15);
            this.ManufacturerLabel.TabIndex = 0;
            this.ManufacturerLabel.Text = "Manufacturer: ";
            // 
            // StrengthLabel
            // 
            this.StrengthLabel.AutoSize = true;
            this.StrengthLabel.Location = new System.Drawing.Point(8, 48);
            this.StrengthLabel.Name = "StrengthLabel";
            this.StrengthLabel.Size = new System.Drawing.Size(59, 15);
            this.StrengthLabel.TabIndex = 2;
            this.StrengthLabel.Text = "Strength: ";
            // 
            // APAPLabel
            // 
            this.APAPLabel.AutoSize = true;
            this.APAPLabel.Location = new System.Drawing.Point(8, 108);
            this.APAPLabel.Name = "APAPLabel";
            this.APAPLabel.Size = new System.Drawing.Size(96, 15);
            this.APAPLabel.TabIndex = 7;
            this.APAPLabel.Text = "Acetaminophen:";
            // 
            // ImprintLabel
            // 
            this.ImprintLabel.AutoSize = true;
            this.ImprintLabel.Location = new System.Drawing.Point(8, 63);
            this.ImprintLabel.Name = "ImprintLabel";
            this.ImprintLabel.Size = new System.Drawing.Size(51, 15);
            this.ImprintLabel.TabIndex = 2;
            this.ImprintLabel.Text = "Imprint: ";
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(8, 78);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(42, 15);
            this.ColorLabel.TabIndex = 4;
            this.ColorLabel.Text = "Color: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.FilterComboBox);
            this.groupBox2.Controls.Add(this.ImprintSearchTextBox);
            this.groupBox2.Controls.Add(this.ImprintListBox);
            this.groupBox2.Location = new System.Drawing.Point(18, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 434);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pill Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Results";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Type Filter";
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.DisplayMember = "dd";
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.Location = new System.Drawing.Point(17, 77);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FilterComboBox.Size = new System.Drawing.Size(165, 23);
            this.FilterComboBox.TabIndex = 6;
            this.FilterComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
            this.FilterComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilterComboBox_KeyDown);
            // 
            // ImprintSearchTextBox
            // 
            this.ImprintSearchTextBox.Location = new System.Drawing.Point(17, 35);
            this.ImprintSearchTextBox.Name = "ImprintSearchTextBox";
            this.ImprintSearchTextBox.Size = new System.Drawing.Size(165, 21);
            this.ImprintSearchTextBox.TabIndex = 5;
            this.ImprintSearchTextBox.TextChanged += new System.EventHandler(this.ImprintSearchTextBox_TextChanged);
            this.ImprintSearchTextBox.Click += new System.EventHandler(this.ImprintSearchTextBox_Click);
            // 
            // ImprintListBox
            // 
            this.ImprintListBox.FormattingEnabled = true;
            this.ImprintListBox.ItemHeight = 15;
            this.ImprintListBox.Location = new System.Drawing.Point(17, 119);
            this.ImprintListBox.Name = "ImprintListBox";
            this.ImprintListBox.Size = new System.Drawing.Size(165, 304);
            this.ImprintListBox.TabIndex = 2;
            this.ImprintListBox.SelectedIndexChanged += new System.EventHandler(this.ImprintListBox_SelectedIndexChanged);
            // 
            // prepTab
            // 
            this.prepTab.Location = new System.Drawing.Point(4, 24);
            this.prepTab.Name = "prepTab";
            this.prepTab.Size = new System.Drawing.Size(750, 460);
            this.prepTab.TabIndex = 5;
            this.prepTab.Text = "Prep. Methods";
            this.prepTab.UseVisualStyleBackColor = true;
            // 
            // clinicDirTab
            // 
            this.clinicDirTab.Location = new System.Drawing.Point(4, 24);
            this.clinicDirTab.Name = "clinicDirTab";
            this.clinicDirTab.Size = new System.Drawing.Size(750, 460);
            this.clinicDirTab.TabIndex = 2;
            this.clinicDirTab.Text = "Clinic Directories";
            this.clinicDirTab.UseVisualStyleBackColor = true;
            // 
            // chemistryTab
            // 
            this.chemistryTab.Location = new System.Drawing.Point(4, 24);
            this.chemistryTab.Name = "chemistryTab";
            this.chemistryTab.Size = new System.Drawing.Size(750, 460);
            this.chemistryTab.TabIndex = 3;
            this.chemistryTab.Text = "Chemistry";
            this.chemistryTab.UseVisualStyleBackColor = true;
            // 
            // emergencyTab
            // 
            this.emergencyTab.ForeColor = System.Drawing.Color.DarkRed;
            this.emergencyTab.Location = new System.Drawing.Point(4, 24);
            this.emergencyTab.Name = "emergencyTab";
            this.emergencyTab.Size = new System.Drawing.Size(750, 460);
            this.emergencyTab.TabIndex = 4;
            this.emergencyTab.Text = "Emergency";
            this.emergencyTab.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "generalInfotab.png");
            this.imageList1.Images.SetKeyName(1, "pillIdtab48.png");
            this.imageList1.Images.SetKeyName(2, "prepTab.png");
            this.imageList1.Images.SetKeyName(3, "clinicTab.png");
            this.imageList1.Images.SetKeyName(4, "chemistryTab.png");
            this.imageList1.Images.SetKeyName(5, "emergencyTab.png");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Search Term";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(797, 520);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opiology";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.generalInfoTab.ResumeLayout(false);
            this.generalInfoTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drugPicture)).EndInit();
            this.DosageGroupBox.ResumeLayout(false);
            this.DosageGroupBox.PerformLayout();
            this.ROAGroupBox.ResumeLayout(false);
            this.ROAGroupBox.PerformLayout();
            this.pillIdTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.TabPage generalInfoTab;
        private System.Windows.Forms.GroupBox ROAGroupBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TabPage pillIdTab;
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
        private System.Windows.Forms.TabPage clinicDirTab;
        private System.Windows.Forms.TabPage chemistryTab;
        private System.Windows.Forms.TabPage emergencyTab;
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
        private System.Windows.Forms.ComboBox FilterComboBox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ConversionResultLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TextSizeDecButton;
        private System.Windows.Forms.Button TextSizeIncButton;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TabPage prepTab;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox PIDDescTextBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label APAPLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}

