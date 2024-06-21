namespace Mercadochio.Resources.FomulariosPersona
{
    partial class FormVerMisValoraciones
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
            this.dataGridViewValoracionesPersona = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValoracionesPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(12, 30);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(282, 38);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Mis Valoraciones";
            // 
            // dataGridViewValoracionesPersona
            // 
            this.dataGridViewValoracionesPersona.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewValoracionesPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewValoracionesPersona.Location = new System.Drawing.Point(19, 121);
            this.dataGridViewValoracionesPersona.Name = "dataGridViewValoracionesPersona";
            this.dataGridViewValoracionesPersona.ReadOnly = true;
            this.dataGridViewValoracionesPersona.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridViewValoracionesPersona.RowTemplate.Height = 24;
            this.dataGridViewValoracionesPersona.Size = new System.Drawing.Size(837, 364);
            this.dataGridViewValoracionesPersona.TabIndex = 1;
            // 
            // FormVerMisValoraciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(967, 515);
            this.Controls.Add(this.dataGridViewValoracionesPersona);
            this.Controls.Add(this.labelTitulo);
            this.Name = "FormVerMisValoraciones";
            this.Text = "FormVerMisValoraciones";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValoracionesPersona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.DataGridView dataGridViewValoracionesPersona;
    }
}