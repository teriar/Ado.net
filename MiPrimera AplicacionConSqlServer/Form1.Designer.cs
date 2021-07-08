
namespace MiPrimera_AplicacionConSqlServer
{
    partial class Form1
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
            this.dgbClinica = new System.Windows.Forms.DataGridView();
            this.Clinica = new System.Windows.Forms.Label();
            this.txtIdClinica = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgbClinica)).BeginInit();
            this.SuspendLayout();
            // 
            // dgbClinica
            // 
            this.dgbClinica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbClinica.Location = new System.Drawing.Point(12, 78);
            this.dgbClinica.Name = "dgbClinica";
            this.dgbClinica.Size = new System.Drawing.Size(491, 348);
            this.dgbClinica.TabIndex = 0;
            // 
            // Clinica
            // 
            this.Clinica.AutoSize = true;
            this.Clinica.Location = new System.Drawing.Point(52, 38);
            this.Clinica.Name = "Clinica";
            this.Clinica.Size = new System.Drawing.Size(49, 13);
            this.Clinica.TabIndex = 1;
            this.Clinica.Text = "IDClinica";
            // 
            // txtIdClinica
            // 
            this.txtIdClinica.Location = new System.Drawing.Point(131, 38);
            this.txtIdClinica.Name = "txtIdClinica";
            this.txtIdClinica.Size = new System.Drawing.Size(162, 20);
            this.txtIdClinica.TabIndex = 2;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(316, 38);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(397, 38);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 4;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 429);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.txtIdClinica);
            this.Controls.Add(this.Clinica);
            this.Controls.Add(this.dgbClinica);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbClinica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgbClinica;
        private System.Windows.Forms.Label Clinica;
        private System.Windows.Forms.TextBox txtIdClinica;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button limpiar;
    }
}

