namespace UI
{
    partial class PrincipalForm
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
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.PrincipalSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.IngresarOpcion = new System.Windows.Forms.ToolStripMenuItem();
            this.AsistenciaSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SolicitarAsistenciaOpcion = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultarAsistenciaOpcion = new System.Windows.Forms.ToolStripMenuItem();
            this.TipoProblemaOpcion = new System.Windows.Forms.ToolStripMenuItem();
            this.EstadoAsistenciaOpcion = new System.Windows.Forms.ToolStripMenuItem();
            this.UsuariosSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AdministrarOpcion = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoriaOpcion = new System.Windows.Forms.ToolStripMenuItem();
            this.EncuestaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultarEncuestaOpcion = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportesSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EstadisticasMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ProveedoresSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AdministrarProveedorOpcion = new System.Windows.Forms.ToolStripMenuItem();
            this.EstadisticasAsistenciaTecnicaOpcion = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrincipalSubMenu,
            this.AsistenciaSubMenu,
            this.UsuariosSubMenu,
            this.EncuestaMenu,
            this.ReportesSubMenu,
            this.EstadisticasMenu,
            this.ProveedoresSubMenu});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(1314, 24);
            this.MenuPrincipal.TabIndex = 1;
            this.MenuPrincipal.Text = "menuStrip1";
            // 
            // PrincipalSubMenu
            // 
            this.PrincipalSubMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IngresarOpcion});
            this.PrincipalSubMenu.Name = "PrincipalSubMenu";
            this.PrincipalSubMenu.Size = new System.Drawing.Size(50, 20);
            this.PrincipalSubMenu.Text = "Menu";
            // 
            // IngresarOpcion
            // 
            this.IngresarOpcion.Name = "IngresarOpcion";
            this.IngresarOpcion.Size = new System.Drawing.Size(116, 22);
            this.IngresarOpcion.Text = "Ingresar";
            this.IngresarOpcion.Click += new System.EventHandler(this.IngresarOpcion_Click);
            // 
            // AsistenciaSubMenu
            // 
            this.AsistenciaSubMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SolicitarAsistenciaOpcion,
            this.ConsultarAsistenciaOpcion,
            this.TipoProblemaOpcion,
            this.EstadoAsistenciaOpcion});
            this.AsistenciaSubMenu.Name = "AsistenciaSubMenu";
            this.AsistenciaSubMenu.Size = new System.Drawing.Size(115, 20);
            this.AsistenciaSubMenu.Text = "Asistencia Tecnica";
            this.AsistenciaSubMenu.Click += new System.EventHandler(this.AsistenciaSubMenu_Click);
            // 
            // SolicitarAsistenciaOpcion
            // 
            this.SolicitarAsistenciaOpcion.Name = "SolicitarAsistenciaOpcion";
            this.SolicitarAsistenciaOpcion.Size = new System.Drawing.Size(186, 22);
            this.SolicitarAsistenciaOpcion.Text = "Solicitar";
            this.SolicitarAsistenciaOpcion.Click += new System.EventHandler(this.SolicitarAsistenciaOpcion_Click);
            // 
            // ConsultarAsistenciaOpcion
            // 
            this.ConsultarAsistenciaOpcion.Name = "ConsultarAsistenciaOpcion";
            this.ConsultarAsistenciaOpcion.Size = new System.Drawing.Size(186, 22);
            this.ConsultarAsistenciaOpcion.Text = "Consultar";
            this.ConsultarAsistenciaOpcion.Click += new System.EventHandler(this.ConsultarAsistenciaOpcion_Click);
            // 
            // TipoProblemaOpcion
            // 
            this.TipoProblemaOpcion.Name = "TipoProblemaOpcion";
            this.TipoProblemaOpcion.Size = new System.Drawing.Size(186, 22);
            this.TipoProblemaOpcion.Text = "Tipo de Problemas";
            this.TipoProblemaOpcion.Click += new System.EventHandler(this.TipoProblemaOpcion_Click);
            // 
            // EstadoAsistenciaOpcion
            // 
            this.EstadoAsistenciaOpcion.Name = "EstadoAsistenciaOpcion";
            this.EstadoAsistenciaOpcion.Size = new System.Drawing.Size(186, 22);
            this.EstadoAsistenciaOpcion.Text = "Estado de Asistencias";
            this.EstadoAsistenciaOpcion.Click += new System.EventHandler(this.EstadoAsistenciaOpcion_Click);
            // 
            // UsuariosSubMenu
            // 
            this.UsuariosSubMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdministrarOpcion,
            this.CategoriaOpcion});
            this.UsuariosSubMenu.Name = "UsuariosSubMenu";
            this.UsuariosSubMenu.Size = new System.Drawing.Size(64, 20);
            this.UsuariosSubMenu.Text = "Usuarios";
            // 
            // AdministrarOpcion
            // 
            this.AdministrarOpcion.Name = "AdministrarOpcion";
            this.AdministrarOpcion.Size = new System.Drawing.Size(136, 22);
            this.AdministrarOpcion.Text = "Administrar";
            this.AdministrarOpcion.Click += new System.EventHandler(this.AdministrarOpcion_Click);
            // 
            // CategoriaOpcion
            // 
            this.CategoriaOpcion.Name = "CategoriaOpcion";
            this.CategoriaOpcion.Size = new System.Drawing.Size(136, 22);
            this.CategoriaOpcion.Text = "Categoria";
            this.CategoriaOpcion.Click += new System.EventHandler(this.CategoriaOpcion_Click);
            // 
            // EncuestaMenu
            // 
            this.EncuestaMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConsultarEncuestaOpcion});
            this.EncuestaMenu.Name = "EncuestaMenu";
            this.EncuestaMenu.Size = new System.Drawing.Size(66, 20);
            this.EncuestaMenu.Text = "Encuesta";
            // 
            // ConsultarEncuestaOpcion
            // 
            this.ConsultarEncuestaOpcion.Name = "ConsultarEncuestaOpcion";
            this.ConsultarEncuestaOpcion.Size = new System.Drawing.Size(125, 22);
            this.ConsultarEncuestaOpcion.Text = "Consultar";
            this.ConsultarEncuestaOpcion.Click += new System.EventHandler(this.ConsultarEncuestaOpcion_Click);
            // 
            // ReportesSubMenu
            // 
            this.ReportesSubMenu.Name = "ReportesSubMenu";
            this.ReportesSubMenu.Size = new System.Drawing.Size(65, 20);
            this.ReportesSubMenu.Text = "Reportes";
            // 
            // EstadisticasMenu
            // 
            this.EstadisticasMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EstadisticasAsistenciaTecnicaOpcion});
            this.EstadisticasMenu.Name = "EstadisticasMenu";
            this.EstadisticasMenu.Size = new System.Drawing.Size(79, 20);
            this.EstadisticasMenu.Text = "Estadísticas";
            // 
            // ProveedoresSubMenu
            // 
            this.ProveedoresSubMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdministrarProveedorOpcion});
            this.ProveedoresSubMenu.Name = "ProveedoresSubMenu";
            this.ProveedoresSubMenu.Size = new System.Drawing.Size(84, 20);
            this.ProveedoresSubMenu.Text = "Proveedores";
            // 
            // AdministrarProveedorOpcion
            // 
            this.AdministrarProveedorOpcion.Name = "AdministrarProveedorOpcion";
            this.AdministrarProveedorOpcion.Size = new System.Drawing.Size(136, 22);
            this.AdministrarProveedorOpcion.Text = "Administrar";
            this.AdministrarProveedorOpcion.Click += new System.EventHandler(this.AdministrarProveedorOpcion_Click);
            // 
            // EstadisticasAsistenciaTecnicaOpcion
            // 
            this.EstadisticasAsistenciaTecnicaOpcion.Name = "EstadisticasAsistenciaTecnicaOpcion";
            this.EstadisticasAsistenciaTecnicaOpcion.Size = new System.Drawing.Size(180, 22);
            this.EstadisticasAsistenciaTecnicaOpcion.Text = "Asistencias Técnicas";
            this.EstadisticasAsistenciaTecnicaOpcion.Click += new System.EventHandler(this.EstadisticasAsistenciaTecnicaOpcion_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 799);
            this.Controls.Add(this.MenuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuPrincipal;
            this.Name = "PrincipalForm";
            this.Text = "Sistema de Asistencias Técnicas";
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem PrincipalSubMenu;
        private System.Windows.Forms.ToolStripMenuItem IngresarOpcion;
        private System.Windows.Forms.ToolStripMenuItem AsistenciaSubMenu;
        private System.Windows.Forms.ToolStripMenuItem SolicitarAsistenciaOpcion;
        private System.Windows.Forms.ToolStripMenuItem ConsultarAsistenciaOpcion;
        private System.Windows.Forms.ToolStripMenuItem UsuariosSubMenu;
        private System.Windows.Forms.ToolStripMenuItem AdministrarOpcion;
        private System.Windows.Forms.ToolStripMenuItem EncuestaMenu;
        private System.Windows.Forms.ToolStripMenuItem ConsultarEncuestaOpcion;
        private System.Windows.Forms.ToolStripMenuItem ReportesSubMenu;
        private System.Windows.Forms.ToolStripMenuItem EstadisticasMenu;
        private System.Windows.Forms.ToolStripMenuItem TipoProblemaOpcion;
        private System.Windows.Forms.ToolStripMenuItem EstadoAsistenciaOpcion;
        private System.Windows.Forms.ToolStripMenuItem CategoriaOpcion;
        private System.Windows.Forms.ToolStripMenuItem ProveedoresSubMenu;
        private System.Windows.Forms.ToolStripMenuItem AdministrarProveedorOpcion;
        private System.Windows.Forms.ToolStripMenuItem EstadisticasAsistenciaTecnicaOpcion;
    }
}