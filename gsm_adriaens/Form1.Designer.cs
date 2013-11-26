namespace gsm_adriaens
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
            this.lbResultaat = new System.Windows.Forms.Label();
            this.btEinde = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.btOkGebruik = new System.Windows.Forms.Button();
            this.tbAntwoord = new System.Windows.Forms.TextBox();
            this.tbDeelnemers = new System.Windows.Forms.TextBox();
            this.lbBezit = new System.Windows.Forms.Label();
            this.btOkAantal = new System.Windows.Forms.Button();
            this.lbAantal = new System.Windows.Forms.Label();
            this.lbEnquete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbResultaat
            // 
            this.lbResultaat.AutoSize = true;
            this.lbResultaat.Location = new System.Drawing.Point(33, 158);
            this.lbResultaat.Name = "lbResultaat";
            this.lbResultaat.Size = new System.Drawing.Size(0, 13);
            this.lbResultaat.TabIndex = 19;
            // 
            // btEinde
            // 
            this.btEinde.Location = new System.Drawing.Point(359, 281);
            this.btEinde.Name = "btEinde";
            this.btEinde.Size = new System.Drawing.Size(75, 23);
            this.btEinde.TabIndex = 18;
            this.btEinde.Text = "Einde";
            this.btEinde.UseVisualStyleBackColor = true;
            this.btEinde.Click += new System.EventHandler(this.btEinde_Click);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(262, 281);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 23);
            this.btReset.TabIndex = 17;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btOkGebruik
            // 
            this.btOkGebruik.Location = new System.Drawing.Point(359, 101);
            this.btOkGebruik.Name = "btOkGebruik";
            this.btOkGebruik.Size = new System.Drawing.Size(75, 23);
            this.btOkGebruik.TabIndex = 16;
            this.btOkGebruik.Text = "OK";
            this.btOkGebruik.UseVisualStyleBackColor = true;
            this.btOkGebruik.Click += new System.EventHandler(this.btOkGebruik_Click);
            // 
            // tbAntwoord
            // 
            this.tbAntwoord.Enabled = false;
            this.tbAntwoord.Location = new System.Drawing.Point(282, 104);
            this.tbAntwoord.Name = "tbAntwoord";
            this.tbAntwoord.Size = new System.Drawing.Size(55, 20);
            this.tbAntwoord.TabIndex = 15;
            this.tbAntwoord.TextChanged += new System.EventHandler(this.tbAntwoord_TextChanged);
            // 
            // tbDeelnemers
            // 
            this.tbDeelnemers.Location = new System.Drawing.Point(282, 53);
            this.tbDeelnemers.Name = "tbDeelnemers";
            this.tbDeelnemers.Size = new System.Drawing.Size(55, 20);
            this.tbDeelnemers.TabIndex = 14;
            // 
            // lbBezit
            // 
            this.lbBezit.AutoSize = true;
            this.lbBezit.Location = new System.Drawing.Point(12, 97);
            this.lbBezit.Name = "lbBezit";
            this.lbBezit.Size = new System.Drawing.Size(243, 26);
            this.lbBezit.TabIndex = 13;
            this.lbBezit.Text = "1. Is het gsm-gebruik toegestaan in de leslokalen?\r\n   (antwoord: j/J (ja), n/N (" +
    "nee), o/O (onverschillig)";
            // 
            // btOkAantal
            // 
            this.btOkAantal.Location = new System.Drawing.Point(359, 48);
            this.btOkAantal.Name = "btOkAantal";
            this.btOkAantal.Size = new System.Drawing.Size(75, 23);
            this.btOkAantal.TabIndex = 12;
            this.btOkAantal.Text = "OK";
            this.btOkAantal.UseVisualStyleBackColor = true;
            this.btOkAantal.Click += new System.EventHandler(this.btOkAantal_Click);
            // 
            // lbAantal
            // 
            this.lbAantal.AutoSize = true;
            this.lbAantal.Location = new System.Drawing.Point(12, 53);
            this.lbAantal.Name = "lbAantal";
            this.lbAantal.Size = new System.Drawing.Size(264, 13);
            this.lbAantal.TabIndex = 11;
            this.lbAantal.Text = "Aantal personen die zullen deelnemen aan de enquête";
            // 
            // lbEnquete
            // 
            this.lbEnquete.AutoSize = true;
            this.lbEnquete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnquete.Location = new System.Drawing.Point(12, 23);
            this.lbEnquete.Name = "lbEnquete";
            this.lbEnquete.Size = new System.Drawing.Size(258, 16);
            this.lbEnquete.TabIndex = 10;
            this.lbEnquete.Text = "Enquête: gsm gebruik in klaslokalen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 322);
            this.Controls.Add(this.lbResultaat);
            this.Controls.Add(this.btEinde);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btOkGebruik);
            this.Controls.Add(this.tbAntwoord);
            this.Controls.Add(this.tbDeelnemers);
            this.Controls.Add(this.lbBezit);
            this.Controls.Add(this.btOkAantal);
            this.Controls.Add(this.lbAantal);
            this.Controls.Add(this.lbEnquete);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbResultaat;
        private System.Windows.Forms.Button btEinde;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btOkGebruik;
        private System.Windows.Forms.TextBox tbAntwoord;
        private System.Windows.Forms.TextBox tbDeelnemers;
        private System.Windows.Forms.Label lbBezit;
        private System.Windows.Forms.Button btOkAantal;
        private System.Windows.Forms.Label lbAantal;
        private System.Windows.Forms.Label lbEnquete;
    }
}

