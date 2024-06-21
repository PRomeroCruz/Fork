namespace Mercadochio.Resources.FormulariosEmpresa
{
    partial class FormEditarDatosEmpresa
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
            this.textBoxLocalizacionEmpresa = new System.Windows.Forms.TextBox();
            this.textBoxHorarioAperturaEmpresa = new System.Windows.Forms.TextBox();
            this.textBoxNombreempresa = new System.Windows.Forms.TextBox();
            this.labelLocalizaciónEmpresa = new System.Windows.Forms.Label();
            this.labelHorarioAperturaEmpresa = new System.Windows.Forms.Label();
            this.labelNombreEmpresa = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.buttonAceptarEditar = new System.Windows.Forms.Button();
            this.textBoxHorarioCierre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxLocalizacionEmpresa
            // 
            this.textBoxLocalizacionEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLocalizacionEmpresa.Location = new System.Drawing.Point(316, 319);
            this.textBoxLocalizacionEmpresa.Name = "textBoxLocalizacionEmpresa";
            this.textBoxLocalizacionEmpresa.Size = new System.Drawing.Size(472, 24);
            this.textBoxLocalizacionEmpresa.TabIndex = 29;
            // 
            // textBoxHorarioAperturaEmpresa
            // 
            this.textBoxHorarioAperturaEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHorarioAperturaEmpresa.Location = new System.Drawing.Point(316, 217);
            this.textBoxHorarioAperturaEmpresa.Name = "textBoxHorarioAperturaEmpresa";
            this.textBoxHorarioAperturaEmpresa.Size = new System.Drawing.Size(472, 24);
            this.textBoxHorarioAperturaEmpresa.TabIndex = 28;
            this.textBoxHorarioAperturaEmpresa.TextChanged += new System.EventHandler(this.textBoxHorarioEmpresa_TextChanged);
            // 
            // textBoxNombreempresa
            // 
            this.textBoxNombreempresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreempresa.Location = new System.Drawing.Point(316, 167);
            this.textBoxNombreempresa.Name = "textBoxNombreempresa";
            this.textBoxNombreempresa.Size = new System.Drawing.Size(472, 24);
            this.textBoxNombreempresa.TabIndex = 27;
            this.textBoxNombreempresa.TextChanged += new System.EventHandler(this.textBoxNombreempresa_TextChanged);
            // 
            // labelLocalizaciónEmpresa
            // 
            this.labelLocalizaciónEmpresa.AutoSize = true;
            this.labelLocalizaciónEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocalizaciónEmpresa.Location = new System.Drawing.Point(12, 322);
            this.labelLocalizaciónEmpresa.Name = "labelLocalizaciónEmpresa";
            this.labelLocalizaciónEmpresa.Size = new System.Drawing.Size(188, 18);
            this.labelLocalizaciónEmpresa.TabIndex = 26;
            this.labelLocalizaciónEmpresa.Text = "Localizacion de la empresa";
            // 
            // labelHorarioAperturaEmpresa
            // 
            this.labelHorarioAperturaEmpresa.AutoSize = true;
            this.labelHorarioAperturaEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHorarioAperturaEmpresa.Location = new System.Drawing.Point(12, 217);
            this.labelHorarioAperturaEmpresa.Name = "labelHorarioAperturaEmpresa";
            this.labelHorarioAperturaEmpresa.Size = new System.Drawing.Size(136, 18);
            this.labelHorarioAperturaEmpresa.TabIndex = 25;
            this.labelHorarioAperturaEmpresa.Text = "Horario de apertura";
            // 
            // labelNombreEmpresa
            // 
            this.labelNombreEmpresa.AutoSize = true;
            this.labelNombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreEmpresa.Location = new System.Drawing.Point(11, 167);
            this.labelNombreEmpresa.Name = "labelNombreEmpresa";
            this.labelNombreEmpresa.Size = new System.Drawing.Size(62, 18);
            this.labelNombreEmpresa.TabIndex = 24;
            this.labelNombreEmpresa.Text = "Nombre";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(15, 26);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(463, 42);
            this.labelTitulo.TabIndex = 30;
            this.labelTitulo.Text = "Editar datos de la empresa";
            // 
            // buttonAceptarEditar
            // 
            this.buttonAceptarEditar.Location = new System.Drawing.Point(614, 374);
            this.buttonAceptarEditar.Name = "buttonAceptarEditar";
            this.buttonAceptarEditar.Size = new System.Drawing.Size(174, 64);
            this.buttonAceptarEditar.TabIndex = 31;
            this.buttonAceptarEditar.Text = "Aceptar";
            this.buttonAceptarEditar.UseVisualStyleBackColor = true;
            this.buttonAceptarEditar.Click += new System.EventHandler(this.buttonAceptarEditar_Click);
            // 
            // textBoxHorarioCierre
            // 
            this.textBoxHorarioCierre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHorarioCierre.Location = new System.Drawing.Point(316, 269);
            this.textBoxHorarioCierre.Name = "textBoxHorarioCierre";
            this.textBoxHorarioCierre.Size = new System.Drawing.Size(472, 24);
            this.textBoxHorarioCierre.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "Horario de cierre";
            // 
            // FormEditarDatosEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxHorarioCierre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAceptarEditar);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.textBoxLocalizacionEmpresa);
            this.Controls.Add(this.textBoxHorarioAperturaEmpresa);
            this.Controls.Add(this.textBoxNombreempresa);
            this.Controls.Add(this.labelLocalizaciónEmpresa);
            this.Controls.Add(this.labelHorarioAperturaEmpresa);
            this.Controls.Add(this.labelNombreEmpresa);
            this.Name = "FormEditarDatosEmpresa";
            this.Text = "FormEditarDatosEmpresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLocalizacionEmpresa;
        private System.Windows.Forms.TextBox textBoxHorarioAperturaEmpresa;
        private System.Windows.Forms.TextBox textBoxNombreempresa;
        private System.Windows.Forms.Label labelLocalizaciónEmpresa;
        private System.Windows.Forms.Label labelHorarioAperturaEmpresa;
        private System.Windows.Forms.Label labelNombreEmpresa;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonAceptarEditar;
        private System.Windows.Forms.TextBox textBoxHorarioCierre;
        private System.Windows.Forms.Label label2;
    }
}