namespace Mercadochio
{
    partial class FormularioEmpresa
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
            this.buttonRegistrarse = new System.Windows.Forms.Button();
            this.buttonIniciarSesion = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.pictureBoxPersona = new System.Windows.Forms.PictureBox();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.SkyBlue;
            this.panelSuperior.Controls.Add(this.label1);
            this.panelSuperior.Controls.Add(this.buttonCerrar);
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1182, 41);
            this.panelSuperior.TabIndex = 5;
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
            this.labelTitulo.Location = new System.Drawing.Point(482, 79);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(258, 54);
            this.labelTitulo.TabIndex = 6;
            this.labelTitulo.Text = "EMPRESA";
            this.labelTitulo.Click += new System.EventHandler(this.labelTitulo_Click);
            // 
            // buttonRegistrarse
            // 
            this.buttonRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarse.Location = new System.Drawing.Point(831, 464);
            this.buttonRegistrarse.Name = "buttonRegistrarse";
            this.buttonRegistrarse.Size = new System.Drawing.Size(329, 112);
            this.buttonRegistrarse.TabIndex = 7;
            this.buttonRegistrarse.Text = "Registrarse";
            this.buttonRegistrarse.UseVisualStyleBackColor = true;
            this.buttonRegistrarse.Click += new System.EventHandler(this.buttonRegistrarse_Click);
            // 
            // buttonIniciarSesion
            // 
            this.buttonIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIniciarSesion.Location = new System.Drawing.Point(831, 308);
            this.buttonIniciarSesion.Name = "buttonIniciarSesion";
            this.buttonIniciarSesion.Size = new System.Drawing.Size(329, 112);
            this.buttonIniciarSesion.TabIndex = 8;
            this.buttonIniciarSesion.Text = "Iniciar Sesion";
            this.buttonIniciarSesion.UseVisualStyleBackColor = true;
            this.buttonIniciarSesion.Click += new System.EventHandler(this.buttonIniciarSesion_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolver.Location = new System.Drawing.Point(16, 464);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(329, 112);
            this.buttonVolver.TabIndex = 9;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // pictureBoxPersona
            // 
            this.pictureBoxPersona.Image = global::Mercadochio.Properties.Resources.Empresa;
            this.pictureBoxPersona.Location = new System.Drawing.Point(12, 57);
            this.pictureBoxPersona.Name = "pictureBoxPersona";
            this.pictureBoxPersona.Size = new System.Drawing.Size(304, 273);
            this.pictureBoxPersona.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPersona.TabIndex = 15;
            this.pictureBoxPersona.TabStop = false;
            // 
            // FormularioEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.pictureBoxPersona);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonIniciarSesion);
            this.Controls.Add(this.buttonRegistrarse);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.panelSuperior);
            this.Name = "FormularioEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormularioEmpresa_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPersona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonRegistrarse;
        private System.Windows.Forms.Button buttonIniciarSesion;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.PictureBox pictureBoxPersona;
    }
}