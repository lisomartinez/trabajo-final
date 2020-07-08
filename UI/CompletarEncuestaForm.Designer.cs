using System.ComponentModel;

namespace UI
{
    partial class CompletarEncuestaForm
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
            this.PreguntasGB = new System.Windows.Forms.GroupBox();
            this.PreguntasDGV = new System.Windows.Forms.DataGridView();
            this.PreguntaGB = new System.Windows.Forms.GroupBox();
            this.PreguntaLBL = new System.Windows.Forms.Label();
            this.RespuestaLBL = new System.Windows.Forms.Label();
            this.PreguntaTB = new System.Windows.Forms.TextBox();
            this.RespuestaTB = new System.Windows.Forms.TextBox();
            this.ResponderBTN = new System.Windows.Forms.Button();
            this.PreguntaNroTB = new System.Windows.Forms.TextBox();
            this.PreguntasGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreguntasDGV)).BeginInit();
            this.PreguntaGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // PreguntasGB
            // 
            this.PreguntasGB.Controls.Add(this.PreguntasDGV);
            this.PreguntasGB.Location = new System.Drawing.Point(22, 13);
            this.PreguntasGB.Name = "PreguntasGB";
            this.PreguntasGB.Size = new System.Drawing.Size(600, 539);
            this.PreguntasGB.TabIndex = 0;
            this.PreguntasGB.TabStop = false;
            this.PreguntasGB.Text = "Preguntas";
            // 
            // PreguntasDGV
            // 
            this.PreguntasDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PreguntasDGV.Location = new System.Drawing.Point(7, 20);
            this.PreguntasDGV.Name = "PreguntasDGV";
            this.PreguntasDGV.Size = new System.Drawing.Size(587, 513);
            this.PreguntasDGV.TabIndex = 0;
            // 
            // PreguntaGB
            // 
            this.PreguntaGB.Controls.Add(this.PreguntaNroTB);
            this.PreguntaGB.Controls.Add(this.ResponderBTN);
            this.PreguntaGB.Controls.Add(this.RespuestaTB);
            this.PreguntaGB.Controls.Add(this.PreguntaTB);
            this.PreguntaGB.Controls.Add(this.RespuestaLBL);
            this.PreguntaGB.Controls.Add(this.PreguntaLBL);
            this.PreguntaGB.Location = new System.Drawing.Point(643, 12);
            this.PreguntaGB.Name = "PreguntaGB";
            this.PreguntaGB.Size = new System.Drawing.Size(458, 540);
            this.PreguntaGB.TabIndex = 1;
            this.PreguntaGB.TabStop = false;
            this.PreguntaGB.Text = "Pregunta";
            // 
            // PreguntaLBL
            // 
            this.PreguntaLBL.AutoSize = true;
            this.PreguntaLBL.Location = new System.Drawing.Point(25, 32);
            this.PreguntaLBL.Name = "PreguntaLBL";
            this.PreguntaLBL.Size = new System.Drawing.Size(53, 13);
            this.PreguntaLBL.TabIndex = 0;
            this.PreguntaLBL.Text = "Pregunta:";
            // 
            // RespuestaLBL
            // 
            this.RespuestaLBL.AutoSize = true;
            this.RespuestaLBL.Location = new System.Drawing.Point(25, 337);
            this.RespuestaLBL.Name = "RespuestaLBL";
            this.RespuestaLBL.Size = new System.Drawing.Size(61, 13);
            this.RespuestaLBL.TabIndex = 0;
            this.RespuestaLBL.Text = "Respuesta:";
            // 
            // PreguntaTB
            // 
            this.PreguntaTB.Location = new System.Drawing.Point(128, 66);
            this.PreguntaTB.Multiline = true;
            this.PreguntaTB.Name = "PreguntaTB";
            this.PreguntaTB.Size = new System.Drawing.Size(312, 258);
            this.PreguntaTB.TabIndex = 1;
            // 
            // RespuestaTB
            // 
            this.RespuestaTB.Location = new System.Drawing.Point(128, 330);
            this.RespuestaTB.Name = "RespuestaTB";
            this.RespuestaTB.Size = new System.Drawing.Size(312, 20);
            this.RespuestaTB.TabIndex = 2;
            // 
            // ResponderBTN
            // 
            this.ResponderBTN.Location = new System.Drawing.Point(128, 414);
            this.ResponderBTN.Name = "ResponderBTN";
            this.ResponderBTN.Size = new System.Drawing.Size(312, 63);
            this.ResponderBTN.TabIndex = 3;
            this.ResponderBTN.Text = "Responder";
            this.ResponderBTN.UseVisualStyleBackColor = true;
            // 
            // PreguntaNroTB
            // 
            this.PreguntaNroTB.Location = new System.Drawing.Point(128, 29);
            this.PreguntaNroTB.Name = "PreguntaNroTB";
            this.PreguntaNroTB.Size = new System.Drawing.Size(109, 20);
            this.PreguntaNroTB.TabIndex = 4;
            // 
            // CompletarEncuestaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 595);
            this.Controls.Add(this.PreguntaGB);
            this.Controls.Add(this.PreguntasGB);
            this.Name = "CompletarEncuestaForm";
            this.Text = "AdministrarEncuestaForm";
            this.Load += new System.EventHandler(this.CompletarEncuestaForm_Load);
            this.PreguntasGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PreguntasDGV)).EndInit();
            this.PreguntaGB.ResumeLayout(false);
            this.PreguntaGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PreguntasGB;
        private System.Windows.Forms.DataGridView PreguntasDGV;
        private System.Windows.Forms.GroupBox PreguntaGB;
        private System.Windows.Forms.Label PreguntaLBL;
        private System.Windows.Forms.Button ResponderBTN;
        private System.Windows.Forms.TextBox RespuestaTB;
        private System.Windows.Forms.TextBox PreguntaTB;
        private System.Windows.Forms.Label RespuestaLBL;
        private System.Windows.Forms.TextBox PreguntaNroTB;
    }
}