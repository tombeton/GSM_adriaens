using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsm_adriaens
{
    public partial class Form1 : Form
    {
        Enquete enquete = new Enquete();
        int aantal = 0;
      
        public Form1()
        {
            InitializeComponent();

        }

        private void btOkAantal_Click(object sender, EventArgs e)
        {
            tbAntwoord.Enabled = true;
            tbAntwoord.Focus();
            {
                try
                {
                    aantal = int.Parse(tbDeelnemers.Text);
                    tbDeelnemers.Enabled = false;

                }
                catch (FormatException)
                {
                    MessageBox.Show("Vul het aantal deelnemers in.");
                    tbDeelnemers.ResetText();
                    tbDeelnemers.Focus();
                    tbAntwoord.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Er is een fout opgetreden.");
                    tbDeelnemers.ResetText();
                    tbDeelnemers.Focus();
                    tbAntwoord.Enabled = false;
                }


            }
        }

        private void btOkGebruik_Click(object sender, EventArgs e)
        {
            bool check;
            enquete.getAntwoord = (tbAntwoord.Text);
            
            check = gsm_adriaens.FoutControle.errors(tbAntwoord.Text);

            if (check)
            {
                aantal--;
                tbAntwoord.ResetText();
                tbAntwoord.Focus();
            }
            
            if (aantal == 0)
            {

                lbResultaat.Text = ("Het gebruik van een gsm is: " + enquete.getMsg()
                    + Environment.NewLine + "aantal ja antwoorden # " + enquete.getJa
                    + Environment.NewLine + "aantal nee antwoorden # " + enquete.getNee
                    + Environment.NewLine + "aantal onbesliste antwoorden # " + enquete.getOnv);

                tbAntwoord.Enabled = false;
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tbDeelnemers.Focus();
        }

        private void btEinde_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btReset_Click(object sender, EventArgs e)
        {

            enquete.getJa = 0;


            tbDeelnemers.ResetText();
            tbDeelnemers.Enabled = true;
            tbAntwoord.Enabled = false;
            tbAntwoord.ResetText();
            lbResultaat.Hide();
            //http://stackoverflow.com/questions/14620375/how-can-we-clear-the-all-form-controls-on-winform
            //foreach (Control ctrl in this.Controls)
            //{
            //    if (ctrl is TextBox)
            //    {
            //        TextBox tb = (TextBox)ctrl;
            //        if (tb != null)
            //        {
            //            tb.Text = string.Empty;
            //        }
            //    }
            //    else if (ctrl is ComboBox)
            //    {
            //        ComboBox dd = (ComboBox)ctrl;
            //        if (dd != null)
            //        {
            //            dd.Text = string.Empty;
            //            dd.SelectedIndex = -1;
            //        }
            //    }

            //}
            //foreach (Control c in control.Controls)
            //{
            //    var textBox = c as TextBox;
            //    var comboBox = c as ComboBox;

            //    if (textBox != null)
            //        (textBox).Clear();

            //    if (comboBox != null)
            //        comboBox.SelectedIndex = -1;

            //    if (c.HasChildren)
            //        ClearSpace(c);
            //}

        }

        private void tbAntwoord_TextChanged(object sender, EventArgs e)
        { }
     
        //    string fout = Convert.ToString(tbAntwoord.Text).ToLower();
            

        //    if (fout == "j")
        //    {
        //        tbAntwoord.ResetText();
        //        tbAntwoord.Focus();
        //        MessageBox.Show("Dit was een juiste ingave");
        //    }
        //    else if (fout == "n")
        //    {
        //        tbAntwoord.ResetText();
        //        tbAntwoord.Focus();

        //    }
        //    else if (fout == "o")
        //    {
        //        tbAntwoord.ResetText();
        //        tbAntwoord.Focus();
        //    }

        //    else MessageBox.Show("Dit was geen juiste ingave, de test eindigd");
        //    tbAntwoord.Enabled = false;
        //}


    }



}

