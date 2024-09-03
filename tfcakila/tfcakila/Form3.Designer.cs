namespace tfcakila
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.brassageinskaDataSet = new tfcakila.brassageinskaDataSet();
            this.brassageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brassageTableAdapter = new tfcakila.brassageinskaDataSetTableAdapters.brassageTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.juryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brassageinskaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brassageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.inscriptionDataGridViewTextBoxColumn,
            this.juryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.brassageBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(269, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(374, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // brassageinskaDataSet
            // 
            this.brassageinskaDataSet.DataSetName = "brassageinskaDataSet";
            this.brassageinskaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // brassageBindingSource
            // 
            this.brassageBindingSource.DataMember = "brassage";
            this.brassageBindingSource.DataSource = this.brassageinskaDataSet;
            this.brassageBindingSource.CurrentChanged += new System.EventHandler(this.brassageBindingSource_CurrentChanged);
            // 
            // brassageTableAdapter
            // 
            this.brassageTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // inscriptionDataGridViewTextBoxColumn
            // 
            this.inscriptionDataGridViewTextBoxColumn.DataPropertyName = "inscription";
            this.inscriptionDataGridViewTextBoxColumn.HeaderText = "inscription";
            this.inscriptionDataGridViewTextBoxColumn.Name = "inscriptionDataGridViewTextBoxColumn";
            // 
            // juryDataGridViewTextBoxColumn
            // 
            this.juryDataGridViewTextBoxColumn.DataPropertyName = "jury";
            this.juryDataGridViewTextBoxColumn.HeaderText = "jury";
            this.juryDataGridViewTextBoxColumn.Name = "juryDataGridViewTextBoxColumn";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 420);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brassageinskaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brassageBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private brassageinskaDataSet brassageinskaDataSet;
        private System.Windows.Forms.BindingSource brassageBindingSource;
        private brassageinskaDataSetTableAdapters.brassageTableAdapter brassageTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inscriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn juryDataGridViewTextBoxColumn;
    }
}