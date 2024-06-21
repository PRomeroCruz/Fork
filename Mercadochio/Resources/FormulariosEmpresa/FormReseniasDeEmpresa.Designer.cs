namespace Mercadochio.Resources.FormulariosEmpresa
{
    partial class FormReseniasDeEmpresa
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.dataGridViewValoracionesEmpresa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValoracionesEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(12, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(443, 42);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Reseñas de mi empresa";
            // 
            // dataGridViewValoracionesEmpresa
            // 
            this.dataGridViewValoracionesEmpresa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewValoracionesEmpresa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewValoracionesEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewValoracionesEmpresa.Location = new System.Drawing.Point(19, 101);
            this.dataGridViewValoracionesEmpresa.Name = "dataGridViewValoracionesEmpresa";
            this.dataGridViewValoracionesEmpresa.ReadOnly = true;
            this.dataGridViewValoracionesEmpresa.RowHeadersWidth = 51;
            this.dataGridViewValoracionesEmpresa.RowTemplate.Height = 24;
            this.dataGridViewValoracionesEmpresa.Size = new System.Drawing.Size(844, 390);
            this.dataGridViewValoracionesEmpresa.TabIndex = 1;
            // 
            // FormReseniasDeEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(967, 515);
            this.Controls.Add(this.dataGridViewValoracionesEmpresa);
            this.Controls.Add(this.labelTitulo);
            this.Name = "FormReseniasDeEmpresa";
            this.Text = "FormReseniasDeEmpresa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValoracionesEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.DataGridView dataGridViewValoracionesEmpresa;
    }
}