namespace PasswortManager
{
    partial class EingabePasswort
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1Website = new System.Windows.Forms.TextBox();
            this.textBox2Passwort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3Passwort = new System.Windows.Forms.Label();
            this.buttonSpeichern = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Passwort eingabe:";
            // 
            // textBox1Website
            // 
            this.textBox1Website.Location = new System.Drawing.Point(35, 138);
            this.textBox1Website.Name = "textBox1Website";
            this.textBox1Website.Size = new System.Drawing.Size(269, 31);
            this.textBox1Website.TabIndex = 1;
            // 
            // textBox2Passwort
            // 
            this.textBox2Passwort.Location = new System.Drawing.Point(322, 138);
            this.textBox2Passwort.Name = "textBox2Passwort";
            this.textBox2Passwort.Size = new System.Drawing.Size(307, 31);
            this.textBox2Passwort.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Website/App";
            // 
            // label3Passwort
            // 
            this.label3Passwort.AutoSize = true;
            this.label3Passwort.Location = new System.Drawing.Point(317, 99);
            this.label3Passwort.Name = "label3Passwort";
            this.label3Passwort.Size = new System.Drawing.Size(100, 25);
            this.label3Passwort.TabIndex = 4;
            this.label3Passwort.Text = "Passwort";
            // 
            // buttonSpeichern
            // 
            this.buttonSpeichern.Location = new System.Drawing.Point(43, 240);
            this.buttonSpeichern.Name = "buttonSpeichern";
            this.buttonSpeichern.Size = new System.Drawing.Size(120, 33);
            this.buttonSpeichern.TabIndex = 5;
            this.buttonSpeichern.Text = "Speichern";
            this.buttonSpeichern.UseVisualStyleBackColor = true;
            // 
            // EingabePasswort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSpeichern);
            this.Controls.Add(this.label3Passwort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2Passwort);
            this.Controls.Add(this.textBox1Website);
            this.Controls.Add(this.label1);
            this.Name = "EingabePasswort";
            this.Text = "EingapePasw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1Website;
        private System.Windows.Forms.TextBox textBox2Passwort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3Passwort;
        private System.Windows.Forms.Button buttonSpeichern;
    }
}