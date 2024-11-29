namespace SG_BIBLIOTECA_CarlosMurilloGomez
{
    partial class FormPrestamos
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
            this.tbxIsbn = new System.Windows.Forms.TextBox();
            this.tbxGenero = new System.Windows.Forms.TextBox();
            this.tbxTitulo = new System.Windows.Forms.TextBox();
            this.tbxAutor = new System.Windows.Forms.TextBox();
            this.lbIsbn = new System.Windows.Forms.Label();
            this.lbGenero = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbAutor = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnPrestar = new System.Windows.Forms.Button();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxIsbn
            // 
            this.tbxIsbn.Location = new System.Drawing.Point(135, 39);
            this.tbxIsbn.Name = "tbxIsbn";
            this.tbxIsbn.Size = new System.Drawing.Size(175, 22);
            this.tbxIsbn.TabIndex = 0;
            // 
            // tbxGenero
            // 
            this.tbxGenero.Location = new System.Drawing.Point(135, 84);
            this.tbxGenero.Name = "tbxGenero";
            this.tbxGenero.Size = new System.Drawing.Size(175, 22);
            this.tbxGenero.TabIndex = 1;
            // 
            // tbxTitulo
            // 
            this.tbxTitulo.Location = new System.Drawing.Point(473, 38);
            this.tbxTitulo.Name = "tbxTitulo";
            this.tbxTitulo.Size = new System.Drawing.Size(186, 22);
            this.tbxTitulo.TabIndex = 2;
            // 
            // tbxAutor
            // 
            this.tbxAutor.Location = new System.Drawing.Point(473, 81);
            this.tbxAutor.Name = "tbxAutor";
            this.tbxAutor.Size = new System.Drawing.Size(186, 22);
            this.tbxAutor.TabIndex = 3;
            // 
            // lbIsbn
            // 
            this.lbIsbn.AutoSize = true;
            this.lbIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsbn.Location = new System.Drawing.Point(77, 41);
            this.lbIsbn.Name = "lbIsbn";
            this.lbIsbn.Size = new System.Drawing.Size(46, 16);
            this.lbIsbn.TabIndex = 4;
            this.lbIsbn.Text = "ISBN:";
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenero.Location = new System.Drawing.Point(50, 87);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(75, 16);
            this.lbGenero.TabIndex = 5;
            this.lbGenero.Text = "GÉNERO:";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(402, 38);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(65, 16);
            this.lbTitulo.TabIndex = 6;
            this.lbTitulo.Text = "TÍTULO:";
            // 
            // lbAutor
            // 
            this.lbAutor.AutoSize = true;
            this.lbAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAutor.Location = new System.Drawing.Point(405, 83);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(64, 16);
            this.lbAutor.TabIndex = 7;
            this.lbAutor.Text = "AUTOR:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoSize = true;
            this.btnLimpiar.Location = new System.Drawing.Point(235, 148);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 26);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.Location = new System.Drawing.Point(460, 148);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 26);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnPrestar
            // 
            this.btnPrestar.AutoSize = true;
            this.btnPrestar.Enabled = false;
            this.btnPrestar.Location = new System.Drawing.Point(354, 388);
            this.btnPrestar.Name = "btnPrestar";
            this.btnPrestar.Size = new System.Drawing.Size(82, 26);
            this.btnPrestar.TabIndex = 10;
            this.btnPrestar.Text = "PRESTAR";
            this.btnPrestar.UseVisualStyleBackColor = true;
            this.btnPrestar.Click += new System.EventHandler(this.btnPrestar_Click);
            // 
            // dgvLibros
            // 
            this.dgvLibros.AllowUserToAddRows = false;
            this.dgvLibros.AllowUserToDeleteRows = false;
            this.dgvLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Location = new System.Drawing.Point(12, 207);
            this.dgvLibros.MultiSelect = false;
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.ReadOnly = true;
            this.dgvLibros.RowHeadersWidth = 51;
            this.dgvLibros.RowTemplate.Height = 24;
            this.dgvLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLibros.Size = new System.Drawing.Size(776, 157);
            this.dgvLibros.TabIndex = 11;
            // 
            // FormPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvLibros);
            this.Controls.Add(this.btnPrestar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lbAutor);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.lbGenero);
            this.Controls.Add(this.lbIsbn);
            this.Controls.Add(this.tbxAutor);
            this.Controls.Add(this.tbxTitulo);
            this.Controls.Add(this.tbxGenero);
            this.Controls.Add(this.tbxIsbn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrestamos";
            this.Text = "FormPrestamos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxIsbn;
        private System.Windows.Forms.TextBox tbxGenero;
        private System.Windows.Forms.TextBox tbxTitulo;
        private System.Windows.Forms.TextBox tbxAutor;
        private System.Windows.Forms.Label lbIsbn;
        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbAutor;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnPrestar;
        private System.Windows.Forms.DataGridView dgvLibros;
    }
}