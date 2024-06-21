namespace Mercadochio
{
    partial class FormRegistrarseEmpresa
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
            this.labelNombreEmpresa = new System.Windows.Forms.Label();
            this.labelCorreoEmpresa = new System.Windows.Forms.Label();
            this.labelContraseniaEmpresa = new System.Windows.Forms.Label();
            this.labelCodigoSecretoEmpresa = new System.Windows.Forms.Label();
            this.labelHorarioEmpresa = new System.Windows.Forms.Label();
            this.labelLocalizaciónEmpresa = new System.Windows.Forms.Label();
            this.textBoxNombreempresa = new System.Windows.Forms.TextBox();
            this.textBoxCorreoEmpresa = new System.Windows.Forms.TextBox();
            this.textBoxCodigoSecretoEmpresa = new System.Windows.Forms.TextBox();
            this.textBoxHorarioEmpresa = new System.Windows.Forms.TextBox();
            this.textBoxLocalizacionEmpresa = new System.Windows.Forms.TextBox();
            this.buttonRegistrarse = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxContrasenia = new System.Windows.Forms.TextBox();
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
            this.panelSuperior.TabIndex = 10;
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
            this.labelTitulo.Location = new System.Drawing.Point(274, 57);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(648, 54);
            this.labelTitulo.TabIndex = 11;
            this.labelTitulo.Text = "REGISTRARSE - EMPRESA";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitulo.Click += new System.EventHandler(this.labelTitulo_Click);
            // 
            // labelNombreEmpresa
            // 
            this.labelNombreEmpresa.AutoSize = true;
            this.labelNombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreEmpresa.Location = new System.Drawing.Point(43, 203);
            this.labelNombreEmpresa.Name = "labelNombreEmpresa";
            this.labelNombreEmpresa.Size = new System.Drawing.Size(322, 25);
            this.labelNombreEmpresa.TabIndex = 12;
            this.labelNombreEmpresa.Text = "Introduzca el nombre de la empresa";
            // 
            // labelCorreoEmpresa
            // 
            this.labelCorreoEmpresa.AutoSize = true;
            this.labelCorreoEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreoEmpresa.Location = new System.Drawing.Point(44, 263);
            this.labelCorreoEmpresa.Name = "labelCorreoEmpresa";
            this.labelCorreoEmpresa.Size = new System.Drawing.Size(291, 25);
            this.labelCorreoEmpresa.TabIndex = 13;
            this.labelCorreoEmpresa.Text = "Introduzca el correo de empresa";
            // 
            // labelContraseniaEmpresa
            // 
            this.labelContraseniaEmpresa.AutoSize = true;
            this.labelContraseniaEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseniaEmpresa.Location = new System.Drawing.Point(43, 323);
            this.labelContraseniaEmpresa.Name = "labelContraseniaEmpresa";
            this.labelContraseniaEmpresa.Size = new System.Drawing.Size(404, 25);
            this.labelContraseniaEmpresa.TabIndex = 14;
            this.labelContraseniaEmpresa.Text = "Introduzca una contraseña para iniciar sesion";
            // 
            // labelCodigoSecretoEmpresa
            // 
            this.labelCodigoSecretoEmpresa.AutoSize = true;
            this.labelCodigoSecretoEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoSecretoEmpresa.Location = new System.Drawing.Point(44, 383);
            this.labelCodigoSecretoEmpresa.Name = "labelCodigoSecretoEmpresa";
            this.labelCodigoSecretoEmpresa.Size = new System.Drawing.Size(262, 25);
            this.labelCodigoSecretoEmpresa.TabIndex = 15;
            this.labelCodigoSecretoEmpresa.Text = "Introduzca un código secreto";
            // 
            // labelHorarioEmpresa
            // 
            this.labelHorarioEmpresa.AutoSize = true;
            this.labelHorarioEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHorarioEmpresa.Location = new System.Drawing.Point(44, 443);
            this.labelHorarioEmpresa.Name = "labelHorarioEmpresa";
            this.labelHorarioEmpresa.Size = new System.Drawing.Size(360, 25);
            this.labelHorarioEmpresa.TabIndex = 16;
            this.labelHorarioEmpresa.Text = "Introduzca el horario de apertura y cierre";
            // 
            // labelLocalizaciónEmpresa
            // 
            this.labelLocalizaciónEmpresa.AutoSize = true;
            this.labelLocalizaciónEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocalizaciónEmpresa.Location = new System.Drawing.Point(44, 503);
            this.labelLocalizaciónEmpresa.Name = "labelLocalizaciónEmpresa";
            this.labelLocalizaciónEmpresa.Size = new System.Drawing.Size(357, 25);
            this.labelLocalizaciónEmpresa.TabIndex = 17;
            this.labelLocalizaciónEmpresa.Text = "Introduzca la localización de la empresa";
            // 
            // textBoxNombreempresa
            // 
            this.textBoxNombreempresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreempresa.Location = new System.Drawing.Point(493, 198);
            this.textBoxNombreempresa.Name = "textBoxNombreempresa";
            this.textBoxNombreempresa.Size = new System.Drawing.Size(403, 30);
            this.textBoxNombreempresa.TabIndex = 18;
            // 
            // textBoxCorreoEmpresa
            // 
            this.textBoxCorreoEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCorreoEmpresa.Location = new System.Drawing.Point(493, 258);
            this.textBoxCorreoEmpresa.Name = "textBoxCorreoEmpresa";
            this.textBoxCorreoEmpresa.Size = new System.Drawing.Size(403, 30);
            this.textBoxCorreoEmpresa.TabIndex = 19;
            // 
            // textBoxCodigoSecretoEmpresa
            // 
            this.textBoxCodigoSecretoEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigoSecretoEmpresa.Location = new System.Drawing.Point(493, 378);
            this.textBoxCodigoSecretoEmpresa.Name = "textBoxCodigoSecretoEmpresa";
            this.textBoxCodigoSecretoEmpresa.Size = new System.Drawing.Size(403, 30);
            this.textBoxCodigoSecretoEmpresa.TabIndex = 21;
            // 
            // textBoxHorarioEmpresa
            // 
            this.textBoxHorarioEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHorarioEmpresa.Location = new System.Drawing.Point(493, 438);
            this.textBoxHorarioEmpresa.Name = "textBoxHorarioEmpresa";
            this.textBoxHorarioEmpresa.Size = new System.Drawing.Size(403, 30);
            this.textBoxHorarioEmpresa.TabIndex = 22;
            // 
            // textBoxLocalizacionEmpresa
            // 
            this.textBoxLocalizacionEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLocalizacionEmpresa.Location = new System.Drawing.Point(493, 498);
            this.textBoxLocalizacionEmpresa.Name = "textBoxLocalizacionEmpresa";
            this.textBoxLocalizacionEmpresa.Size = new System.Drawing.Size(403, 30);
            this.textBoxLocalizacionEmpresa.TabIndex = 23;
            // 
            // buttonRegistrarse
            // 
            this.buttonRegistrarse.Location = new System.Drawing.Point(970, 198);
            this.buttonRegistrarse.Name = "buttonRegistrarse";
            this.buttonRegistrarse.Size = new System.Drawing.Size(183, 113);
            this.buttonRegistrarse.TabIndex = 24;
            this.buttonRegistrarse.Text = "Registrarse";
            this.buttonRegistrarse.UseVisualStyleBackColor = true;
            this.buttonRegistrarse.Click += new System.EventHandler(this.buttonRegistrarse_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(970, 415);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(183, 113);
            this.buttonCancelar.TabIndex = 25;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textBoxContrasenia
            // 
            this.textBoxContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContrasenia.Location = new System.Drawing.Point(493, 318);
            this.textBoxContrasenia.Name = "textBoxContrasenia";
            this.textBoxContrasenia.Size = new System.Drawing.Size(403, 30);
            this.textBoxContrasenia.TabIndex = 26;
            // 
            // FormRegistrarseEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.textBoxContrasenia);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonRegistrarse);
            this.Controls.Add(this.textBoxLocalizacionEmpresa);
            this.Controls.Add(this.textBoxHorarioEmpresa);
            this.Controls.Add(this.textBoxCodigoSecretoEmpresa);
            this.Controls.Add(this.textBoxCorreoEmpresa);
            this.Controls.Add(this.textBoxNombreempresa);
            this.Controls.Add(this.labelLocalizaciónEmpresa);
            this.Controls.Add(this.labelHorarioEmpresa);
            this.Controls.Add(this.labelCodigoSecretoEmpresa);
            this.Controls.Add(this.labelContraseniaEmpresa);
            this.Controls.Add(this.labelCorreoEmpresa);
            this.Controls.Add(this.labelNombreEmpresa);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.panelSuperior);
            this.Name = "FormRegistrarseEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegistrarseEmpresa";
            this.Load += new System.EventHandler(this.FormRegistrarseEmpresa_Load);
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
        private System.Windows.Forms.Label labelNombreEmpresa;
        private System.Windows.Forms.Label labelCorreoEmpresa;
        private System.Windows.Forms.Label labelContraseniaEmpresa;
        private System.Windows.Forms.Label labelCodigoSecretoEmpresa;
        private System.Windows.Forms.Label labelHorarioEmpresa;
        private System.Windows.Forms.Label labelLocalizaciónEmpresa;
        private System.Windows.Forms.TextBox textBoxNombreempresa;
        private System.Windows.Forms.TextBox textBoxCorreoEmpresa;
        private System.Windows.Forms.TextBox textBoxCodigoSecretoEmpresa;
        private System.Windows.Forms.TextBox textBoxHorarioEmpresa;
        private System.Windows.Forms.TextBox textBoxLocalizacionEmpresa;
        private System.Windows.Forms.Button buttonRegistrarse;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBoxContrasenia;
    }
}