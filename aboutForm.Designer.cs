namespace ABC_clinic
{
    partial class aboutForm
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
            System.Windows.Forms.TextBox textBox1;
            textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            textBox1.CausesValidation = false;
            textBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            textBox1.Enabled = false;
            textBox1.Font = new System.Drawing.Font("Tahoma", 16F);
            textBox1.HideSelection = false;
            textBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            textBox1.Location = new System.Drawing.Point(27, 28);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new System.Drawing.Size(352, 328);
            textBox1.TabIndex = 1;
            textBox1.TabStop = false;
            textBox1.Text = "Welcome :)\r\nOur team :\r\n1-Ahmed Gamal Abdel-Nasser\r\n2-Islam Ahmed Al-soghier\r\n3-I" +
    "brahim Hosny Diab\r\n4-Ahmed Refaat Biaomy\r\n5-Ahmed Abdel-Aal Rashid\r\n\r\nsupervisor" +
    " \r\nDr. Ahmed Taloba .\r\n";
            textBox1.WordWrap = false;
            // 
            // aboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 368);
            this.Controls.Add(textBox1);
            this.Name = "aboutForm";
            this.Text = "من نحن";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}