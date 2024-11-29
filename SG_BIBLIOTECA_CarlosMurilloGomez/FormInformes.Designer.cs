namespace SG_BIBLIOTECA_CarlosMurilloGomez
{
    partial class FormInformes
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
            this.btnConsulta1 = new System.Windows.Forms.Button();
            this.btnConsulta2 = new System.Windows.Forms.Button();
            this.dgvQueries = new System.Windows.Forms.DataGridView();
            this.sfdConsultas = new System.Windows.Forms.SaveFileDialog();
            this.lbConsultas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueries)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsulta1
            // 
            this.btnConsulta1.AutoSize = true;
            this.btnConsulta1.Location = new System.Drawing.Point(50, 77);
            this.btnConsulta1.Name = "btnConsulta1";
            this.btnConsulta1.Size = new System.Drawing.Size(289, 26);
            this.btnConsulta1.TabIndex = 0;
            this.btnConsulta1.Text = "GENERO DEL LIBRO MAS PRESTADO";
            this.btnConsulta1.UseVisualStyleBackColor = true;
            this.btnConsulta1.Click += new System.EventHandler(this.btnConsulta1_Click);
            // 
            // btnConsulta2
            // 
            this.btnConsulta2.AutoSize = true;
            this.btnConsulta2.Location = new System.Drawing.Point(366, 77);
            this.btnConsulta2.Name = "btnConsulta2";
            this.btnConsulta2.Size = new System.Drawing.Size(366, 26);
            this.btnConsulta2.TabIndex = 1;
            this.btnConsulta2.Text = "SOCIO CON PRESTAMO SIN DEVOLVER MAS ANTIGUO";
            this.btnConsulta2.UseVisualStyleBackColor = true;
            this.btnConsulta2.Click += new System.EventHandler(this.btnConsulta2_Click);
            // 
            // dgvQueries
            // 
            this.dgvQueries.AllowUserToAddRows = false;
            this.dgvQueries.AllowUserToDeleteRows = false;
            this.dgvQueries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQueries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueries.Location = new System.Drawing.Point(12, 127);
            this.dgvQueries.MultiSelect = false;
            this.dgvQueries.Name = "dgvQueries";
            this.dgvQueries.ReadOnly = true;
            this.dgvQueries.RowHeadersWidth = 51;
            this.dgvQueries.RowTemplate.Height = 24;
            this.dgvQueries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQueries.Size = new System.Drawing.Size(776, 256);
            this.dgvQueries.TabIndex = 2;
            // 
            // sfdConsultas
            // 
            this.sfdConsultas.DefaultExt = "*.xml";
            this.sfdConsultas.Filter = "Archivos XML|*.xml";
            // 
            // lbConsultas
            // 
            this.lbConsultas.AutoSize = true;
            this.lbConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultas.Location = new System.Drawing.Point(332, 26);
            this.lbConsultas.Name = "lbConsultas";
            this.lbConsultas.Size = new System.Drawing.Size(120, 20);
            this.lbConsultas.TabIndex = 3;
            this.lbConsultas.Text = "CONSULTAS";
            // 
            // FormInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbConsultas);
            this.Controls.Add(this.dgvQueries);
            this.Controls.Add(this.btnConsulta2);
            this.Controls.Add(this.btnConsulta1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInformes";
            this.Text = "FormInformes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsulta1;
        private System.Windows.Forms.Button btnConsulta2;
        private System.Windows.Forms.DataGridView dgvQueries;
        private System.Windows.Forms.SaveFileDialog sfdConsultas;
        private System.Windows.Forms.Label lbConsultas;
    }
}