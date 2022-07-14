namespace ProiectPAWWWWWWW
{
    partial class FormMasina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMasina));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.tbAn = new System.Windows.Forms.TextBox();
            this.tbCuloare = new System.Windows.Forms.TextBox();
            this.btnAdaugaMasina = new System.Windows.Forms.Button();
            this.treeViewMasina = new System.Windows.Forms.TreeView();
            this.epMarca = new System.Windows.Forms.ErrorProvider(this.components);
            this.epAn = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCuloare = new System.Windows.Forms.ErrorProvider(this.components);
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pbDragDrop = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnIncarcaImagine = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inapoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.epMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCuloare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDragDrop)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca Masinii:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "An Inmatriculare";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Culoare";
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(116, 66);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(132, 22);
            this.tbMarca.TabIndex = 3;
            // 
            // tbAn
            // 
            this.tbAn.Location = new System.Drawing.Point(134, 108);
            this.tbAn.Name = "tbAn";
            this.tbAn.Size = new System.Drawing.Size(100, 22);
            this.tbAn.TabIndex = 4;
            // 
            // tbCuloare
            // 
            this.tbCuloare.Location = new System.Drawing.Point(87, 151);
            this.tbCuloare.Name = "tbCuloare";
            this.tbCuloare.Size = new System.Drawing.Size(100, 22);
            this.tbCuloare.TabIndex = 5;
            // 
            // btnAdaugaMasina
            // 
            this.btnAdaugaMasina.Location = new System.Drawing.Point(12, 213);
            this.btnAdaugaMasina.Name = "btnAdaugaMasina";
            this.btnAdaugaMasina.Size = new System.Drawing.Size(129, 48);
            this.btnAdaugaMasina.TabIndex = 6;
            this.btnAdaugaMasina.Text = "Adauga Masina";
            this.btnAdaugaMasina.UseVisualStyleBackColor = true;
            this.btnAdaugaMasina.Click += new System.EventHandler(this.btnAdaugaMasina_Click);
            // 
            // treeViewMasina
            // 
            this.treeViewMasina.Location = new System.Drawing.Point(162, 213);
            this.treeViewMasina.Name = "treeViewMasina";
            this.treeViewMasina.Size = new System.Drawing.Size(228, 200);
            this.treeViewMasina.TabIndex = 8;
            this.treeViewMasina.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewMasina_AfterSelect);
            // 
            // epMarca
            // 
            this.epMarca.ContainerControl = this;
            // 
            // epAn
            // 
            this.epAn.ContainerControl = this;
            // 
            // epCuloare
            // 
            this.epCuloare.ContainerControl = this;
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(519, 69);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(216, 156);
            this.pb1.TabIndex = 9;
            this.pb1.TabStop = false;
            this.pb1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb1_MouseDown);
            // 
            // pbDragDrop
            // 
            this.pbDragDrop.Location = new System.Drawing.Point(519, 241);
            this.pbDragDrop.Name = "pbDragDrop";
            this.pbDragDrop.Size = new System.Drawing.Size(220, 172);
            this.pbDragDrop.TabIndex = 10;
            this.pbDragDrop.TabStop = false;
            this.pbDragDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbDragDrop_DragDrop);
            this.pbDragDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbDragDrop_DragEnter);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnIncarcaImagine});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnIncarcaImagine
            // 
            this.btnIncarcaImagine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnIncarcaImagine.Image = ((System.Drawing.Image)(resources.GetObject("btnIncarcaImagine.Image")));
            this.btnIncarcaImagine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIncarcaImagine.Name = "btnIncarcaImagine";
            this.btnIncarcaImagine.Size = new System.Drawing.Size(29, 24);
            this.btnIncarcaImagine.Text = "Incarca Imagine";
            this.btnIncarcaImagine.Click += new System.EventHandler(this.btnIncarcaImagine_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inapoiToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inapoiToolStripMenuItem
            // 
            this.inapoiToolStripMenuItem.Name = "inapoiToolStripMenuItem";
            this.inapoiToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.inapoiToolStripMenuItem.Text = "Inapoi";
            this.inapoiToolStripMenuItem.Click += new System.EventHandler(this.inapoiToolStripMenuItem_Click_1);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click_1);
            // 
            // FormMasina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pbDragDrop);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.treeViewMasina);
            this.Controls.Add(this.btnAdaugaMasina);
            this.Controls.Add(this.tbCuloare);
            this.Controls.Add(this.tbAn);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMasina";
            this.Text = "FormMasina";
            this.Load += new System.EventHandler(this.FormMasina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCuloare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDragDrop)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.TextBox tbAn;
        private System.Windows.Forms.TextBox tbCuloare;
        private System.Windows.Forms.Button btnAdaugaMasina;
        private System.Windows.Forms.TreeView treeViewMasina;
        private System.Windows.Forms.ErrorProvider epMarca;
        private System.Windows.Forms.ErrorProvider epAn;
        private System.Windows.Forms.ErrorProvider epCuloare;
        private System.Windows.Forms.PictureBox pbDragDrop;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnIncarcaImagine;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inapoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
    }
}