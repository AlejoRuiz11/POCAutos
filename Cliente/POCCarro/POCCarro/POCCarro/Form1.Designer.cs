using System.Drawing;

namespace POCCarro
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vehiculosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblIcono = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.panelCentro = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panelCentro.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.ForeColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehiculosMenu,
            this.ayudaMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 0;
            // 
            // vehiculosMenu
            // 
            this.vehiculosMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAgregar,
            this.mnuListar,
            this.mnuConsultar,
            this.mnuActualizar,
            this.mnuEliminar});
            this.vehiculosMenu.ForeColor = System.Drawing.Color.White;
            this.vehiculosMenu.Name = "vehiculosMenu";
            this.vehiculosMenu.Size = new System.Drawing.Size(78, 23);
            this.vehiculosMenu.Text = "Vehículos";
            this.vehiculosMenu.Click += new System.EventHandler(this.vehiculosMenu_Click);
            // 
            // mnuAgregar
            // 
            this.mnuAgregar.Name = "mnuAgregar";
            this.mnuAgregar.Size = new System.Drawing.Size(218, 24);
            this.mnuAgregar.Text = "➕  Agregar vehículo";
            this.mnuAgregar.Click += new System.EventHandler(this.mnuAgregar_Click);
            // 
            // mnuListar
            // 
            this.mnuListar.Name = "mnuListar";
            this.mnuListar.Size = new System.Drawing.Size(218, 24);
            this.mnuListar.Text = "📋  Listar vehículos";
            this.mnuListar.Click += new System.EventHandler(this.mnuListar_Click);
            // 
            // mnuConsultar
            // 
            this.mnuConsultar.Name = "mnuConsultar";
            this.mnuConsultar.Size = new System.Drawing.Size(218, 24);
            this.mnuConsultar.Text = "🔍  Consultar vehículo";
            this.mnuConsultar.Click += new System.EventHandler(this.mnuConsultar_Click);
            // 
            // mnuActualizar
            // 
            this.mnuActualizar.Name = "mnuActualizar";
            this.mnuActualizar.Size = new System.Drawing.Size(218, 24);
            this.mnuActualizar.Text = "✏️  Actualizar vehículo";
            this.mnuActualizar.Click += new System.EventHandler(this.mnuActualizar_Click);
            // 
            // mnuEliminar
            // 
            this.mnuEliminar.Name = "mnuEliminar";
            this.mnuEliminar.Size = new System.Drawing.Size(218, 24);
            this.mnuEliminar.Text = "🗑️  Eliminar vehículo";
            this.mnuEliminar.Click += new System.EventHandler(this.mnuEliminar_Click);
            // 
            // ayudaMenu
            // 
            this.ayudaMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAcercaDe});
            this.ayudaMenu.ForeColor = System.Drawing.Color.White;
            this.ayudaMenu.Name = "ayudaMenu";
            this.ayudaMenu.Size = new System.Drawing.Size(60, 23);
            this.ayudaMenu.Text = "Ayuda";
            // 
            // mnuAcercaDe
            // 
            this.mnuAcercaDe.Name = "mnuAcercaDe";
            this.mnuAcercaDe.Size = new System.Drawing.Size(146, 24);
            this.mnuAcercaDe.Text = "Acerca de...";
            this.mnuAcercaDe.Click += new System.EventHandler(this.mnuAcercaDe_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.lblTitulo.Location = new System.Drawing.Point(80, 250);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(640, 50);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Sistema de Gestión de Automóviles";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitulo.Location = new System.Drawing.Point(80, 310);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(640, 30);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Selecciona una opción del menú Vehículos para comenzar";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIcono
            // 
            this.lblIcono.Font = new System.Drawing.Font("Segoe UI", 72F);
            this.lblIcono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.lblIcono.Location = new System.Drawing.Point(295, 120);
            this.lblIcono.Name = "lblIcono";
            this.lblIcono.Size = new System.Drawing.Size(220, 130);
            this.lblIcono.TabIndex = 0;
            this.lblIcono.Text = "🚗";
            this.lblIcono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIcono.Click += new System.EventHandler(this.lblIcono_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblVersion.ForeColor = System.Drawing.Color.LightGray;
            this.lblVersion.Location = new System.Drawing.Point(80, 480);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(640, 20);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "v1.0.0 — Universidad de Ibagué 2026A";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCentro
            // 
            this.panelCentro.BackColor = System.Drawing.Color.White;
            this.panelCentro.Controls.Add(this.lblIcono);
            this.panelCentro.Controls.Add(this.lblTitulo);
            this.panelCentro.Controls.Add(this.lblSubtitulo);
            this.panelCentro.Controls.Add(this.lblVersion);
            this.panelCentro.Location = new System.Drawing.Point(0, 28);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(800, 520);
            this.panelCentro.TabIndex = 1;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelCentro);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestión de Automóviles";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelCentro.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vehiculosMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuAgregar;
        private System.Windows.Forms.ToolStripMenuItem mnuListar;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultar;
        private System.Windows.Forms.ToolStripMenuItem mnuActualizar;
        private System.Windows.Forms.ToolStripMenuItem mnuEliminar;
        private System.Windows.Forms.ToolStripMenuItem ayudaMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuAcercaDe;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblIcono;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Panel panelCentro;
    }
}
