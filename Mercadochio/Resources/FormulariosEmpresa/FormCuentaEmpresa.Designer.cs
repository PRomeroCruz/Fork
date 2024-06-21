namespace Mercadochio.Resources.FormulariosEmpresa
{
    partial class FormCuentaEmpresa
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
            this.labelNombreEmpresa = new System.Windows.Forms.Label();
            this.labelCorreoEmpresa = new System.Windows.Forms.Label();
            this.labelHoraApertura = new System.Windows.Forms.Label();
            this.labelDomicilio = new System.Windows.Forms.Label();
            this.richTextBoxDescripcion = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAñadirDescripcion = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.controlHora1 = new BibliotecaControlesMercadochio.ControlHora();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombreEmpresa
            // 
            this.labelNombreEmpresa.AutoSize = true;
            this.labelNombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreEmpresa.Location = new System.Drawing.Point(12, 27);
            this.labelNombreEmpresa.Name = "labelNombreEmpresa";
            this.labelNombreEmpresa.Size = new System.Drawing.Size(396, 42);
            this.labelNombreEmpresa.TabIndex = 0;
            this.labelNombreEmpresa.Text = "Nombre de la empresa";
            // 
            // labelCorreoEmpresa
            // 
            this.labelCorreoEmpresa.AutoSize = true;
            this.labelCorreoEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreoEmpresa.Location = new System.Drawing.Point(14, 87);
            this.labelCorreoEmpresa.Name = "labelCorreoEmpresa";
            this.labelCorreoEmpresa.Size = new System.Drawing.Size(248, 29);
            this.labelCorreoEmpresa.TabIndex = 1;
            this.labelCorreoEmpresa.Text = "Correo de la empresa";
            // 
            // labelHoraApertura
            // 
            this.labelHoraApertura.AutoSize = true;
            this.labelHoraApertura.Location = new System.Drawing.Point(16, 139);
            this.labelHoraApertura.Name = "labelHoraApertura";
            this.labelHoraApertura.Size = new System.Drawing.Size(120, 16);
            this.labelHoraApertura.TabIndex = 2;
            this.labelHoraApertura.Text = "De HORA a HORA";
            // 
            // labelDomicilio
            // 
            this.labelDomicilio.AutoSize = true;
            this.labelDomicilio.Location = new System.Drawing.Point(16, 180);
            this.labelDomicilio.Name = "labelDomicilio";
            this.labelDomicilio.Size = new System.Drawing.Size(63, 16);
            this.labelDomicilio.TabIndex = 3;
            this.labelDomicilio.Text = "Domicilio";
            // 
            // richTextBoxDescripcion
            // 
            this.richTextBoxDescripcion.Location = new System.Drawing.Point(19, 282);
            this.richTextBoxDescripcion.Name = "richTextBoxDescripcion";
            this.richTextBoxDescripcion.Size = new System.Drawing.Size(413, 221);
            this.richTextBoxDescripcion.TabIndex = 4;
            this.richTextBoxDescripcion.Text = "Si ves esto, es porque no tienes una descripción, Añade una !!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mercadochio.Properties.Resources.Empresa;
            this.pictureBox1.Location = new System.Drawing.Point(731, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAñadirDescripcion
            // 
            this.buttonAñadirDescripcion.Location = new System.Drawing.Point(463, 409);
            this.buttonAñadirDescripcion.Name = "buttonAñadirDescripcion";
            this.buttonAñadirDescripcion.Size = new System.Drawing.Size(211, 94);
            this.buttonAñadirDescripcion.TabIndex = 6;
            this.buttonAñadirDescripcion.Text = "Añadir descripcion de la caja";
            this.buttonAñadirDescripcion.UseVisualStyleBackColor = true;
            this.buttonAñadirDescripcion.Click += new System.EventHandler(this.buttonAñadirDescripcion_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(744, 409);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(211, 94);
            this.buttonEditar.TabIndex = 7;
            this.buttonEditar.Text = "Editar Datos";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // controlHora1
            // 
            this.controlHora1.BackColor = System.Drawing.Color.Transparent;
            this.controlHora1.Location = new System.Drawing.Point(0, 199);
            this.controlHora1.Name = "controlHora1";
            this.controlHora1.Size = new System.Drawing.Size(349, 80);
            this.controlHora1.TabIndex = 8;
            // 
            // FormCuentaEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(967, 515);
            this.Controls.Add(this.controlHora1);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonAñadirDescripcion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBoxDescripcion);
            this.Controls.Add(this.labelDomicilio);
            this.Controls.Add(this.labelHoraApertura);
            this.Controls.Add(this.labelCorreoEmpresa);
            this.Controls.Add(this.labelNombreEmpresa);
            this.Name = "FormCuentaEmpresa";
            this.Text = "FormCuentaEmpresa";
            this.Load += new System.EventHandler(this.FormCuentaEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombreEmpresa;
        private System.Windows.Forms.Label labelCorreoEmpresa;
        private System.Windows.Forms.Label labelHoraApertura;
        private System.Windows.Forms.Label labelDomicilio;
        private System.Windows.Forms.RichTextBox richTextBoxDescripcion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAñadirDescripcion;
        private System.Windows.Forms.Button buttonEditar;
        private BibliotecaControlesMercadochio.ControlHora controlHora1;
    }
}