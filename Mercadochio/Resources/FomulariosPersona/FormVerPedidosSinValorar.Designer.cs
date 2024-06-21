namespace Mercadochio.Resources.FomulariosPersona
{
    partial class FormVerPedidosSinValorar
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
            this.dataGridViewPedidos = new System.Windows.Forms.DataGridView();
            this.trackBarValoracion = new System.Windows.Forms.TrackBar();
            this.labelNumeroValoracion = new System.Windows.Forms.Label();
            this.buttonAniadirValoracion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarValoracion)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(12, 20);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(609, 42);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Estos son sus pedidos sin valorar";
            // 
            // dataGridViewPedidos
            // 
            this.dataGridViewPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidos.Location = new System.Drawing.Point(19, 225);
            this.dataGridViewPedidos.Name = "dataGridViewPedidos";
            this.dataGridViewPedidos.ReadOnly = true;
            this.dataGridViewPedidos.RowHeadersWidth = 51;
            this.dataGridViewPedidos.RowTemplate.Height = 24;
            this.dataGridViewPedidos.Size = new System.Drawing.Size(591, 268);
            this.dataGridViewPedidos.TabIndex = 1;
            // 
            // trackBar1
            // 
            this.trackBarValoracion.Location = new System.Drawing.Point(616, 263);
            this.trackBarValoracion.Name = "trackBar1";
            this.trackBarValoracion.Size = new System.Drawing.Size(326, 56);
            this.trackBarValoracion.TabIndex = 2;
            this.trackBarValoracion.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // labelNumeroValoracion
            // 
            this.labelNumeroValoracion.AutoSize = true;
            this.labelNumeroValoracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroValoracion.Location = new System.Drawing.Point(768, 224);
            this.labelNumeroValoracion.Name = "labelNumeroValoracion";
            this.labelNumeroValoracion.Size = new System.Drawing.Size(32, 36);
            this.labelNumeroValoracion.TabIndex = 3;
            this.labelNumeroValoracion.Text = "0";
            // 
            // buttonAniadirValoracion
            // 
            this.buttonAniadirValoracion.Location = new System.Drawing.Point(666, 383);
            this.buttonAniadirValoracion.Name = "buttonAniadirValoracion";
            this.buttonAniadirValoracion.Size = new System.Drawing.Size(276, 110);
            this.buttonAniadirValoracion.TabIndex = 4;
            this.buttonAniadirValoracion.Text = "Añadir la valoracion a la fila seleccionada";
            this.buttonAniadirValoracion.UseVisualStyleBackColor = true;
            this.buttonAniadirValoracion.Click += new System.EventHandler(this.buttonAniadirValoracion_Click);
            // 
            // FormVerPedidosSinValorar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(967, 515);
            this.Controls.Add(this.buttonAniadirValoracion);
            this.Controls.Add(this.labelNumeroValoracion);
            this.Controls.Add(this.trackBarValoracion);
            this.Controls.Add(this.dataGridViewPedidos);
            this.Controls.Add(this.labelTitulo);
            this.Name = "FormVerPedidosSinValorar";
            this.Text = "FormVerPedidosSinValorar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarValoracion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.DataGridView dataGridViewPedidos;
        private System.Windows.Forms.TrackBar trackBarValoracion;
        private System.Windows.Forms.Label labelNumeroValoracion;
        private System.Windows.Forms.Button buttonAniadirValoracion;
    }
}