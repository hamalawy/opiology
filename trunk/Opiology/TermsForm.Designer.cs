namespace Opiology
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
            this.AcceptButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TermsTextBox
            // 
            this.TermsTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.TermsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TermsTextBox.Location = new System.Drawing.Point(8, 9);
            this.TermsTextBox.Multiline = true;
            this.TermsTextBox.Name = "TermsTextBox";
            this.TermsTextBox.ReadOnly = true;
            this.TermsTextBox.Size = new System.Drawing.Size(311, 194);
            this.TermsTextBox.TabIndex = 0;
            this.TermsTextBox.Text = resources.GetString("TermsTextBox.Text");
            this.TermsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(12, 209);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(75, 25);
            this.AcceptButton.TabIndex = 1;
            this.AcceptButton.Text = "Agree";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(241, 209);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 25);
            this.QuitButton.TabIndex = 2;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // TermsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 240);
            this.ControlBox = false;
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.TermsTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TermsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Terms";
            this.Load += new System.EventHandler(this.TermsForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TermsForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TermsTextBox;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button QuitButton;
    }
}