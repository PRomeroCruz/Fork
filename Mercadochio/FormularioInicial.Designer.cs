namespace Mercadochio
{
    partial class FormularioInicial
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelEslogan = new System.Windows.Forms.Label();
            this.buttonEmpresa = new System.Windows.Forms.Button();
            this.buttonPersona = new System.Windows.Forms.Button();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.panelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.Transparent;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(372, 133);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(447, 99);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Mercadochio";
            // 
            // labelEslogan
            // 
            this.labelEslogan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelEslogan.AutoSize = true;
            this.labelEslogan.BackColor = System.Drawing.Color.Transparent;
            this.labelEslogan.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEslogan.Location = new System.Drawing.Point(398, 232);
            this.labelEslogan.Name = "labelEslogan";
            this.labelEslogan.Size = new System.Drawing.Size(396, 33);
            this.labelEslogan.TabIndex = 1;
            this.labelEslogan.Text = "Porque con ochios, la vida es mejor";
            this.labelEslogan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelEslogan.Click += new System.EventHandler(this.labelEslogan_Click);
            // 
            // buttonEmpresa
            // 
            this.buttonEmpresa.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpresa.Location = new System.Drawing.Point(210, 357);
            this.buttonEmpresa.Name = "buttonEmpresa";
            this.buttonEmpresa.Size = new System.Drawing.Size(300, 100);
            this.buttonEmpresa.TabIndex = 2;
            this.buttonEmpresa.Text = "Soy una empresa";
            this.buttonEmpresa.UseVisualStyleBackColor = false;
            this.buttonEmpresa.Click += new System.EventHandler(this.buttonEmpresa_Click_1);
            // 
            // buttonPersona
            // 
            this.buttonPersona.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPersona.Location = new System.Drawing.Point(682, 357);
            this.buttonPersona.Name = "buttonPersona";
            this.buttonPersona.Size = new System.Drawing.Size(300, 100);
            this.buttonPersona.TabIndex = 3;
            this.buttonPersona.Text = "Soy una persona";
            this.buttonPersona.UseVisualStyleBackColor = false;
            this.buttonPersona.Click += new System.EventHandler(this.buttonPersona_Click);
            // 
            // panelSuperior
            // 
            this.panelSuperior.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelSuperior.BackColor = System.Drawing.Color.SkyBlue;
            this.panelSuperior.Controls.Add(this.label1);
            this.panelSuperior.Controls.Add(this.buttonCerrar);
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1183, 41);
            this.panelSuperior.TabIndex = 4;
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
            // FormularioInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mercadochio.Properties.Resources.ochos_de_sabiote;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.buttonPersona);
            this.Controls.Add(this.buttonEmpresa);
            this.Controls.Add(this.labelEslogan);
            this.Controls.Add(this.labelTitulo);
            this.Name = "FormularioInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelEslogan;
        private System.Windows.Forms.Button buttonEmpresa;
        private System.Windows.Forms.Button buttonPersona;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Label label1;
    }
}

