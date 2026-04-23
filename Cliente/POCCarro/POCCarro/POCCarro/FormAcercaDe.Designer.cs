using System.Drawing;

namespace POCCarro
{
    partial class FormAcercaDe
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
            this.lblIcono = new System.Windows.Forms.Label();
            this.lblAppNombre = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.separador1 = new System.Windows.Forms.Label();
            this.lblIntegrantes = new System.Windows.Forms.Label();
            this.lblMiembro1Nombre = new System.Windows.Forms.Label();
            this.lblMiembro1Rol = new System.Windows.Forms.Label();
            this.lblMiembro2Nombre = new System.Windows.Forms.Label();
            this.lblMiembro2Rol = new System.Windows.Forms.Label();
            this.lblMiembro3Nombre = new System.Windows.Forms.Label();
            this.lblMiembro3Rol = new System.Windows.Forms.Label();
            this.separador2 = new System.Windows.Forms.Label();
            this.lblUniversidad = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIcono
            // 
            this.lblIcono.Font = new System.Drawing.Font("Segoe UI Emoji", 28F);
            this.lblIcono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.lblIcono.Location = new System.Drawing.Point(30, 20);
            this.lblIcono.Name = "lblIcono";
            this.lblIcono.Size = new System.Drawing.Size(360, 55);
            this.lblIcono.TabIndex = 0;
            this.lblIcono.Text = "🚗";
            this.lblIcono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAppNombre
            // 
            this.lblAppNombre.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblAppNombre.Location = new System.Drawing.Point(30, 78);
            this.lblAppNombre.Name = "lblAppNombre";
            this.lblAppNombre.Size = new System.Drawing.Size(360, 28);
            this.lblAppNombre.TabIndex = 1;
            this.lblAppNombre.Text = "AutoGest";
            this.lblAppNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVersion
            // 
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblVersion.ForeColor = System.Drawing.Color.Gray;
            this.lblVersion.Location = new System.Drawing.Point(30, 106);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(360, 22);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Version 1.0.0 - 2026A";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // separador1
            // 
            this.separador1.BackColor = System.Drawing.Color.LightGray;
            this.separador1.Location = new System.Drawing.Point(30, 140);
            this.separador1.Name = "separador1";
            this.separador1.Size = new System.Drawing.Size(360, 1);
            this.separador1.TabIndex = 3;
            // 
            // lblIntegrantes
            // 
            this.lblIntegrantes.AutoSize = true;
            this.lblIntegrantes.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblIntegrantes.ForeColor = System.Drawing.Color.Gray;
            this.lblIntegrantes.Location = new System.Drawing.Point(30, 150);
            this.lblIntegrantes.Name = "lblIntegrantes";
            this.lblIntegrantes.Size = new System.Drawing.Size(165, 21);
            this.lblIntegrantes.TabIndex = 4;
            this.lblIntegrantes.Text = "Integrantes del equipo";
            // 
            // lblMiembro1Nombre
            // 
            this.lblMiembro1Nombre.AutoSize = true;
            this.lblMiembro1Nombre.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblMiembro1Nombre.Location = new System.Drawing.Point(30, 175);
            this.lblMiembro1Nombre.Name = "lblMiembro1Nombre";
            this.lblMiembro1Nombre.Size = new System.Drawing.Size(135, 21);
            this.lblMiembro1Nombre.TabIndex = 5;
            this.lblMiembro1Nombre.Text = "Kevin Rodriguez";
            // 
            // lblMiembro1Rol
            // 
            this.lblMiembro1Rol.AutoSize = true;
            this.lblMiembro1Rol.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblMiembro1Rol.ForeColor = System.Drawing.Color.Gray;
            this.lblMiembro1Rol.Location = new System.Drawing.Point(250, 175);
            this.lblMiembro1Rol.Name = "lblMiembro1Rol";
            this.lblMiembro1Rol.Size = new System.Drawing.Size(105, 21);
            this.lblMiembro1Rol.TabIndex = 6;
            this.lblMiembro1Rol.Text = "Desarrollador";
            // 
            // lblMiembro2Nombre
            // 
            this.lblMiembro2Nombre.AutoSize = true;
            this.lblMiembro2Nombre.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblMiembro2Nombre.Location = new System.Drawing.Point(30, 200);
            this.lblMiembro2Nombre.Name = "lblMiembro2Nombre";
            this.lblMiembro2Nombre.Size = new System.Drawing.Size(122, 21);
            this.lblMiembro2Nombre.TabIndex = 7;
            this.lblMiembro2Nombre.Text = "Alejandro Ruiz";
            // 
            // lblMiembro2Rol
            // 
            this.lblMiembro2Rol.AutoSize = true;
            this.lblMiembro2Rol.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblMiembro2Rol.ForeColor = System.Drawing.Color.Gray;
            this.lblMiembro2Rol.Location = new System.Drawing.Point(250, 200);
            this.lblMiembro2Rol.Name = "lblMiembro2Rol";
            this.lblMiembro2Rol.Size = new System.Drawing.Size(105, 21);
            this.lblMiembro2Rol.TabIndex = 8;
            this.lblMiembro2Rol.Text = "Desarrollador";
            // 
            // lblMiembro3Nombre
            // 
            this.lblMiembro3Nombre.AutoSize = true;
            this.lblMiembro3Nombre.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblMiembro3Nombre.Location = new System.Drawing.Point(30, 225);
            this.lblMiembro3Nombre.Name = "lblMiembro3Nombre";
            this.lblMiembro3Nombre.Size = new System.Drawing.Size(180, 21);
            this.lblMiembro3Nombre.TabIndex = 9;
            this.lblMiembro3Nombre.Text = "Juan Angel Bocanegra";
            // 
            // lblMiembro3Rol
            // 
            this.lblMiembro3Rol.AutoSize = true;
            this.lblMiembro3Rol.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblMiembro3Rol.ForeColor = System.Drawing.Color.Gray;
            this.lblMiembro3Rol.Location = new System.Drawing.Point(250, 225);
            this.lblMiembro3Rol.Name = "lblMiembro3Rol";
            this.lblMiembro3Rol.Size = new System.Drawing.Size(105, 21);
            this.lblMiembro3Rol.TabIndex = 10;
            this.lblMiembro3Rol.Text = "Desarrollador";
            // 
            // separador2
            // 
            this.separador2.BackColor = System.Drawing.Color.LightGray;
            this.separador2.Location = new System.Drawing.Point(30, 266);
            this.separador2.Name = "separador2";
            this.separador2.Size = new System.Drawing.Size(360, 1);
            this.separador2.TabIndex = 13;
            // 
            // lblUniversidad
            // 
            this.lblUniversidad.AutoSize = true;
            this.lblUniversidad.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblUniversidad.ForeColor = System.Drawing.Color.Gray;
            this.lblUniversidad.Location = new System.Drawing.Point(30, 281);
            this.lblUniversidad.Name = "lblUniversidad";
            this.lblUniversidad.Size = new System.Drawing.Size(291, 21);
            this.lblUniversidad.TabIndex = 14;
            this.lblUniversidad.Text = "Universidad de Ibague - Ing. de Sistemas";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(230, 331);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(160, 40);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormAcercaDe
            // 
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(420, 400);
            this.Controls.Add(this.lblIcono);
            this.Controls.Add(this.lblAppNombre);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.separador1);
            this.Controls.Add(this.lblIntegrantes);
            this.Controls.Add(this.lblMiembro1Nombre);
            this.Controls.Add(this.lblMiembro1Rol);
            this.Controls.Add(this.lblMiembro2Nombre);
            this.Controls.Add(this.lblMiembro2Rol);
            this.Controls.Add(this.lblMiembro3Nombre);
            this.Controls.Add(this.lblMiembro3Rol);
            this.Controls.Add(this.separador2);
            this.Controls.Add(this.lblUniversidad);
            this.Controls.Add(this.btnCerrar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acerca de AutoGest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblIcono;
        private System.Windows.Forms.Label lblAppNombre;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label separador1;
        private System.Windows.Forms.Label lblIntegrantes;
        private System.Windows.Forms.Label lblMiembro1Nombre;
        private System.Windows.Forms.Label lblMiembro1Rol;
        private System.Windows.Forms.Label lblMiembro2Nombre;
        private System.Windows.Forms.Label lblMiembro2Rol;
        private System.Windows.Forms.Label lblMiembro3Nombre;
        private System.Windows.Forms.Label lblMiembro3Rol;
        private System.Windows.Forms.Label separador2;
        private System.Windows.Forms.Label lblUniversidad;
        private System.Windows.Forms.Button btnCerrar;
    }
}