using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ProiectPAWWWWWWW
{
    public partial class FormSofer : Form
    {
        List<Sofer> listaSofer;
        public FormSofer()
        {
            InitializeComponent();
            listaSofer = new List<Sofer>();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        } 
        private void btnAdaugaS_Click_1(object sender, EventArgs e)
        {
            Sofer sofer = new Sofer();
            sofer.NumeS = tbNumeSofer.Text;
            sofer.PrenumeS = tbPrenumeSofer.Text;
            try
            {
                if (tbVarsta.Text != "" && (tbVarsta.Text.All(char.IsDigit)))
                {
                    sofer.Varsta = Int32.Parse(tbVarsta.Text);

                }
                else
                    throw new ExceptieValidare();
            }
            catch (ExceptieValidare ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            listaSofer.Add(sofer);
            MessageBox.Show(sofer.ToString());
            golireFormular();
        }

       
        private void golireLista()
        {
            lvSofer.Items.Clear();
        }
        private void golireFormular()
        {
            tbNumeSofer.Clear();
            tbPrenumeSofer.Clear();
            tbVarsta.Clear();

        }


        private void tbVarsta_Validated_1(object sender, EventArgs e)
        {
            epVarsta.Clear();
        }

        private void tbVarsta_Validating_1(object sender, CancelEventArgs e)
        {
            if (tbVarsta.Text == "" || !tbVarsta.Text.All(char.IsDigit))
            {
                epVarsta.SetError((Control)sender, "Informatie incorecta");
                e.Cancel = true;
            }

        }

        private void btnAfisSofer_Click_1(object sender, EventArgs e)
        {
            golireLista();
            foreach (Sofer s in listaSofer)
            {
                ListViewItem item = new ListViewItem(s.NumeS);
                item.SubItems.Add(s.PrenumeS);
                if (s.Varsta != 0)
                    item.SubItems.Add(s.Varsta.ToString());

                lvSofer.Items.Add(item);
            }

        }

        private void btnGolesteSofer_Click_1(object sender, EventArgs e)
        {
            golireLista();
        }

        private void inapoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog.Document = printDocument;
            pageSetupDialog.PageSettings = printDocument.DefaultPageSettings;
            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
            {
                printPreviewDialog.Document = printDocument;
                printPreviewDialog.ShowDialog();
            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Times New Roman", 12);
            Brush brush = Brushes.DarkBlue;
            Pen pen = new Pen(brush);
            PageSettings settings = printDocument.DefaultPageSettings;
            var totalW = settings.PaperSize.Width - settings.Margins.Left - settings.Margins.Right;
            var totalH = settings.PaperSize.Height - settings.Margins.Top - settings.Margins.Bottom;

            if (settings.Landscape)
            {
                var temp = totalH;
                totalH = totalW;
                totalW = temp;
            }

            var cellW = totalW / 5;
            var cellH = 40;

            int x = settings.Margins.Left;
            int y = 100;

            //desenare cap tabel
            graphics.DrawRectangle(pen, x, y, cellW, cellH);
            graphics.DrawRectangle(pen, x + cellW, y, cellW, cellH);
            graphics.DrawRectangle(pen, x + cellW * 2, y, cellW, cellH);
          
            //desenare text coloane
            graphics.DrawString("Nume Sofer", font, brush, x, y);
            graphics.DrawString("Prenume ", font, brush, x + cellW, y);
            graphics.DrawString("Varsta", font, brush, x + cellW * 2, y);
         
            y += cellH;
            foreach (Sofer s in listaSofer)
            {
                graphics.DrawRectangle(pen, x, y, cellW, cellH);
                graphics.DrawRectangle(pen, x + cellW, y, cellW, cellH);
                graphics.DrawRectangle(pen, x + cellW * 2, y, cellW, cellH);
              

                graphics.DrawString(s.NumeS, font, brush, x, y);
                graphics.DrawString(s.PrenumeS, font, brush, x + cellW, y);
                graphics.DrawString(s.Varsta.ToString(), font, brush, x + 2 * cellW, y);
              

                y += cellH;
            }
        }
        private Sofer GetSoferFromList(ListViewItem item)
        {
            Sofer sofer = new Sofer();
            sofer.NumeS = item.SubItems[0].Text;
            sofer.PrenumeS = item.SubItems[1].Text;
            sofer.Varsta = Int32.Parse(item.SubItems[2].Text);
            return sofer;
        }

        private void salvareXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvSofer.SelectedItems[0] != null)
            {
                ListViewItem item = lvSofer.SelectedItems[0];
                Sofer sofer = GetSoferFromList(item);

                FileStream file = new FileStream("soferi.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(file);
                sw.Write(sofer.ToString());
                sw.Close();
                sw.Close();
                MessageBox.Show("Salvare cu succes!");
            }
        }

        private void salvareXMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lvSofer.SelectedItems[0] != null)
            {
                ListViewItem item = lvSofer.SelectedItems[0];
               Sofer sofer = GetSoferFromList(item);

                FileStream file = new FileStream("comanda.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Sofer));
                xmlSerializer.Serialize(file, sofer);
                file.Close();
                MessageBox.Show("Salvare cu succes!");
            }
        }

        private void FormSofer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.X)
                Application.Exit();
        }
    }
 }


