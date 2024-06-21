namespace Mercadochio.Resources.FormulariosEmpresa
{
    partial class FormActualizarOfertaOchios
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
            this.components = new System.ComponentModel.Container();
            this.interfacesMercaochioDataSet = new Mercadochio.InterfacesMercaochioDataSet();
            this.ochioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ochioTableAdapter = new Mercadochio.InterfacesMercaochioDataSetTableAdapters.OchioTableAdapter();
            this.tableAdapterManager = new Mercadochio.InterfacesMercaochioDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEliminarOchio = new System.Windows.Forms.Button();
            this.buttonAgregarOchio = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonRecargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.interfacesMercaochioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ochioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // interfacesMercaochioDataSet
            // 
            this.interfacesMercaochioDataSet.DataSetName = "InterfacesMercaochioDataSet";
            this.interfacesMercaochioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ochioBindingSource
            // 
            this.ochioBindingSource.DataMember = "Ochio";
            this.ochioBindingSource.DataSource = this.interfacesMercaochioDataSet;
            // 
            // ochioTableAdapter
            // 
            this.ochioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmpresaTableAdapter = null;
            this.tableAdapterManager.OchioTableAdapter = this.ochioTableAdapter;
            this.tableAdapterManager.PersonaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Mercadochio.InterfacesMercaochioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tus ochios:";
            // 
            // buttonEliminarOchio
            // 
            this.buttonEliminarOchio.Location = new System.Drawing.Point(24, 394);
            this.buttonEliminarOchio.Name = "buttonEliminarOchio";
            this.buttonEliminarOchio.Size = new System.Drawing.Size(271, 99);
            this.buttonEliminarOchio.TabIndex = 3;
            this.buttonEliminarOchio.Text = "Eliminar Ochio";
            this.buttonEliminarOchio.UseVisualStyleBackColor = true;
            this.buttonEliminarOchio.Click += new System.EventHandler(this.buttonEliminarOchio_Click);
            // 
            // buttonAgregarOchio
            // 
            this.buttonAgregarOchio.Location = new System.Drawing.Point(323, 394);
            this.buttonAgregarOchio.Name = "buttonAgregarOchio";
            this.buttonAgregarOchio.Size = new System.Drawing.Size(271, 99);
            this.buttonAgregarOchio.TabIndex = 4;
            this.buttonAgregarOchio.Text = "Agregar nuevo ochio";
            this.buttonAgregarOchio.UseVisualStyleBackColor = true;
            this.buttonAgregarOchio.Click += new System.EventHandler(this.buttonAgregarOchio_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(912, 237);
            this.dataGridView1.TabIndex = 5;
            // 
            // buttonRecargar
            // 
            this.buttonRecargar.Location = new System.Drawing.Point(837, 63);
            this.buttonRecargar.Name = "buttonRecargar";
            this.buttonRecargar.Size = new System.Drawing.Size(99, 42);
            this.buttonRecargar.TabIndex = 6;
            this.buttonRecargar.Text = "Recargar";
            this.buttonRecargar.UseVisualStyleBackColor = true;
            this.buttonRecargar.Click += new System.EventHandler(this.buttonRecargar_Click);
            // 
            // FormActualizarOfertaOchios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(967, 515);
            this.Controls.Add(this.buttonRecargar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAgregarOchio);
            this.Controls.Add(this.buttonEliminarOchio);
            this.Controls.Add(this.label1);
            this.Name = "FormActualizarOfertaOchios";
            this.Text = "FormActualizarOfertaOchios";
            this.Load += new System.EventHandler(this.FormActualizarOfertaOchios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.interfacesMercaochioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ochioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InterfacesMercaochioDataSet interfacesMercaochioDataSet;
        private System.Windows.Forms.BindingSource ochioBindingSource;
        private InterfacesMercaochioDataSetTableAdapters.OchioTableAdapter ochioTableAdapter;
        private InterfacesMercaochioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEliminarOchio;
        private System.Windows.Forms.Button buttonAgregarOchio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonRecargar;
    }
}