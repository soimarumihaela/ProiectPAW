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
    public partial class FormInitial : Form
    {
        public FormInitial()
        {
            InitializeComponent();
        }

        private void btnSofer_Click(object sender, EventArgs e)
        {
            FormSofer form = new FormSofer();
            this.Hide();
            form.ShowDialog();
             this.Show();
           
        }

        private void btnMasina_Click(object sender, EventArgs e)
        {
            FormMasina form = new FormMasina();
            this.Hide();
            form.ShowDialog();
           this.Show();
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            FormRuta form = new FormRuta();
            this.Hide();
            form.ShowDialog();
            this.Show();
            

        }
    }
}
