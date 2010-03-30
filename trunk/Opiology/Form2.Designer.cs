namespace Opiometrics
{
    partial class TermsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TermsForm));
            this.TermsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TermsTextBox
            // 
            this.TermsTextBox.Location = new System.Drawing.Point(16, 14);
            this.TermsTextBox.Multiline = true;
            this.TermsTextBox.Name = "TermsTextBox";
            this.TermsTextBox.Size = new System.Drawing.Size(300, 157);
            this.TermsTextBox.TabIndex = 0;
            this.TermsTextBox.Text = resources.GetString("TermsTextBox.Text");
            // 
            // TermsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 207);
            this.Controls.Add(this.TermsTextBox);
            this.Name = "TermsForm";
            this.Text = "Terms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TermsTextBox;
    }
}