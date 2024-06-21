namespace Mercadochio.Resources.FormulariosEmpresa
{
    partial class FormSolicitudesPedido
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonMarcarComoRecibido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(12, 43);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(427, 36);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Tiene las siguientes solicitudes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(615, 349);
            this.dataGridView1.TabIndex = 1;
            // 
            // buttonMarcarComoRecibido
            // 
            this.buttonMarcarComoRecibido.Location = new System.Drawing.Point(744, 381);
            this.buttonMarcarComoRecibido.Name = "buttonMarcarComoRecibido";
            this.buttonMarcarComoRecibido.Size = new System.Drawing.Size(211, 100);
            this.buttonMarcarComoRecibido.TabIndex = 2;
            this.buttonMarcarComoRecibido.Text = "Marcar como recibido";
            this.buttonMarcarComoRecibido.UseVisualStyleBackColor = true;
            this.buttonMarcarComoRecibido.Click += new System.EventHandler(this.buttonMarcarComoRecibido_Click);
            // 
            // FormSolicitudesPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(967, 515);
            this.Controls.Add(this.buttonMarcarComoRecibido);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelTitulo);
            this.Name = "FormSolicitudesPedido";
            this.Text = "FormSolicitudesPedido";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonMarcarComoRecibido;
    }
}