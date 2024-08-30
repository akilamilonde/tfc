namespace tfcakila
{
    partial class secretaire
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.acceuilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elèvesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enseignantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.séctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acceuilToolStripMenuItem,
            this.elèvesToolStripMenuItem,
            this.enseignantsToolStripMenuItem,
            this.classeToolStripMenuItem,
            this.coursToolStripMenuItem,
            this.séctionToolStripMenuItem,
            this.rapportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1466, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // acceuilToolStripMenuItem
            // 
            this.acceuilToolStripMenuItem.Name = "acceuilToolStripMenuItem";
            this.acceuilToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.acceuilToolStripMenuItem.Text = "Acceuil";
            this.acceuilToolStripMenuItem.Click += new System.EventHandler(this.acceuilToolStripMenuItem_Click);
            // 
            // elèvesToolStripMenuItem
            // 
            this.elèvesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrementToolStripMenuItem,
            this.inscriptionToolStripMenuItem});
            this.elèvesToolStripMenuItem.Name = "elèvesToolStripMenuItem";
            this.elèvesToolStripMenuItem.Size = new System.Drawing.Size(72, 29);
            this.elèvesToolStripMenuItem.Text = "Elèves";
            // 
            // enregistrementToolStripMenuItem
            // 
            this.enregistrementToolStripMenuItem.Name = "enregistrementToolStripMenuItem";
            this.enregistrementToolStripMenuItem.Size = new System.Drawing.Size(203, 30);
            this.enregistrementToolStripMenuItem.Text = "Enregistrement";
            this.enregistrementToolStripMenuItem.Click += new System.EventHandler(this.enregistrementToolStripMenuItem_Click);
            // 
            // inscriptionToolStripMenuItem
            // 
            this.inscriptionToolStripMenuItem.Name = "inscriptionToolStripMenuItem";
            this.inscriptionToolStripMenuItem.Size = new System.Drawing.Size(203, 30);
            this.inscriptionToolStripMenuItem.Text = "inscription";
            // 
            // enseignantsToolStripMenuItem
            // 
            this.enseignantsToolStripMenuItem.Name = "enseignantsToolStripMenuItem";
            this.enseignantsToolStripMenuItem.Size = new System.Drawing.Size(207, 29);
            this.enseignantsToolStripMenuItem.Text = "Enregistrer Enseignants";
            this.enseignantsToolStripMenuItem.Click += new System.EventHandler(this.enseignantsToolStripMenuItem_Click);
            // 
            // classeToolStripMenuItem
            // 
            this.classeToolStripMenuItem.Name = "classeToolStripMenuItem";
            this.classeToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.classeToolStripMenuItem.Text = "Classe";
            this.classeToolStripMenuItem.Click += new System.EventHandler(this.classeToolStripMenuItem_Click);
            // 
            // coursToolStripMenuItem
            // 
            this.coursToolStripMenuItem.Name = "coursToolStripMenuItem";
            this.coursToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
            this.coursToolStripMenuItem.Text = "Cours";
            this.coursToolStripMenuItem.Click += new System.EventHandler(this.coursToolStripMenuItem_Click);
            // 
            // séctionToolStripMenuItem
            // 
            this.séctionToolStripMenuItem.Name = "séctionToolStripMenuItem";
            this.séctionToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.séctionToolStripMenuItem.Text = "Séction";
            this.séctionToolStripMenuItem.Click += new System.EventHandler(this.séctionToolStripMenuItem_Click);
            // 
            // rapportsToolStripMenuItem
            // 
            this.rapportsToolStripMenuItem.Name = "rapportsToolStripMenuItem";
            this.rapportsToolStripMenuItem.Size = new System.Drawing.Size(177, 29);
            this.rapportsToolStripMenuItem.Text = "Consulter Rapports";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1404, 709);
            this.panel1.TabIndex = 1;
            // 
            // secretaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 771);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "secretaire";
            this.Text = "secretaire";
            this.Load += new System.EventHandler(this.secretaire_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acceuilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elèvesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enseignantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapportsToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem enregistrementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem séctionToolStripMenuItem;
    }
}