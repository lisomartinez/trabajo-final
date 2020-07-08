namespace UI
{
    partial class OrdenDeCompra
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
            this.ComponenteGB = new System.Windows.Forms.GroupBox();
            this.GenearOrdenBTN = new System.Windows.Forms.Button();
            this.ProveedoresDGV = new System.Windows.Forms.DataGridView();
            this.ComponenteGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ComponenteGB
            // 
            this.ComponenteGB.Controls.Add(this.GenearOrdenBTN);
            this.ComponenteGB.Controls.Add(this.ProveedoresDGV);
            this.ComponenteGB.Location = new System.Drawing.Point(12, 12);
            this.ComponenteGB.Name = "ComponenteGB";
            this.ComponenteGB.Size = new System.Drawing.Size(524, 298);
            this.ComponenteGB.TabIndex = 3;
            this.ComponenteGB.TabStop = false;
            this.ComponenteGB.Text = "Componente por proveedor";
            // 
            // GenearOrdenBTN
            // 
            this.GenearOrdenBTN.Location = new System.Drawing.Point(11, 254);
            this.GenearOrdenBTN.Name = "GenearOrdenBTN";
            this.GenearOrdenBTN.Size = new System.Drawing.Size(204, 29);
            this.GenearOrdenBTN.TabIndex = 1;
            this.GenearOrdenBTN.Text = "Generar Orden De Compra";
            this.GenearOrdenBTN.UseVisualStyleBackColor = true;
            // 
            // ProveedoresDGV
            // 
            this.ProveedoresDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProveedoresDGV.Location = new System.Drawing.Point(11, 24);
            this.ProveedoresDGV.Name = "ProveedoresDGV";
            this.ProveedoresDGV.Size = new System.Drawing.Size(500, 212);
            this.ProveedoresDGV.TabIndex = 0;
            // 
            // OrdenDeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 341);
            this.Controls.Add(this.ComponenteGB);
            this.Name = "OrdenDeCompra";
            this.Text = "OrdenDeCompra";
            this.Load += new System.EventHandler(this.OrdenDeCompra_Load);
            this.ComponenteGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ComponenteGB;
        private System.Windows.Forms.Button GenearOrdenBTN;
        private System.Windows.Forms.DataGridView ProveedoresDGV;
    }
}