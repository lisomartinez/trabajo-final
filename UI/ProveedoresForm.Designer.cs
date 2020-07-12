using System.ComponentModel;

namespace UI
{
    partial class ProveedoresForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.ProveedoresGB = new System.Windows.Forms.GroupBox();
            this.ProveedoresDGV = new System.Windows.Forms.DataGridView();
            this.ProveedorGB = new System.Windows.Forms.GroupBox();
            this.TelefonoTB = new System.Windows.Forms.TextBox();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.DireccionTB = new System.Windows.Forms.TextBox();
            this.RazonSocialTB = new System.Windows.Forms.TextBox();
            this.CuitTB = new System.Windows.Forms.TextBox();
            this.TelefonoLBL = new System.Windows.Forms.Label();
            this.EmailLBL = new System.Windows.Forms.Label();
            this.DireccionLBL = new System.Windows.Forms.Label();
            this.RazonSocialLBL = new System.Windows.Forms.Label();
            this.CuitLBL = new System.Windows.Forms.Label();
            this.GestionarPreciosBTN = new System.Windows.Forms.Button();
            this.ModificacionBTN = new System.Windows.Forms.Button();
            this.BajaBTN = new System.Windows.Forms.Button();
            this.AltaBTN = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ProveedoresGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresDGV)).BeginInit();
            this.ProveedorGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProveedoresGB
            // 
            this.ProveedoresGB.Controls.Add(this.ProveedoresDGV);
            this.ProveedoresGB.Location = new System.Drawing.Point(12, 12);
            this.ProveedoresGB.Name = "ProveedoresGB";
            this.ProveedoresGB.Size = new System.Drawing.Size(631, 556);
            this.ProveedoresGB.TabIndex = 0;
            this.ProveedoresGB.TabStop = false;
            this.ProveedoresGB.Text = "Proveedores";
            // 
            // ProveedoresDGV
            // 
            this.ProveedoresDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProveedoresDGV.Location = new System.Drawing.Point(9, 23);
            this.ProveedoresDGV.Name = "ProveedoresDGV";
            this.ProveedoresDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProveedoresDGV.Size = new System.Drawing.Size(608, 523);
            this.ProveedoresDGV.TabIndex = 0;
            this.ProveedoresDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProveedoresDGV_CellClick);
            // 
            // ProveedorGB
            // 
            this.ProveedorGB.Controls.Add(this.TelefonoTB);
            this.ProveedorGB.Controls.Add(this.EmailTB);
            this.ProveedorGB.Controls.Add(this.DireccionTB);
            this.ProveedorGB.Controls.Add(this.RazonSocialTB);
            this.ProveedorGB.Controls.Add(this.CuitTB);
            this.ProveedorGB.Controls.Add(this.TelefonoLBL);
            this.ProveedorGB.Controls.Add(this.EmailLBL);
            this.ProveedorGB.Controls.Add(this.DireccionLBL);
            this.ProveedorGB.Controls.Add(this.RazonSocialLBL);
            this.ProveedorGB.Controls.Add(this.CuitLBL);
            this.ProveedorGB.Controls.Add(this.GestionarPreciosBTN);
            this.ProveedorGB.Controls.Add(this.ModificacionBTN);
            this.ProveedorGB.Controls.Add(this.BajaBTN);
            this.ProveedorGB.Controls.Add(this.AltaBTN);
            this.ProveedorGB.Location = new System.Drawing.Point(682, 18);
            this.ProveedorGB.Name = "ProveedorGB";
            this.ProveedorGB.Size = new System.Drawing.Size(383, 550);
            this.ProveedorGB.TabIndex = 1;
            this.ProveedorGB.TabStop = false;
            this.ProveedorGB.Text = "Proveedor";
            // 
            // TelefonoTB
            // 
            this.TelefonoTB.Location = new System.Drawing.Point(106, 220);
            this.TelefonoTB.Name = "TelefonoTB";
            this.TelefonoTB.Size = new System.Drawing.Size(227, 20);
            this.TelefonoTB.TabIndex = 2;
            // 
            // EmailTB
            // 
            this.EmailTB.Location = new System.Drawing.Point(106, 174);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(227, 20);
            this.EmailTB.TabIndex = 2;
            // 
            // DireccionTB
            // 
            this.DireccionTB.Location = new System.Drawing.Point(106, 124);
            this.DireccionTB.Name = "DireccionTB";
            this.DireccionTB.Size = new System.Drawing.Size(227, 20);
            this.DireccionTB.TabIndex = 2;
            // 
            // RazonSocialTB
            // 
            this.RazonSocialTB.Location = new System.Drawing.Point(106, 76);
            this.RazonSocialTB.Name = "RazonSocialTB";
            this.RazonSocialTB.Size = new System.Drawing.Size(227, 20);
            this.RazonSocialTB.TabIndex = 2;
            // 
            // CuitTB
            // 
            this.CuitTB.Location = new System.Drawing.Point(106, 29);
            this.CuitTB.Name = "CuitTB";
            this.CuitTB.Size = new System.Drawing.Size(227, 20);
            this.CuitTB.TabIndex = 2;
            // 
            // TelefonoLBL
            // 
            this.TelefonoLBL.AutoSize = true;
            this.TelefonoLBL.Location = new System.Drawing.Point(24, 227);
            this.TelefonoLBL.Name = "TelefonoLBL";
            this.TelefonoLBL.Size = new System.Drawing.Size(52, 13);
            this.TelefonoLBL.TabIndex = 1;
            this.TelefonoLBL.Text = "Telefono:";
            // 
            // EmailLBL
            // 
            this.EmailLBL.AutoSize = true;
            this.EmailLBL.Location = new System.Drawing.Point(24, 181);
            this.EmailLBL.Name = "EmailLBL";
            this.EmailLBL.Size = new System.Drawing.Size(35, 13);
            this.EmailLBL.TabIndex = 1;
            this.EmailLBL.Text = "Email:";
            // 
            // DireccionLBL
            // 
            this.DireccionLBL.AutoSize = true;
            this.DireccionLBL.Location = new System.Drawing.Point(24, 131);
            this.DireccionLBL.Name = "DireccionLBL";
            this.DireccionLBL.Size = new System.Drawing.Size(55, 13);
            this.DireccionLBL.TabIndex = 1;
            this.DireccionLBL.Text = "Direccion:";
            // 
            // RazonSocialLBL
            // 
            this.RazonSocialLBL.AutoSize = true;
            this.RazonSocialLBL.Location = new System.Drawing.Point(24, 83);
            this.RazonSocialLBL.Name = "RazonSocialLBL";
            this.RazonSocialLBL.Size = new System.Drawing.Size(73, 13);
            this.RazonSocialLBL.TabIndex = 1;
            this.RazonSocialLBL.Text = "Razon Social:";
            // 
            // CuitLBL
            // 
            this.CuitLBL.AutoSize = true;
            this.CuitLBL.Location = new System.Drawing.Point(24, 36);
            this.CuitLBL.Name = "CuitLBL";
            this.CuitLBL.Size = new System.Drawing.Size(35, 13);
            this.CuitLBL.TabIndex = 1;
            this.CuitLBL.Text = "CUIT:";
            // 
            // GestionarPreciosBTN
            // 
            this.GestionarPreciosBTN.Location = new System.Drawing.Point(45, 364);
            this.GestionarPreciosBTN.Name = "GestionarPreciosBTN";
            this.GestionarPreciosBTN.Size = new System.Drawing.Size(266, 23);
            this.GestionarPreciosBTN.TabIndex = 0;
            this.GestionarPreciosBTN.Text = "Gestionar Lista de Precios";
            this.GestionarPreciosBTN.UseVisualStyleBackColor = true;
            this.GestionarPreciosBTN.Click += new System.EventHandler(this.GestionarPreciosBTN_Click);
            // 
            // ModificacionBTN
            // 
            this.ModificacionBTN.Location = new System.Drawing.Point(236, 305);
            this.ModificacionBTN.Name = "ModificacionBTN";
            this.ModificacionBTN.Size = new System.Drawing.Size(75, 23);
            this.ModificacionBTN.TabIndex = 0;
            this.ModificacionBTN.Text = "Modifcacion";
            this.ModificacionBTN.UseVisualStyleBackColor = true;
            this.ModificacionBTN.Click += new System.EventHandler(this.ModificacionBTN_Click);
            // 
            // BajaBTN
            // 
            this.BajaBTN.Location = new System.Drawing.Point(145, 305);
            this.BajaBTN.Name = "BajaBTN";
            this.BajaBTN.Size = new System.Drawing.Size(75, 23);
            this.BajaBTN.TabIndex = 0;
            this.BajaBTN.Text = "Baja";
            this.BajaBTN.UseVisualStyleBackColor = true;
            this.BajaBTN.Click += new System.EventHandler(this.BajaBTN_Click);
            // 
            // AltaBTN
            // 
            this.AltaBTN.Location = new System.Drawing.Point(45, 305);
            this.AltaBTN.Name = "AltaBTN";
            this.AltaBTN.Size = new System.Drawing.Size(75, 23);
            this.AltaBTN.TabIndex = 0;
            this.AltaBTN.Text = "Alta";
            this.AltaBTN.UseVisualStyleBackColor = true;
            this.AltaBTN.Click += new System.EventHandler(this.AltaBTN_Click);
            // 
            // ProveedoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 582);
            this.Controls.Add(this.ProveedorGB);
            this.Controls.Add(this.ProveedoresGB);
            this.Name = "ProveedoresForm";
            this.Text = "ProveedoresForm";
            this.Load += new System.EventHandler(this.ProveedoresForm_Load);
            this.ProveedoresGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresDGV)).EndInit();
            this.ProveedorGB.ResumeLayout(false);
            this.ProveedorGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ProveedoresGB;
        private System.Windows.Forms.DataGridView ProveedoresDGV;
        private System.Windows.Forms.GroupBox ProveedorGB;
        private System.Windows.Forms.Button GestionarPreciosBTN;
        private System.Windows.Forms.Button ModificacionBTN;
        private System.Windows.Forms.Button BajaBTN;
        private System.Windows.Forms.Button AltaBTN;
        private BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label EmailLBL;
        private System.Windows.Forms.Label DireccionLBL;
        private System.Windows.Forms.Label RazonSocialLBL;
        private System.Windows.Forms.Label CuitLBL;
        private System.Windows.Forms.TextBox TelefonoTB;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.TextBox DireccionTB;
        private System.Windows.Forms.TextBox RazonSocialTB;
        private System.Windows.Forms.TextBox CuitTB;
        private System.Windows.Forms.Label TelefonoLBL;
    }
}