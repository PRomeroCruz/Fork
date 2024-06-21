namespace Mercadochio
{
    partial class FormMenuPrincipalPersona
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
            this.panelContenedorIzquierdo = new System.Windows.Forms.Panel();
            this.panelContenedorMenu = new System.Windows.Forms.Panel();
            this.buttonResenias = new System.Windows.Forms.Button();
            this.buttonComprarOchios = new System.Windows.Forms.Button();
            this.buttonVerMisPedidos = new System.Windows.Forms.Button();
            this.buttoCuenta = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelBienvenido = new System.Windows.Forms.Label();
            this.panelContenedorMenuPersona = new System.Windows.Forms.Panel();
            this.panelSuperior.SuspendLayout();
            this.panelContenedorIzquierdo.SuspendLayout();
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
            this.panelSuperior.TabIndex = 12;
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
            // panelContenedorIzquierdo
            // 
            this.panelContenedorIzquierdo.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panelContenedorIzquierdo.Controls.Add(this.panelContenedorMenu);
            this.panelContenedorIzquierdo.Controls.Add(this.buttonResenias);
            this.panelContenedorIzquierdo.Controls.Add(this.buttonComprarOchios);
            this.panelContenedorIzquierdo.Controls.Add(this.buttonVerMisPedidos);
            this.panelContenedorIzquierdo.Controls.Add(this.buttoCuenta);
            this.panelContenedorIzquierdo.Controls.Add(this.buttonMenu);
            this.panelContenedorIzquierdo.Controls.Add(this.labelNombre);
            this.panelContenedorIzquierdo.Controls.Add(this.labelBienvenido);
            this.panelContenedorIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelContenedorIzquierdo.Location = new System.Drawing.Point(0, 41);
            this.panelContenedorIzquierdo.Name = "panelContenedorIzquierdo";
            this.panelContenedorIzquierdo.Size = new System.Drawing.Size(200, 562);
            this.panelContenedorIzquierdo.TabIndex = 13;
            // 
            // panelContenedorMenu
            // 
            this.panelContenedorMenu.Location = new System.Drawing.Point(197, 0);
            this.panelContenedorMenu.Name = "panelContenedorMenu";
            this.panelContenedorMenu.Size = new System.Drawing.Size(985, 562);
            this.panelContenedorMenu.TabIndex = 16;
            // 
            // buttonResenias
            // 
            this.buttonResenias.Location = new System.Drawing.Point(0, 468);
            this.buttonResenias.Name = "buttonResenias";
            this.buttonResenias.Size = new System.Drawing.Size(200, 82);
            this.buttonResenias.TabIndex = 18;
            this.buttonResenias.Text = "Mis valoraciones";
            this.buttonResenias.UseVisualStyleBackColor = true;
            this.buttonResenias.Visible = false;
            this.buttonResenias.Click += new System.EventHandler(this.buttonResenias_Click);
            // 
            // buttonComprarOchios
            // 
            this.buttonComprarOchios.Location = new System.Drawing.Point(0, 380);
            this.buttonComprarOchios.Name = "buttonComprarOchios";
            this.buttonComprarOchios.Size = new System.Drawing.Size(200, 82);
            this.buttonComprarOchios.TabIndex = 17;
            this.buttonComprarOchios.Text = "Comprar Ochios";
            this.buttonComprarOchios.UseVisualStyleBackColor = true;
            this.buttonComprarOchios.Visible = false;
            this.buttonComprarOchios.Click += new System.EventHandler(this.buttonComprarOchios_Click);
            // 
            // buttonVerMisPedidos
            // 
            this.buttonVerMisPedidos.Location = new System.Drawing.Point(0, 292);
            this.buttonVerMisPedidos.Name = "buttonVerMisPedidos";
            this.buttonVerMisPedidos.Size = new System.Drawing.Size(200, 82);
            this.buttonVerMisPedidos.TabIndex = 16;
            this.buttonVerMisPedidos.Text = "Ver mis pedidos sin valorar";
            this.buttonVerMisPedidos.UseVisualStyleBackColor = true;
            this.buttonVerMisPedidos.Visible = false;
            this.buttonVerMisPedidos.Click += new System.EventHandler(this.buttonVerMisPedidos_Click);
            // 
            // buttoCuenta
            // 
            this.buttoCuenta.Location = new System.Drawing.Point(0, 204);
            this.buttoCuenta.Name = "buttoCuenta";
            this.buttoCuenta.Size = new System.Drawing.Size(200, 82);
            this.buttoCuenta.TabIndex = 15;
            this.buttoCuenta.Text = "Cuenta";
            this.buttoCuenta.UseVisualStyleBackColor = true;
            this.buttoCuenta.Visible = false;
            this.buttoCuenta.Click += new System.EventHandler(this.buttoCuenta_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.Location = new System.Drawing.Point(0, 116);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(130, 82);
            this.buttonMenu.TabIndex = 14;
            this.buttonMenu.Text = "☰";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(11, 50);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(184, 25);
            this.labelNombre.TabIndex = 14;
            this.labelNombre.Text = "Nombre de persona";
            // 
            // labelBienvenido
            // 
            this.labelBienvenido.AutoSize = true;
            this.labelBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenido.Location = new System.Drawing.Point(11, 15);
            this.labelBienvenido.Name = "labelBienvenido";
            this.labelBienvenido.Size = new System.Drawing.Size(119, 25);
            this.labelBienvenido.TabIndex = 14;
            this.labelBienvenido.Text = "Bienvenido";
            // 
            // panelContenedorMenuPersona
            // 
            this.panelContenedorMenuPersona.Location = new System.Drawing.Point(197, 41);
            this.panelContenedorMenuPersona.Name = "panelContenedorMenuPersona";
            this.panelContenedorMenuPersona.Size = new System.Drawing.Size(985, 562);
            this.panelContenedorMenuPersona.TabIndex = 14;
            // 
            // FormMenuPrincipalPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.panelContenedorMenuPersona);
            this.Controls.Add(this.panelContenedorIzquierdo);
            this.Controls.Add(this.panelSuperior);
            this.Name = "FormMenuPrincipalPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenuPrincipalPersona";
            this.Load += new System.EventHandler(this.FormMenuPrincipalPersona_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelContenedorIzquierdo.ResumeLayout(false);
            this.panelContenedorIzquierdo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Panel panelContenedorIzquierdo;
        private System.Windows.Forms.Button buttonComprarOchios;
        private System.Windows.Forms.Button buttonVerMisPedidos;
        private System.Windows.Forms.Button buttoCuenta;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelBienvenido;
        private System.Windows.Forms.Button buttonResenias;
        private System.Windows.Forms.Panel panelContenedorMenu;
        private System.Windows.Forms.Panel panelContenedorMenuPersona;
    }
}