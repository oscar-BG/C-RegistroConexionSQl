namespace appUsuario
{
    partial class FTabla
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
            this.components = new System.ComponentModel.Container();
            this.dgvTablaRegistros = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTablaRegistros
            // 
            this.dgvTablaRegistros.AllowUserToAddRows = false;
            this.dgvTablaRegistros.AllowUserToDeleteRows = false;
            this.dgvTablaRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaRegistros.Location = new System.Drawing.Point(42, 31);
            this.dgvTablaRegistros.Name = "dgvTablaRegistros";
            this.dgvTablaRegistros.ReadOnly = true;
            this.dgvTablaRegistros.Size = new System.Drawing.Size(572, 240);
            this.dgvTablaRegistros.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(265, 278);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 346);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvTablaRegistros);
            this.Name = "FTabla";
            this.Text = "FTabla";
            this.Load += new System.EventHandler(this.FTabla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTablaRegistros;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}