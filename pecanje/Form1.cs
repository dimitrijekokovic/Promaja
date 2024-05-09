using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pecanje
{
    public partial class Form1 : Form
    {
        private void dodajobrisipanel(UserControl control)
        {

            panelmenjaj.Controls.Clear();
            panelmenjaj.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dodajobrisipanel(new vrsteriba());
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dodajobrisipanel(new masinice());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dodajobrisipanel(new stapovi());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        bool rasiren = false;

        

        bool bol = false;
        private void prvaTranzicija_Tick(object sender, EventArgs e)
        {
            if(bol)
            {
                sidebar.Width -= 10;
                if(sidebar.Width <= 59)
                {
                    bol = false;
                    prvaTranzicija.Stop();
                    pnVrste.Width = sidebar.Width;
                    pnMasinice.Width = sidebar.Width;                }

            }
            else
            {
                sidebar.Width += 10;
                if(sidebar.Width >= 200)
                {
                    bol = true; prvaTranzicija.Stop();

                    pnVrste.Width = sidebar.Width;
                    pnMasinice.Width = sidebar.Width;
                }
            }
        }

       

        private void btnGlavni_Click_1(object sender, EventArgs e)
        {
            prvaTranzicija.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void pnUdice_Click(object sender, EventArgs e)
        {
            dodajobrisipanel(new udice());
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void panelmenjaj_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pretragaBT_Click(object sender, EventArgs e)
        {
            dodajobrisipanel(new pretraga());
        }
    }
    
}
