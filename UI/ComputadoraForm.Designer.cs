using System.ComponentModel;

namespace UI
{
    partial class ComputadoraForm
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
            this.ComputadoraGB = new System.Windows.Forms.GroupBox();
            this.ModificacionBTN = new System.Windows.Forms.Button();
            this.BajaBTN = new System.Windows.Forms.Button();
            this.AltaBTN = new System.Windows.Forms.Button();
            this.SoftwareGB = new System.Windows.Forms.GroupBox();
            this.QuitarSoftwareBTN = new System.Windows.Forms.Button();
            this.SoftwareDGV = new System.Windows.Forms.DataGridView();
            this.AgregarSoftwareBTN = new System.Windows.Forms.Button();
            this.ComponentesGB = new System.Windows.Forms.GroupBox();
            this.QuitarComponenteBTN = new System.Windows.Forms.Button();
            this.ComponenteDGV = new System.Windows.Forms.DataGridView();
            this.AgregarComponenteBTN = new System.Windows.Forms.Button();
            this.ModeloTB = new System.Windows.Forms.TextBox();
            this.MarcaTB = new System.Windows.Forms.TextBox();
            this.CodigoTB = new System.Windows.Forms.TextBox();
            this.ModeloLBL = new System.Windows.Forms.Label();
            this.MarcaLBL = new System.Windows.Forms.Label();
            this.CdoigoLBL = new System.Windows.Forms.Label();
            this.ComputadorasGB = new System.Windows.Forms.GroupBox();
            this.GestionarSoftwareBTN = new System.Windows.Forms.Button();
            this.ComputadorasDGV = new System.Windows.Forms.DataGridView();
            this.GestionarComputadoraBTN = new System.Windows.Forms.Button();
            this.ComputadoraGB.SuspendLayout();
            this.SoftwareGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoftwareDGV)).BeginInit();
            this.ComponentesGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComponenteDGV)).BeginInit();
            this.ComputadorasGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComputadorasDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ComputadoraGB
            // 
            this.ComputadoraGB.Controls.Add(this.ModificacionBTN);
            this.ComputadoraGB.Controls.Add(this.BajaBTN);
            this.ComputadoraGB.Controls.Add(this.AltaBTN);
            this.ComputadoraGB.Controls.Add(this.SoftwareGB);
            this.ComputadoraGB.Controls.Add(this.ComponentesGB);
            this.ComputadoraGB.Controls.Add(this.ModeloTB);
            this.ComputadoraGB.Controls.Add(this.MarcaTB);
            this.ComputadoraGB.Controls.Add(this.CodigoTB);
            this.ComputadoraGB.Controls.Add(this.ModeloLBL);
            this.ComputadoraGB.Controls.Add(this.MarcaLBL);
            this.ComputadoraGB.Controls.Add(this.CdoigoLBL);
            this.ComputadoraGB.Location = new System.Drawing.Point(598, 12);
            this.ComputadoraGB.Name = "ComputadoraGB";
            this.ComputadoraGB.Size = new System.Drawing.Size(564, 829);
            this.ComputadoraGB.TabIndex = 1;
            this.ComputadoraGB.TabStop = false;
            this.ComputadoraGB.Text = "Computadora";
            // 
            // ModificacionBTN
            // 
            this.ModificacionBTN.Location = new System.Drawing.Point(408, 766);
            this.ModificacionBTN.Name = "ModificacionBTN";
            this.ModificacionBTN.Size = new System.Drawing.Size(123, 41);
            this.ModificacionBTN.TabIndex = 4;
            this.ModificacionBTN.Text = "Modificacion";
            this.ModificacionBTN.UseVisualStyleBackColor = true;
            this.ModificacionBTN.Click += new System.EventHandler(this.ModificacionBTN_Click);
            // 
            // BajaBTN
            // 
            this.BajaBTN.Location = new System.Drawing.Point(229, 766);
            this.BajaBTN.Name = "BajaBTN";
            this.BajaBTN.Size = new System.Drawing.Size(123, 41);
            this.BajaBTN.TabIndex = 4;
            this.BajaBTN.Text = "Baja";
            this.BajaBTN.UseVisualStyleBackColor = true;
            this.BajaBTN.Click += new System.EventHandler(this.BajaBTN_Click);
            // 
            // AltaBTN
            // 
            this.AltaBTN.Location = new System.Drawing.Point(33, 766);
            this.AltaBTN.Name = "AltaBTN";
            this.AltaBTN.Size = new System.Drawing.Size(123, 41);
            this.AltaBTN.TabIndex = 4;
            this.AltaBTN.Text = "Alta";
            this.AltaBTN.UseVisualStyleBackColor = true;
            this.AltaBTN.Click += new System.EventHandler(this.AltaBTN_Click);
            // 
            // SoftwareGB
            // 
            this.SoftwareGB.Controls.Add(this.QuitarSoftwareBTN);
            this.SoftwareGB.Controls.Add(this.SoftwareDGV);
            this.SoftwareGB.Controls.Add(this.AgregarSoftwareBTN);
            this.SoftwareGB.Location = new System.Drawing.Point(20, 459);
            this.SoftwareGB.Name = "SoftwareGB";
            this.SoftwareGB.Size = new System.Drawing.Size(524, 290);
            this.SoftwareGB.TabIndex = 3;
            this.SoftwareGB.TabStop = false;
            this.SoftwareGB.Text = "Software";
            // 
            // QuitarSoftwareBTN
            // 
            this.QuitarSoftwareBTN.Location = new System.Drawing.Point(232, 242);
            this.QuitarSoftwareBTN.Name = "QuitarSoftwareBTN";
            this.QuitarSoftwareBTN.Size = new System.Drawing.Size(123, 41);
            this.QuitarSoftwareBTN.TabIndex = 5;
            this.QuitarSoftwareBTN.Text = "Quitar Software";
            this.QuitarSoftwareBTN.UseVisualStyleBackColor = true;
            this.QuitarSoftwareBTN.Click += new System.EventHandler(this.QuitarSoftwareBTN_Click);
            // 
            // SoftwareDGV
            // 
            this.SoftwareDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SoftwareDGV.Location = new System.Drawing.Point(11, 24);
            this.SoftwareDGV.Name = "SoftwareDGV";
            this.SoftwareDGV.Size = new System.Drawing.Size(500, 212);
            this.SoftwareDGV.TabIndex = 0;
            // 
            // AgregarSoftwareBTN
            // 
            this.AgregarSoftwareBTN.Location = new System.Drawing.Point(90, 242);
            this.AgregarSoftwareBTN.Name = "AgregarSoftwareBTN";
            this.AgregarSoftwareBTN.Size = new System.Drawing.Size(123, 41);
            this.AgregarSoftwareBTN.TabIndex = 6;
            this.AgregarSoftwareBTN.Text = "Agregar Software";
            this.AgregarSoftwareBTN.UseVisualStyleBackColor = true;
            this.AgregarSoftwareBTN.Click += new System.EventHandler(this.AgregarSoftwareBTN_Click);
            // 
            // ComponentesGB
            // 
            this.ComponentesGB.Controls.Add(this.QuitarComponenteBTN);
            this.ComponentesGB.Controls.Add(this.ComponenteDGV);
            this.ComponentesGB.Controls.Add(this.AgregarComponenteBTN);
            this.ComponentesGB.Location = new System.Drawing.Point(20, 172);
            this.ComponentesGB.Name = "ComponentesGB";
            this.ComponentesGB.Size = new System.Drawing.Size(524, 281);
            this.ComponentesGB.TabIndex = 2;
            this.ComponentesGB.TabStop = false;
            this.ComponentesGB.Text = "Componentes";
            // 
            // QuitarComponenteBTN
            // 
            this.QuitarComponenteBTN.Location = new System.Drawing.Point(232, 240);
            this.QuitarComponenteBTN.Name = "QuitarComponenteBTN";
            this.QuitarComponenteBTN.Size = new System.Drawing.Size(123, 41);
            this.QuitarComponenteBTN.TabIndex = 5;
            this.QuitarComponenteBTN.Text = "Quitar Componente";
            this.QuitarComponenteBTN.UseVisualStyleBackColor = true;
            this.QuitarComponenteBTN.Click += new System.EventHandler(this.QuitarComponenteBTN_Click);
            // 
            // ComponenteDGV
            // 
            this.ComponenteDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComponenteDGV.Location = new System.Drawing.Point(11, 24);
            this.ComponenteDGV.Name = "ComponenteDGV";
            this.ComponenteDGV.Size = new System.Drawing.Size(500, 212);
            this.ComponenteDGV.TabIndex = 0;
            // 
            // AgregarComponenteBTN
            // 
            this.AgregarComponenteBTN.Location = new System.Drawing.Point(90, 240);
            this.AgregarComponenteBTN.Name = "AgregarComponenteBTN";
            this.AgregarComponenteBTN.Size = new System.Drawing.Size(123, 41);
            this.AgregarComponenteBTN.TabIndex = 6;
            this.AgregarComponenteBTN.Text = "Agregar Componente";
            this.AgregarComponenteBTN.UseVisualStyleBackColor = true;
            this.AgregarComponenteBTN.Click += new System.EventHandler(this.AgregarComponenteBTN_Click);
            // 
            // ModeloTB
            // 
            this.ModeloTB.Location = new System.Drawing.Point(98, 137);
            this.ModeloTB.Name = "ModeloTB";
            this.ModeloTB.Size = new System.Drawing.Size(224, 20);
            this.ModeloTB.TabIndex = 1;
            // 
            // MarcaTB
            // 
            this.MarcaTB.Location = new System.Drawing.Point(98, 91);
            this.MarcaTB.Name = "MarcaTB";
            this.MarcaTB.Size = new System.Drawing.Size(224, 20);
            this.MarcaTB.TabIndex = 1;
            // 
            // CodigoTB
            // 
            this.CodigoTB.Location = new System.Drawing.Point(98, 44);
            this.CodigoTB.Name = "CodigoTB";
            this.CodigoTB.Size = new System.Drawing.Size(224, 20);
            this.CodigoTB.TabIndex = 1;
            // 
            // ModeloLBL
            // 
            this.ModeloLBL.Location = new System.Drawing.Point(21, 133);
            this.ModeloLBL.Name = "ModeloLBL";
            this.ModeloLBL.Size = new System.Drawing.Size(91, 24);
            this.ModeloLBL.TabIndex = 0;
            this.ModeloLBL.Text = "Modelo:";
            // 
            // MarcaLBL
            // 
            this.MarcaLBL.Location = new System.Drawing.Point(21, 91);
            this.MarcaLBL.Name = "MarcaLBL";
            this.MarcaLBL.Size = new System.Drawing.Size(91, 24);
            this.MarcaLBL.TabIndex = 0;
            this.MarcaLBL.Text = "Marca:";
            // 
            // CdoigoLBL
            // 
            this.CdoigoLBL.Location = new System.Drawing.Point(21, 48);
            this.CdoigoLBL.Name = "CdoigoLBL";
            this.CdoigoLBL.Size = new System.Drawing.Size(91, 24);
            this.CdoigoLBL.TabIndex = 0;
            this.CdoigoLBL.Text = "Codigo:";
            // 
            // ComputadorasGB
            // 
            this.ComputadorasGB.Controls.Add(this.GestionarSoftwareBTN);
            this.ComputadorasGB.Controls.Add(this.ComputadorasDGV);
            this.ComputadorasGB.Controls.Add(this.GestionarComputadoraBTN);
            this.ComputadorasGB.Location = new System.Drawing.Point(14, 6);
            this.ComputadorasGB.Name = "ComputadorasGB";
            this.ComputadorasGB.Size = new System.Drawing.Size(570, 829);
            this.ComputadorasGB.TabIndex = 2;
            this.ComputadorasGB.TabStop = false;
            this.ComputadorasGB.Text = "Computadoras:";
            // 
            // GestionarSoftwareBTN
            // 
            this.GestionarSoftwareBTN.Location = new System.Drawing.Point(268, 527);
            this.GestionarSoftwareBTN.Name = "GestionarSoftwareBTN";
            this.GestionarSoftwareBTN.Size = new System.Drawing.Size(123, 41);
            this.GestionarSoftwareBTN.TabIndex = 5;
            this.GestionarSoftwareBTN.Text = "Gestionar Software";
            this.GestionarSoftwareBTN.UseVisualStyleBackColor = true;
            this.GestionarSoftwareBTN.Click += new System.EventHandler(this.GestionarSoftwareBTN_Click);
            // 
            // ComputadorasDGV
            // 
            this.ComputadorasDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComputadorasDGV.Location = new System.Drawing.Point(3, 26);
            this.ComputadorasDGV.Name = "ComputadorasDGV";
            this.ComputadorasDGV.Size = new System.Drawing.Size(557, 469);
            this.ComputadorasDGV.TabIndex = 0;
            // 
            // GestionarComputadoraBTN
            // 
            this.GestionarComputadoraBTN.Location = new System.Drawing.Point(48, 527);
            this.GestionarComputadoraBTN.Name = "GestionarComputadoraBTN";
            this.GestionarComputadoraBTN.Size = new System.Drawing.Size(123, 41);
            this.GestionarComputadoraBTN.TabIndex = 6;
            this.GestionarComputadoraBTN.Text = "Gestionar Componentes";
            this.GestionarComputadoraBTN.UseVisualStyleBackColor = true;
            this.GestionarComputadoraBTN.Click += new System.EventHandler(this.GestionarComputadoraBTN_Click);
            // 
            // ComputadoraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 857);
            this.Controls.Add(this.ComputadorasGB);
            this.Controls.Add(this.ComputadoraGB);
            this.Name = "ComputadoraForm";
            this.Text = "ComputadoraForm";
            this.Load += new System.EventHandler(this.ComputadoraForm_Load);
            this.ComputadoraGB.ResumeLayout(false);
            this.ComputadoraGB.PerformLayout();
            this.SoftwareGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SoftwareDGV)).EndInit();
            this.ComponentesGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComponenteDGV)).EndInit();
            this.ComputadorasGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComputadorasDGV)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView ComponenteDGV;
        private System.Windows.Forms.DataGridView SoftwareDGV;
        private System.Windows.Forms.DataGridView ComputadorasDGV;
        private System.Windows.Forms.GroupBox ComputadoraGB;
        private System.Windows.Forms.GroupBox ComponentesGB;
        private System.Windows.Forms.GroupBox ComputadorasGB;
        private System.Windows.Forms.GroupBox SoftwareGB;
        private System.Windows.Forms.Label CdoigoLBL;
        private System.Windows.Forms.Label MarcaLBL;
        private System.Windows.Forms.Label ModeloLBL;
        private System.Windows.Forms.TextBox CodigoTB;
        private System.Windows.Forms.TextBox MarcaTB;
        private System.Windows.Forms.TextBox ModeloTB;

        #endregion

        private System.Windows.Forms.Button ModificacionBTN;
        private System.Windows.Forms.Button BajaBTN;
        private System.Windows.Forms.Button AltaBTN;
        private System.Windows.Forms.Button QuitarSoftwareBTN;
        private System.Windows.Forms.Button AgregarSoftwareBTN;
        private System.Windows.Forms.Button QuitarComponenteBTN;
        private System.Windows.Forms.Button AgregarComponenteBTN;
        private System.Windows.Forms.Button GestionarSoftwareBTN;
        private System.Windows.Forms.Button GestionarComputadoraBTN;
    }
}