using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAWWWWWWW
{
    public partial class FormRuta : Form
    {
        List<Ruta> listaRuta;
        public FormRuta()
        {
            InitializeComponent();
            listaRuta = new List<Ruta>();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ruta ruta = new Ruta();
            ruta.numeR = tbNumeR.Text;
            listaRuta.Add(ruta);
            MessageBox.Show(ruta.ToString());
            golireFormular();

            golireLista();
            foreach (Ruta r in listaRuta)
            {
                ListViewItem item = new ListViewItem(r.numeR);
               

                lvRuta.Items.Add(item);
            }
        }
        private void golireFormular()
        {
            tbNumeR.Clear();
            

        }
        private void golireLista()
        {
            lvRuta.Items.Clear();
        }

        private void inapoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
