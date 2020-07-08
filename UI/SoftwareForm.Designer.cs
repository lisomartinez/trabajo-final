namespace UI
{
    partial class SoftwareForm
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
            this.SoftwaresGB = new System.Windows.Forms.GroupBox();
            this.SoftwareDGV = new System.Windows.Forms.DataGridView();
            this.SoftwareGB = new System.Windows.Forms.GroupBox();
            this.ModificacionBTN = new System.Windows.Forms.Button();
            this.BajaBTN = new System.Windows.Forms.Button();
            this.AltaBTN = new System.Windows.Forms.Button();
            this.DesarrolladorTB = new System.Windows.Forms.TextBox();
            this.VersionTB = new System.Windows.Forms.TextBox();
            this.NombreTB = new System.Windows.Forms.TextBox();
            this.CodigoTB = new System.Windows.Forms.TextBox();
            this.DesarrolladorLBL = new System.Windows.Forms.Label();
            this.VersionLBL = new System.Windows.Forms.Label();
            this.NombreLBL = new System.Windows.Forms.Label();
            this.CodigoLBL = new System.Windows.Forms.Label();
            this.SoftwaresGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoftwareDGV)).BeginInit();
            this.SoftwareGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // SoftwaresGB
            // 
            this.SoftwaresGB.Controls.Add(this.SoftwareDGV);
            this.SoftwaresGB.Location = new System.Drawing.Point(12, 12);
            this.SoftwaresGB.Name = "SoftwaresGB";
            this.SoftwaresGB.Size = new System.Drawing.Size(521, 426);
            this.SoftwaresGB.TabIndex = 4;
            this.SoftwaresGB.TabStop = false;
            this.SoftwaresGB.Text = "Softwares";
            // 
            // SoftwareDGV
            // 
            this.SoftwareDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SoftwareDGV.Location = new System.Drawing.Point(11, 24);
            this.SoftwareDGV.Name = "SoftwareDGV";
            this.SoftwareDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SoftwareDGV.Size = new System.Drawing.Size(500, 382);
            this.SoftwareDGV.TabIndex = 0;
            this.SoftwareDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SoftwareDGV_CellClick);
            // 
            // SoftwareGB
            // 
            this.SoftwareGB.Controls.Add(this.ModificacionBTN);
            this.SoftwareGB.Controls.Add(this.BajaBTN);
            this.SoftwareGB.Controls.Add(this.AltaBTN);
            this.SoftwareGB.Controls.Add(this.DesarrolladorTB);
            this.SoftwareGB.Controls.Add(this.VersionTB);
            this.SoftwareGB.Controls.Add(this.NombreTB);
            this.SoftwareGB.Controls.Add(this.CodigoTB);
            this.SoftwareGB.Controls.Add(this.DesarrolladorLBL);
            this.SoftwareGB.Controls.Add(this.VersionLBL);
            this.SoftwareGB.Controls.Add(this.NombreLBL);
            this.SoftwareGB.Controls.Add(this.CodigoLBL);
            this.SoftwareGB.Location = new System.Drawing.Point(548, 20);
            this.SoftwareGB.Name = "SoftwareGB";
            this.SoftwareGB.Size = new System.Drawing.Size(405, 417);
            this.SoftwareGB.TabIndex = 5;
            this.SoftwareGB.TabStop = false;
            this.SoftwareGB.Text = "Software";
            // 
            // ModificacionBTN
            // 
            this.ModificacionBTN.Location = new System.Drawing.Point(276, 203);
            this.ModificacionBTN.Name = "ModificacionBTN";
            this.ModificacionBTN.Size = new System.Drawing.Size(123, 41);
            this.ModificacionBTN.TabIndex = 5;
            this.ModificacionBTN.Text = "Modificacion";
            this.ModificacionBTN.UseVisualStyleBackColor = true;
            this.ModificacionBTN.Click += new System.EventHandler(this.ModificacionBTN_Click);
            // 
            // BajaBTN
            // 
            this.BajaBTN.Location = new System.Drawing.Point(148, 203);
            this.BajaBTN.Name = "BajaBTN";
            this.BajaBTN.Size = new System.Drawing.Size(123, 41);
            this.BajaBTN.TabIndex = 6;
            this.BajaBTN.Text = "Baja";
            this.BajaBTN.UseVisualStyleBackColor = true;
            this.BajaBTN.Click += new System.EventHandler(this.BajaBTN_Click);
            // 
            // AltaBTN
            // 
            this.AltaBTN.Location = new System.Drawing.Point(19, 203);
            this.AltaBTN.Name = "AltaBTN";
            this.AltaBTN.Size = new System.Drawing.Size(123, 41);
            this.AltaBTN.TabIndex = 7;
            this.AltaBTN.Text = "Alta";
            this.AltaBTN.UseVisualStyleBackColor = true;
            this.AltaBTN.Click += new System.EventHandler(this.AltaBTN_Click);
            // 
            // DesarrolladorTB
            // 
            this.DesarrolladorTB.Location = new System.Drawing.Point(97, 148);
            this.DesarrolladorTB.Name = "DesarrolladorTB";
            this.DesarrolladorTB.Size = new System.Drawing.Size(302, 20);
            this.DesarrolladorTB.TabIndex = 1;
            // 
            // VersionTB
            // 
            this.VersionTB.Location = new System.Drawing.Point(97, 100);
            this.VersionTB.Name = "VersionTB";
            this.VersionTB.Size = new System.Drawing.Size(302, 20);
            this.VersionTB.TabIndex = 1;
            // 
            // NombreTB
            // 
            this.NombreTB.Location = new System.Drawing.Point(97, 65);
            this.NombreTB.Name = "NombreTB";
            this.NombreTB.Size = new System.Drawing.Size(302, 20);
            this.NombreTB.TabIndex = 1;
            // 
            // CodigoTB
            // 
            this.CodigoTB.Location = new System.Drawing.Point(97, 24);
            this.CodigoTB.Name = "CodigoTB";
            this.CodigoTB.Size = new System.Drawing.Size(302, 20);
            this.CodigoTB.TabIndex = 1;
            // 
            // DesarrolladorLBL
            // 
            this.DesarrolladorLBL.AutoSize = true;
            this.DesarrolladorLBL.Location = new System.Drawing.Point(18, 155);
            this.DesarrolladorLBL.Name = "DesarrolladorLBL";
            this.DesarrolladorLBL.Size = new System.Drawing.Size(69, 13);
            this.DesarrolladorLBL.TabIndex = 0;
            this.DesarrolladorLBL.Text = "Desarrollador";
            // 
            // VersionLBL
            // 
            this.VersionLBL.AutoSize = true;
            this.VersionLBL.Location = new System.Drawing.Point(16, 107);
            this.VersionLBL.Name = "VersionLBL";
            this.VersionLBL.Size = new System.Drawing.Size(42, 13);
            this.VersionLBL.TabIndex = 0;
            this.VersionLBL.Text = "Version";
            // 
            // NombreLBL
            // 
            this.NombreLBL.AutoSize = true;
            this.NombreLBL.Location = new System.Drawing.Point(16, 72);
            this.NombreLBL.Name = "NombreLBL";
            this.NombreLBL.Size = new System.Drawing.Size(44, 13);
            this.NombreLBL.TabIndex = 0;
            this.NombreLBL.Text = "Nombre";
            // 
            // CodigoLBL
            // 
            this.CodigoLBL.AutoSize = true;
            this.CodigoLBL.Location = new System.Drawing.Point(16, 31);
            this.CodigoLBL.Name = "CodigoLBL";
            this.CodigoLBL.Size = new System.Drawing.Size(40, 13);
            this.CodigoLBL.TabIndex = 0;
            this.CodigoLBL.Text = "Codigo";
            // 
            // SoftwareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 447);
            this.Controls.Add(this.SoftwareGB);
            this.Controls.Add(this.SoftwaresGB);
            this.Name = "SoftwareForm";
            this.Text = "SoftwareForm";
            this.Load += new System.EventHandler(this.SoftwareForm_Load);
            this.SoftwaresGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SoftwareDGV)).EndInit();
            this.SoftwareGB.ResumeLayout(false);
            this.SoftwareGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SoftwaresGB;
        private System.Windows.Forms.DataGridView SoftwareDGV;
        private System.Windows.Forms.GroupBox SoftwareGB;
        private System.Windows.Forms.TextBox DesarrolladorTB;
        private System.Windows.Forms.TextBox VersionTB;
        private System.Windows.Forms.TextBox NombreTB;
        private System.Windows.Forms.TextBox CodigoTB;
        private System.Windows.Forms.Label DesarrolladorLBL;
        private System.Windows.Forms.Label VersionLBL;
        private System.Windows.Forms.Label NombreLBL;
        private System.Windows.Forms.Label CodigoLBL;
        private System.Windows.Forms.Button ModificacionBTN;
        private System.Windows.Forms.Button BajaBTN;
        private System.Windows.Forms.Button AltaBTN;
    }
}