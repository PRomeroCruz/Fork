namespace Mercadochio.Resources.FomulariosPersona
{
    partial class FormEditarCuentaPersona
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelTituloEditar = new System.Windows.Forms.Label();
            this.labelDomicilio = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDomicilio = new System.Windows.Forms.TextBox();
            this.buttonAceptarEdicion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(12, 162);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(87, 25);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelTituloEditar
            // 
            this.labelTituloEditar.AutoSize = true;
            this.labelTituloEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloEditar.Location = new System.Drawing.Point(12, 20);
            this.labelTituloEditar.Name = "labelTituloEditar";
            this.labelTituloEditar.Size = new System.Drawing.Size(321, 51);
            this.labelTituloEditar.TabIndex = 1;
            this.labelTituloEditar.Text = "Editar Persona";
            // 
            // labelDomicilio
            // 
            this.labelDomicilio.AutoSize = true;
            this.labelDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDomicilio.Location = new System.Drawing.Point(12, 219);
            this.labelDomicilio.Name = "labelDomicilio";
            this.labelDomicilio.Size = new System.Drawing.Size(96, 25);
            this.labelDomicilio.TabIndex = 2;
            this.labelDomicilio.Text = "Domicilio:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(144, 159);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(501, 30);
            this.textBoxNombre.TabIndex = 3;
            // 
            // textBoxDomicilio
            // 
            this.textBoxDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDomicilio.Location = new System.Drawing.Point(144, 216);
            this.textBoxDomicilio.Name = "textBoxDomicilio";
            this.textBoxDomicilio.Size = new System.Drawing.Size(501, 30);
            this.textBoxDomicilio.TabIndex = 4;
            // 
            // buttonAceptarEdicion
            // 
            this.buttonAceptarEdicion.Location = new System.Drawing.Point(541, 348);
            this.buttonAceptarEdicion.Name = "buttonAceptarEdicion";
            this.buttonAceptarEdicion.Size = new System.Drawing.Size(247, 90);
            this.buttonAceptarEdicion.TabIndex = 5;
            this.buttonAceptarEdicion.Text = "Aceptar";
            this.buttonAceptarEdicion.UseVisualStyleBackColor = true;
            this.buttonAceptarEdicion.Click += new System.EventHandler(this.buttonAceptarEdicion_Click);
            // 
            // FormEditarCuentaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAceptarEdicion);
            this.Controls.Add(this.textBoxDomicilio);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelDomicilio);
            this.Controls.Add(this.labelTituloEditar);
            this.Controls.Add(this.labelNombre);
            this.Name = "FormEditarCuentaPersona";
            this.Text = "FormEditarCuentaPersona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelTituloEditar;
        private System.Windows.Forms.Label labelDomicilio;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDomicilio;
        private System.Windows.Forms.Button buttonAceptarEdicion;
    }
}