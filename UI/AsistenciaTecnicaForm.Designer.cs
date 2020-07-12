using System.ComponentModel;

namespace UI
{
    partial class AsistenciaTecnicaForm
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
            this.AsistenciasTecnicasGB = new System.Windows.Forms.GroupBox();
            this.AsistenciasTecnicasDGV = new System.Windows.Forms.DataGridView();
            this.AsistenciaTecnicaGB = new System.Windows.Forms.GroupBox();
            this.DescripcionTB = new System.Windows.Forms.TextBox();
            this.DescripcionLBL = new System.Windows.Forms.Label();
            this.CalificarBTN = new System.Windows.Forms.Button();
            this.GestionComputadoraBTN = new System.Windows.Forms.Button();
            this.EliminarBTN = new System.Windows.Forms.Button();
            this.ModificarBTN = new System.Windows.Forms.Button();
            this.ActualizarEstadoBTN = new System.Windows.Forms.Button();
            this.EstadoCB = new System.Windows.Forms.ComboBox();
            this.TipoProblemaCB = new System.Windows.Forms.ComboBox();
            this.CalificacionTB = new System.Windows.Forms.TextBox();
            this.TecnicoTB = new System.Windows.Forms.TextBox();
            this.UsuarioTB = new System.Windows.Forms.TextBox();
            this.FechaTB = new System.Windows.Forms.TextBox();
            this.CodigoTB = new System.Windows.Forms.TextBox();
            this.CalificacionLBL = new System.Windows.Forms.Label();
            this.EstadoLBL = new System.Windows.Forms.Label();
            this.TipoProblemaLBL = new System.Windows.Forms.Label();
            this.TecnicoLBL = new System.Windows.Forms.Label();
            this.FechaLBL = new System.Windows.Forms.Label();
            this.UsuarioLBL = new System.Windows.Forms.Label();
            this.CodigoLBL = new System.Windows.Forms.Label();
            this.AsistenciasTecnicasGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AsistenciasTecnicasDGV)).BeginInit();
            this.AsistenciaTecnicaGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // AsistenciasTecnicasGB
            // 
            this.AsistenciasTecnicasGB.Controls.Add(this.AsistenciasTecnicasDGV);
            this.AsistenciasTecnicasGB.Location = new System.Drawing.Point(12, 17);
            this.AsistenciasTecnicasGB.Name = "AsistenciasTecnicasGB";
            this.AsistenciasTecnicasGB.Size = new System.Drawing.Size(652, 525);
            this.AsistenciasTecnicasGB.TabIndex = 0;
            this.AsistenciasTecnicasGB.TabStop = false;
            this.AsistenciasTecnicasGB.Text = "Asistencias Técnicas";
            // 
            // AsistenciasTecnicasDGV
            // 
            this.AsistenciasTecnicasDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AsistenciasTecnicasDGV.Location = new System.Drawing.Point(6, 24);
            this.AsistenciasTecnicasDGV.Name = "AsistenciasTecnicasDGV";
            this.AsistenciasTecnicasDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AsistenciasTecnicasDGV.Size = new System.Drawing.Size(640, 431);
            this.AsistenciasTecnicasDGV.TabIndex = 0;
            this.AsistenciasTecnicasDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AsistenciasTecnicasDGV_CellClick);
            // 
            // AsistenciaTecnicaGB
            // 
            this.AsistenciaTecnicaGB.Controls.Add(this.DescripcionTB);
            this.AsistenciaTecnicaGB.Controls.Add(this.DescripcionLBL);
            this.AsistenciaTecnicaGB.Controls.Add(this.CalificarBTN);
            this.AsistenciaTecnicaGB.Controls.Add(this.GestionComputadoraBTN);
            this.AsistenciaTecnicaGB.Controls.Add(this.EliminarBTN);
            this.AsistenciaTecnicaGB.Controls.Add(this.ModificarBTN);
            this.AsistenciaTecnicaGB.Controls.Add(this.ActualizarEstadoBTN);
            this.AsistenciaTecnicaGB.Controls.Add(this.EstadoCB);
            this.AsistenciaTecnicaGB.Controls.Add(this.TipoProblemaCB);
            this.AsistenciaTecnicaGB.Controls.Add(this.CalificacionTB);
            this.AsistenciaTecnicaGB.Controls.Add(this.TecnicoTB);
            this.AsistenciaTecnicaGB.Controls.Add(this.UsuarioTB);
            this.AsistenciaTecnicaGB.Controls.Add(this.FechaTB);
            this.AsistenciaTecnicaGB.Controls.Add(this.CodigoTB);
            this.AsistenciaTecnicaGB.Controls.Add(this.CalificacionLBL);
            this.AsistenciaTecnicaGB.Controls.Add(this.EstadoLBL);
            this.AsistenciaTecnicaGB.Controls.Add(this.TipoProblemaLBL);
            this.AsistenciaTecnicaGB.Controls.Add(this.TecnicoLBL);
            this.AsistenciaTecnicaGB.Controls.Add(this.FechaLBL);
            this.AsistenciaTecnicaGB.Controls.Add(this.UsuarioLBL);
            this.AsistenciaTecnicaGB.Controls.Add(this.CodigoLBL);
            this.AsistenciaTecnicaGB.Location = new System.Drawing.Point(716, 17);
            this.AsistenciaTecnicaGB.Name = "AsistenciaTecnicaGB";
            this.AsistenciaTecnicaGB.Size = new System.Drawing.Size(389, 618);
            this.AsistenciaTecnicaGB.TabIndex = 1;
            this.AsistenciaTecnicaGB.TabStop = false;
            this.AsistenciaTecnicaGB.Text = "Asistencia Tecnias";
            // 
            // DescripcionTB
            // 
            this.DescripcionTB.Location = new System.Drawing.Point(114, 324);
            this.DescripcionTB.Multiline = true;
            this.DescripcionTB.Name = "DescripcionTB";
            this.DescripcionTB.Size = new System.Drawing.Size(230, 77);
            this.DescripcionTB.TabIndex = 6;
            // 
            // DescripcionLBL
            // 
            this.DescripcionLBL.Location = new System.Drawing.Point(11, 327);
            this.DescripcionLBL.Name = "DescripcionLBL";
            this.DescripcionLBL.Size = new System.Drawing.Size(102, 27);
            this.DescripcionLBL.TabIndex = 5;
            this.DescripcionLBL.Text = "Descripcion:";
            // 
            // CalificarBTN
            // 
            this.CalificarBTN.Location = new System.Drawing.Point(14, 569);
            this.CalificarBTN.Name = "CalificarBTN";
            this.CalificarBTN.Size = new System.Drawing.Size(347, 41);
            this.CalificarBTN.TabIndex = 4;
            this.CalificarBTN.Text = "Calificar Asistencia";
            this.CalificarBTN.UseVisualStyleBackColor = true;
            this.CalificarBTN.Click += new System.EventHandler(this.CalificarBTN_Click);
            // 
            // GestionComputadoraBTN
            // 
            this.GestionComputadoraBTN.Location = new System.Drawing.Point(14, 522);
            this.GestionComputadoraBTN.Name = "GestionComputadoraBTN";
            this.GestionComputadoraBTN.Size = new System.Drawing.Size(347, 41);
            this.GestionComputadoraBTN.TabIndex = 4;
            this.GestionComputadoraBTN.Text = "Gestionar Computadora Asignada";
            this.GestionComputadoraBTN.UseVisualStyleBackColor = true;
            this.GestionComputadoraBTN.Click += new System.EventHandler(this.GestionComputadoraBTN_Click);
            // 
            // EliminarBTN
            // 
            this.EliminarBTN.Location = new System.Drawing.Point(250, 422);
            this.EliminarBTN.Name = "EliminarBTN";
            this.EliminarBTN.Size = new System.Drawing.Size(94, 68);
            this.EliminarBTN.TabIndex = 3;
            this.EliminarBTN.Text = "Eliminar";
            this.EliminarBTN.UseVisualStyleBackColor = true;
            this.EliminarBTN.Click += new System.EventHandler(this.EliminarBTN_Click);
            // 
            // ModificarBTN
            // 
            this.ModificarBTN.Location = new System.Drawing.Point(131, 422);
            this.ModificarBTN.Name = "ModificarBTN";
            this.ModificarBTN.Size = new System.Drawing.Size(94, 68);
            this.ModificarBTN.TabIndex = 3;
            this.ModificarBTN.Text = "Modificar";
            this.ModificarBTN.UseVisualStyleBackColor = true;
            this.ModificarBTN.Click += new System.EventHandler(this.ModificarBTN_Click);
            // 
            // ActualizarEstadoBTN
            // 
            this.ActualizarEstadoBTN.Location = new System.Drawing.Point(14, 422);
            this.ActualizarEstadoBTN.Name = "ActualizarEstadoBTN";
            this.ActualizarEstadoBTN.Size = new System.Drawing.Size(94, 68);
            this.ActualizarEstadoBTN.TabIndex = 3;
            this.ActualizarEstadoBTN.Text = "Actualizar Estado";
            this.ActualizarEstadoBTN.UseVisualStyleBackColor = true;
            this.ActualizarEstadoBTN.Click += new System.EventHandler(this.ActualizarEstadoBTN_Click);
            // 
            // EstadoCB
            // 
            this.EstadoCB.FormattingEnabled = true;
            this.EstadoCB.Location = new System.Drawing.Point(114, 229);
            this.EstadoCB.Name = "EstadoCB";
            this.EstadoCB.Size = new System.Drawing.Size(230, 21);
            this.EstadoCB.TabIndex = 2;
            // 
            // TipoProblemaCB
            // 
            this.TipoProblemaCB.FormattingEnabled = true;
            this.TipoProblemaCB.Location = new System.Drawing.Point(114, 68);
            this.TipoProblemaCB.Name = "TipoProblemaCB";
            this.TipoProblemaCB.Size = new System.Drawing.Size(230, 21);
            this.TipoProblemaCB.TabIndex = 2;
            // 
            // CalificacionTB
            // 
            this.CalificacionTB.Location = new System.Drawing.Point(114, 270);
            this.CalificacionTB.Name = "CalificacionTB";
            this.CalificacionTB.Size = new System.Drawing.Size(230, 20);
            this.CalificacionTB.TabIndex = 1;
            // 
            // TecnicoTB
            // 
            this.TecnicoTB.Location = new System.Drawing.Point(114, 189);
            this.TecnicoTB.Name = "TecnicoTB";
            this.TecnicoTB.Size = new System.Drawing.Size(230, 20);
            this.TecnicoTB.TabIndex = 1;
            // 
            // UsuarioTB
            // 
            this.UsuarioTB.Location = new System.Drawing.Point(114, 149);
            this.UsuarioTB.Name = "UsuarioTB";
            this.UsuarioTB.Size = new System.Drawing.Size(230, 20);
            this.UsuarioTB.TabIndex = 1;
            // 
            // FechaTB
            // 
            this.FechaTB.Location = new System.Drawing.Point(114, 108);
            this.FechaTB.Name = "FechaTB";
            this.FechaTB.Size = new System.Drawing.Size(230, 20);
            this.FechaTB.TabIndex = 1;
            // 
            // CodigoTB
            // 
            this.CodigoTB.Location = new System.Drawing.Point(114, 27);
            this.CodigoTB.Name = "CodigoTB";
            this.CodigoTB.Size = new System.Drawing.Size(230, 20);
            this.CodigoTB.TabIndex = 1;
            // 
            // CalificacionLBL
            // 
            this.CalificacionLBL.Location = new System.Drawing.Point(11, 270);
            this.CalificacionLBL.Name = "CalificacionLBL";
            this.CalificacionLBL.Size = new System.Drawing.Size(102, 27);
            this.CalificacionLBL.TabIndex = 0;
            this.CalificacionLBL.Text = "Calificacion:";
            // 
            // EstadoLBL
            // 
            this.EstadoLBL.Location = new System.Drawing.Point(11, 229);
            this.EstadoLBL.Name = "EstadoLBL";
            this.EstadoLBL.Size = new System.Drawing.Size(102, 27);
            this.EstadoLBL.TabIndex = 0;
            this.EstadoLBL.Text = "Estado:";
            // 
            // TipoProblemaLBL
            // 
            this.TipoProblemaLBL.Location = new System.Drawing.Point(6, 68);
            this.TipoProblemaLBL.Name = "TipoProblemaLBL";
            this.TipoProblemaLBL.Size = new System.Drawing.Size(102, 27);
            this.TipoProblemaLBL.TabIndex = 0;
            this.TipoProblemaLBL.Text = "Tipo de Problema:";
            // 
            // TecnicoLBL
            // 
            this.TecnicoLBL.Location = new System.Drawing.Point(11, 189);
            this.TecnicoLBL.Name = "TecnicoLBL";
            this.TecnicoLBL.Size = new System.Drawing.Size(102, 27);
            this.TecnicoLBL.TabIndex = 0;
            this.TecnicoLBL.Text = "Técnico:";
            // 
            // FechaLBL
            // 
            this.FechaLBL.Location = new System.Drawing.Point(11, 108);
            this.FechaLBL.Name = "FechaLBL";
            this.FechaLBL.Size = new System.Drawing.Size(63, 27);
            this.FechaLBL.TabIndex = 0;
            this.FechaLBL.Text = "Fecha:";
            // 
            // UsuarioLBL
            // 
            this.UsuarioLBL.Location = new System.Drawing.Point(11, 149);
            this.UsuarioLBL.Name = "UsuarioLBL";
            this.UsuarioLBL.Size = new System.Drawing.Size(63, 27);
            this.UsuarioLBL.TabIndex = 0;
            this.UsuarioLBL.Text = "Legajo:";
            // 
            // CodigoLBL
            // 
            this.CodigoLBL.Location = new System.Drawing.Point(11, 27);
            this.CodigoLBL.Name = "CodigoLBL";
            this.CodigoLBL.Size = new System.Drawing.Size(63, 27);
            this.CodigoLBL.TabIndex = 0;
            this.CodigoLBL.Text = "Codigo:";
            // 
            // AsistenciaTecnicaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 647);
            this.Controls.Add(this.AsistenciaTecnicaGB);
            this.Controls.Add(this.AsistenciasTecnicasGB);
            this.Name = "AsistenciaTecnicaForm";
            this.Text = "Asistencia Técnica";
            this.Load += new System.EventHandler(this.AsistenciaTecnicaForm_Load);
            this.AsistenciasTecnicasGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AsistenciasTecnicasDGV)).EndInit();
            this.AsistenciaTecnicaGB.ResumeLayout(false);
            this.AsistenciaTecnicaGB.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView AsistenciasTecnicasDGV;
        private System.Windows.Forms.GroupBox AsistenciasTecnicasGB;
        private System.Windows.Forms.GroupBox AsistenciaTecnicaGB;
        private System.Windows.Forms.ComboBox TipoProblemaCB;
        private System.Windows.Forms.Label CodigoLBL;
        private System.Windows.Forms.Label UsuarioLBL;
        private System.Windows.Forms.Label TecnicoLBL;
        private System.Windows.Forms.Label TipoProblemaLBL;
        private System.Windows.Forms.Label CalificacionLBL;
        private System.Windows.Forms.Label EstadoLBL;
        private System.Windows.Forms.Label FechaLBL;
        private System.Windows.Forms.TextBox CodigoTB;
        private System.Windows.Forms.TextBox FechaTB;
        private System.Windows.Forms.TextBox UsuarioTB;
        private System.Windows.Forms.TextBox TecnicoTB;
        private System.Windows.Forms.TextBox CalificacionTB;

        #endregion

        private System.Windows.Forms.Button EliminarBTN;
        private System.Windows.Forms.Button ModificarBTN;
        private System.Windows.Forms.Button ActualizarEstadoBTN;
        private System.Windows.Forms.ComboBox EstadoCB;
        private System.Windows.Forms.Button GestionComputadoraBTN;
        private System.Windows.Forms.Button CalificarBTN;
        private System.Windows.Forms.TextBox DescripcionTB;
        private System.Windows.Forms.Label DescripcionLBL;
    }
}