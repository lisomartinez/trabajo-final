using System.ComponentModel;

namespace UI
{
    partial class ReemplazoComponenteForm
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
            this.ComponentesGB = new System.Windows.Forms.GroupBox();
            this.ReemplazarBTN = new System.Windows.Forms.Button();
            this.ComponentesDGV = new System.Windows.Forms.DataGridView();
            this.ModeloTB = new System.Windows.Forms.TextBox();
            this.MarcaTB = new System.Windows.Forms.TextBox();
            this.CodigoTB = new System.Windows.Forms.TextBox();
            this.ModeloLBL = new System.Windows.Forms.Label();
            this.MarcaLBL = new System.Windows.Forms.Label();
            this.CodigoLBL = new System.Windows.Forms.Label();
            this.ComputadoraGB.SuspendLayout();
            this.ComponentesGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComponentesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ComputadoraGB
            // 
            this.ComputadoraGB.Controls.Add(this.ComponentesGB);
            this.ComputadoraGB.Controls.Add(this.ModeloTB);
            this.ComputadoraGB.Controls.Add(this.MarcaTB);
            this.ComputadoraGB.Controls.Add(this.CodigoTB);
            this.ComputadoraGB.Controls.Add(this.ModeloLBL);
            this.ComputadoraGB.Controls.Add(this.MarcaLBL);
            this.ComputadoraGB.Controls.Add(this.CodigoLBL);
            this.ComputadoraGB.Location = new System.Drawing.Point(12, 19);
            this.ComputadoraGB.Name = "ComputadoraGB";
            this.ComputadoraGB.Size = new System.Drawing.Size(567, 514);
            this.ComputadoraGB.TabIndex = 0;
            this.ComputadoraGB.TabStop = false;
            this.ComputadoraGB.Text = "Computadora";
            // 
            // ComponentesGB
            // 
            this.ComponentesGB.Controls.Add(this.ReemplazarBTN);
            this.ComponentesGB.Controls.Add(this.ComponentesDGV);
            this.ComponentesGB.Location = new System.Drawing.Point(20, 185);
            this.ComponentesGB.Name = "ComponentesGB";
            this.ComponentesGB.Size = new System.Drawing.Size(524, 298);
            this.ComponentesGB.TabIndex = 2;
            this.ComponentesGB.TabStop = false;
            this.ComponentesGB.Text = "Componentes";
            // 
            // ReemplazarBTN
            // 
            this.ReemplazarBTN.Location = new System.Drawing.Point(11, 253);
            this.ReemplazarBTN.Name = "ReemplazarBTN";
            this.ReemplazarBTN.Size = new System.Drawing.Size(204, 29);
            this.ReemplazarBTN.TabIndex = 1;
            this.ReemplazarBTN.Text = "Reemplazar Componente";
            this.ReemplazarBTN.UseVisualStyleBackColor = true;
            this.ReemplazarBTN.Click += new System.EventHandler(this.ReemplazarBTN_Click);
            // 
            // ComponentesDGV
            // 
            this.ComponentesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComponentesDGV.Location = new System.Drawing.Point(11, 24);
            this.ComponentesDGV.Name = "ComponentesDGV";
            this.ComponentesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ComponentesDGV.Size = new System.Drawing.Size(500, 212);
            this.ComponentesDGV.TabIndex = 0;
            this.ComponentesDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ComponentesDGV_CellClick);
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
            // CodigoLBL
            // 
            this.CodigoLBL.Location = new System.Drawing.Point(21, 48);
            this.CodigoLBL.Name = "CodigoLBL";
            this.CodigoLBL.Size = new System.Drawing.Size(91, 24);
            this.CodigoLBL.TabIndex = 0;
            this.CodigoLBL.Text = "Codigo:";
            // 
            // ReemplazoComponenteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 553);
            this.Controls.Add(this.ComputadoraGB);
            this.Name = "ReemplazoComponenteForm";
            this.Text = "Reemplazar Componente";
            this.Load += new System.EventHandler(this.ReemplazoComponenteForm_Load);
            this.ComputadoraGB.ResumeLayout(false);
            this.ComputadoraGB.PerformLayout();
            this.ComponentesGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComponentesDGV)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button ReemplazarBTN;
        private System.Windows.Forms.DataGridView ComponentesDGV;
        private System.Windows.Forms.GroupBox ComputadoraGB;
        private System.Windows.Forms.GroupBox ComponentesGB;
        private System.Windows.Forms.Label CodigoLBL;
        private System.Windows.Forms.Label MarcaLBL;
        private System.Windows.Forms.Label ModeloLBL;
        private System.Windows.Forms.TextBox CodigoTB;
        private System.Windows.Forms.TextBox MarcaTB;
        private System.Windows.Forms.TextBox ModeloTB;

        #endregion
    }
}