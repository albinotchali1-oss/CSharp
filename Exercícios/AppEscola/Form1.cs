using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscola
{
    public partial class FormMain : Form
    {
        float n1, n2, n3, n4, media;
        public FormMain()
        {
            InitializeComponent();
        }
        public void resultado()
        {
            n1 = float.Parse(txtN1.Text);
            n2 = float.Parse(txtN2.Text);
            n3 = float.Parse(txtN3.Text);
            n4 = float.Parse(txtN4.Text);

            media = (n1 + n2 + n3 + n4) / 4;
            lblMedia.Text = media.ToString();
        }
        public void CalcularMedia()
        {
            if(media >= 15){lblSituacao.Text = "Aprovado com distinção.";}
            else if(media >= 10) { lblSituacao.Text = "Aprovado."; }
            else if(media >= 7) { lblSituacao.Text = "Recurso."; }
            else { lblSituacao.Text = "Reprovado."; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            resultado();
            CalcularMedia();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            date.Text = DateTime.Today.ToString();
            lblNome.Text = Program.usuario;
        }
    }
}
