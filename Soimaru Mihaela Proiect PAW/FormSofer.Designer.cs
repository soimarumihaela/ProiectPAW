namespace ProiectPAWWWWWWW
{
    partial class FormSofer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSofer));
            this.btnGolesteSofer = new System.Windows.Forms.Button();
            this.btnAfisSofer = new System.Windows.Forms.Button();
            this.lvSofer = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdaugaS = new System.Windows.Forms.Button();
            this.tbVarsta = new System.Windows.Forms.TextBox();
            this.tbPrenumeSofer = new System.Windows.Forms.TextBox();
            this.tbNumeSofer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.epVarsta = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inapoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.contextSalvare = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.salvareXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareXMLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.epVarsta)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextSalvare.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGolesteSofer
            // 
            this.btnGolesteSofer.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnGolesteSofer.Location = new System.Drawing.Point(609, 370);
            this.btnGolesteSofer.Name = "btnGolesteSofer";
            this.btnGolesteSofer.Size = new System.Drawing.Size(121, 49);
            this.btnGolesteSofer.TabIndex = 19;
            this.btnGolesteSofer.Text = "Goleste Lista";
            this.btnGolesteSofer.UseVisualStyleBackColor = false;
            this.btnGolesteSofer.Click += new System.EventHandler(this.btnGolesteSofer_Click_1);
            // 
            // btnAfisSofer
            // 
            this.btnAfisSofer.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnAfisSofer.Location = new System.Drawing.Point(420, 370);
            this.btnAfisSofer.Name = "btnAfisSofer";
            this.btnAfisSofer.Size = new System.Drawing.Size(127, 50);
            this.btnAfisSofer.TabIndex = 18;
            this.btnAfisSofer.Text = "Afiseaza Lista";
            this.btnAfisSofer.UseVisualStyleBackColor = false;
            this.btnAfisSofer.Click += new System.EventHandler(this.btnAfisSofer_Click_1);
            // 
            // lvSofer
            // 
            this.lvSofer.BackColor = System.Drawing.Color.Linen;
            this.lvSofer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvSofer.Location = new System.Drawing.Point(420, 30);
            this.lvSofer.Name = "lvSofer";
            this.lvSofer.Size = new System.Drawing.Size(330, 309);
            this.lvSofer.TabIndex = 17;
            this.lvSofer.UseCompatibleStateImageBehavior = false;
            this.lvSofer.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nume Sofer";
            this.columnHeader1.Width = 95;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prenume Sofer";
            this.columnHeader2.Width = 105;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Varsta";
            // 
            // btnAdaugaS
            // 
            this.btnAdaugaS.BackColor = System.Drawing.Color.MistyRose;
            this.btnAdaugaS.Location = new System.Drawing.Point(51, 322);
            this.btnAdaugaS.Name = "btnAdaugaS";
            this.btnAdaugaS.Size = new System.Drawing.Size(161, 59);
            this.btnAdaugaS.TabIndex = 16;
            this.btnAdaugaS.Text = "Adauga Sofer";
            this.btnAdaugaS.UseVisualStyleBackColor = false;
            this.btnAdaugaS.Click += new System.EventHandler(this.btnAdaugaS_Click_1);
            // 
            // tbVarsta
            // 
            this.tbVarsta.Location = new System.Drawing.Point(153, 179);
            this.tbVarsta.Name = "tbVarsta";
            this.tbVarsta.Size = new System.Drawing.Size(100, 22);
            this.tbVarsta.TabIndex = 15;
            this.tbVarsta.Validating += new System.ComponentModel.CancelEventHandler(this.tbVarsta_Validating_1);
            this.tbVarsta.Validated += new System.EventHandler(this.tbVarsta_Validated_1);
            // 
            // tbPrenumeSofer
            // 
            this.tbPrenumeSofer.Location = new System.Drawing.Point(196, 143);
            this.tbPrenumeSofer.Name = "tbPrenumeSofer";
            this.tbPrenumeSofer.Size = new System.Drawing.Size(142, 22);
            this.tbPrenumeSofer.TabIndex = 14;
            // 
            // tbNumeSofer
            // 
            this.tbNumeSofer.Location = new System.Drawing.Point(185, 99);
            this.tbNumeSofer.Name = "tbNumeSofer";
            this.tbNumeSofer.Size = new System.Drawing.Size(147, 22);
            this.tbNumeSofer.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Varsta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Prenume Sofer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nume Sofer";
            // 
            // epVarsta
            // 
            this.epVarsta.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inapoiToolStripMenuItem,
            this.iesireToolStripMenuItem,
            this.printToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inapoiToolStripMenuItem
            // 
            this.inapoiToolStripMenuItem.Name = "inapoiToolStripMenuItem";
            this.inapoiToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.inapoiToolStripMenuItem.Text = "Inapoi";
            this.inapoiToolStripMenuItem.Click += new System.EventHandler(this.inapoiToolStripMenuItem_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // contextSalvare
            // 
            this.contextSalvare.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextSalvare.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareXMLToolStripMenuItem,
            this.salvareXMLToolStripMenuItem1});
            this.contextSalvare.Name = "contextMenuStrip1";
            this.contextSalvare.Size = new System.Drawing.Size(160, 52);
            // 
            // salvareXMLToolStripMenuItem
            // 
            this.salvareXMLToolStripMenuItem.Name = "salvareXMLToolStripMenuItem";
            this.salvareXMLToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.salvareXMLToolStripMenuItem.Text = "Salvare TXT";
            this.salvareXMLToolStripMenuItem.Click += new System.EventHandler(this.salvareXMLToolStripMenuItem_Click);
            // 
            // salvareXMLToolStripMenuItem1
            // 
            this.salvareXMLToolStripMenuItem1.Name = "salvareXMLToolStripMenuItem1";
            this.salvareXMLToolStripMenuItem1.Size = new System.Drawing.Size(159, 24);
            this.salvareXMLToolStripMenuItem1.Text = "Salvare XML";
            this.salvareXMLToolStripMenuItem1.Click += new System.EventHandler(this.salvareXMLToolStripMenuItem1_Click);
            // 
            // FormSofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGolesteSofer);
            this.Controls.Add(this.btnAfisSofer);
            this.Controls.Add(this.lvSofer);
            this.Controls.Add(this.btnAdaugaS);
            this.Controls.Add(this.tbVarsta);
            this.Controls.Add(this.tbPrenumeSofer);
            this.Controls.Add(this.tbNumeSofer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormSofer";
            this.Text = "FormSofer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormSofer_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.epVarsta)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextSalvare.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGolesteSofer;
        private System.Windows.Forms.Button btnAfisSofer;
        private System.Windows.Forms.ListView lvSofer;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnAdaugaS;
        private System.Windows.Forms.TextBox tbVarsta;
        private System.Windows.Forms.TextBox tbPrenumeSofer;
        private System.Windows.Forms.TextBox tbNumeSofer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider epVarsta;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inapoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.ContextMenuStrip contextSalvare;
        private System.Windows.Forms.ToolStripMenuItem salvareXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareXMLToolStripMenuItem1;
    }
}