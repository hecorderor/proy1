﻿namespace SistemaVentas
{
    partial class ReporteVentasProducto
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
            this.CancelarRVP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CancelarRVP
            // 
            this.CancelarRVP.Location = new System.Drawing.Point(216, 255);
            this.CancelarRVP.Name = "CancelarRVP";
            this.CancelarRVP.Size = new System.Drawing.Size(122, 38);
            this.CancelarRVP.TabIndex = 0;
            this.CancelarRVP.Text = "Cancelar";
            this.CancelarRVP.UseVisualStyleBackColor = true;
            this.CancelarRVP.Click += new System.EventHandler(this.CancelarRVP_Click);
            // 
            // ReporteVentasProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 336);
            this.Controls.Add(this.CancelarRVP);
            this.Name = "ReporteVentasProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de ventas por producto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelarRVP;
    }
}