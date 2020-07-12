namespace UI
{
    partial class ReporteAsistenciaTecnicaForm
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
            this.DatosGralesGB = new System.Windows.Forms.GroupBox();
            this.PromedioTecnicosLBL = new System.Windows.Forms.Label();
            this.MediaInicioFinLBL = new System.Windows.Forms.Label();
            this.MediaSolicitudInicioLBL = new System.Windows.Forms.Label();
            this.MediaDuracionLBL = new System.Windows.Forms.Label();
            this.TecnicoGB = new System.Windows.Forms.GroupBox();
            this.TecnicosGB = new System.Windows.Forms.GroupBox();
            this.TecnicosDGV = new System.Windows.Forms.DataGridView();
            this.MediaDuracionTB = new System.Windows.Forms.TextBox();
            this.MediaSolicitudInicioTB = new System.Windows.Forms.TextBox();
            this.MediaInicioFinTB = new System.Windows.Forms.TextBox();
            this.PromedioTecnicosTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TipoProblemaCB = new System.Windows.Forms.ComboBox();
            this.PorTipoProblemaGB = new System.Windows.Forms.GroupBox();
            this.PromedioTecnicoTB = new System.Windows.Forms.TextBox();
            this.PromedioTecnicoDesvTB = new System.Windows.Forms.TextBox();
            this.MediaInicioFinTecDesvTB = new System.Windows.Forms.TextBox();
            this.MediaInicioFinTecTB = new System.Windows.Forms.TextBox();
            this.MediaInicioTecDesvTB = new System.Windows.Forms.TextBox();
            this.MediaInicioTecTB = new System.Windows.Forms.TextBox();
            this.MediaDuracionTecnicoDesvTB = new System.Windows.Forms.TextBox();
            this.MediaDuracionTecnicoTB = new System.Windows.Forms.TextBox();
            this.PromedioTecnicoDesvLBL = new System.Windows.Forms.Label();
            this.MediaInicioFinTecDesvLBL = new System.Windows.Forms.Label();
            this.MediaInicioTecDesvLBL = new System.Windows.Forms.Label();
            this.MediaDuracionTecnicoDesvLBL = new System.Windows.Forms.Label();
            this.PromedioTecnicoLBL = new System.Windows.Forms.Label();
            this.MediaInicioFinTecLBL = new System.Windows.Forms.Label();
            this.MediaInicioTecLBL = new System.Windows.Forms.Label();
            this.MediaDuracionTecnicoLBL = new System.Windows.Forms.Label();
            this.PromedioTecnicoTotalTB = new System.Windows.Forms.TextBox();
            this.PromedioTecnicoTotalDesvTB = new System.Windows.Forms.TextBox();
            this.PromedioTecnicoTotalDesvLBL = new System.Windows.Forms.Label();
            this.PromedioTecnicoTotalLBL = new System.Windows.Forms.Label();
            this.DatosGralesGB.SuspendLayout();
            this.TecnicoGB.SuspendLayout();
            this.TecnicosGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TecnicosDGV)).BeginInit();
            this.PorTipoProblemaGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatosGralesGB
            // 
            this.DatosGralesGB.Controls.Add(this.PromedioTecnicosTB);
            this.DatosGralesGB.Controls.Add(this.MediaInicioFinTB);
            this.DatosGralesGB.Controls.Add(this.MediaSolicitudInicioTB);
            this.DatosGralesGB.Controls.Add(this.MediaDuracionTB);
            this.DatosGralesGB.Controls.Add(this.PromedioTecnicosLBL);
            this.DatosGralesGB.Controls.Add(this.MediaInicioFinLBL);
            this.DatosGralesGB.Controls.Add(this.MediaSolicitudInicioLBL);
            this.DatosGralesGB.Controls.Add(this.MediaDuracionLBL);
            this.DatosGralesGB.Location = new System.Drawing.Point(12, 11);
            this.DatosGralesGB.Name = "DatosGralesGB";
            this.DatosGralesGB.Size = new System.Drawing.Size(349, 520);
            this.DatosGralesGB.TabIndex = 0;
            this.DatosGralesGB.TabStop = false;
            this.DatosGralesGB.Text = "Datos Generales";
            // 
            // PromedioTecnicosLBL
            // 
            this.PromedioTecnicosLBL.AutoSize = true;
            this.PromedioTecnicosLBL.Location = new System.Drawing.Point(109, 275);
            this.PromedioTecnicosLBL.Name = "PromedioTecnicosLBL";
            this.PromedioTecnicosLBL.Size = new System.Drawing.Size(182, 13);
            this.PromedioTecnicosLBL.TabIndex = 2;
            this.PromedioTecnicosLBL.Text = "Calificacion Promedio de los tecnicos";
            // 
            // MediaInicioFinLBL
            // 
            this.MediaInicioFinLBL.AutoSize = true;
            this.MediaInicioFinLBL.Location = new System.Drawing.Point(16, 161);
            this.MediaInicioFinLBL.Name = "MediaInicioFinLBL";
            this.MediaInicioFinLBL.Size = new System.Drawing.Size(275, 13);
            this.MediaInicioFinLBL.TabIndex = 0;
            this.MediaInicioFinLBL.Text = "Tiempo medio de duracion desde inicio hasta finalización";
            this.MediaInicioFinLBL.Click += new System.EventHandler(this.label1_Click);
            // 
            // MediaSolicitudInicioLBL
            // 
            this.MediaSolicitudInicioLBL.AutoSize = true;
            this.MediaSolicitudInicioLBL.Location = new System.Drawing.Point(30, 96);
            this.MediaSolicitudInicioLBL.Name = "MediaSolicitudInicioLBL";
            this.MediaSolicitudInicioLBL.Size = new System.Drawing.Size(261, 13);
            this.MediaSolicitudInicioLBL.TabIndex = 0;
            this.MediaSolicitudInicioLBL.Text = "Tiempo medio de duracion desde solicitud hasta inicio";
            this.MediaSolicitudInicioLBL.Click += new System.EventHandler(this.label1_Click);
            // 
            // MediaDuracionLBL
            // 
            this.MediaDuracionLBL.AutoSize = true;
            this.MediaDuracionLBL.Location = new System.Drawing.Point(51, 39);
            this.MediaDuracionLBL.Name = "MediaDuracionLBL";
            this.MediaDuracionLBL.Size = new System.Drawing.Size(240, 13);
            this.MediaDuracionLBL.TabIndex = 0;
            this.MediaDuracionLBL.Text = "Tiempo medio de duracion de Asistencia Técnica";
            this.MediaDuracionLBL.Click += new System.EventHandler(this.label1_Click);
            // 
            // TecnicoGB
            // 
            this.TecnicoGB.Controls.Add(this.PromedioTecnicoTotalTB);
            this.TecnicoGB.Controls.Add(this.PromedioTecnicoTotalDesvTB);
            this.TecnicoGB.Controls.Add(this.PromedioTecnicoTotalDesvLBL);
            this.TecnicoGB.Controls.Add(this.PromedioTecnicoTotalLBL);
            this.TecnicoGB.Controls.Add(this.PorTipoProblemaGB);
            this.TecnicoGB.Controls.Add(this.TipoProblemaCB);
            this.TecnicoGB.Controls.Add(this.label1);
            this.TecnicoGB.Location = new System.Drawing.Point(785, 11);
            this.TecnicoGB.Name = "TecnicoGB";
            this.TecnicoGB.Size = new System.Drawing.Size(458, 520);
            this.TecnicoGB.TabIndex = 0;
            this.TecnicoGB.TabStop = false;
            this.TecnicoGB.Text = "Tecnico";
            // 
            // TecnicosGB
            // 
            this.TecnicosGB.Controls.Add(this.TecnicosDGV);
            this.TecnicosGB.Location = new System.Drawing.Point(376, 11);
            this.TecnicosGB.Name = "TecnicosGB";
            this.TecnicosGB.Size = new System.Drawing.Size(376, 520);
            this.TecnicosGB.TabIndex = 1;
            this.TecnicosGB.TabStop = false;
            this.TecnicosGB.Text = "Tecnicos";
            // 
            // TecnicosDGV
            // 
            this.TecnicosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TecnicosDGV.Location = new System.Drawing.Point(7, 20);
            this.TecnicosDGV.MultiSelect = false;
            this.TecnicosDGV.Name = "TecnicosDGV";
            this.TecnicosDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TecnicosDGV.Size = new System.Drawing.Size(363, 492);
            this.TecnicosDGV.StandardTab = true;
            this.TecnicosDGV.TabIndex = 0;
            this.TecnicosDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TecnicosDGV_CellClick);
            // 
            // MediaDuracionTB
            // 
            this.MediaDuracionTB.Location = new System.Drawing.Point(297, 34);
            this.MediaDuracionTB.Name = "MediaDuracionTB";
            this.MediaDuracionTB.Size = new System.Drawing.Size(46, 20);
            this.MediaDuracionTB.TabIndex = 3;
            // 
            // MediaSolicitudInicioTB
            // 
            this.MediaSolicitudInicioTB.Location = new System.Drawing.Point(297, 93);
            this.MediaSolicitudInicioTB.Name = "MediaSolicitudInicioTB";
            this.MediaSolicitudInicioTB.Size = new System.Drawing.Size(46, 20);
            this.MediaSolicitudInicioTB.TabIndex = 3;
            // 
            // MediaInicioFinTB
            // 
            this.MediaInicioFinTB.Location = new System.Drawing.Point(297, 158);
            this.MediaInicioFinTB.Name = "MediaInicioFinTB";
            this.MediaInicioFinTB.Size = new System.Drawing.Size(46, 20);
            this.MediaInicioFinTB.TabIndex = 3;
            // 
            // PromedioTecnicosTB
            // 
            this.PromedioTecnicosTB.Location = new System.Drawing.Point(297, 268);
            this.PromedioTecnicosTB.Name = "PromedioTecnicosTB";
            this.PromedioTecnicosTB.Size = new System.Drawing.Size(46, 20);
            this.PromedioTecnicosTB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tipo de Problema:";
            // 
            // TipoProblemaCB
            // 
            this.TipoProblemaCB.FormattingEnabled = true;
            this.TipoProblemaCB.Location = new System.Drawing.Point(153, 33);
            this.TipoProblemaCB.Name = "TipoProblemaCB";
            this.TipoProblemaCB.Size = new System.Drawing.Size(196, 21);
            this.TipoProblemaCB.TabIndex = 6;
            // 
            // PorTipoProblemaGB
            // 
            this.PorTipoProblemaGB.Controls.Add(this.PromedioTecnicoTB);
            this.PorTipoProblemaGB.Controls.Add(this.PromedioTecnicoDesvTB);
            this.PorTipoProblemaGB.Controls.Add(this.MediaInicioFinTecDesvTB);
            this.PorTipoProblemaGB.Controls.Add(this.MediaInicioFinTecTB);
            this.PorTipoProblemaGB.Controls.Add(this.MediaInicioTecDesvTB);
            this.PorTipoProblemaGB.Controls.Add(this.MediaInicioTecTB);
            this.PorTipoProblemaGB.Controls.Add(this.MediaDuracionTecnicoDesvTB);
            this.PorTipoProblemaGB.Controls.Add(this.MediaDuracionTecnicoTB);
            this.PorTipoProblemaGB.Controls.Add(this.PromedioTecnicoDesvLBL);
            this.PorTipoProblemaGB.Controls.Add(this.MediaInicioFinTecDesvLBL);
            this.PorTipoProblemaGB.Controls.Add(this.MediaInicioTecDesvLBL);
            this.PorTipoProblemaGB.Controls.Add(this.MediaDuracionTecnicoDesvLBL);
            this.PorTipoProblemaGB.Controls.Add(this.PromedioTecnicoLBL);
            this.PorTipoProblemaGB.Controls.Add(this.MediaInicioFinTecLBL);
            this.PorTipoProblemaGB.Controls.Add(this.MediaInicioTecLBL);
            this.PorTipoProblemaGB.Controls.Add(this.MediaDuracionTecnicoLBL);
            this.PorTipoProblemaGB.Location = new System.Drawing.Point(19, 79);
            this.PorTipoProblemaGB.Name = "PorTipoProblemaGB";
            this.PorTipoProblemaGB.Size = new System.Drawing.Size(386, 368);
            this.PorTipoProblemaGB.TabIndex = 7;
            this.PorTipoProblemaGB.TabStop = false;
            this.PorTipoProblemaGB.Text = "Por Tipo Problema:";
            // 
            // PromedioTecnicoTB
            // 
            this.PromedioTecnicoTB.Location = new System.Drawing.Point(301, 282);
            this.PromedioTecnicoTB.Name = "PromedioTecnicoTB";
            this.PromedioTecnicoTB.Size = new System.Drawing.Size(46, 20);
            this.PromedioTecnicoTB.TabIndex = 13;
            // 
            // PromedioTecnicoDesvTB
            // 
            this.PromedioTecnicoDesvTB.Location = new System.Drawing.Point(301, 308);
            this.PromedioTecnicoDesvTB.Name = "PromedioTecnicoDesvTB";
            this.PromedioTecnicoDesvTB.Size = new System.Drawing.Size(46, 20);
            this.PromedioTecnicoDesvTB.TabIndex = 14;
            // 
            // MediaInicioFinTecDesvTB
            // 
            this.MediaInicioFinTecDesvTB.Location = new System.Drawing.Point(301, 239);
            this.MediaInicioFinTecDesvTB.Name = "MediaInicioFinTecDesvTB";
            this.MediaInicioFinTecDesvTB.Size = new System.Drawing.Size(46, 20);
            this.MediaInicioFinTecDesvTB.TabIndex = 15;
            // 
            // MediaInicioFinTecTB
            // 
            this.MediaInicioFinTecTB.Location = new System.Drawing.Point(301, 213);
            this.MediaInicioFinTecTB.Name = "MediaInicioFinTecTB";
            this.MediaInicioFinTecTB.Size = new System.Drawing.Size(46, 20);
            this.MediaInicioFinTecTB.TabIndex = 16;
            // 
            // MediaInicioTecDesvTB
            // 
            this.MediaInicioTecDesvTB.Location = new System.Drawing.Point(301, 144);
            this.MediaInicioTecDesvTB.Name = "MediaInicioTecDesvTB";
            this.MediaInicioTecDesvTB.Size = new System.Drawing.Size(46, 20);
            this.MediaInicioTecDesvTB.TabIndex = 17;
            // 
            // MediaInicioTecTB
            // 
            this.MediaInicioTecTB.Location = new System.Drawing.Point(301, 118);
            this.MediaInicioTecTB.Name = "MediaInicioTecTB";
            this.MediaInicioTecTB.Size = new System.Drawing.Size(46, 20);
            this.MediaInicioTecTB.TabIndex = 18;
            // 
            // MediaDuracionTecnicoDesvTB
            // 
            this.MediaDuracionTecnicoDesvTB.Location = new System.Drawing.Point(301, 49);
            this.MediaDuracionTecnicoDesvTB.Name = "MediaDuracionTecnicoDesvTB";
            this.MediaDuracionTecnicoDesvTB.Size = new System.Drawing.Size(46, 20);
            this.MediaDuracionTecnicoDesvTB.TabIndex = 19;
            // 
            // MediaDuracionTecnicoTB
            // 
            this.MediaDuracionTecnicoTB.Location = new System.Drawing.Point(301, 23);
            this.MediaDuracionTecnicoTB.Name = "MediaDuracionTecnicoTB";
            this.MediaDuracionTecnicoTB.Size = new System.Drawing.Size(46, 20);
            this.MediaDuracionTecnicoTB.TabIndex = 20;
            // 
            // PromedioTecnicoDesvLBL
            // 
            this.PromedioTecnicoDesvLBL.AutoSize = true;
            this.PromedioTecnicoDesvLBL.Location = new System.Drawing.Point(170, 315);
            this.PromedioTecnicoDesvLBL.Name = "PromedioTecnicoDesvLBL";
            this.PromedioTecnicoDesvLBL.Size = new System.Drawing.Size(117, 13);
            this.PromedioTecnicoDesvLBL.TabIndex = 9;
            this.PromedioTecnicoDesvLBL.Text = "Desviación de la media";
            // 
            // MediaInicioFinTecDesvLBL
            // 
            this.MediaInicioFinTecDesvLBL.AutoSize = true;
            this.MediaInicioFinTecDesvLBL.Location = new System.Drawing.Point(172, 242);
            this.MediaInicioFinTecDesvLBL.Name = "MediaInicioFinTecDesvLBL";
            this.MediaInicioFinTecDesvLBL.Size = new System.Drawing.Size(117, 13);
            this.MediaInicioFinTecDesvLBL.TabIndex = 10;
            this.MediaInicioFinTecDesvLBL.Text = "Desviación de la media";
            // 
            // MediaInicioTecDesvLBL
            // 
            this.MediaInicioTecDesvLBL.AutoSize = true;
            this.MediaInicioTecDesvLBL.Location = new System.Drawing.Point(172, 151);
            this.MediaInicioTecDesvLBL.Name = "MediaInicioTecDesvLBL";
            this.MediaInicioTecDesvLBL.Size = new System.Drawing.Size(117, 13);
            this.MediaInicioTecDesvLBL.TabIndex = 11;
            this.MediaInicioTecDesvLBL.Text = "Desviación de la media";
            // 
            // MediaDuracionTecnicoDesvLBL
            // 
            this.MediaDuracionTecnicoDesvLBL.AutoSize = true;
            this.MediaDuracionTecnicoDesvLBL.Location = new System.Drawing.Point(172, 56);
            this.MediaDuracionTecnicoDesvLBL.Name = "MediaDuracionTecnicoDesvLBL";
            this.MediaDuracionTecnicoDesvLBL.Size = new System.Drawing.Size(117, 13);
            this.MediaDuracionTecnicoDesvLBL.TabIndex = 12;
            this.MediaDuracionTecnicoDesvLBL.Text = "Desviación de la media";
            // 
            // PromedioTecnicoLBL
            // 
            this.PromedioTecnicoLBL.AutoSize = true;
            this.PromedioTecnicoLBL.Location = new System.Drawing.Point(180, 285);
            this.PromedioTecnicoLBL.Name = "PromedioTecnicoLBL";
            this.PromedioTecnicoLBL.Size = new System.Drawing.Size(107, 13);
            this.PromedioTecnicoLBL.TabIndex = 5;
            this.PromedioTecnicoLBL.Text = "Calificación promedio";
            // 
            // MediaInicioFinTecLBL
            // 
            this.MediaInicioFinTecLBL.AutoSize = true;
            this.MediaInicioFinTecLBL.Location = new System.Drawing.Point(14, 218);
            this.MediaInicioFinTecLBL.Name = "MediaInicioFinTecLBL";
            this.MediaInicioFinTecLBL.Size = new System.Drawing.Size(275, 13);
            this.MediaInicioFinTecLBL.TabIndex = 6;
            this.MediaInicioFinTecLBL.Text = "Tiempo medio de duracion desde inicio hasta finalización";
            // 
            // MediaInicioTecLBL
            // 
            this.MediaInicioTecLBL.AutoSize = true;
            this.MediaInicioTecLBL.Location = new System.Drawing.Point(28, 121);
            this.MediaInicioTecLBL.Name = "MediaInicioTecLBL";
            this.MediaInicioTecLBL.Size = new System.Drawing.Size(261, 13);
            this.MediaInicioTecLBL.TabIndex = 7;
            this.MediaInicioTecLBL.Text = "Tiempo medio de duracion desde solicitud hasta inicio";
            // 
            // MediaDuracionTecnicoLBL
            // 
            this.MediaDuracionTecnicoLBL.AutoSize = true;
            this.MediaDuracionTecnicoLBL.Location = new System.Drawing.Point(49, 30);
            this.MediaDuracionTecnicoLBL.Name = "MediaDuracionTecnicoLBL";
            this.MediaDuracionTecnicoLBL.Size = new System.Drawing.Size(240, 13);
            this.MediaDuracionTecnicoLBL.TabIndex = 8;
            this.MediaDuracionTecnicoLBL.Text = "Tiempo medio de duracion de Asistencia Técnica";
            // 
            // PromedioTecnicoTotalTB
            // 
            this.PromedioTecnicoTotalTB.Location = new System.Drawing.Point(300, 459);
            this.PromedioTecnicoTotalTB.Name = "PromedioTecnicoTotalTB";
            this.PromedioTecnicoTotalTB.Size = new System.Drawing.Size(46, 20);
            this.PromedioTecnicoTotalTB.TabIndex = 17;
            // 
            // PromedioTecnicoTotalDesvTB
            // 
            this.PromedioTecnicoTotalDesvTB.Location = new System.Drawing.Point(300, 485);
            this.PromedioTecnicoTotalDesvTB.Name = "PromedioTecnicoTotalDesvTB";
            this.PromedioTecnicoTotalDesvTB.Size = new System.Drawing.Size(46, 20);
            this.PromedioTecnicoTotalDesvTB.TabIndex = 18;
            // 
            // PromedioTecnicoTotalDesvLBL
            // 
            this.PromedioTecnicoTotalDesvLBL.AutoSize = true;
            this.PromedioTecnicoTotalDesvLBL.Location = new System.Drawing.Point(169, 492);
            this.PromedioTecnicoTotalDesvLBL.Name = "PromedioTecnicoTotalDesvLBL";
            this.PromedioTecnicoTotalDesvLBL.Size = new System.Drawing.Size(117, 13);
            this.PromedioTecnicoTotalDesvLBL.TabIndex = 16;
            this.PromedioTecnicoTotalDesvLBL.Text = "Desviación de la media";
            // 
            // PromedioTecnicoTotalLBL
            // 
            this.PromedioTecnicoTotalLBL.AutoSize = true;
            this.PromedioTecnicoTotalLBL.Location = new System.Drawing.Point(179, 462);
            this.PromedioTecnicoTotalLBL.Name = "PromedioTecnicoTotalLBL";
            this.PromedioTecnicoTotalLBL.Size = new System.Drawing.Size(107, 13);
            this.PromedioTecnicoTotalLBL.TabIndex = 15;
            this.PromedioTecnicoTotalLBL.Text = "Calificación promedio";
            // 
            // ReporteAsistenciaTecnicaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 543);
            this.Controls.Add(this.TecnicosGB);
            this.Controls.Add(this.TecnicoGB);
            this.Controls.Add(this.DatosGralesGB);
            this.Name = "ReporteAsistenciaTecnicaForm";
            this.Text = "ReporteDesempenioTecnicosForm";
            this.Load += new System.EventHandler(this.ReporteAsistenciaTecnicaForm_Load);
            this.DatosGralesGB.ResumeLayout(false);
            this.DatosGralesGB.PerformLayout();
            this.TecnicoGB.ResumeLayout(false);
            this.TecnicoGB.PerformLayout();
            this.TecnicosGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TecnicosDGV)).EndInit();
            this.PorTipoProblemaGB.ResumeLayout(false);
            this.PorTipoProblemaGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DatosGralesGB;
        private System.Windows.Forms.Label MediaDuracionLBL;
        private System.Windows.Forms.Label PromedioTecnicosLBL;
        private System.Windows.Forms.Label MediaInicioFinLBL;
        private System.Windows.Forms.Label MediaSolicitudInicioLBL;
        private System.Windows.Forms.GroupBox TecnicoGB;
        private System.Windows.Forms.GroupBox TecnicosGB;
        private System.Windows.Forms.DataGridView TecnicosDGV;
        private System.Windows.Forms.TextBox PromedioTecnicosTB;
        private System.Windows.Forms.TextBox MediaInicioFinTB;
        private System.Windows.Forms.TextBox MediaSolicitudInicioTB;
        private System.Windows.Forms.TextBox MediaDuracionTB;
        private System.Windows.Forms.TextBox PromedioTecnicoTotalTB;
        private System.Windows.Forms.TextBox PromedioTecnicoTotalDesvTB;
        private System.Windows.Forms.Label PromedioTecnicoTotalDesvLBL;
        private System.Windows.Forms.Label PromedioTecnicoTotalLBL;
        private System.Windows.Forms.GroupBox PorTipoProblemaGB;
        private System.Windows.Forms.TextBox PromedioTecnicoTB;
        private System.Windows.Forms.TextBox PromedioTecnicoDesvTB;
        private System.Windows.Forms.TextBox MediaInicioFinTecDesvTB;
        private System.Windows.Forms.TextBox MediaInicioFinTecTB;
        private System.Windows.Forms.TextBox MediaInicioTecDesvTB;
        private System.Windows.Forms.TextBox MediaInicioTecTB;
        private System.Windows.Forms.TextBox MediaDuracionTecnicoDesvTB;
        private System.Windows.Forms.TextBox MediaDuracionTecnicoTB;
        private System.Windows.Forms.Label PromedioTecnicoDesvLBL;
        private System.Windows.Forms.Label MediaInicioFinTecDesvLBL;
        private System.Windows.Forms.Label MediaInicioTecDesvLBL;
        private System.Windows.Forms.Label MediaDuracionTecnicoDesvLBL;
        private System.Windows.Forms.Label PromedioTecnicoLBL;
        private System.Windows.Forms.Label MediaInicioFinTecLBL;
        private System.Windows.Forms.Label MediaInicioTecLBL;
        private System.Windows.Forms.Label MediaDuracionTecnicoLBL;
        private System.Windows.Forms.ComboBox TipoProblemaCB;
        private System.Windows.Forms.Label label1;
    }
}