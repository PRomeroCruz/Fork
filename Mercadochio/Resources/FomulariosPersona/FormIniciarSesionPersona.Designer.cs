namespace Mercadochio
{
    partial class FormIniciarSesionPersona
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
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textBoxContraseniaPersona = new System.Windows.Forms.TextBox();
            this.textBoxCorreoPersona = new System.Windows.Forms.TextBox();
            this.labelContraseniaPersona = new System.Windows.Forms.Label();
            this.labelNombrePersona = new System.Windows.Forms.Label();
            this.buttonIniciarSesion = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.panelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.SkyBlue;
            this.panelSuperior.Controls.Add(this.label1);
            this.panelSuperior.Controls.Add(this.buttonCerrar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1182, 41);
            this.panelSuperior.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mercadochio - Tu mercado online de ochios";
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.BackColor = System.Drawing.Color.IndianRed;
            this.buttonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrar.Location = new System.Drawing.Point(1145, 5);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(30, 30);
            this.buttonCerrar.TabIndex = 0;
            this.buttonCerrar.Text = "X";
            this.buttonCerrar.UseVisualStyleBackColor = false;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(274, 73);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(677, 54);
            this.labelTitulo.TabIndex = 41;
            this.labelTitulo.Text = "INICIAR SESION - PERSONA";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxContraseniaPersona
            // 
            this.textBoxContraseniaPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContraseniaPersona.Location = new System.Drawing.Point(615, 348);
            this.textBoxContraseniaPersona.Name = "textBoxContraseniaPersona";
            this.textBoxContraseniaPersona.Size = new System.Drawing.Size(403, 30);
            this.textBoxContraseniaPersona.TabIndex = 45;
            // 
            // textBoxCorreoPersona
            // 
            this.textBoxCorreoPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCorreoPersona.Location = new System.Drawing.Point(615, 224);
            this.textBoxCorreoPersona.Name = "textBoxCorreoPersona";
            this.textBoxCorreoPersona.Size = new System.Drawing.Size(403, 30);
            this.textBoxCorreoPersona.TabIndex = 44;
            // 
            // labelContraseniaPersona
            // 
            this.labelContraseniaPersona.AutoSize = true;
            this.labelContraseniaPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseniaPersona.Location = new System.Drawing.Point(165, 353);
            this.labelContraseniaPersona.Name = "labelContraseniaPersona";
            this.labelContraseniaPersona.Size = new System.Drawing.Size(225, 25);
            this.labelContraseniaPersona.TabIndex = 43;
            this.labelContraseniaPersona.Text = "Introduzca la contraseña";
            // 
            // labelNombrePersona
            // 
            this.labelNombrePersona.AutoSize = true;
            this.labelNombrePersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombrePersona.Location = new System.Drawing.Point(165, 229);
            this.labelNombrePersona.Name = "labelNombrePersona";
            this.labelNombrePersona.Size = new System.Drawing.Size(189, 25);
            this.labelNombrePersona.TabIndex = 42;
            this.labelNombrePersona.Text = "Introduzca su correo";
            // 
            // buttonIniciarSesion
            // 
            this.buttonIniciarSesion.Location = new System.Drawing.Point(170, 469);
            this.buttonIniciarSesion.Name = "buttonIniciarSesion";
            this.buttonIniciarSesion.Size = new System.Drawing.Size(377, 93);
            this.buttonIniciarSesion.TabIndex = 46;
            this.buttonIniciarSesion.Text = "Iniciar Sesion";
            this.buttonIniciarSesion.UseVisualStyleBackColor = true;
            this.buttonIniciarSesion.Click += new System.EventHandler(this.buttonRegistrarse_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(641, 469);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(377, 93);
            this.buttonCancelar.TabIndex = 47;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FormIniciarSesionPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonIniciarSesion);
            this.Controls.Add(this.textBoxContraseniaPersona);
            this.Controls.Add(this.textBoxCorreoPersona);
            this.Controls.Add(this.labelContraseniaPersona);
            this.Controls.Add(this.labelNombrePersona);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.panelSuperior);
            this.Name = "FormIniciarSesionPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormIniciarSesion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormIniciarSesion_FormClosing);
            this.Load += new System.EventHandler(this.FormIniciarSesionPersona_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox textBoxContraseniaPersona;
        private System.Windows.Forms.TextBox textBoxCorreoPersona;
        private System.Windows.Forms.Label labelContraseniaPersona;
        private System.Windows.Forms.Label labelNombrePersona;
        private System.Windows.Forms.Button buttonIniciarSesion;
        private System.Windows.Forms.Button buttonCancelar;
    }
}