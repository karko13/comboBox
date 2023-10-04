namespace _07ComboBoxKontrolaIvanoKarkovic
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
            this.multicombo = new System.Windows.Forms.ComboBox();
            this.txtlbl = new System.Windows.Forms.Label();
            this.kutija = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // multicombo
            // 
            this.multicombo.FormattingEnabled = true;
            this.multicombo.Items.AddRange(new object[] {
            "BMW",
            "AUDI",
            "FERRARI",
            "MCLAREN",
            "LAMBORGINI",
            "BUGGATI",
            "FIAT",
            "HONDA",
            "CITROEN"});
            this.multicombo.Location = new System.Drawing.Point(214, 97);
            this.multicombo.Name = "multicombo";
            this.multicombo.Size = new System.Drawing.Size(314, 21);
            this.multicombo.TabIndex = 0;
            this.multicombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtlbl
            // 
            this.txtlbl.AutoSize = true;
            this.txtlbl.Location = new System.Drawing.Point(214, 57);
            this.txtlbl.Name = "txtlbl";
            this.txtlbl.Size = new System.Drawing.Size(159, 13);
            this.txtlbl.TabIndex = 1;
            this.txtlbl.Text = "Odaberite nešto iz combo box-a:";
            // 
            // kutija
            // 
            this.kutija.Location = new System.Drawing.Point(93, 153);
            this.kutija.Multiline = true;
            this.kutija.Name = "kutija";
            this.kutija.Size = new System.Drawing.Size(583, 254);
            this.kutija.TabIndex = 2;
            this.kutija.Text = "Odabrali ste:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kutija);
            this.Controls.Add(this.txtlbl);
            this.Controls.Add(this.multicombo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox multicombo;
        private System.Windows.Forms.Label txtlbl;
        private System.Windows.Forms.TextBox kutija;
    }
}

