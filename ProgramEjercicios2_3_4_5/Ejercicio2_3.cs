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
    public partial class Ejercicio2_3 : Form
    {
        public Ejercicio2_3()
        {
            InitializeComponent();
        }

        private void Ejercicio2_3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RtextBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void gradoButton_Click(object sender, EventArgs e)
        {
            Double resultado = Convert.ToInt32(gradoTextBox1.Text);
            resultadotextBox.Text = (resultado*0.0174532925).ToString();
        }
    }
}
