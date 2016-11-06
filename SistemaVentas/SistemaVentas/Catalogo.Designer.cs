namespace SistemaVentas
{
    partial class Catalogo
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
            this.SalirCP = new System.Windows.Forms.Button();
            this.dateTimeCliente = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // SalirCP
            // 
            this.SalirCP.Location = new System.Drawing.Point(147, 274);
            this.SalirCP.Name = "SalirCP";
            this.SalirCP.Size = new System.Drawing.Size(123, 39);
            this.SalirCP.TabIndex = 0;
            this.SalirCP.Text = "Salir";
            this.SalirCP.UseVisualStyleBackColor = true;
            this.SalirCP.Click += new System.EventHandler(this.SalirCP_Click);
            // 
            // dateTimeCliente
            // 
            this.dateTimeCliente.Location = new System.Drawing.Point(74, 144);
            this.dateTimeCliente.Name = "dateTimeCliente";
            this.dateTimeCliente.Size = new System.Drawing.Size(200, 20);
            this.dateTimeCliente.TabIndex = 1;
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 325);
            this.Controls.Add(this.dateTimeCliente);
            this.Controls.Add(this.SalirCP);
            this.Name = "Catalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo de productos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SalirCP;
        public System.Windows.Forms.DateTimePicker dateTimeCliente;
    }
}