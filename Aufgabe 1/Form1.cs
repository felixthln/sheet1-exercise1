using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_1
{
    public partial class Form1 : Form
    {

        private string name;

        public Form1()
        {
            InitializeComponent();

            // MessageBox.Show("Bitte Namen Eingeben!");
        }

        private void btnEingabe(object sender, EventArgs e)
        {
            if (name != null)
            {
                lblGreetingLabel.Text = "Hallo " + name;
            }
            else
            {
                MessageBox.Show("Keinen Namen eingegeben!");
            }
        }

        private void txtNameTextChanged(object sender, EventArgs e)
        {
            name = txtNameBox.Text;
        }
    }
}
