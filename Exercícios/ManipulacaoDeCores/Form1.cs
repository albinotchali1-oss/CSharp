using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipulacaoDeCores
{
    public partial class Form1 : Form
    {
        Color cor = Color.Black;
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
            Exibir();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar2.Value.ToString();
            Exibir();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label3.Text = trackBar3.Value.ToString();
            Exibir();
        }
        private void Exibir()
        {
            panel1.BackColor = cor;
            cor = Color.FromArgb(trackBar1.Value,trackBar2.Value,trackBar3.Value);
            label4.Text="RGB (" +trackBar1.Value+ "," +trackBar2.Value+ "," +trackBar3.Value +")";
        }
    }
}
