namespace Mercadochio.Resources.FomulariosPersona
{
    partial class FormCuentaPersona
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.labelDomicilio = new System.Windows.Forms.Label();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.labelTotalResenias = new System.Windows.Forms.Label();
            this.controlHora1 = new BibliotecaControlesMercadochio.ControlHora();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mercadochio.Properties.Resources.Persona;
            this.pictureBox1.Location = new System.Drawing.Point(705, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(12, 24);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(150, 42);
            this.labelNombre.TabIndex = 7;
            this.labelNombre.Text = "Nombre";
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreo.Location = new System.Drawing.Point(12, 90);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(173, 25);
            this.labelCorreo.TabIndex = 8;
            this.labelCorreo.Text = "Correo Electronico";
            // 
            // labelDomicilio
            // 
            this.labelDomicilio.AutoSize = true;
            this.labelDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDomicilio.Location = new System.Drawing.Point(15, 143);
            this.labelDomicilio.Name = "labelDomicilio";
            this.labelDomicilio.Size = new System.Drawing.Size(79, 20);
            this.labelDomicilio.TabIndex = 9;
            this.labelDomicilio.Text = "Domicilio";
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(705, 410);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(250, 93);
            this.buttonEditar.TabIndex = 10;
            this.buttonEditar.Text = "Editar Datos";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // labelTotalResenias
            // 
            this.labelTotalResenias.AutoSize = true;
            this.labelTotalResenias.Location = new System.Drawing.Point(16, 195);
            this.labelTotalResenias.Name = "labelTotalResenias";
            this.labelTotalResenias.Size = new System.Drawing.Size(199, 16);
            this.labelTotalResenias.TabIndex = 11;
            this.labelTotalResenias.Text = "Has hecho un total de X reseñas";
            // 
            // controlHora1
            // 
            this.controlHora1.BackColor = System.Drawing.Color.Transparent;
            this.controlHora1.Location = new System.Drawing.Point(-5, 453);
            this.controlHora1.Name = "controlHora1";
            this.controlHora1.Size = new System.Drawing.Size(349, 80);
            this.controlHora1.TabIndex = 12;
            // 
            // FormCuentaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(967, 515);
            this.Controls.Add(this.controlHora1);
            this.Controls.Add(this.labelTotalResenias);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.labelDomicilio);
            this.Controls.Add(this.labelCorreo);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormCuentaPersona";
            this.Text = "FormCuentaPersona";
            this.Load += new System.EventHandler(this.FormCuentaPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.Label labelDomicilio;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Label labelTotalResenias;
        private BibliotecaControlesMercadochio.ControlHora controlHora1;
    }
}