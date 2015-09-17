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
    public partial class Ejercicios2_3_4_5 : Form
    {
        public Ejercicios2_3_4_5()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void Ejercicios2_3_4_5_Load(object sender, EventArgs e)
        {

        }

        private void ejercicio1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ejercicio2_2 ej = new Ejercicio2_2();
            ej.Show();
        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio2_1 ej = new Ejercicio2_1();
            ej.Show();
        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio2_3 ej = new Ejercicio2_3();
            ej.Show();
        }
    }
}
