﻿using System.ComponentModel;

namespace UI
{
    partial class SolicitudAsistenciaForm
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
            this.SolicitarAsistenciaGB = new System.Windows.Forms.GroupBox();
            this.TurnosDGV = new System.Windows.Forms.DataGridView();
            this.ConfirmarSolicitudBTN = new System.Windows.Forms.Button();
            this.SolicitarTurnoBTN = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.DescripcionProblemaTB = new System.Windows.Forms.Label();
            this.TipoProblemaLBL = new System.Windows.Forms.Label();
            this.SolicitarAsistenciaGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TurnosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // SolicitarAsistenciaGB
            // 
            this.SolicitarAsistenciaGB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SolicitarAsistenciaGB.Controls.Add(this.TurnosDGV);
            this.SolicitarAsistenciaGB.Controls.Add(this.ConfirmarSolicitudBTN);
            this.SolicitarAsistenciaGB.Controls.Add(this.SolicitarTurnoBTN);
            this.SolicitarAsistenciaGB.Controls.Add(this.textBox1);
            this.SolicitarAsistenciaGB.Controls.Add(this.comboBox2);
            this.SolicitarAsistenciaGB.Controls.Add(this.DescripcionProblemaTB);
            this.SolicitarAsistenciaGB.Controls.Add(this.TipoProblemaLBL);
            this.SolicitarAsistenciaGB.Location = new System.Drawing.Point(12, 18);
            this.SolicitarAsistenciaGB.Name = "SolicitarAsistenciaGB";
            this.SolicitarAsistenciaGB.Size = new System.Drawing.Size(590, 628);
            this.SolicitarAsistenciaGB.TabIndex = 0;
            this.SolicitarAsistenciaGB.TabStop = false;
            this.SolicitarAsistenciaGB.Text = "Solicitar Asistencia Técnica:";
            // 
            // TurnosDGV
            // 
            this.TurnosDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TurnosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TurnosDGV.Enabled = false;
            this.TurnosDGV.Location = new System.Drawing.Point(21, 395);
            this.TurnosDGV.Name = "TurnosDGV";
            this.TurnosDGV.Size = new System.Drawing.Size(544, 176);
            this.TurnosDGV.TabIndex = 4;
            // 
            // ConfirmarSolicitudBTN
            // 
            this.ConfirmarSolicitudBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmarSolicitudBTN.Enabled = false;
            this.ConfirmarSolicitudBTN.Location = new System.Drawing.Point(21, 577);
            this.ConfirmarSolicitudBTN.Name = "ConfirmarSolicitudBTN";
            this.ConfirmarSolicitudBTN.Size = new System.Drawing.Size(544, 42);
            this.ConfirmarSolicitudBTN.TabIndex = 3;
            this.ConfirmarSolicitudBTN.Text = "Confirmar Solicitud";
            this.ConfirmarSolicitudBTN.UseVisualStyleBackColor = true;
            this.ConfirmarSolicitudBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // SolicitarTurnoBTN
            // 
            this.SolicitarTurnoBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SolicitarTurnoBTN.Location = new System.Drawing.Point(21, 296);
            this.SolicitarTurnoBTN.Name = "SolicitarTurnoBTN";
            this.SolicitarTurnoBTN.Size = new System.Drawing.Size(544, 39);
            this.SolicitarTurnoBTN.TabIndex = 3;
            this.SolicitarTurnoBTN.Text = "Solicitar Turno";
            this.SolicitarTurnoBTN.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(122, 78);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(443, 212);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(122, 28);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(443, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // DescripcionProblemaTB
            // 
            this.DescripcionProblemaTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DescripcionProblemaTB.Location = new System.Drawing.Point(21, 78);
            this.DescripcionProblemaTB.Name = "DescripcionProblemaTB";
            this.DescripcionProblemaTB.Size = new System.Drawing.Size(135, 26);
            this.DescripcionProblemaTB.TabIndex = 0;
            this.DescripcionProblemaTB.Text = "Descripción:";
            // 
            // TipoProblemaLBL
            // 
            this.TipoProblemaLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TipoProblemaLBL.Location = new System.Drawing.Point(21, 23);
            this.TipoProblemaLBL.Name = "TipoProblemaLBL";
            this.TipoProblemaLBL.Size = new System.Drawing.Size(135, 26);
            this.TipoProblemaLBL.TabIndex = 0;
            this.TipoProblemaLBL.Text = "Tipo de Problema";
            // 
            // SolicitudAsistenciaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 661);
            this.Controls.Add(this.SolicitarAsistenciaGB);
            this.Name = "SolicitudAsistenciaForm";
            this.Text = "Solicitar Asistencia";
            this.Load += new System.EventHandler(this.SolicitudAsistenciaForm_Load);
            this.SolicitarAsistenciaGB.ResumeLayout(false);
            this.SolicitarAsistenciaGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TurnosDGV)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button ConfirmarSolicitudBTN;
        private System.Windows.Forms.Label DescripcionProblemaTB;
        private System.Windows.Forms.GroupBox SolicitarAsistenciaGB;
        private System.Windows.Forms.Button SolicitarTurnoBTN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label TipoProblemaLBL;
        private System.Windows.Forms.DataGridView TurnosDGV;

        #endregion
    }
}