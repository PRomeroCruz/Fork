namespace Mercadochio.Resources.FormulariosEmpresa
{
    partial class FormAniadirOchio
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
            this.empresaTableAdapter1 = new Mercadochio.InterfacesMercaochioDataSetTableAdapters.EmpresaTableAdapter();
            this.buttonAniadir = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelAlergenos = new System.Windows.Forms.Label();
            this.labelTamanio = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxAlergenos = new System.Windows.Forms.TextBox();
            this.textBoxTamanio = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // empresaTableAdapter1
            // 
            this.empresaTableAdapter1.ClearBeforeFill = true;
            // 
            // buttonAniadir
            // 
            this.buttonAniadir.Location = new System.Drawing.Point(571, 360);
            this.buttonAniadir.Name = "buttonAniadir";
            this.buttonAniadir.Size = new System.Drawing.Size(217, 78);
            this.buttonAniadir.TabIndex = 0;
            this.buttonAniadir.Text = "Añadir ochio";
            this.buttonAniadir.UseVisualStyleBackColor = true;
            this.buttonAniadir.Click += new System.EventHandler(this.buttonAniadir_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(337, 360);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(217, 78);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(31, 37);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(87, 25);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelAlergenos
            // 
            this.labelAlergenos.AutoSize = true;
            this.labelAlergenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlergenos.Location = new System.Drawing.Point(31, 89);
            this.labelAlergenos.Name = "labelAlergenos";
            this.labelAlergenos.Size = new System.Drawing.Size(101, 25);
            this.labelAlergenos.TabIndex = 3;
            this.labelAlergenos.Text = "Alérgenos";
            // 
            // labelTamanio
            // 
            this.labelTamanio.AutoSize = true;
            this.labelTamanio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTamanio.Location = new System.Drawing.Point(31, 151);
            this.labelTamanio.Name = "labelTamanio";
            this.labelTamanio.Size = new System.Drawing.Size(91, 25);
            this.labelTamanio.TabIndex = 4;
            this.labelTamanio.Text = "Tamaño:";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.Location = new System.Drawing.Point(31, 202);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(73, 25);
            this.labelPrecio.TabIndex = 5;
            this.labelPrecio.Text = "Precio:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(179, 37);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(343, 30);
            this.textBoxNombre.TabIndex = 6;
            // 
            // textBoxAlergenos
            // 
            this.textBoxAlergenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAlergenos.Location = new System.Drawing.Point(179, 86);
            this.textBoxAlergenos.Name = "textBoxAlergenos";
            this.textBoxAlergenos.Size = new System.Drawing.Size(343, 30);
            this.textBoxAlergenos.TabIndex = 7;
            // 
            // textBoxTamanio
            // 
            this.textBoxTamanio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTamanio.Location = new System.Drawing.Point(179, 148);
            this.textBoxTamanio.Name = "textBoxTamanio";
            this.textBoxTamanio.Size = new System.Drawing.Size(343, 30);
            this.textBoxTamanio.TabIndex = 8;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrecio.Location = new System.Drawing.Point(179, 202);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(343, 30);
            this.textBoxPrecio.TabIndex = 9;
            // 
            // FormAniadirOchio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.textBoxTamanio);
            this.Controls.Add(this.textBoxAlergenos);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelTamanio);
            this.Controls.Add(this.labelAlergenos);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAniadir);
            this.Name = "FormAniadirOchio";
            this.Text = "FormAniadirOchio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InterfacesMercaochioDataSetTableAdapters.EmpresaTableAdapter empresaTableAdapter1;
        private System.Windows.Forms.Button buttonAniadir;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelAlergenos;
        private System.Windows.Forms.Label labelTamanio;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxAlergenos;
        private System.Windows.Forms.TextBox textBoxTamanio;
        private System.Windows.Forms.TextBox textBoxPrecio;
    }
}