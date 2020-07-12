namespace UI
{
    partial class GestionarComputadoraUsuarioForm
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
            this.ComputadoraGB = new System.Windows.Forms.GroupBox();
            this.ComputadorasDGV = new System.Windows.Forms.DataGridView();
            this.UsuarioGB = new System.Windows.Forms.GroupBox();
            this.ApellidoTB = new System.Windows.Forms.TextBox();
            this.NombreTB = new System.Windows.Forms.TextBox();
            this.LegajoTB = new System.Windows.Forms.TextBox();
            this.ApellidoLBL = new System.Windows.Forms.Label();
            this.NombreLBL = new System.Windows.Forms.Label();
            this.LegajoLBL = new System.Windows.Forms.Label();
            this.DesasignarBTN = new System.Windows.Forms.Button();
            this.AsignarBTN = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ComputadoraGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComputadorasDGV)).BeginInit();
            this.UsuarioGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComputadoraGB
            // 
            this.ComputadoraGB.Controls.Add(this.ComputadorasDGV);
            this.ComputadoraGB.Location = new System.Drawing.Point(7, 11);
            this.ComputadoraGB.Name = "ComputadoraGB";
            this.ComputadoraGB.Size = new System.Drawing.Size(458, 459);
            this.ComputadoraGB.TabIndex = 0;
            this.ComputadoraGB.TabStop = false;
            this.ComputadoraGB.Text = "Computadora";
            // 
            // ComputadorasDGV
            // 
            this.ComputadorasDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComputadorasDGV.Location = new System.Drawing.Point(9, 17);
            this.ComputadorasDGV.Name = "ComputadorasDGV";
            this.ComputadorasDGV.Size = new System.Drawing.Size(435, 431);
            this.ComputadorasDGV.TabIndex = 0;
            // 
            // UsuarioGB
            // 
            this.UsuarioGB.Controls.Add(this.ApellidoTB);
            this.UsuarioGB.Controls.Add(this.NombreTB);
            this.UsuarioGB.Controls.Add(this.LegajoTB);
            this.UsuarioGB.Controls.Add(this.ApellidoLBL);
            this.UsuarioGB.Controls.Add(this.NombreLBL);
            this.UsuarioGB.Controls.Add(this.LegajoLBL);
            this.UsuarioGB.Controls.Add(this.DesasignarBTN);
            this.UsuarioGB.Controls.Add(this.AsignarBTN);
            this.UsuarioGB.Location = new System.Drawing.Point(471, 12);
            this.UsuarioGB.Name = "UsuarioGB";
            this.UsuarioGB.Size = new System.Drawing.Size(377, 459);
            this.UsuarioGB.TabIndex = 0;
            this.UsuarioGB.TabStop = false;
            this.UsuarioGB.Text = "Legajo";
            // 
            // ApellidoTB
            // 
            this.ApellidoTB.Location = new System.Drawing.Point(54, 110);
            this.ApellidoTB.Name = "ApellidoTB";
            this.ApellidoTB.Size = new System.Drawing.Size(152, 20);
            this.ApellidoTB.TabIndex = 2;
            // 
            // NombreTB
            // 
            this.NombreTB.Location = new System.Drawing.Point(54, 64);
            this.NombreTB.Name = "NombreTB";
            this.NombreTB.Size = new System.Drawing.Size(152, 20);
            this.NombreTB.TabIndex = 2;
            // 
            // LegajoTB
            // 
            this.LegajoTB.Location = new System.Drawing.Point(54, 27);
            this.LegajoTB.Name = "LegajoTB";
            this.LegajoTB.Size = new System.Drawing.Size(152, 20);
            this.LegajoTB.TabIndex = 2;
            // 
            // ApellidoLBL
            // 
            this.ApellidoLBL.AutoSize = true;
            this.ApellidoLBL.Location = new System.Drawing.Point(13, 113);
            this.ApellidoLBL.Name = "ApellidoLBL";
            this.ApellidoLBL.Size = new System.Drawing.Size(47, 13);
            this.ApellidoLBL.TabIndex = 1;
            this.ApellidoLBL.Text = "Apellido:";
            // 
            // NombreLBL
            // 
            this.NombreLBL.AutoSize = true;
            this.NombreLBL.Location = new System.Drawing.Point(13, 67);
            this.NombreLBL.Name = "NombreLBL";
            this.NombreLBL.Size = new System.Drawing.Size(47, 13);
            this.NombreLBL.TabIndex = 1;
            this.NombreLBL.Text = "Nombre:";
            // 
            // LegajoLBL
            // 
            this.LegajoLBL.AutoSize = true;
            this.LegajoLBL.Location = new System.Drawing.Point(13, 30);
            this.LegajoLBL.Name = "LegajoLBL";
            this.LegajoLBL.Size = new System.Drawing.Size(42, 13);
            this.LegajoLBL.TabIndex = 1;
            this.LegajoLBL.Text = "Legajo:";
            // 
            // DesasignarBTN
            // 
            this.DesasignarBTN.Location = new System.Drawing.Point(191, 186);
            this.DesasignarBTN.Name = "DesasignarBTN";
            this.DesasignarBTN.Size = new System.Drawing.Size(169, 44);
            this.DesasignarBTN.TabIndex = 0;
            this.DesasignarBTN.Text = "Desasignar";
            this.DesasignarBTN.UseVisualStyleBackColor = true;
            this.DesasignarBTN.Click += new System.EventHandler(this.DesasignarBTN_Click);
            // 
            // AsignarBTN
            // 
            this.AsignarBTN.Location = new System.Drawing.Point(16, 186);
            this.AsignarBTN.Name = "AsignarBTN";
            this.AsignarBTN.Size = new System.Drawing.Size(169, 44);
            this.AsignarBTN.TabIndex = 0;
            this.AsignarBTN.Text = "Asignar";
            this.AsignarBTN.UseVisualStyleBackColor = true;
            this.AsignarBTN.Click += new System.EventHandler(this.AsignarBTN_Click);
            // 
            // GestionarComputadoraUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 495);
            this.Controls.Add(this.UsuarioGB);
            this.Controls.Add(this.ComputadoraGB);
            this.Name = "GestionarComputadoraUsuarioForm";
            this.Text = "GestionarComputadoraUsuarioForm";
            this.Load += new System.EventHandler(this.GestionarComputadoraUsuarioForm_Load);
            this.ComputadoraGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComputadorasDGV)).EndInit();
            this.UsuarioGB.ResumeLayout(false);
            this.UsuarioGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ComputadoraGB;
        private System.Windows.Forms.DataGridView ComputadorasDGV;
        private System.Windows.Forms.GroupBox UsuarioGB;
        private System.Windows.Forms.TextBox ApellidoTB;
        private System.Windows.Forms.TextBox NombreTB;
        private System.Windows.Forms.TextBox LegajoTB;
        private System.Windows.Forms.Label ApellidoLBL;
        private System.Windows.Forms.Label NombreLBL;
        private System.Windows.Forms.Label LegajoLBL;
        private System.Windows.Forms.Button DesasignarBTN;
        private System.Windows.Forms.Button AsignarBTN;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}