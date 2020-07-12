using System.ComponentModel;

namespace UI
{
    partial class UsuarioForm
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
            this.TecnicoGB = new System.Windows.Forms.GroupBox();
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
            this.UsuariosGB = new System.Windows.Forms.GroupBox();
            this.UsuariosDGV = new System.Windows.Forms.DataGridView();
            this.TecnicoGB.SuspendLayout();
            this.UsuariosGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // TecnicoGB
            // 
            this.TecnicoGB.Controls.Add(this.CambiarPasswordBTN);
            this.TecnicoGB.Controls.Add(this.ModificacionBTN);
            this.TecnicoGB.Controls.Add(this.AltaBTN);
            this.TecnicoGB.Controls.Add(this.BajaBTN);
            this.TecnicoGB.Controls.Add(this.EmailTB);
            this.TecnicoGB.Controls.Add(this.ApellidoTB);
            this.TecnicoGB.Controls.Add(this.NombreTB);
            this.TecnicoGB.Controls.Add(this.LegajoTB);
            this.TecnicoGB.Controls.Add(this.EmailLBL);
            this.TecnicoGB.Controls.Add(this.ApellidoLBL);
            this.TecnicoGB.Controls.Add(this.NombreLBL);
            this.TecnicoGB.Controls.Add(this.LegajoLBL);
            this.TecnicoGB.Location = new System.Drawing.Point(828, 12);
            this.TecnicoGB.Name = "TecnicoGB";
            this.TecnicoGB.Size = new System.Drawing.Size(381, 394);
            this.TecnicoGB.TabIndex = 5;
            this.TecnicoGB.TabStop = false;
            this.TecnicoGB.Text = "Tecnico";
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
            // UsuariosGB
            // 
            this.UsuariosGB.Controls.Add(this.UsuariosDGV);
            this.UsuariosGB.Location = new System.Drawing.Point(3, 12);
            this.UsuariosGB.Name = "UsuariosGB";
            this.UsuariosGB.Size = new System.Drawing.Size(819, 673);
            this.UsuariosGB.TabIndex = 4;
            this.UsuariosGB.TabStop = false;
            this.UsuariosGB.Text = "Usuarios";
            // 
            // UsuariosDGV
            // 
            this.UsuariosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariosDGV.Location = new System.Drawing.Point(6, 29);
            this.UsuariosDGV.Name = "UsuariosDGV";
            this.UsuariosDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsuariosDGV.Size = new System.Drawing.Size(804, 627);
            this.UsuariosDGV.TabIndex = 0;
            this.UsuariosDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsuariosDGV_CellClick);
            // 
            // UsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 690);
            this.Controls.Add(this.TecnicoGB);
            this.Controls.Add(this.UsuariosGB);
            this.Name = "UsuarioForm";
            this.Text = "UsuarioForm";
            this.Load += new System.EventHandler(this.UsuarioForm_Load);
            this.TecnicoGB.ResumeLayout(false);
            this.TecnicoGB.PerformLayout();
            this.UsuariosGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TecnicoGB;
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
        private System.Windows.Forms.GroupBox UsuariosGB;
        private System.Windows.Forms.DataGridView UsuariosDGV;
    }
}