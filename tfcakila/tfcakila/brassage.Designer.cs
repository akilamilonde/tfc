namespace tfcakila
{
    partial class brassage
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
            this.cmbjury = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbjury
            // 
            this.cmbjury.FormattingEnabled = true;
            this.cmbjury.Location = new System.Drawing.Point(388, 159);
            this.cmbjury.Name = "cmbjury";
            this.cmbjury.Size = new System.Drawing.Size(318, 28);
            this.cmbjury.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(743, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // brassage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbjury);
            this.Name = "brassage";
            this.Size = new System.Drawing.Size(1301, 500);
            this.Load += new System.EventHandler(this.brassage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbjury;
        private System.Windows.Forms.Button button1;
    }
}
