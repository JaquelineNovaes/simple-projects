using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletim
{
    public partial class TelaNota : Form
    {
        public TelaNota()
        {
            InitializeComponent();
        }

        Nota nota = new Nota();
        List<Nota> lista = new List<Nota>();
        int i = 0;

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double n1, n2, m;
            n1 = double.Parse(txtnota1.Text);
            n2 = double.Parse(txtnota2.Text);
            m = (n1 + n2) / 2;
            txtmedia.Text = m.ToString();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            nota = new Nota();
            nota.Nome = txtnome.Text;
            nota.Turma = txtturma.Text;
            nota.Nota1 = double.Parse(txtnota1.Text);
            nota.Nota2 = double.Parse(txtnota2.Text);
            nota.Media = double.Parse(txtmedia.Text);
            lista.Add(nota);
            dgvalunos.Rows.Add();
            dgvalunos.Rows[i].Cells[0].Value = nota.Nome;
            dgvalunos.Rows[i].Cells[1].Value = nota.Turma;
            dgvalunos.Rows[i].Cells[2].Value = nota.Nota1;
            dgvalunos.Rows[i].Cells[3].Value = nota.Nota2;
            dgvalunos.Rows[i].Cells[4].Value = nota.Media;
            i++;
            limpar();
            MessageBox.Show("Salvo com sucesso");
            txtnome.Focus();
        }

        private void limpar()
        {
            txtnome.Text = null;
            txtturma.Text = null;
            txtnota1.Text = null;
            txtnota2.Text = null;
            txtmedia.Text = null;
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            for(int i=0; i<lista.Count; i++)
            {
                if (lista[i].Nome == txtnome.Text)
                {
                    txtturma.Text = lista[i].Turma;
                    txtnota1.Text = lista[i].Nota1.ToString();
                    txtnota2.Text = lista[i].Nota2.ToString();
                    txtmedia.Text = lista[i].Media.ToString();
                }  
            }
        }
    }
}
