namespace BusquedaEnGrafo
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.grafoDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lifoTypeRadioButton = new System.Windows.Forms.RadioButton();
            this.fifoTypeRadioButton = new System.Windows.Forms.RadioButton();
            this.searchButton = new System.Windows.Forms.Button();
            this.aVaraRadioButton = new System.Windows.Forms.RadioButton();
            this.aEstrellaRadioButton = new System.Windows.Forms.RadioButton();
            this.nodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conecctionsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initialNodeColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.finalNodeColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.heuristicaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grafoDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grafo:";
            // 
            // grafoDataGridView
            // 
            this.grafoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grafoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grafoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nodeColumn,
            this.conecctionsColumn,
            this.initialNodeColumn,
            this.finalNodeColumn,
            this.heuristicaColumn});
            this.grafoDataGridView.Location = new System.Drawing.Point(12, 29);
            this.grafoDataGridView.Name = "grafoDataGridView";
            this.grafoDataGridView.RowTemplate.Height = 24;
            this.grafoDataGridView.Size = new System.Drawing.Size(753, 328);
            this.grafoDataGridView.TabIndex = 1;
            this.grafoDataGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.grafoDataGridView_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.aEstrellaRadioButton);
            this.groupBox1.Controls.Add(this.aVaraRadioButton);
            this.groupBox1.Controls.Add(this.lifoTypeRadioButton);
            this.groupBox1.Controls.Add(this.fifoTypeRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(15, 373);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 77);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Búsqueda:";
            // 
            // lifoTypeRadioButton
            // 
            this.lifoTypeRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lifoTypeRadioButton.AutoSize = true;
            this.lifoTypeRadioButton.Location = new System.Drawing.Point(247, 35);
            this.lifoTypeRadioButton.Name = "lifoTypeRadioButton";
            this.lifoTypeRadioButton.Size = new System.Drawing.Size(136, 21);
            this.lifoTypeRadioButton.TabIndex = 1;
            this.lifoTypeRadioButton.Text = "Por Altura (LIFO)";
            this.lifoTypeRadioButton.UseVisualStyleBackColor = true;
            // 
            // fifoTypeRadioButton
            // 
            this.fifoTypeRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fifoTypeRadioButton.AutoSize = true;
            this.fifoTypeRadioButton.Checked = true;
            this.fifoTypeRadioButton.Location = new System.Drawing.Point(42, 35);
            this.fifoTypeRadioButton.Name = "fifoTypeRadioButton";
            this.fifoTypeRadioButton.Size = new System.Drawing.Size(152, 21);
            this.fifoTypeRadioButton.TabIndex = 0;
            this.fifoTypeRadioButton.TabStop = true;
            this.fifoTypeRadioButton.Text = "Por Anchura (FIFO)";
            this.fifoTypeRadioButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(673, 465);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(92, 30);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Buscar";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // aVaraRadioButton
            // 
            this.aVaraRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aVaraRadioButton.AutoSize = true;
            this.aVaraRadioButton.Location = new System.Drawing.Point(452, 35);
            this.aVaraRadioButton.Name = "aVaraRadioButton";
            this.aVaraRadioButton.Size = new System.Drawing.Size(70, 21);
            this.aVaraRadioButton.TabIndex = 2;
            this.aVaraRadioButton.Text = "A vara";
            this.aVaraRadioButton.UseVisualStyleBackColor = true;
            // 
            // aEstrellaRadioButton
            // 
            this.aEstrellaRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aEstrellaRadioButton.AutoSize = true;
            this.aEstrellaRadioButton.Location = new System.Drawing.Point(582, 35);
            this.aEstrellaRadioButton.Name = "aEstrellaRadioButton";
            this.aEstrellaRadioButton.Size = new System.Drawing.Size(117, 21);
            this.aEstrellaRadioButton.TabIndex = 3;
            this.aEstrellaRadioButton.Text = "A* (A Estrella)";
            this.aEstrellaRadioButton.UseVisualStyleBackColor = true;
            // 
            // nodeColumn
            // 
            this.nodeColumn.HeaderText = "Nodo";
            this.nodeColumn.Name = "nodeColumn";
            this.nodeColumn.Width = 60;
            // 
            // conecctionsColumn
            // 
            this.conecctionsColumn.HeaderText = "Conexiones";
            this.conecctionsColumn.Name = "conecctionsColumn";
            this.conecctionsColumn.Width = 150;
            // 
            // initialNodeColumn
            // 
            this.initialNodeColumn.HeaderText = "Nodo Inicial";
            this.initialNodeColumn.Name = "initialNodeColumn";
            this.initialNodeColumn.Width = 75;
            // 
            // finalNodeColumn
            // 
            this.finalNodeColumn.HeaderText = "Nodo Final";
            this.finalNodeColumn.Name = "finalNodeColumn";
            this.finalNodeColumn.Width = 75;
            // 
            // heuristicaColumn
            // 
            this.heuristicaColumn.HeaderText = "Heurística";
            this.heuristicaColumn.Name = "heuristicaColumn";
            this.heuristicaColumn.Width = 70;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 507);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grafoDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Búsqueda en Grafos";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grafoDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grafoDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton lifoTypeRadioButton;
        private System.Windows.Forms.RadioButton fifoTypeRadioButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.RadioButton aEstrellaRadioButton;
        private System.Windows.Forms.RadioButton aVaraRadioButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conecctionsColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn initialNodeColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn finalNodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heuristicaColumn;
    }
}

