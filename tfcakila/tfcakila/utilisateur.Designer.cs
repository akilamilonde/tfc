namespace tfcakila
{
    partial class utilisateur
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtmotdepasse = new System.Windows.Forms.TextBox();
            this.cmbfonction = new System.Windows.Forms.ComboBox();
            this.tableau = new System.Windows.Forms.DataGridView();
            this.ajouter = new System.Windows.Forms.Button();
            this.supprimer = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.vider = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de Passe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fonction";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(292, 84);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(260, 37);
            this.txtusername.TabIndex = 3;
            // 
            // txtmotdepasse
            // 
            this.txtmotdepasse.Location = new System.Drawing.Point(292, 127);
            this.txtmotdepasse.Multiline = true;
            this.txtmotdepasse.Name = "txtmotdepasse";
            this.txtmotdepasse.Size = new System.Drawing.Size(260, 37);
            this.txtmotdepasse.TabIndex = 4;
            // 
            // cmbfonction
            // 
            this.cmbfonction.FormattingEnabled = true;
            this.cmbfonction.Location = new System.Drawing.Point(292, 170);
            this.cmbfonction.Name = "cmbfonction";
            this.cmbfonction.Size = new System.Drawing.Size(260, 28);
            this.cmbfonction.TabIndex = 5;
            // 
            // tableau
            // 
            this.tableau.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4});
            this.tableau.Location = new System.Drawing.Point(121, 227);
            this.tableau.Name = "tableau";
            this.tableau.RowTemplate.Height = 28;
            this.tableau.Size = new System.Drawing.Size(757, 150);
            this.tableau.TabIndex = 6;
            this.tableau.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableau_CellClick);
            this.tableau.SelectionChanged += new System.EventHandler(this.tableau_SelectionChanged);
            // 
            // ajouter
            // 
            this.ajouter.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter.Location = new System.Drawing.Point(562, 84);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(160, 42);
            this.ajouter.TabIndex = 7;
            this.ajouter.Text = "AJOUTER";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // supprimer
            // 
            this.supprimer.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer.Location = new System.Drawing.Point(562, 159);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(160, 42);
            this.supprimer.TabIndex = 8;
            this.supprimer.Text = "SUPPRIMER";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // modifier
            // 
            this.modifier.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier.Location = new System.Drawing.Point(728, 84);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(150, 42);
            this.modifier.TabIndex = 9;
            this.modifier.Text = "MODIFIER";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // vider
            // 
            this.vider.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vider.Location = new System.Drawing.Point(728, 162);
            this.vider.Name = "vider";
            this.vider.Size = new System.Drawing.Size(150, 42);
            this.vider.TabIndex = 10;
            this.vider.Text = "VIDER";
            this.vider.UseVisualStyleBackColor = true;
            this.vider.Click += new System.EventHandler(this.vider_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(292, 41);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(260, 37);
            this.txtid.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "NUMERO";
            this.Column5.Name = "Column5";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "User Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mot de Passe";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fonction";
            this.Column4.Name = "Column4";
            // 
            // utilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.vider);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.tableau);
            this.Controls.Add(this.cmbfonction);
            this.Controls.Add(this.txtmotdepasse);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "utilisateur";
            this.Size = new System.Drawing.Size(1011, 605);
            this.Load += new System.EventHandler(this.utilisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtmotdepasse;
        private System.Windows.Forms.ComboBox cmbfonction;
        private System.Windows.Forms.DataGridView tableau;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button vider;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
