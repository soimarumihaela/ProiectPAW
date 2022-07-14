using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAWWWWWWW
{
    public partial class FormMasina : Form
    {
        List<Masina> listaMasina;
        public FormMasina()
        {
            InitializeComponent();
            listaMasina = new List<Masina>();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void golireFormular()
        {
            tbMarca.Clear();
            tbAn.Clear();
            tbCuloare.Clear();

        }

        private void afisareTreeView()
        {
            foreach (Masina m in listaMasina)
            {
                TreeNode node = new TreeNode(m.Marca);
                node.Nodes.Add("An Inmatriculare", m.AnInmatriculare.ToString());
                node.Nodes.Add("Adresa", m.Culoare);
                treeViewMasina.Nodes.Add(node);
            }
        }
        private void curataTreeView()
        {
            treeViewMasina.Nodes.Clear();
        }

        private void btnAdaugaMasina_Click(object sender, EventArgs e)
        {
            if (tbMarca.Text == "")
            {
                epMarca.SetError(tbMarca, "Informatie lipsa");
                epAn.Clear();
                epCuloare.Clear();
            }

            else if (tbAn.Text == "" || !tbAn.Text.All(char.IsDigit))
            {
                epMarca.Clear();
                epCuloare.Clear();
                epAn.SetError(tbAn, "Informatie lipsa");
            }
            else if (tbCuloare.Text == "")
            {
                epMarca.Clear();
                epAn.Clear();
                epCuloare.SetError(tbCuloare, "Informatie lipsa");
            }
            else
            {
                epCuloare.Clear();
                epMarca.Clear();
                epAn.Clear();
                curataTreeView();
                Masina masina = new Masina();
                masina.Marca = tbMarca.Text;
                masina.AnInmatriculare = Int32.Parse(tbAn.Text);
                masina.Culoare = tbCuloare.Text;
                listaMasina.Add(masina);
                afisareTreeView();
                golireFormular();
            }
        }

        private void inapoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void treeViewMasina_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIncarcaImagine_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Incarca imagine";
            dialog.Filter = "bmp files (*.bmp)|*.bmp";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pb1.Image = Image.FromFile(dialog.FileName);
                pb1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        private void pb1_MouseDown(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).DoDragDrop(pb1.Image, DragDropEffects.Copy);
        }

        private void FormMasina_Load(object sender, EventArgs e)
        {
            pbDragDrop.AllowDrop = true;

        }

        private void pbDragDrop_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pbDragDrop_DragDrop(object sender, DragEventArgs e)
        {
            pbDragDrop.Image = (Image)e.Data.GetData(DataFormats.Bitmap, true);
            pbDragDrop.SizeMode = PictureBoxSizeMode.StretchImage;
           
        }

        private void inapoiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void iesireToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
