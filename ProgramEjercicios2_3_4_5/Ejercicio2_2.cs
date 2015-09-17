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
    public partial class Ejercicio2_2 : Form
    {
        public Ejercicio2_2()
        {
            InitializeComponent();
        }

        private void Ejercicio2_2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nume = 0, nume1 = 0, res = 0;
            nume = Convert.ToInt32(NumTextBox1.Text);
            nume1 = Convert.ToInt32(NumTextBox2.Text);
            res = nume + nume1;
            textBox1.Text = res.ToString();

        }
        

        private void NumTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
