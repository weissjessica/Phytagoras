using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weiss_Jessica_Phytagoras
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCBerechnen_Click(object sender, EventArgs e)

        {
            //0.Defaultwerte setze
            txtBoxA.BackColor = Color.White;
            txtBoxB.BackColor = Color.White;
            txtBoxC.BackColor = Color.White;

            //1.Variablen definieren
            double a = 0;
            double b = 0;
            double c = 0;

            //2. Eingabekontrolle
            if (double.TryParse(txtBoxA.Text, out a) == false)
            {
                lblEingabekontrolle.Text = "Bitte geben Sie eine korrekte Zahl ein.";
                txtBoxA.BackColor = Color.Red;
                txtBoxA.Text = "";
                txtBoxA.Focus();
                return;
            }
            if (double.TryParse(txtBoxB.Text, out b) == false)
            {
                lblEingabekontrolle.Text = "Bitte geben Sie eine korrekte Zahl ein.";
                txtBoxB.BackColor = Color.Red;
                txtBoxB.Text = "";
                txtBoxB.Focus();
                return;
            }

            //3.Rechnen

            //Hypothenuse berechnen
            c = Math.Sqrt( Math.Pow(a, 2) + Math.Pow(b, 2));

            //Ausgabe
            txtBoxC.Text = c.ToString();
            lblEingabekontrolle.Text = "Die Hypothenuse hat eine Länge von " + c.ToString();

         }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnABBerechnen_Click(object sender, EventArgs e)
        {
            //0.Defaultwerte setze
            txtBoxA.BackColor = Color.White;
            txtBoxB.BackColor = Color.White;
            txtBoxC.BackColor = Color.White;

            //1.Variablen definieren
            double a = 0;
            double b = 0;
            double c = 0;

            //Abgefüllte Felder kontrollieren
            if (double.TryParse(txtBoxC.Text, out c) == false)
            {
                lblEingabekontrolle.Text = "Bitte geben Sie eine korrekte Zahl ein.";
                txtBoxC.BackColor = Color.Red;
                txtBoxC.Text = "";
                txtBoxC.Focus();
                return;
            }

            if (txtBoxA.Text == "" && txtBoxB.Text != "")
            {
                if (double.TryParse(txtBoxB.Text, out b) == false)
                {
                    lblEingabekontrolle.Text = "Bitte geben Sie eine korrekte Zahl ein.";
                    txtBoxB.BackColor = Color.Red;
                    txtBoxB.Text = "";
                    txtBoxB.Focus();
                    return;
                }

                a = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(b, 2));
                lblEingabekontrolle.Text = "A hat eine Länge von " + a.ToString();
                txtBoxA.Text = a.ToString();

            } else if(txtBoxA.Text != "" && txtBoxB.Text == "")
            {
                if (double.TryParse(txtBoxA.Text, out a) == false)
                {
                    lblEingabekontrolle.Text = "Bitte geben Sie eine korrekte Zahl ein.";
                    txtBoxA.BackColor = Color.Red;
                    txtBoxA.Text = "";
                    txtBoxA.Focus();
                    return;
                }

                b = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(a, 2));
                lblEingabekontrolle.Text = "B hat eine Länge von " + b.ToString();
                txtBoxB.Text = b.ToString();

            }
            else
            {
                lblEingabekontrolle.Text = "Bitte geben Sie eine korrekte Zahl ein.";
                txtBoxA.BackColor = Color.Red;
                txtBoxB.BackColor = Color.Red;
                txtBoxA.Text = "";
                txtBoxB.Text = "";
                txtBoxA.Focus();
                return;
            }
        }
    }
}
