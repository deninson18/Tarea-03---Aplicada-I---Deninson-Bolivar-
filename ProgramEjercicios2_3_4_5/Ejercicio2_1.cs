using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramEjercicios2_3_4_5
{
    public partial class Ejercicio2_1 : Form
    {
        public Ejercicio2_1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(LongTextBox.Text);
            int valor1 = Convert.ToInt32(NumTextBox2.Text);

            int res = valor * valor1;
            ResTextBox3.Text = Convert.ToString(res);
        }
    }
}
