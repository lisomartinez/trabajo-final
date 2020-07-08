namespace UI
{
    partial class TecnicoForm
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
            this.UsuarioGB = new System.Windows.Forms.GroupBox();
            this.CambiarPasswordBTN = new System.Windows.Forms.Button();
            this.ModificacionBTN = new System.Windows.Forms.Button();
            this.AltaBTN = new System.Windows.Forms.Button();
            this.BajaBTN = new System.Windows.Forms.Button();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.ApellidoTB = new System.Windows.Forms.TextBox();
            this.NombreTB = new System.Windows.Forms.TextBox();
            this.LegajoTB = new System.Windows.Forms.TextBox();
            this.EmailLBL = new System.Windows.Forms.Label();
            this.ApellidoLBL = new System.Windows.Forms.Label();
            this.NombreLBL = new System.Windows.Forms.Label();
            this.LegajoLBL = new System.Windows.Forms.Label();
            this.TecnicosGB = new System.Windows.Forms.GroupBox();
            this.TecnicosDGV = new System.Windows.Forms.DataGridView();
            this.UsuarioGB.SuspendLayout();
            this.TecnicosGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TecnicosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // UsuarioGB
            // 
            this.UsuarioGB.Controls.Add(this.CambiarPasswordBTN);
            this.UsuarioGB.Controls.Add(this.ModificacionBTN);
            this.UsuarioGB.Controls.Add(this.AltaBTN);
            this.UsuarioGB.Controls.Add(this.BajaBTN);
            this.UsuarioGB.Controls.Add(this.EmailTB);
            this.UsuarioGB.Controls.Add(this.ApellidoTB);
            this.UsuarioGB.Controls.Add(this.NombreTB);
            this.UsuarioGB.Controls.Add(this.LegajoTB);
            this.UsuarioGB.Controls.Add(this.EmailLBL);
            this.UsuarioGB.Controls.Add(this.ApellidoLBL);
            this.UsuarioGB.Controls.Add(this.NombreLBL);
            this.UsuarioGB.Controls.Add(this.LegajoLBL);
            this.UsuarioGB.Location = new System.Drawing.Point(648, 12);
            this.UsuarioGB.Name = "UsuarioGB";
            this.UsuarioGB.Size = new System.Drawing.Size(381, 394);
            this.UsuarioGB.TabIndex = 3;
            this.UsuarioGB.TabStop = false;
            this.UsuarioGB.Text = "TecnicoGB";
            // 
            // CambiarPasswordBTN
            // 
            this.CambiarPasswordBTN.Location = new System.Drawing.Point(16, 336);
            this.CambiarPasswordBTN.Name = "CambiarPasswordBTN";
            this.CambiarPasswordBTN.Size = new System.Drawing.Size(347, 41);
            this.CambiarPasswordBTN.TabIndex = 3;
            this.CambiarPasswordBTN.Text = "Cambiar Password";
            this.CambiarPasswordBTN.UseVisualStyleBackColor = true;
            this.CambiarPasswordBTN.Click += new System.EventHandler(this.CambiarPasswordBTN_Click);
            // 
            // ModificacionBTN
            // 
            this.ModificacionBTN.Location = new System.Drawing.Point(266, 241);
            this.ModificacionBTN.Name = "ModificacionBTN";
            this.ModificacionBTN.Size = new System.Drawing.Size(97, 63);
            this.ModificacionBTN.TabIndex = 2;
            this.ModificacionBTN.Text = "Modificacion";
            this.ModificacionBTN.UseVisualStyleBackColor = true;
            this.ModificacionBTN.Click += new System.EventHandler(this.ModificacionBTN_Click);
            // 
            // AltaBTN
            // 
            this.AltaBTN.Location = new System.Drawing.Point(16, 241);
            this.AltaBTN.Name = "AltaBTN";
            this.AltaBTN.Size = new System.Drawing.Size(97, 63);
            this.AltaBTN.TabIndex = 2;
            this.AltaBTN.Text = "Alta";
            this.AltaBTN.UseVisualStyleBackColor = true;
            this.AltaBTN.Click += new System.EventHandler(this.AltaBTN_Click);
            // 
            // BajaBTN
            // 
            this.BajaBTN.Location = new System.Drawing.Point(143, 241);
            this.BajaBTN.Name = "BajaBTN";
            this.BajaBTN.Size = new System.Drawing.Size(97, 63);
            this.BajaBTN.TabIndex = 2;
            this.BajaBTN.Text = "Baja";
            this.BajaBTN.UseVisualStyleBackColor = true;
            this.BajaBTN.Click += new System.EventHandler(this.BajaBTN_Click);
            // 
            // EmailTB
            // 
            this.EmailTB.Location = new System.Drawing.Point(89, 173);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(239, 20);
            this.EmailTB.TabIndex = 1;
            // 
            // ApellidoTB
            // 
            this.ApellidoTB.Location = new System.Drawing.Point(89, 125);
            this.ApellidoTB.Name = "ApellidoTB";
            this.ApellidoTB.Size = new System.Drawing.Size(239, 20);
            this.ApellidoTB.TabIndex = 1;
            // 
            // NombreTB
            // 
            this.NombreTB.Location = new System.Drawing.Point(89, 76);
            this.NombreTB.Name = "NombreTB";
            this.NombreTB.Size = new System.Drawing.Size(239, 20);
            this.NombreTB.TabIndex = 1;
            // 
            // LegajoTB
            // 
            this.LegajoTB.Location = new System.Drawing.Point(89, 29);
            this.LegajoTB.Name = "LegajoTB";
            this.LegajoTB.Size = new System.Drawing.Size(239, 20);
            this.LegajoTB.TabIndex = 1;
            // 
            // EmailLBL
            // 
            this.EmailLBL.Location = new System.Drawing.Point(16, 173);
            this.EmailLBL.Name = "EmailLBL";
            this.EmailLBL.Size = new System.Drawing.Size(100, 23);
            this.EmailLBL.TabIndex = 0;
            this.EmailLBL.Text = "Email";
            // 
            // ApellidoLBL
            // 
            this.ApellidoLBL.Location = new System.Drawing.Point(16, 125);
            this.ApellidoLBL.Name = "ApellidoLBL";
            this.ApellidoLBL.Size = new System.Drawing.Size(100, 23);
            this.ApellidoLBL.TabIndex = 0;
            this.ApellidoLBL.Text = "Apellido";
            // 
            // NombreLBL
            // 
            this.NombreLBL.Location = new System.Drawing.Point(16, 76);
            this.NombreLBL.Name = "NombreLBL";
            this.NombreLBL.Size = new System.Drawing.Size(64, 23);
            this.NombreLBL.TabIndex = 0;
            this.NombreLBL.Text = "Nombre";
            // 
            // LegajoLBL
            // 
            this.LegajoLBL.Location = new System.Drawing.Point(16, 29);
            this.LegajoLBL.Name = "LegajoLBL";
            this.LegajoLBL.Size = new System.Drawing.Size(100, 23);
            this.LegajoLBL.TabIndex = 0;
            this.LegajoLBL.Text = "Legajo";
            // 
            // TecnicosGB
            // 
            this.TecnicosGB.Controls.Add(this.TecnicosDGV);
            this.TecnicosGB.Location = new System.Drawing.Point(12, 12);
            this.TecnicosGB.Name = "TecnicosGB";
            this.TecnicosGB.Size = new System.Drawing.Size(630, 673);
            this.TecnicosGB.TabIndex = 2;
            this.TecnicosGB.TabStop = false;
            this.TecnicosGB.Text = "Tecnicos";
            // 
            // TecnicosDGV
            // 
            this.TecnicosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TecnicosDGV.Location = new System.Drawing.Point(6, 29);
            this.TecnicosDGV.Name = "TecnicosDGV";
            this.TecnicosDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TecnicosDGV.Size = new System.Drawing.Size(607, 627);
            this.TecnicosDGV.TabIndex = 0;
            this.TecnicosDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TecnicosDGV_CellClick);
            // 
            // TecnicoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 700);
            this.Controls.Add(this.UsuarioGB);
            this.Controls.Add(this.TecnicosGB);
            this.Name = "TecnicoForm";
            this.Text = "TecnicoForm";
            this.Load += new System.EventHandler(this.TecnicoForm_Load);
            this.UsuarioGB.ResumeLayout(false);
            this.UsuarioGB.PerformLayout();
            this.TecnicosGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TecnicosDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UsuarioGB;
        private System.Windows.Forms.Button CambiarPasswordBTN;
        private System.Windows.Forms.Button ModificacionBTN;
        private System.Windows.Forms.Button AltaBTN;
        private System.Windows.Forms.Button BajaBTN;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.TextBox ApellidoTB;
        private System.Windows.Forms.TextBox NombreTB;
        private System.Windows.Forms.TextBox LegajoTB;
        private System.Windows.Forms.Label EmailLBL;
        private System.Windows.Forms.Label ApellidoLBL;
        private System.Windows.Forms.Label NombreLBL;
        private System.Windows.Forms.Label LegajoLBL;
        private System.Windows.Forms.GroupBox TecnicosGB;
        private System.Windows.Forms.DataGridView TecnicosDGV;
    }
}