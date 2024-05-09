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
    public partial class pretraga : UserControl
    {
        public pretraga()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dodajobrisipanel1(new udicepretraga());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dodajobrisipanel1(new masinicepretraga());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dodajobrisipanel1(new stapovipretraga());
        }
        private void dodajobrisipanel1(UserControl control)
        {

            panel.Controls.Clear();
            panel.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dodajobrisipanel1(new ribepretraga());
        }
    }
}
