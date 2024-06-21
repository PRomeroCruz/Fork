namespace Mercadochio.Resources.FomulariosPersona
{
    partial class FormDetallesEmpresa
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
            this.labelDomicilio = new System.Windows.Forms.Label();
            this.labelHoraApertura = new System.Windows.Forms.Label();
            this.labelCorreoEmpresa = new System.Windows.Forms.Label();
            this.labelNombreEmpresa = new System.Windows.Forms.Label();
            this.richTextBoxDescripcionEmpresa = new System.Windows.Forms.RichTextBox();
            this.interfacesMercaochioDataSet = new Mercadochio.InterfacesMercaochioDataSet();
            this.dataGridViewOchiosDisponibles = new System.Windows.Forms.DataGridView();
            this.labelOchiosDisponibles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.interfacesMercaochioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOchiosDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDomicilio
            // 
            this.labelDomicilio.AutoSize = true;
            this.labelDomicilio.Location = new System.Drawing.Point(16, 171);
            this.labelDomicilio.Name = "labelDomicilio";
            this.labelDomicilio.Size = new System.Drawing.Size(63, 16);
            this.labelDomicilio.TabIndex = 7;
            this.labelDomicilio.Text = "Domicilio";
            // 
            // labelHoraApertura
            // 
            this.labelHoraApertura.AutoSize = true;
            this.labelHoraApertura.Location = new System.Drawing.Point(16, 130);
            this.labelHoraApertura.Name = "labelHoraApertura";
            this.labelHoraApertura.Size = new System.Drawing.Size(120, 16);
            this.labelHoraApertura.TabIndex = 6;
            this.labelHoraApertura.Text = "De HORA a HORA";
            // 
            // labelCorreoEmpresa
            // 
            this.labelCorreoEmpresa.AutoSize = true;
            this.labelCorreoEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreoEmpresa.Location = new System.Drawing.Point(14, 78);
            this.labelCorreoEmpresa.Name = "labelCorreoEmpresa";
            this.labelCorreoEmpresa.Size = new System.Drawing.Size(248, 29);
            this.labelCorreoEmpresa.TabIndex = 5;
            this.labelCorreoEmpresa.Text = "Correo de la empresa";
            // 
            // labelNombreEmpresa
            // 
            this.labelNombreEmpresa.AutoSize = true;
            this.labelNombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreEmpresa.Location = new System.Drawing.Point(12, 18);
            this.labelNombreEmpresa.Name = "labelNombreEmpresa";
            this.labelNombreEmpresa.Size = new System.Drawing.Size(396, 42);
            this.labelNombreEmpresa.TabIndex = 4;
            this.labelNombreEmpresa.Text = "Nombre de la empresa";
            // 
            // richTextBoxDescripcionEmpresa
            // 
            this.richTextBoxDescripcionEmpresa.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxDescripcionEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxDescripcionEmpresa.Location = new System.Drawing.Point(19, 208);
            this.richTextBoxDescripcionEmpresa.Name = "richTextBoxDescripcionEmpresa";
            this.richTextBoxDescripcionEmpresa.Size = new System.Drawing.Size(415, 134);
            this.richTextBoxDescripcionEmpresa.TabIndex = 8;
            this.richTextBoxDescripcionEmpresa.Text = "";
            // 
            // interfacesMercaochioDataSet
            // 
            this.interfacesMercaochioDataSet.DataSetName = "InterfacesMercaochioDataSet";
            this.interfacesMercaochioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewOchiosDisponibles
            // 
            this.dataGridViewOchiosDisponibles.ColumnHeadersHeight = 29;
            this.dataGridViewOchiosDisponibles.Location = new System.Drawing.Point(350, 221);
            this.dataGridViewOchiosDisponibles.Name = "dataGridViewOchiosDisponibles";
            this.dataGridViewOchiosDisponibles.RowHeadersWidth = 51;
            this.dataGridViewOchiosDisponibles.Size = new System.Drawing.Size(850, 238);
            this.dataGridViewOchiosDisponibles.TabIndex = 0;
            this.dataGridViewOchiosDisponibles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOchiosDisponibles_CellDoubleClick);
            // 
            // labelOchiosDisponibles
            // 
            this.labelOchiosDisponibles.AutoSize = true;
            this.labelOchiosDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOchiosDisponibles.Location = new System.Drawing.Point(344, 173);
            this.labelOchiosDisponibles.Name = "labelOchiosDisponibles";
            this.labelOchiosDisponibles.Size = new System.Drawing.Size(263, 32);
            this.labelOchiosDisponibles.TabIndex = 9;
            this.labelOchiosDisponibles.Text = "Ochios disponibles:";
            // 
            // FormDetallesEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 483);
            this.Controls.Add(this.labelOchiosDisponibles);
            this.Controls.Add(this.dataGridViewOchiosDisponibles);
            this.Controls.Add(this.richTextBoxDescripcionEmpresa);
            this.Controls.Add(this.labelDomicilio);
            this.Controls.Add(this.labelHoraApertura);
            this.Controls.Add(this.labelCorreoEmpresa);
            this.Controls.Add(this.labelNombreEmpresa);
            this.Name = "FormDetallesEmpresa";
            this.Text = "FormDetallesEmpresa";
            ((System.ComponentModel.ISupportInitialize)(this.interfacesMercaochioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOchiosDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDomicilio;
        private System.Windows.Forms.Label labelHoraApertura;
        private System.Windows.Forms.Label labelCorreoEmpresa;
        private System.Windows.Forms.Label labelNombreEmpresa;
        private System.Windows.Forms.RichTextBox richTextBoxDescripcionEmpresa;
        private InterfacesMercaochioDataSet interfacesMercaochioDataSet;
        private System.Windows.Forms.DataGridView dataGridViewOchiosDisponibles;
        private System.Windows.Forms.Label labelOchiosDisponibles;
    }
}