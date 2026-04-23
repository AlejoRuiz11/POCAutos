namespace POCCarro
{
    partial class FormConsultar
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblCriterio = new System.Windows.Forms.Label();
            this.comboCriterio = new System.Windows.Forms.ComboBox();
            this.txtMatriculaConsulta = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblPrecioPuertas = new System.Windows.Forms.Label();
            this.lblColorRegistro = new System.Windows.Forms.Label();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCriterio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblCriterio.Location = new System.Drawing.Point(20, 20);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(148, 20);
            this.lblCriterio.TabIndex = 0;
            this.lblCriterio.Text = "Criterio de búsqueda";
            // 
            // comboCriterio
            // 
            this.comboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCriterio.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.comboCriterio.FormattingEnabled = true;
            this.comboCriterio.Items.AddRange(new object[] {
            "Por matrícula",
            "Por marca"});
            this.comboCriterio.Location = new System.Drawing.Point(20, 42);
            this.comboCriterio.Name = "comboCriterio";
            this.comboCriterio.Size = new System.Drawing.Size(410, 33);
            this.comboCriterio.TabIndex = 0;
            // 
            // txtMatriculaConsulta
            // 
            this.txtMatriculaConsulta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMatriculaConsulta.Location = new System.Drawing.Point(20, 90);
            this.txtMatriculaConsulta.Name = "txtMatriculaConsulta";
            this.txtMatriculaConsulta.Size = new System.Drawing.Size(270, 30);
            this.txtMatriculaConsulta.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(103)))), ((int)(((byte)(160)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(305, 88);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(125, 32);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfo.Controls.Add(this.lblResultado);
            this.panelInfo.Controls.Add(this.lblNombre);
            this.panelInfo.Controls.Add(this.lblMatricula);
            this.panelInfo.Controls.Add(this.lblPrecioPuertas);
            this.panelInfo.Controls.Add(this.lblColorRegistro);
            this.panelInfo.Location = new System.Drawing.Point(20, 140);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(410, 249);
            this.panelInfo.TabIndex = 3;
            this.panelInfo.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 14);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 23);
            this.lblResultado.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblNombre.Location = new System.Drawing.Point(12, 14);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 25);
            this.lblNombre.TabIndex = 0;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblMatricula.Location = new System.Drawing.Point(12, 40);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(0, 20);
            this.lblMatricula.TabIndex = 1;
            // 
            // lblPrecioPuertas
            // 
            this.lblPrecioPuertas.AutoSize = true;
            this.lblPrecioPuertas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPrecioPuertas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblPrecioPuertas.Location = new System.Drawing.Point(12, 68);
            this.lblPrecioPuertas.Name = "lblPrecioPuertas";
            this.lblPrecioPuertas.Size = new System.Drawing.Size(0, 20);
            this.lblPrecioPuertas.TabIndex = 2;
            // 
            // lblColorRegistro
            // 
            this.lblColorRegistro.AutoSize = true;
            this.lblColorRegistro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblColorRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblColorRegistro.Location = new System.Drawing.Point(12, 96);
            this.lblColorRegistro.Name = "lblColorRegistro";
            this.lblColorRegistro.Size = new System.Drawing.Size(0, 20);
            this.lblColorRegistro.TabIndex = 3;
            // 
            // FormConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 414);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.comboCriterio);
            this.Controls.Add(this.txtMatriculaConsulta);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panelInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormConsultar";
            this.Text = "Consultar vehículo";
            this.Load += new System.EventHandler(this.FormConsultar_Load);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.ComboBox comboCriterio;
        private System.Windows.Forms.TextBox txtMatriculaConsulta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblPrecioPuertas;
        private System.Windows.Forms.Label lblColorRegistro;
        private System.Windows.Forms.Label lblResultado;
    }
}