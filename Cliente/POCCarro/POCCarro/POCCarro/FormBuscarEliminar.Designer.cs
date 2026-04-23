namespace POCCarro
{
    partial class FormBuscarEliminar
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
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtMatriculaBuscarEliminar = new System.Windows.Forms.TextBox();
            this.btnBuscarEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMatricula.Location = new System.Drawing.Point(166, 27);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(94, 28);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matricula";
            // 
            // txtMatriculaBuscarEliminar
            // 
            this.txtMatriculaBuscarEliminar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtMatriculaBuscarEliminar.Location = new System.Drawing.Point(46, 64);
            this.txtMatriculaBuscarEliminar.Name = "txtMatriculaBuscarEliminar";
            this.txtMatriculaBuscarEliminar.Size = new System.Drawing.Size(297, 39);
            this.txtMatriculaBuscarEliminar.TabIndex = 1;
            // 
            // btnBuscarEliminar
            // 
            this.btnBuscarEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnBuscarEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEliminar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnBuscarEliminar.ForeColor = System.Drawing.Color.White;
            this.btnBuscarEliminar.Location = new System.Drawing.Point(366, 59);
            this.btnBuscarEliminar.Name = "btnBuscarEliminar";
            this.btnBuscarEliminar.Size = new System.Drawing.Size(137, 45);
            this.btnBuscarEliminar.TabIndex = 2;
            this.btnBuscarEliminar.Text = "Buscar";
            this.btnBuscarEliminar.UseVisualStyleBackColor = false;
            this.btnBuscarEliminar.Click += new System.EventHandler(this.btnBuscarEliminar_Click);
            // 
            // FormBuscarEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 149);
            this.Controls.Add(this.btnBuscarEliminar);
            this.Controls.Add(this.txtMatriculaBuscarEliminar);
            this.Controls.Add(this.lblMatricula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormBuscarEliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar";
            this.Load += new System.EventHandler(this.FormBuscarEliminar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Estas son las declaraciones que faltaban:
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtMatriculaBuscarEliminar;
        private System.Windows.Forms.Button btnBuscarEliminar;
    }
}
