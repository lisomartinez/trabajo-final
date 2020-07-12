namespace UI
{
    partial class EstadoAsistenciaForm
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
            this.EstadosGB = new System.Windows.Forms.GroupBox();
            this.EstadosDGV = new System.Windows.Forms.DataGridView();
            this.EstadoGB = new System.Windows.Forms.GroupBox();
            this.EliminarBTN = new System.Windows.Forms.Button();
            this.ModificarBTN = new System.Windows.Forms.Button();
            this.AgregarBTN = new System.Windows.Forms.Button();
            this.DescripcionTB = new System.Windows.Forms.TextBox();
            this.NombreTB = new System.Windows.Forms.TextBox();
            this.CodigoTB = new System.Windows.Forms.TextBox();
            this.DescripcionLBL = new System.Windows.Forms.Label();
            this.NombreLBL = new System.Windows.Forms.Label();
            this.CodigoLBL = new System.Windows.Forms.Label();
            this.EstadosGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EstadosDGV)).BeginInit();
            this.EstadoGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // EstadosGB
            // 
            this.EstadosGB.Controls.Add(this.EstadosDGV);
            this.EstadosGB.Location = new System.Drawing.Point(4, 6);
            this.EstadosGB.Name = "EstadosGB";
            this.EstadosGB.Size = new System.Drawing.Size(414, 422);
            this.EstadosGB.TabIndex = 0;
            this.EstadosGB.TabStop = false;
            this.EstadosGB.Text = "Estados:";
            // 
            // EstadosDGV
            // 
            this.EstadosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EstadosDGV.Location = new System.Drawing.Point(6, 16);
            this.EstadosDGV.Name = "EstadosDGV";
            this.EstadosDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EstadosDGV.Size = new System.Drawing.Size(402, 400);
            this.EstadosDGV.TabIndex = 0;
            this.EstadosDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EstadosDGV_CellClick);
            // 
            // EstadoGB
            // 
            this.EstadoGB.Controls.Add(this.EliminarBTN);
            this.EstadoGB.Controls.Add(this.ModificarBTN);
            this.EstadoGB.Controls.Add(this.AgregarBTN);
            this.EstadoGB.Controls.Add(this.DescripcionTB);
            this.EstadoGB.Controls.Add(this.NombreTB);
            this.EstadoGB.Controls.Add(this.CodigoTB);
            this.EstadoGB.Controls.Add(this.DescripcionLBL);
            this.EstadoGB.Controls.Add(this.NombreLBL);
            this.EstadoGB.Controls.Add(this.CodigoLBL);
            this.EstadoGB.Location = new System.Drawing.Point(424, 6);
            this.EstadoGB.Name = "EstadoGB";
            this.EstadoGB.Size = new System.Drawing.Size(386, 422);
            this.EstadoGB.TabIndex = 0;
            this.EstadoGB.TabStop = false;
            this.EstadoGB.Text = "Estado:";
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
            // DescripcionTB
            // 
            this.DescripcionTB.Location = new System.Drawing.Point(103, 117);
            this.DescripcionTB.Name = "DescripcionTB";
            this.DescripcionTB.Size = new System.Drawing.Size(257, 20);
            this.DescripcionTB.TabIndex = 1;
            // 
            // NombreTB
            // 
            this.NombreTB.Location = new System.Drawing.Point(103, 74);
            this.NombreTB.Name = "NombreTB";
            this.NombreTB.Size = new System.Drawing.Size(257, 20);
            this.NombreTB.TabIndex = 1;
            // 
            // CodigoTB
            // 
            this.CodigoTB.Location = new System.Drawing.Point(103, 29);
            this.CodigoTB.Name = "CodigoTB";
            this.CodigoTB.Size = new System.Drawing.Size(257, 20);
            this.CodigoTB.TabIndex = 1;
            // 
            // DescripcionLBL
            // 
            this.DescripcionLBL.AutoSize = true;
            this.DescripcionLBL.Location = new System.Drawing.Point(26, 124);
            this.DescripcionLBL.Name = "DescripcionLBL";
            this.DescripcionLBL.Size = new System.Drawing.Size(66, 13);
            this.DescripcionLBL.TabIndex = 0;
            this.DescripcionLBL.Text = "Descripción:";
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
            // CodigoLBL
            // 
            this.CodigoLBL.AutoSize = true;
            this.CodigoLBL.Location = new System.Drawing.Point(26, 36);
            this.CodigoLBL.Name = "CodigoLBL";
            this.CodigoLBL.Size = new System.Drawing.Size(43, 13);
            this.CodigoLBL.TabIndex = 0;
            this.CodigoLBL.Text = "Código:";
            // 
            // EstadoAsistenciaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 440);
            this.Controls.Add(this.EstadoGB);
            this.Controls.Add(this.EstadosGB);
            this.Name = "EstadoAsistenciaForm";
            this.Text = "EstadoAsistenciaForm";
            this.Load += new System.EventHandler(this.EstadoAsistenciaForm_Load);
            this.EstadosGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EstadosDGV)).EndInit();
            this.EstadoGB.ResumeLayout(false);
            this.EstadoGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox EstadosGB;
        private System.Windows.Forms.DataGridView EstadosDGV;
        private System.Windows.Forms.GroupBox EstadoGB;
        private System.Windows.Forms.TextBox DescripcionTB;
        private System.Windows.Forms.TextBox NombreTB;
        private System.Windows.Forms.TextBox CodigoTB;
        private System.Windows.Forms.Label DescripcionLBL;
        private System.Windows.Forms.Label NombreLBL;
        private System.Windows.Forms.Label CodigoLBL;
        private System.Windows.Forms.Button EliminarBTN;
        private System.Windows.Forms.Button ModificarBTN;
        private System.Windows.Forms.Button AgregarBTN;
    }
}