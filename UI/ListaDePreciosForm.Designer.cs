namespace UI
{
    partial class ListaDePreciosForm
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
            this.ComponentesPrecioDGV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PrecioTB = new System.Windows.Forms.TextBox();
            this.ModeloTB = new System.Windows.Forms.TextBox();
            this.MarcaTB = new System.Windows.Forms.TextBox();
            this.NroSerieTB = new System.Windows.Forms.TextBox();
            this.PrecioLBL = new System.Windows.Forms.Label();
            this.AgregarComponenteBTN = new System.Windows.Forms.Button();
            this.EliminarComponenteBTN = new System.Windows.Forms.Button();
            this.AsignarPrecioBTN = new System.Windows.Forms.Button();
            this.ModeloLBL = new System.Windows.Forms.Label();
            this.MarcaLBL = new System.Windows.Forms.Label();
            this.NroSerieLBL = new System.Windows.Forms.Label();
            this.ComponentesGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComponentesPrecioDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComponentesGB
            // 
            this.ComponentesGB.Controls.Add(this.ComponentesPrecioDGV);
            this.ComponentesGB.Location = new System.Drawing.Point(15, 22);
            this.ComponentesGB.Name = "ComponentesGB";
            this.ComponentesGB.Size = new System.Drawing.Size(486, 660);
            this.ComponentesGB.TabIndex = 0;
            this.ComponentesGB.TabStop = false;
            this.ComponentesGB.Text = "Precios de Componentes";
            // 
            // ComponentesPrecioDGV
            // 
            this.ComponentesPrecioDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComponentesPrecioDGV.Location = new System.Drawing.Point(11, 29);
            this.ComponentesPrecioDGV.Name = "ComponentesPrecioDGV";
            this.ComponentesPrecioDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ComponentesPrecioDGV.Size = new System.Drawing.Size(453, 616);
            this.ComponentesPrecioDGV.TabIndex = 0;
            this.ComponentesPrecioDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ComponentesPrecioDGV_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PrecioTB);
            this.groupBox1.Controls.Add(this.ModeloTB);
            this.groupBox1.Controls.Add(this.MarcaTB);
            this.groupBox1.Controls.Add(this.NroSerieTB);
            this.groupBox1.Controls.Add(this.PrecioLBL);
            this.groupBox1.Controls.Add(this.AgregarComponenteBTN);
            this.groupBox1.Controls.Add(this.EliminarComponenteBTN);
            this.groupBox1.Controls.Add(this.AsignarPrecioBTN);
            this.groupBox1.Controls.Add(this.ModeloLBL);
            this.groupBox1.Controls.Add(this.MarcaLBL);
            this.groupBox1.Controls.Add(this.NroSerieLBL);
            this.groupBox1.Location = new System.Drawing.Point(524, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 351);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Componente";
            // 
            // PrecioTB
            // 
            this.PrecioTB.Location = new System.Drawing.Point(147, 201);
            this.PrecioTB.Name = "PrecioTB";
            this.PrecioTB.Size = new System.Drawing.Size(200, 20);
            this.PrecioTB.TabIndex = 9;
            // 
            // ModeloTB
            // 
            this.ModeloTB.Enabled = false;
            this.ModeloTB.Location = new System.Drawing.Point(147, 147);
            this.ModeloTB.Name = "ModeloTB";
            this.ModeloTB.Size = new System.Drawing.Size(200, 20);
            this.ModeloTB.TabIndex = 9;
            // 
            // MarcaTB
            // 
            this.MarcaTB.Enabled = false;
            this.MarcaTB.Location = new System.Drawing.Point(147, 96);
            this.MarcaTB.Name = "MarcaTB";
            this.MarcaTB.Size = new System.Drawing.Size(200, 20);
            this.MarcaTB.TabIndex = 10;
            // 
            // NroSerieTB
            // 
            this.NroSerieTB.Enabled = false;
            this.NroSerieTB.Location = new System.Drawing.Point(145, 43);
            this.NroSerieTB.Name = "NroSerieTB";
            this.NroSerieTB.Size = new System.Drawing.Size(200, 20);
            this.NroSerieTB.TabIndex = 11;
            // 
            // PrecioLBL
            // 
            this.PrecioLBL.AutoSize = true;
            this.PrecioLBL.Location = new System.Drawing.Point(53, 204);
            this.PrecioLBL.Name = "PrecioLBL";
            this.PrecioLBL.Size = new System.Drawing.Size(37, 13);
            this.PrecioLBL.TabIndex = 3;
            this.PrecioLBL.Text = "Precio";
            // 
            // AgregarComponenteBTN
            // 
            this.AgregarComponenteBTN.Location = new System.Drawing.Point(147, 296);
            this.AgregarComponenteBTN.Name = "AgregarComponenteBTN";
            this.AgregarComponenteBTN.Size = new System.Drawing.Size(198, 23);
            this.AgregarComponenteBTN.TabIndex = 8;
            this.AgregarComponenteBTN.Text = "Agregar Componente de Lista";
            this.AgregarComponenteBTN.UseVisualStyleBackColor = true;
            this.AgregarComponenteBTN.Click += new System.EventHandler(this.AgregarComponenteBTN_Click);
            // 
            // EliminarComponenteBTN
            // 
            this.EliminarComponenteBTN.Location = new System.Drawing.Point(240, 256);
            this.EliminarComponenteBTN.Name = "EliminarComponenteBTN";
            this.EliminarComponenteBTN.Size = new System.Drawing.Size(198, 23);
            this.EliminarComponenteBTN.TabIndex = 8;
            this.EliminarComponenteBTN.Text = "Eliminar Componente de Lista";
            this.EliminarComponenteBTN.UseVisualStyleBackColor = true;
            this.EliminarComponenteBTN.Click += new System.EventHandler(this.EliminarComponenteBTN_Click);
            // 
            // AsignarPrecioBTN
            // 
            this.AsignarPrecioBTN.Location = new System.Drawing.Point(16, 256);
            this.AsignarPrecioBTN.Name = "AsignarPrecioBTN";
            this.AsignarPrecioBTN.Size = new System.Drawing.Size(198, 23);
            this.AsignarPrecioBTN.TabIndex = 8;
            this.AsignarPrecioBTN.Text = "Asignar Precio";
            this.AsignarPrecioBTN.UseVisualStyleBackColor = true;
            this.AsignarPrecioBTN.Click += new System.EventHandler(this.AsignarPrecioBTN_Click);
            // 
            // ModeloLBL
            // 
            this.ModeloLBL.AutoSize = true;
            this.ModeloLBL.Location = new System.Drawing.Point(53, 154);
            this.ModeloLBL.Name = "ModeloLBL";
            this.ModeloLBL.Size = new System.Drawing.Size(42, 13);
            this.ModeloLBL.TabIndex = 3;
            this.ModeloLBL.Text = "Modelo";
            // 
            // MarcaLBL
            // 
            this.MarcaLBL.AutoSize = true;
            this.MarcaLBL.Location = new System.Drawing.Point(53, 96);
            this.MarcaLBL.Name = "MarcaLBL";
            this.MarcaLBL.Size = new System.Drawing.Size(37, 13);
            this.MarcaLBL.TabIndex = 4;
            this.MarcaLBL.Text = "Marca";
            // 
            // NroSerieLBL
            // 
            this.NroSerieLBL.AutoSize = true;
            this.NroSerieLBL.Location = new System.Drawing.Point(53, 46);
            this.NroSerieLBL.Name = "NroSerieLBL";
            this.NroSerieLBL.Size = new System.Drawing.Size(86, 13);
            this.NroSerieLBL.TabIndex = 5;
            this.NroSerieLBL.Text = "Numero de Serie";
            // 
            // ListaDePreciosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 759);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ComponentesGB);
            this.Name = "ListaDePreciosForm";
            this.Text = "ListaDePreciosForm";
            this.Load += new System.EventHandler(this.ListaDePreciosForm_Load);
            this.ComponentesGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComponentesPrecioDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ComponentesGB;
        private System.Windows.Forms.DataGridView ComponentesPrecioDGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ModeloTB;
        private System.Windows.Forms.TextBox MarcaTB;
        private System.Windows.Forms.TextBox NroSerieTB;
        private System.Windows.Forms.Button AsignarPrecioBTN;
        private System.Windows.Forms.Label ModeloLBL;
        private System.Windows.Forms.Label MarcaLBL;
        private System.Windows.Forms.Label NroSerieLBL;
        private System.Windows.Forms.TextBox PrecioTB;
        private System.Windows.Forms.Label PrecioLBL;
        private System.Windows.Forms.Button AgregarComponenteBTN;
        private System.Windows.Forms.Button EliminarComponenteBTN;
    }
}