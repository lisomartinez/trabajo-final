namespace UI
{
    partial class ComponenteForm
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
            this.ComponentesGB = new System.Windows.Forms.GroupBox();
            this.ComputadoraSeleccionadaGB = new System.Windows.Forms.GroupBox();
            this.AgregarComponeteACompBTN = new System.Windows.Forms.Button();
            this.ComputadoraIdLBL = new System.Windows.Forms.Label();
            this.ComputadoraIdTB = new System.Windows.Forms.TextBox();
            this.ComponentesDGV = new System.Windows.Forms.DataGridView();
            this.ComponenteGB = new System.Windows.Forms.GroupBox();
            this.ModeloTB = new System.Windows.Forms.TextBox();
            this.MarcaTB = new System.Windows.Forms.TextBox();
            this.NroSerieTB = new System.Windows.Forms.TextBox();
            this.ModificarBTN = new System.Windows.Forms.Button();
            this.BajaBTN = new System.Windows.Forms.Button();
            this.AltaBTN = new System.Windows.Forms.Button();
            this.ModeloLBL = new System.Windows.Forms.Label();
            this.MarcaLBL = new System.Windows.Forms.Label();
            this.NroSerieLBL = new System.Windows.Forms.Label();
            this.EspecificacionesGB = new System.Windows.Forms.GroupBox();
            this.EspecificacionDGV = new System.Windows.Forms.DataGridView();
            this.EspecificacionGB = new System.Windows.Forms.GroupBox();
            this.DescripcionTB = new System.Windows.Forms.TextBox();
            this.NombreTB = new System.Windows.Forms.TextBox();
            this.CodigoTB = new System.Windows.Forms.TextBox();
            this.ModificacionEspecificacionBTN = new System.Windows.Forms.Button();
            this.BajaEspecificacionBTN = new System.Windows.Forms.Button();
            this.AltaEspecificacionBTN = new System.Windows.Forms.Button();
            this.DescripcionLBL = new System.Windows.Forms.Label();
            this.NombreLBL = new System.Windows.Forms.Label();
            this.CodigoLBL = new System.Windows.Forms.Label();
            this.ComponentesGB.SuspendLayout();
            this.ComputadoraSeleccionadaGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComponentesDGV)).BeginInit();
            this.ComponenteGB.SuspendLayout();
            this.EspecificacionesGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EspecificacionDGV)).BeginInit();
            this.EspecificacionGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComponentesGB
            // 
            this.ComponentesGB.Controls.Add(this.ComputadoraSeleccionadaGB);
            this.ComponentesGB.Controls.Add(this.ComponentesDGV);
            this.ComponentesGB.Location = new System.Drawing.Point(12, 12);
            this.ComponentesGB.Name = "ComponentesGB";
            this.ComponentesGB.Size = new System.Drawing.Size(598, 686);
            this.ComponentesGB.TabIndex = 0;
            this.ComponentesGB.TabStop = false;
            this.ComponentesGB.Text = "Componentes";
            // 
            // ComputadoraSeleccionadaGB
            // 
            this.ComputadoraSeleccionadaGB.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ComputadoraSeleccionadaGB.Controls.Add(this.AgregarComponeteACompBTN);
            this.ComputadoraSeleccionadaGB.Controls.Add(this.ComputadoraIdLBL);
            this.ComputadoraSeleccionadaGB.Controls.Add(this.ComputadoraIdTB);
            this.ComputadoraSeleccionadaGB.Location = new System.Drawing.Point(0, 547);
            this.ComputadoraSeleccionadaGB.Name = "ComputadoraSeleccionadaGB";
            this.ComputadoraSeleccionadaGB.Size = new System.Drawing.Size(590, 100);
            this.ComputadoraSeleccionadaGB.TabIndex = 3;
            this.ComputadoraSeleccionadaGB.TabStop = false;
            this.ComputadoraSeleccionadaGB.Text = "Computadora Seleccionada";
            // 
            // AgregarComponeteACompBTN
            // 
            this.AgregarComponeteACompBTN.Location = new System.Drawing.Point(18, 66);
            this.AgregarComponeteACompBTN.Name = "AgregarComponeteACompBTN";
            this.AgregarComponeteACompBTN.Size = new System.Drawing.Size(554, 28);
            this.AgregarComponeteACompBTN.TabIndex = 4;
            this.AgregarComponeteACompBTN.Text = "Agregar Componente Seleccionado a Computadora";
            this.AgregarComponeteACompBTN.UseVisualStyleBackColor = true;
            this.AgregarComponeteACompBTN.Click += new System.EventHandler(this.AgregarComponeteACompBTN_Click);
            // 
            // ComputadoraIdLBL
            // 
            this.ComputadoraIdLBL.AutoSize = true;
            this.ComputadoraIdLBL.Location = new System.Drawing.Point(15, 37);
            this.ComputadoraIdLBL.Name = "ComputadoraIdLBL";
            this.ComputadoraIdLBL.Size = new System.Drawing.Size(82, 13);
            this.ComputadoraIdLBL.TabIndex = 2;
            this.ComputadoraIdLBL.Text = "Id Computadora";
            // 
            // ComputadoraIdTB
            // 
            this.ComputadoraIdTB.Location = new System.Drawing.Point(103, 34);
            this.ComputadoraIdTB.Name = "ComputadoraIdTB";
            this.ComputadoraIdTB.Size = new System.Drawing.Size(217, 20);
            this.ComputadoraIdTB.TabIndex = 2;
            // 
            // ComponentesDGV
            // 
            this.ComponentesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComponentesDGV.Location = new System.Drawing.Point(0, 19);
            this.ComponentesDGV.Name = "ComponentesDGV";
            this.ComponentesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ComponentesDGV.Size = new System.Drawing.Size(590, 513);
            this.ComponentesDGV.TabIndex = 0;
            this.ComponentesDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ComponentesDGV_CellClick);
            // 
            // ComponenteGB
            // 
            this.ComponenteGB.Controls.Add(this.ModeloTB);
            this.ComponenteGB.Controls.Add(this.MarcaTB);
            this.ComponenteGB.Controls.Add(this.NroSerieTB);
            this.ComponenteGB.Controls.Add(this.ModificarBTN);
            this.ComponenteGB.Controls.Add(this.BajaBTN);
            this.ComponenteGB.Controls.Add(this.AltaBTN);
            this.ComponenteGB.Controls.Add(this.ModeloLBL);
            this.ComponenteGB.Controls.Add(this.MarcaLBL);
            this.ComponenteGB.Controls.Add(this.NroSerieLBL);
            this.ComponenteGB.Location = new System.Drawing.Point(629, 74);
            this.ComponenteGB.Name = "ComponenteGB";
            this.ComponenteGB.Size = new System.Drawing.Size(320, 223);
            this.ComponenteGB.TabIndex = 1;
            this.ComponenteGB.TabStop = false;
            this.ComponenteGB.Text = "Componente";
            // 
            // ModeloTB
            // 
            this.ModeloTB.Location = new System.Drawing.Point(104, 123);
            this.ModeloTB.Name = "ModeloTB";
            this.ModeloTB.Size = new System.Drawing.Size(200, 20);
            this.ModeloTB.TabIndex = 2;
            // 
            // MarcaTB
            // 
            this.MarcaTB.Location = new System.Drawing.Point(104, 69);
            this.MarcaTB.Name = "MarcaTB";
            this.MarcaTB.Size = new System.Drawing.Size(200, 20);
            this.MarcaTB.TabIndex = 2;
            // 
            // NroSerieTB
            // 
            this.NroSerieTB.Location = new System.Drawing.Point(104, 20);
            this.NroSerieTB.Name = "NroSerieTB";
            this.NroSerieTB.Size = new System.Drawing.Size(200, 20);
            this.NroSerieTB.TabIndex = 2;
            // 
            // ModificarBTN
            // 
            this.ModificarBTN.Location = new System.Drawing.Point(175, 184);
            this.ModificarBTN.Name = "ModificarBTN";
            this.ModificarBTN.Size = new System.Drawing.Size(75, 23);
            this.ModificarBTN.TabIndex = 1;
            this.ModificarBTN.Text = "Modificacion";
            this.ModificarBTN.UseVisualStyleBackColor = true;
            this.ModificarBTN.Click += new System.EventHandler(this.ModificarBTN_Click);
            // 
            // BajaBTN
            // 
            this.BajaBTN.Location = new System.Drawing.Point(94, 184);
            this.BajaBTN.Name = "BajaBTN";
            this.BajaBTN.Size = new System.Drawing.Size(75, 23);
            this.BajaBTN.TabIndex = 1;
            this.BajaBTN.Text = "Baja";
            this.BajaBTN.UseVisualStyleBackColor = true;
            this.BajaBTN.Click += new System.EventHandler(this.BajaBTN_Click);
            // 
            // AltaBTN
            // 
            this.AltaBTN.Location = new System.Drawing.Point(13, 184);
            this.AltaBTN.Name = "AltaBTN";
            this.AltaBTN.Size = new System.Drawing.Size(75, 23);
            this.AltaBTN.TabIndex = 1;
            this.AltaBTN.Text = "Alta";
            this.AltaBTN.UseVisualStyleBackColor = true;
            this.AltaBTN.Click += new System.EventHandler(this.AltaBTN_Click);
            // 
            // ModeloLBL
            // 
            this.ModeloLBL.AutoSize = true;
            this.ModeloLBL.Location = new System.Drawing.Point(10, 134);
            this.ModeloLBL.Name = "ModeloLBL";
            this.ModeloLBL.Size = new System.Drawing.Size(42, 13);
            this.ModeloLBL.TabIndex = 0;
            this.ModeloLBL.Text = "Modelo";
            // 
            // MarcaLBL
            // 
            this.MarcaLBL.AutoSize = true;
            this.MarcaLBL.Location = new System.Drawing.Point(10, 76);
            this.MarcaLBL.Name = "MarcaLBL";
            this.MarcaLBL.Size = new System.Drawing.Size(37, 13);
            this.MarcaLBL.TabIndex = 0;
            this.MarcaLBL.Text = "Marca";
            // 
            // NroSerieLBL
            // 
            this.NroSerieLBL.AutoSize = true;
            this.NroSerieLBL.Location = new System.Drawing.Point(10, 26);
            this.NroSerieLBL.Name = "NroSerieLBL";
            this.NroSerieLBL.Size = new System.Drawing.Size(86, 13);
            this.NroSerieLBL.TabIndex = 0;
            this.NroSerieLBL.Text = "Numero de Serie";
            // 
            // EspecificacionesGB
            // 
            this.EspecificacionesGB.Controls.Add(this.EspecificacionDGV);
            this.EspecificacionesGB.Location = new System.Drawing.Point(960, 12);
            this.EspecificacionesGB.Name = "EspecificacionesGB";
            this.EspecificacionesGB.Size = new System.Drawing.Size(600, 553);
            this.EspecificacionesGB.TabIndex = 1;
            this.EspecificacionesGB.TabStop = false;
            this.EspecificacionesGB.Text = "Especificaciones Técnicas";
            // 
            // EspecificacionDGV
            // 
            this.EspecificacionDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EspecificacionDGV.Location = new System.Drawing.Point(4, 20);
            this.EspecificacionDGV.Name = "EspecificacionDGV";
            this.EspecificacionDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EspecificacionDGV.Size = new System.Drawing.Size(590, 512);
            this.EspecificacionDGV.TabIndex = 0;
            this.EspecificacionDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EspecificacionDGV_CellClick);
            // 
            // EspecificacionGB
            // 
            this.EspecificacionGB.Controls.Add(this.DescripcionTB);
            this.EspecificacionGB.Controls.Add(this.NombreTB);
            this.EspecificacionGB.Controls.Add(this.CodigoTB);
            this.EspecificacionGB.Controls.Add(this.ModificacionEspecificacionBTN);
            this.EspecificacionGB.Controls.Add(this.BajaEspecificacionBTN);
            this.EspecificacionGB.Controls.Add(this.AltaEspecificacionBTN);
            this.EspecificacionGB.Controls.Add(this.DescripcionLBL);
            this.EspecificacionGB.Controls.Add(this.NombreLBL);
            this.EspecificacionGB.Controls.Add(this.CodigoLBL);
            this.EspecificacionGB.Location = new System.Drawing.Point(629, 360);
            this.EspecificacionGB.Name = "EspecificacionGB";
            this.EspecificacionGB.Size = new System.Drawing.Size(320, 253);
            this.EspecificacionGB.TabIndex = 2;
            this.EspecificacionGB.TabStop = false;
            this.EspecificacionGB.Text = "Especificación Técnica";
            // 
            // DescripcionTB
            // 
            this.DescripcionTB.Location = new System.Drawing.Point(104, 122);
            this.DescripcionTB.Name = "DescripcionTB";
            this.DescripcionTB.Size = new System.Drawing.Size(200, 20);
            this.DescripcionTB.TabIndex = 2;
            // 
            // NombreTB
            // 
            this.NombreTB.Location = new System.Drawing.Point(104, 78);
            this.NombreTB.Name = "NombreTB";
            this.NombreTB.Size = new System.Drawing.Size(200, 20);
            this.NombreTB.TabIndex = 2;
            // 
            // CodigoTB
            // 
            this.CodigoTB.Location = new System.Drawing.Point(104, 37);
            this.CodigoTB.Name = "CodigoTB";
            this.CodigoTB.Size = new System.Drawing.Size(200, 20);
            this.CodigoTB.TabIndex = 2;
            // 
            // ModificacionEspecificacionBTN
            // 
            this.ModificacionEspecificacionBTN.Location = new System.Drawing.Point(185, 182);
            this.ModificacionEspecificacionBTN.Name = "ModificacionEspecificacionBTN";
            this.ModificacionEspecificacionBTN.Size = new System.Drawing.Size(75, 23);
            this.ModificacionEspecificacionBTN.TabIndex = 2;
            this.ModificacionEspecificacionBTN.Text = "Modificacion";
            this.ModificacionEspecificacionBTN.UseVisualStyleBackColor = true;
            this.ModificacionEspecificacionBTN.Click += new System.EventHandler(this.ModificacionEspecificacionBTN_Click);
            // 
            // BajaEspecificacionBTN
            // 
            this.BajaEspecificacionBTN.Location = new System.Drawing.Point(104, 182);
            this.BajaEspecificacionBTN.Name = "BajaEspecificacionBTN";
            this.BajaEspecificacionBTN.Size = new System.Drawing.Size(75, 23);
            this.BajaEspecificacionBTN.TabIndex = 3;
            this.BajaEspecificacionBTN.Text = "Baja";
            this.BajaEspecificacionBTN.UseVisualStyleBackColor = true;
            this.BajaEspecificacionBTN.Click += new System.EventHandler(this.BajaEspecificacionBTN_Click);
            // 
            // AltaEspecificacionBTN
            // 
            this.AltaEspecificacionBTN.Location = new System.Drawing.Point(23, 182);
            this.AltaEspecificacionBTN.Name = "AltaEspecificacionBTN";
            this.AltaEspecificacionBTN.Size = new System.Drawing.Size(75, 23);
            this.AltaEspecificacionBTN.TabIndex = 4;
            this.AltaEspecificacionBTN.Text = "Alta";
            this.AltaEspecificacionBTN.UseVisualStyleBackColor = true;
            this.AltaEspecificacionBTN.Click += new System.EventHandler(this.AltaEspecificacionBTN_Click);
            // 
            // DescripcionLBL
            // 
            this.DescripcionLBL.AutoSize = true;
            this.DescripcionLBL.Location = new System.Drawing.Point(20, 129);
            this.DescripcionLBL.Name = "DescripcionLBL";
            this.DescripcionLBL.Size = new System.Drawing.Size(63, 13);
            this.DescripcionLBL.TabIndex = 0;
            this.DescripcionLBL.Text = "Descripcion";
            // 
            // NombreLBL
            // 
            this.NombreLBL.AutoSize = true;
            this.NombreLBL.Location = new System.Drawing.Point(20, 85);
            this.NombreLBL.Name = "NombreLBL";
            this.NombreLBL.Size = new System.Drawing.Size(44, 13);
            this.NombreLBL.TabIndex = 1;
            this.NombreLBL.Text = "Nombre";
            // 
            // CodigoLBL
            // 
            this.CodigoLBL.AutoSize = true;
            this.CodigoLBL.Location = new System.Drawing.Point(20, 44);
            this.CodigoLBL.Name = "CodigoLBL";
            this.CodigoLBL.Size = new System.Drawing.Size(40, 13);
            this.CodigoLBL.TabIndex = 1;
            this.CodigoLBL.Text = "Codigo";
            // 
            // ComponenteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1572, 811);
            this.Controls.Add(this.EspecificacionGB);
            this.Controls.Add(this.EspecificacionesGB);
            this.Controls.Add(this.ComponenteGB);
            this.Controls.Add(this.ComponentesGB);
            this.Name = "ComponenteForm";
            this.Text = "ComponenteForm";
            this.Load += new System.EventHandler(this.ComponenteForm_Load);
            this.ComponentesGB.ResumeLayout(false);
            this.ComputadoraSeleccionadaGB.ResumeLayout(false);
            this.ComputadoraSeleccionadaGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComponentesDGV)).EndInit();
            this.ComponenteGB.ResumeLayout(false);
            this.ComponenteGB.PerformLayout();
            this.EspecificacionesGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EspecificacionDGV)).EndInit();
            this.EspecificacionGB.ResumeLayout(false);
            this.EspecificacionGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ComponentesGB;
        private System.Windows.Forms.DataGridView ComponentesDGV;
        private System.Windows.Forms.GroupBox ComponenteGB;
        private System.Windows.Forms.Label ModeloLBL;
        private System.Windows.Forms.Label MarcaLBL;
        private System.Windows.Forms.Label NroSerieLBL;
        private System.Windows.Forms.GroupBox EspecificacionesGB;
        private System.Windows.Forms.GroupBox EspecificacionGB;
        private System.Windows.Forms.Button ModificarBTN;
        private System.Windows.Forms.Button BajaBTN;
        private System.Windows.Forms.Button AltaBTN;
        private System.Windows.Forms.DataGridView EspecificacionDGV;
        private System.Windows.Forms.Button ModificacionEspecificacionBTN;
        private System.Windows.Forms.Button BajaEspecificacionBTN;
        private System.Windows.Forms.Button AltaEspecificacionBTN;
        private System.Windows.Forms.Label DescripcionLBL;
        private System.Windows.Forms.Label NombreLBL;
        private System.Windows.Forms.Label CodigoLBL;
        private System.Windows.Forms.GroupBox ComputadoraSeleccionadaGB;
        private System.Windows.Forms.Label ComputadoraIdLBL;
        private System.Windows.Forms.TextBox ModeloTB;
        private System.Windows.Forms.TextBox MarcaTB;
        private System.Windows.Forms.TextBox NroSerieTB;
        private System.Windows.Forms.TextBox DescripcionTB;
        private System.Windows.Forms.TextBox NombreTB;
        private System.Windows.Forms.TextBox CodigoTB;
        private System.Windows.Forms.Button AgregarComponeteACompBTN;
        private System.Windows.Forms.TextBox ComputadoraIdTB;
    }
}