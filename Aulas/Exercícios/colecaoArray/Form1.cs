using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colecaoArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int[] valoles = new int[] { 10, 23, 5, 3, 55, 22, 45 };

            //foreach (int valor in valoles)
            //    lista.Items.Add(valor);

            //int[] valoles = new int[] { 10, 23, 5, 3, 55, 22, 45 };

            //for (int indice = 0; indice < 7; indice++)
            //    lista.Items.Add(valoles[indice]);

            int[] valoles = new int[] { 10, 23, 5, 3, 55, 22, 45, 234, 52, 235, 654, 8898, 21, 56, 4, 876, 23, 5, 57, 342, 2364, 676, 1145, 535, };

            for (int indice = 0; indice < valoles.Length; indice++)
                lista.Items.Add(valoles[indice]);
        }
    }
}