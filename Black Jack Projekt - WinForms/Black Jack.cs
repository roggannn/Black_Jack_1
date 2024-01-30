using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int Balans = 1000;
        int SparPosition = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            
            this.Size = new System.Drawing.Size(1920, 1080);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            Saldo.Text = $"Saldo : {Balans}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ReglerText.Visible == false)
            {
                ReglerText.Visible = true;
                ReglerKnapp.BackColor = Color.Thistle;
            }
            else
            ReglerText.Visible = false;
            ReglerKnapp.BackColor = Color.White;

        }

        private void Sparfiler_Click(object sender, EventArgs e)
        {
            if (sparListaBakgrund.Visible == false)
            {
                VisaSparListaBakgrund();
            }
            else if (sparListaBakgrund.Visible == true)
            {
                NoSparListaBakgrund();
            }
            
            
        }
        private void VisaSparListaBakgrund()
        {
            sparListaBakgrund.Visible = true;
            Save1.Visible = true;
            Save1.BringToFront();
            Save2.Visible = true;
            Save2.BringToFront();
            Save3.Visible = true;
            Save3.BringToFront();
            Save4.Visible = true;
            Save4.BringToFront();

        }

        private void NoSparListaBakgrund()
        {
            sparListaBakgrund.Visible = false;
            Save1.Visible = false;
            Save2.Visible = false;
            Save3.Visible = false;
            Save4.Visible = false;
            SparaKnapp.Visible = false;
            LaddaKnapp.Visible = false;

        }

        private void Save1_Click(object sender, EventArgs e)
        {
            SparaKnapp.Location = new Point(341, 209);
            SparaKnapp.Visible = true;
            LaddaKnapp.Location = new Point(341, 241);
            LaddaKnapp.Visible = true;
            SparPosition = 1;
        }

        private void Save2_Click(object sender, EventArgs e)
        {
            SparaKnapp.Location = new Point(341, 280);
            SparaKnapp.Visible = true;
            LaddaKnapp.Location = new Point(341, 321);
            LaddaKnapp.Visible = true;
            SparPosition = 2;
        }

        private void Save3_Click(object sender, EventArgs e)
        {
            SparaKnapp.Location = new Point(341, 353);
            SparaKnapp.Visible = true;
            LaddaKnapp.Location = new Point(341, 394);
            LaddaKnapp.Visible = true;
            SparPosition = 3;
        }

        private void Save4_Click(object sender, EventArgs e)
        {
            SparaKnapp.Location = new Point(341, 426);
            SparaKnapp.Visible = true;
            LaddaKnapp.Location = new Point(341, 467);
            LaddaKnapp.Visible = true;
            SparPosition = 4;
        }

        private void SparaKnapp_Click(object sender, EventArgs e)
        {
            SparaKnapp.Visible = false;
            LaddaKnapp.Visible = false;
            if (SparPosition == 1)
            {
                Properties.Settings.Default.Save1 = Balans;
                Properties.Settings.Default.Save();
            }
            else if (SparPosition == 2)
            {
                Properties.Settings.Default.Save2 = Balans;
                Properties.Settings.Default.Save();
            }
            else if (SparPosition == 3)
            {
                Properties.Settings.Default.Save3 = Balans;
                Properties.Settings.Default.Save();
            }
            else if (SparPosition == 4)
            {
                Properties.Settings.Default.Save2 = Balans;
                Properties.Settings.Default.Save();
            }

        }

        private void LaddaKnapp_Click(object sender, EventArgs e)
        {
            SparaKnapp.Visible = false;
            LaddaKnapp.Visible = false;
            if (SparPosition == 1)
            {
                Balans = Properties.Settings.Default.Save1;
                Saldo.Text = $"Saldo : {Balans}";
            }
            else if (SparPosition == 2)
            {
                Balans = Properties.Settings.Default.Save2;
                Saldo.Text = $"Saldo : {Balans}";
            }
            else if (SparPosition == 3)
            {
                Balans = Properties.Settings.Default.Save3;
                Saldo.Text = $"Saldo : {Balans}";
            }
            else if (SparPosition == 4)
            {
                Balans = Properties.Settings.Default.Save4;
                Saldo.Text = $"Saldo : {Balans}";
            }
        }
    }
}
