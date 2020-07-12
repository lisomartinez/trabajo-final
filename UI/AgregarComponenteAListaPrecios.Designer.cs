namespace UI
{
    partial class AgregarComponenteAListaPrecios
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
            this.ComponentesDGV = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AgregarBTN = new System.Windows.Forms.Button();
            this.PrecioTB = new System.Windows.Forms.TextBox();
            this.ModeloTB = new System.Windows.Forms.TextBox();
            this.MarcaTB = new System.Windows.Forms.TextBox();
            this.NroSerieTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NroSerieLBL = new System.Windows.Forms.Label();
            this.ComponentesGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComponentesDGV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComponentesGB
            // 
            this.ComponentesGB.Controls.Add(this.ComponentesDGV);
            this.ComponentesGB.Location = new System.Drawing.Point(12, 3);
            this.ComponentesGB.Name = "ComponentesGB";
            this.ComponentesGB.Size = new System.Drawing.Size(566, 502);
            this.ComponentesGB.TabIndex = 0;
            this.ComponentesGB.TabStop = false;
            this.ComponentesGB.Text = "ComponentesGB";
            // 
            // ComponentesDGV
            // 
            this.ComponentesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComponentesDGV.Location = new System.Drawing.Point(10, 19);
            this.ComponentesDGV.Name = "ComponentesDGV";
            this.ComponentesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ComponentesDGV.Size = new System.Drawing.Size(550, 477);
            this.ComponentesDGV.TabIndex = 0;
            this.ComponentesDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ComponentesDGV_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AgregarBTN);
            this.groupBox2.Controls.Add(this.PrecioTB);
            this.groupBox2.Controls.Add(this.ModeloTB);
            this.groupBox2.Controls.Add(this.MarcaTB);
            this.groupBox2.Controls.Add(this.NroSerieTB);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.NroSerieLBL);
            this.groupBox2.Location = new System.Drawing.Point(596, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 502);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ComponenteGB";
            // 
            // AgregarBTN
            // 
            this.AgregarBTN.Location = new System.Drawing.Point(30, 202);
            this.AgregarBTN.Name = "AgregarBTN";
            this.AgregarBTN.Size = new System.Drawing.Size(308, 37);
            this.AgregarBTN.TabIndex = 2;
            this.AgregarBTN.Text = "Agregar";
            this.AgregarBTN.UseVisualStyleBackColor = true;
            this.AgregarBTN.Click += new System.EventHandler(this.AgregarBTN_Click);
            // 
            // PrecioTB
            // 
            this.PrecioTB.Location = new System.Drawing.Point(141, 145);
            this.PrecioTB.Name = "PrecioTB";
            this.PrecioTB.Size = new System.Drawing.Size(198, 20);
            this.PrecioTB.TabIndex = 1;
            // 
            // ModeloTB
            // 
            this.ModeloTB.Enabled = false;
            this.ModeloTB.Location = new System.Drawing.Point(141, 105);
            this.ModeloTB.Name = "ModeloTB";
            this.ModeloTB.Size = new System.Drawing.Size(198, 20);
            this.ModeloTB.TabIndex = 1;
            // 
            // MarcaTB
            // 
            this.MarcaTB.Enabled = false;
            this.MarcaTB.Location = new System.Drawing.Point(141, 65);
            this.MarcaTB.Name = "MarcaTB";
            this.MarcaTB.Size = new System.Drawing.Size(198, 20);
            this.MarcaTB.TabIndex = 1;
            // 
            // NroSerieTB
            // 
            this.NroSerieTB.Enabled = false;
            this.NroSerieTB.Location = new System.Drawing.Point(141, 25);
            this.NroSerieTB.Name = "NroSerieTB";
            this.NroSerieTB.Size = new System.Drawing.Size(198, 20);
            this.NroSerieTB.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Modelo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Marca:";
            // 
            // NroSerieLBL
            // 
            this.NroSerieLBL.AutoSize = true;
            this.NroSerieLBL.Location = new System.Drawing.Point(25, 32);
            this.NroSerieLBL.Name = "NroSerieLBL";
            this.NroSerieLBL.Size = new System.Drawing.Size(89, 13);
            this.NroSerieLBL.TabIndex = 0;
            this.NroSerieLBL.Text = "Numero de Serie:";
            // 
            // AgregarComponenteAListaPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 532);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ComponentesGB);
            this.Name = "AgregarComponenteAListaPrecios";
            this.Text = "AgregarComponenteAListaPreciosControlador";
            this.Load += new System.EventHandler(this.AgregarComponenteAListaPrecios_Load);
            this.ComponentesGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComponentesDGV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ComponentesGB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView ComponentesDGV;
        private System.Windows.Forms.Button AgregarBTN;
        private System.Windows.Forms.TextBox PrecioTB;
        private System.Windows.Forms.TextBox ModeloTB;
        private System.Windows.Forms.TextBox MarcaTB;
        private System.Windows.Forms.TextBox NroSerieTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NroSerieLBL;
    }
}