using System.ComponentModel;

namespace UI
{
    partial class EncuestaForm
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
            this.EncuestasGB = new System.Windows.Forms.GroupBox();
            this.EncuestasDGV = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.EncuestaGB = new System.Windows.Forms.GroupBox();
            this.FechaTB = new System.Windows.Forms.TextBox();
            this.CodigoTB = new System.Windows.Forms.TextBox();
            this.VigenteCHKB = new System.Windows.Forms.CheckBox();
            this.FechaCreacionLBL = new System.Windows.Forms.Label();
            this.CodigoLBL = new System.Windows.Forms.Label();
            this.PreguntaGB = new System.Windows.Forms.GroupBox();
            this.PuntajeMinTB = new System.Windows.Forms.TextBox();
            this.PuntajeMinLBL = new System.Windows.Forms.Label();
            this.PuntajeMaxTB = new System.Windows.Forms.TextBox();
            this.PesoRelativoTB = new System.Windows.Forms.TextBox();
            this.PuntajeMaxLBL = new System.Windows.Forms.Label();
            this.PesoRelativoLBL = new System.Windows.Forms.Label();
            this.TextoTB = new System.Windows.Forms.TextBox();
            this.NroTB = new System.Windows.Forms.TextBox();
            this.TextoLBL = new System.Windows.Forms.Label();
            this.NroLBL = new System.Windows.Forms.Label();
            this.PreguntasDGV = new System.Windows.Forms.DataGridView();
            this.PreguntasGB = new System.Windows.Forms.GroupBox();
            this.EncuestasGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EncuestasDGV)).BeginInit();
            this.EncuestaGB.SuspendLayout();
            this.PreguntaGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreguntasDGV)).BeginInit();
            this.PreguntasGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // EncuestasGB
            // 
            this.EncuestasGB.Controls.Add(this.EncuestasDGV);
            this.EncuestasGB.Location = new System.Drawing.Point(13, 10);
            this.EncuestasGB.Name = "EncuestasGB";
            this.EncuestasGB.Size = new System.Drawing.Size(433, 630);
            this.EncuestasGB.TabIndex = 0;
            this.EncuestasGB.TabStop = false;
            this.EncuestasGB.Text = "Encuestas";
            // 
            // EncuestasDGV
            // 
            this.EncuestasDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EncuestasDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.EncuestasDGV.Location = new System.Drawing.Point(11, 24);
            this.EncuestasDGV.Name = "EncuestasDGV";
            this.EncuestasDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EncuestasDGV.Size = new System.Drawing.Size(412, 580);
            this.EncuestasDGV.TabIndex = 0;
            this.EncuestasDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EncuestasDGV_CellClick);
            // 
            // EncuestaGB
            // 
            this.EncuestaGB.Controls.Add(this.FechaTB);
            this.EncuestaGB.Controls.Add(this.CodigoTB);
            this.EncuestaGB.Controls.Add(this.VigenteCHKB);
            this.EncuestaGB.Controls.Add(this.FechaCreacionLBL);
            this.EncuestaGB.Controls.Add(this.CodigoLBL);
            this.EncuestaGB.Location = new System.Drawing.Point(452, 16);
            this.EncuestaGB.Name = "EncuestaGB";
            this.EncuestaGB.Size = new System.Drawing.Size(433, 286);
            this.EncuestaGB.TabIndex = 0;
            this.EncuestaGB.TabStop = false;
            this.EncuestaGB.Text = "Encuesta";
            // 
            // FechaTB
            // 
            this.FechaTB.Location = new System.Drawing.Point(113, 69);
            this.FechaTB.Name = "FechaTB";
            this.FechaTB.Size = new System.Drawing.Size(223, 20);
            this.FechaTB.TabIndex = 2;
            // 
            // CodigoTB
            // 
            this.CodigoTB.Location = new System.Drawing.Point(111, 24);
            this.CodigoTB.Name = "CodigoTB";
            this.CodigoTB.Size = new System.Drawing.Size(223, 20);
            this.CodigoTB.TabIndex = 2;
            // 
            // VigenteCHKB
            // 
            this.VigenteCHKB.AutoSize = true;
            this.VigenteCHKB.Location = new System.Drawing.Point(10, 122);
            this.VigenteCHKB.Name = "VigenteCHKB";
            this.VigenteCHKB.Size = new System.Drawing.Size(62, 17);
            this.VigenteCHKB.TabIndex = 1;
            this.VigenteCHKB.Text = "Vigente";
            this.VigenteCHKB.UseVisualStyleBackColor = true;
            // 
            // FechaCreacionLBL
            // 
            this.FechaCreacionLBL.AutoSize = true;
            this.FechaCreacionLBL.Location = new System.Drawing.Point(7, 76);
            this.FechaCreacionLBL.Name = "FechaCreacionLBL";
            this.FechaCreacionLBL.Size = new System.Drawing.Size(100, 13);
            this.FechaCreacionLBL.TabIndex = 0;
            this.FechaCreacionLBL.Text = "Fecha de Creación:";
            // 
            // CodigoLBL
            // 
            this.CodigoLBL.AutoSize = true;
            this.CodigoLBL.Location = new System.Drawing.Point(7, 31);
            this.CodigoLBL.Name = "CodigoLBL";
            this.CodigoLBL.Size = new System.Drawing.Size(43, 13);
            this.CodigoLBL.TabIndex = 0;
            this.CodigoLBL.Text = "Código:";
            // 
            // PreguntaGB
            // 
            this.PreguntaGB.Controls.Add(this.PuntajeMinTB);
            this.PreguntaGB.Controls.Add(this.PuntajeMinLBL);
            this.PreguntaGB.Controls.Add(this.PuntajeMaxTB);
            this.PreguntaGB.Controls.Add(this.PesoRelativoTB);
            this.PreguntaGB.Controls.Add(this.PuntajeMaxLBL);
            this.PreguntaGB.Controls.Add(this.PesoRelativoLBL);
            this.PreguntaGB.Controls.Add(this.TextoTB);
            this.PreguntaGB.Controls.Add(this.NroTB);
            this.PreguntaGB.Controls.Add(this.TextoLBL);
            this.PreguntaGB.Controls.Add(this.NroLBL);
            this.PreguntaGB.Location = new System.Drawing.Point(901, 23);
            this.PreguntaGB.Name = "PreguntaGB";
            this.PreguntaGB.Size = new System.Drawing.Size(433, 617);
            this.PreguntaGB.TabIndex = 0;
            this.PreguntaGB.TabStop = false;
            this.PreguntaGB.Text = "Pregunta";
            // 
            // PuntajeMinTB
            // 
            this.PuntajeMinTB.Location = new System.Drawing.Point(129, 367);
            this.PuntajeMinTB.Name = "PuntajeMinTB";
            this.PuntajeMinTB.Size = new System.Drawing.Size(284, 20);
            this.PuntajeMinTB.TabIndex = 12;
            // 
            // PuntajeMinLBL
            // 
            this.PuntajeMinLBL.AutoSize = true;
            this.PuntajeMinLBL.Location = new System.Drawing.Point(23, 374);
            this.PuntajeMinLBL.Name = "PuntajeMinLBL";
            this.PuntajeMinLBL.Size = new System.Drawing.Size(84, 13);
            this.PuntajeMinLBL.TabIndex = 11;
            this.PuntajeMinLBL.Text = "Puntaje Mínimo:";
            // 
            // PuntajeMaxTB
            // 
            this.PuntajeMaxTB.Location = new System.Drawing.Point(129, 315);
            this.PuntajeMaxTB.Name = "PuntajeMaxTB";
            this.PuntajeMaxTB.Size = new System.Drawing.Size(284, 20);
            this.PuntajeMaxTB.TabIndex = 9;
            // 
            // PesoRelativoTB
            // 
            this.PesoRelativoTB.Location = new System.Drawing.Point(127, 270);
            this.PesoRelativoTB.Name = "PesoRelativoTB";
            this.PesoRelativoTB.Size = new System.Drawing.Size(284, 20);
            this.PesoRelativoTB.TabIndex = 10;
            // 
            // PuntajeMaxLBL
            // 
            this.PuntajeMaxLBL.AutoSize = true;
            this.PuntajeMaxLBL.Location = new System.Drawing.Point(23, 322);
            this.PuntajeMaxLBL.Name = "PuntajeMaxLBL";
            this.PuntajeMaxLBL.Size = new System.Drawing.Size(85, 13);
            this.PuntajeMaxLBL.TabIndex = 7;
            this.PuntajeMaxLBL.Text = "Puntaje Máximo:";
            // 
            // PesoRelativoLBL
            // 
            this.PesoRelativoLBL.AutoSize = true;
            this.PesoRelativoLBL.Location = new System.Drawing.Point(23, 277);
            this.PesoRelativoLBL.Name = "PesoRelativoLBL";
            this.PesoRelativoLBL.Size = new System.Drawing.Size(76, 13);
            this.PesoRelativoLBL.TabIndex = 8;
            this.PesoRelativoLBL.Text = "Peso Relativo:";
            // 
            // TextoTB
            // 
            this.TextoTB.Location = new System.Drawing.Point(129, 79);
            this.TextoTB.Multiline = true;
            this.TextoTB.Name = "TextoTB";
            this.TextoTB.Size = new System.Drawing.Size(284, 162);
            this.TextoTB.TabIndex = 5;
            // 
            // NroTB
            // 
            this.NroTB.Location = new System.Drawing.Point(127, 34);
            this.NroTB.Name = "NroTB";
            this.NroTB.Size = new System.Drawing.Size(284, 20);
            this.NroTB.TabIndex = 6;
            // 
            // TextoLBL
            // 
            this.TextoLBL.AutoSize = true;
            this.TextoLBL.Location = new System.Drawing.Point(23, 86);
            this.TextoLBL.Name = "TextoLBL";
            this.TextoLBL.Size = new System.Drawing.Size(37, 13);
            this.TextoLBL.TabIndex = 3;
            this.TextoLBL.Text = "Texto:";
            // 
            // NroLBL
            // 
            this.NroLBL.AutoSize = true;
            this.NroLBL.Location = new System.Drawing.Point(23, 41);
            this.NroLBL.Name = "NroLBL";
            this.NroLBL.Size = new System.Drawing.Size(47, 13);
            this.NroLBL.TabIndex = 4;
            this.NroLBL.Text = "Número:";
            // 
            // PreguntasDGV
            // 
            this.PreguntasDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PreguntasDGV.Location = new System.Drawing.Point(6, 35);
            this.PreguntasDGV.Name = "PreguntasDGV";
            this.PreguntasDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PreguntasDGV.Size = new System.Drawing.Size(412, 251);
            this.PreguntasDGV.TabIndex = 0;
            this.PreguntasDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PreguntasDGV_CellClick);
            // 
            // PreguntasGB
            // 
            this.PreguntasGB.Controls.Add(this.PreguntasDGV);
            this.PreguntasGB.Location = new System.Drawing.Point(452, 328);
            this.PreguntasGB.Name = "PreguntasGB";
            this.PreguntasGB.Size = new System.Drawing.Size(433, 312);
            this.PreguntasGB.TabIndex = 0;
            this.PreguntasGB.TabStop = false;
            this.PreguntasGB.Text = "Preguntas de Encuesta";
            // 
            // EncuestaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 652);
            this.Controls.Add(this.PreguntaGB);
            this.Controls.Add(this.PreguntasGB);
            this.Controls.Add(this.EncuestaGB);
            this.Controls.Add(this.EncuestasGB);
            this.Name = "EncuestaForm";
            this.Text = "EncuestaForm";
            this.Load += new System.EventHandler(this.EncuestaForm_Load);
            this.EncuestasGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EncuestasDGV)).EndInit();
            this.EncuestaGB.ResumeLayout(false);
            this.EncuestaGB.PerformLayout();
            this.PreguntaGB.ResumeLayout(false);
            this.PreguntaGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreguntasDGV)).EndInit();
            this.PreguntasGB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox EncuestasGB;
        private System.Windows.Forms.DataGridView EncuestasDGV;
        private BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox EncuestaGB;
        private System.Windows.Forms.GroupBox PreguntaGB;
        private System.Windows.Forms.DataGridView PreguntasDGV;
        private System.Windows.Forms.GroupBox PreguntasGB;
        private System.Windows.Forms.Label FechaCreacionLBL;
        private System.Windows.Forms.Label CodigoLBL;
        private System.Windows.Forms.CheckBox VigenteCHKB;
        private System.Windows.Forms.TextBox FechaTB;
        private System.Windows.Forms.TextBox CodigoTB;
        private System.Windows.Forms.TextBox PuntajeMaxTB;
        private System.Windows.Forms.TextBox PesoRelativoTB;
        private System.Windows.Forms.Label PuntajeMaxLBL;
        private System.Windows.Forms.Label PesoRelativoLBL;
        private System.Windows.Forms.TextBox NroTB;
        private System.Windows.Forms.Label TextoLBL;
        private System.Windows.Forms.Label NroLBL;
        private System.Windows.Forms.TextBox PuntajeMinTB;
        private System.Windows.Forms.Label PuntajeMinLBL;
        private System.Windows.Forms.TextBox TextoTB;
    }
}