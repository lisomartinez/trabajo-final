namespace UI
{
    partial class TipoProblemaForm
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
            this.TipoProblemaGB = new System.Windows.Forms.GroupBox();
            this.EliminarBTN = new System.Windows.Forms.Button();
            this.ModificarBTN = new System.Windows.Forms.Button();
            this.AgregarBTN = new System.Windows.Forms.Button();
            this.NombreTB = new System.Windows.Forms.TextBox();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.NombreLBL = new System.Windows.Forms.Label();
            this.IdLBL = new System.Windows.Forms.Label();
            this.TiposProblemaGB = new System.Windows.Forms.GroupBox();
            this.TiposProblemaDGV = new System.Windows.Forms.DataGridView();
            this.TipoProblemaGB.SuspendLayout();
            this.TiposProblemaGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TiposProblemaDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // TipoProblemaGB
            // 
            this.TipoProblemaGB.Controls.Add(this.EliminarBTN);
            this.TipoProblemaGB.Controls.Add(this.ModificarBTN);
            this.TipoProblemaGB.Controls.Add(this.AgregarBTN);
            this.TipoProblemaGB.Controls.Add(this.NombreTB);
            this.TipoProblemaGB.Controls.Add(this.IdTB);
            this.TipoProblemaGB.Controls.Add(this.NombreLBL);
            this.TipoProblemaGB.Controls.Add(this.IdLBL);
            this.TipoProblemaGB.Location = new System.Drawing.Point(423, 3);
            this.TipoProblemaGB.Name = "TipoProblemaGB";
            this.TipoProblemaGB.Size = new System.Drawing.Size(386, 422);
            this.TipoProblemaGB.TabIndex = 1;
            this.TipoProblemaGB.TabStop = false;
            this.TipoProblemaGB.Text = "Tipo Problema:";
            // 
            // EliminarBTN
            // 
            this.EliminarBTN.Location = new System.Drawing.Point(257, 175);
            this.EliminarBTN.Name = "EliminarBTN";
            this.EliminarBTN.Size = new System.Drawing.Size(119, 36);
            this.EliminarBTN.TabIndex = 2;
            this.EliminarBTN.Text = "Eliminar";
            this.EliminarBTN.UseVisualStyleBackColor = true;
            this.EliminarBTN.Click += new System.EventHandler(this.EliminarBTN_Click);
            // 
            // ModificarBTN
            // 
            this.ModificarBTN.Location = new System.Drawing.Point(132, 175);
            this.ModificarBTN.Name = "ModificarBTN";
            this.ModificarBTN.Size = new System.Drawing.Size(119, 36);
            this.ModificarBTN.TabIndex = 2;
            this.ModificarBTN.Text = "Modificar";
            this.ModificarBTN.UseVisualStyleBackColor = true;
            this.ModificarBTN.Click += new System.EventHandler(this.ModificarBTN_Click);
            // 
            // AgregarBTN
            // 
            this.AgregarBTN.Location = new System.Drawing.Point(7, 175);
            this.AgregarBTN.Name = "AgregarBTN";
            this.AgregarBTN.Size = new System.Drawing.Size(119, 36);
            this.AgregarBTN.TabIndex = 2;
            this.AgregarBTN.Text = "Agregar";
            this.AgregarBTN.UseVisualStyleBackColor = true;
            this.AgregarBTN.Click += new System.EventHandler(this.AgregarBTN_Click);
            // 
            // NombreTB
            // 
            this.NombreTB.Location = new System.Drawing.Point(103, 74);
            this.NombreTB.Name = "NombreTB";
            this.NombreTB.Size = new System.Drawing.Size(257, 20);
            this.NombreTB.TabIndex = 1;
            // 
            // IdTB
            // 
            this.IdTB.Location = new System.Drawing.Point(103, 29);
            this.IdTB.Name = "IdTB";
            this.IdTB.Size = new System.Drawing.Size(257, 20);
            this.IdTB.TabIndex = 1;
            // 
            // NombreLBL
            // 
            this.NombreLBL.AutoSize = true;
            this.NombreLBL.Location = new System.Drawing.Point(26, 81);
            this.NombreLBL.Name = "NombreLBL";
            this.NombreLBL.Size = new System.Drawing.Size(47, 13);
            this.NombreLBL.TabIndex = 0;
            this.NombreLBL.Text = "Nombre:";
            // 
            // IdLBL
            // 
            this.IdLBL.AutoSize = true;
            this.IdLBL.Location = new System.Drawing.Point(26, 36);
            this.IdLBL.Name = "IdLBL";
            this.IdLBL.Size = new System.Drawing.Size(43, 13);
            this.IdLBL.TabIndex = 0;
            this.IdLBL.Text = "Código:";
            // 
            // TiposProblemaGB
            // 
            this.TiposProblemaGB.Controls.Add(this.TiposProblemaDGV);
            this.TiposProblemaGB.Location = new System.Drawing.Point(3, 3);
            this.TiposProblemaGB.Name = "TiposProblemaGB";
            this.TiposProblemaGB.Size = new System.Drawing.Size(414, 422);
            this.TiposProblemaGB.TabIndex = 2;
            this.TiposProblemaGB.TabStop = false;
            this.TiposProblemaGB.Text = "Tipos de Problema:";
            // 
            // TiposProblemaDGV
            // 
            this.TiposProblemaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TiposProblemaDGV.Location = new System.Drawing.Point(6, 16);
            this.TiposProblemaDGV.Name = "TiposProblemaDGV";
            this.TiposProblemaDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TiposProblemaDGV.Size = new System.Drawing.Size(402, 400);
            this.TiposProblemaDGV.TabIndex = 0;
            this.TiposProblemaDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EstadosDGV_CellClick);
            // 
            // TipoProblemaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 434);
            this.Controls.Add(this.TipoProblemaGB);
            this.Controls.Add(this.TiposProblemaGB);
            this.Name = "TipoProblemaForm";
            this.Text = "TipoProblemaForm";
            this.Load += new System.EventHandler(this.TipoProblemaForm_Load);
            this.TipoProblemaGB.ResumeLayout(false);
            this.TipoProblemaGB.PerformLayout();
            this.TiposProblemaGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TiposProblemaDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TipoProblemaGB;
        private System.Windows.Forms.Button EliminarBTN;
        private System.Windows.Forms.Button ModificarBTN;
        private System.Windows.Forms.Button AgregarBTN;
        private System.Windows.Forms.TextBox NombreTB;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.Label NombreLBL;
        private System.Windows.Forms.Label IdLBL;
        private System.Windows.Forms.GroupBox TiposProblemaGB;
        private System.Windows.Forms.DataGridView TiposProblemaDGV;
    }
}