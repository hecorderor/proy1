namespace SistemaVentas
{
    partial class Facturacion
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
            this.CancelarFact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CancelarFact
            // 
            this.CancelarFact.Location = new System.Drawing.Point(182, 312);
            this.CancelarFact.Name = "CancelarFact";
            this.CancelarFact.Size = new System.Drawing.Size(75, 23);
            this.CancelarFact.TabIndex = 0;
            this.CancelarFact.Text = "Cancelar";
            this.CancelarFact.UseVisualStyleBackColor = true;
            this.CancelarFact.Click += new System.EventHandler(this.CancelarFact_Click);
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 409);
            this.Controls.Add(this.CancelarFact);
            this.Name = "Facturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelarFact;
    }
}