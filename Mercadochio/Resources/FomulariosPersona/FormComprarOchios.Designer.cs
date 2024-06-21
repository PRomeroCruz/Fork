namespace Mercadochio.Resources.FomulariosPersona
{
    partial class FormComprarOchios
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
            this.dataGridViewEmpresas = new System.Windows.Forms.DataGridView();
            this.labelOrdenar = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpresas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiendas de Ochios disponibles";
            // 
            // dataGridViewEmpresas
            // 
            this.dataGridViewEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpresas.Location = new System.Drawing.Point(20, 110);
            this.dataGridViewEmpresas.Name = "dataGridViewEmpresas";
            this.dataGridViewEmpresas.RowHeadersWidth = 51;
            this.dataGridViewEmpresas.RowTemplate.Height = 24;
            this.dataGridViewEmpresas.Size = new System.Drawing.Size(856, 235);
            this.dataGridViewEmpresas.TabIndex = 1;
            this.dataGridViewEmpresas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmpresas_CellDoubleClick);
            // 
            // labelOrdenar
            // 
            this.labelOrdenar.AutoSize = true;
            this.labelOrdenar.Location = new System.Drawing.Point(22, 366);
            this.labelOrdenar.Name = "labelOrdenar";
            this.labelOrdenar.Size = new System.Drawing.Size(82, 16);
            this.labelOrdenar.TabIndex = 2;
            this.labelOrdenar.Text = "Ordenar por:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nombre",
            "Valoracion",
            "Correo electronico"});
            this.comboBox1.Location = new System.Drawing.Point(120, 363);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FormComprarOchios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(967, 515);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelOrdenar);
            this.Controls.Add(this.dataGridViewEmpresas);
            this.Controls.Add(this.label1);
            this.Name = "FormComprarOchios";
            this.Text = "FormComprarOchios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpresas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewEmpresas;
        private System.Windows.Forms.Label labelOrdenar;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}