namespace SG_BIBLIOTECA_CarlosMurilloGomez
{
    partial class FormSocio
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
            this.lbDni = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbApellidos = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbFechaNac = new System.Windows.Forms.Label();
            this.lbFoto = new System.Windows.Forms.Label();
            this.lbDniContenido = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCambiarFoto = new System.Windows.Forms.Button();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxApellidos = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            this.ofdCaratula = new System.Windows.Forms.OpenFileDialog();
            this.epCampos = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbxDni = new System.Windows.Forms.MaskedTextBox();
            this.tbxTelefono = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCampos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDni
            // 
            this.lbDni.AutoSize = true;
            this.lbDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDni.Location = new System.Drawing.Point(142, 48);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(37, 16);
            this.lbDni.TabIndex = 0;
            this.lbDni.Text = "DNI:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(103, 89);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(76, 16);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "NOMBRE:";
            // 
            // lbApellidos
            // 
            this.lbApellidos.AutoSize = true;
            this.lbApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellidos.Location = new System.Drawing.Point(86, 134);
            this.lbApellidos.Name = "lbApellidos";
            this.lbApellidos.Size = new System.Drawing.Size(93, 16);
            this.lbApellidos.TabIndex = 2;
            this.lbApellidos.Text = "APELLIDOS:";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefono.Location = new System.Drawing.Point(88, 176);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(91, 16);
            this.lbTelefono.TabIndex = 3;
            this.lbTelefono.Text = "TELÉFONO:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(124, 221);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(55, 16);
            this.lbEmail.TabIndex = 4;
            this.lbEmail.Text = "EMAIL:";
            // 
            // lbFechaNac
            // 
            this.lbFechaNac.AutoSize = true;
            this.lbFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaNac.Location = new System.Drawing.Point(21, 281);
            this.lbFechaNac.Name = "lbFechaNac";
            this.lbFechaNac.Size = new System.Drawing.Size(158, 16);
            this.lbFechaNac.TabIndex = 5;
            this.lbFechaNac.Text = "FECHA NACIMIENTO:";
            // 
            // lbFoto
            // 
            this.lbFoto.AutoSize = true;
            this.lbFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFoto.Location = new System.Drawing.Point(127, 337);
            this.lbFoto.Name = "lbFoto";
            this.lbFoto.Size = new System.Drawing.Size(52, 16);
            this.lbFoto.TabIndex = 6;
            this.lbFoto.Text = "FOTO:";
            // 
            // lbDniContenido
            // 
            this.lbDniContenido.Location = new System.Drawing.Point(218, 48);
            this.lbDniContenido.Name = "lbDniContenido";
            this.lbDniContenido.Size = new System.Drawing.Size(180, 38);
            this.lbDniContenido.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(175, 477);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 26);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(301, 477);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 26);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCambiarFoto
            // 
            this.btnCambiarFoto.AutoSize = true;
            this.btnCambiarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarFoto.Location = new System.Drawing.Point(389, 337);
            this.btnCambiarFoto.Name = "btnCambiarFoto";
            this.btnCambiarFoto.Size = new System.Drawing.Size(101, 50);
            this.btnCambiarFoto.TabIndex = 10;
            this.btnCambiarFoto.Text = "CAMBIAR";
            this.btnCambiarFoto.UseVisualStyleBackColor = true;
            this.btnCambiarFoto.Click += new System.EventHandler(this.btnCambiarFoto_Click);
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(221, 276);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(269, 22);
            this.dtpFechaNac.TabIndex = 11;
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(221, 89);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(269, 22);
            this.tbxNombre.TabIndex = 12;
            // 
            // tbxApellidos
            // 
            this.tbxApellidos.Location = new System.Drawing.Point(221, 134);
            this.tbxApellidos.Name = "tbxApellidos";
            this.tbxApellidos.Size = new System.Drawing.Size(269, 22);
            this.tbxApellidos.TabIndex = 13;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(221, 221);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(269, 22);
            this.tbxEmail.TabIndex = 15;
            // 
            // pbxFoto
            // 
            this.pbxFoto.Location = new System.Drawing.Point(221, 337);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(120, 108);
            this.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFoto.TabIndex = 16;
            this.pbxFoto.TabStop = false;
            // 
            // ofdCaratula
            // 
            this.ofdCaratula.Filter = "\"Archivos de imagen\" | *.png";
            // 
            // epCampos
            // 
            this.epCampos.ContainerControl = this;
            // 
            // tbxDni
            // 
            this.tbxDni.Location = new System.Drawing.Point(221, 48);
            this.tbxDni.Mask = "00000000L";
            this.tbxDni.Name = "tbxDni";
            this.tbxDni.Size = new System.Drawing.Size(269, 22);
            this.tbxDni.TabIndex = 18;
            // 
            // tbxTelefono
            // 
            this.tbxTelefono.Location = new System.Drawing.Point(221, 176);
            this.tbxTelefono.Mask = "000-000-000";
            this.tbxTelefono.Name = "tbxTelefono";
            this.tbxTelefono.Size = new System.Drawing.Size(269, 22);
            this.tbxTelefono.TabIndex = 19;
            // 
            // FormSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 550);
            this.Controls.Add(this.tbxTelefono);
            this.Controls.Add(this.tbxDni);
            this.Controls.Add(this.pbxFoto);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxApellidos);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.btnCambiarFoto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lbDniContenido);
            this.Controls.Add(this.lbFoto);
            this.Controls.Add(this.lbFechaNac);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.lbApellidos);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbDni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSocio";
            this.Load += new System.EventHandler(this.FormSocio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCampos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDni;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbApellidos;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbFechaNac;
        private System.Windows.Forms.Label lbFoto;
        private System.Windows.Forms.Label lbDniContenido;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCambiarFoto;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.TextBox tbxApellidos;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.PictureBox pbxFoto;
        private System.Windows.Forms.OpenFileDialog ofdCaratula;
        private System.Windows.Forms.ErrorProvider epCampos;
        private System.Windows.Forms.MaskedTextBox tbxDni;
        private System.Windows.Forms.MaskedTextBox tbxTelefono;
    }
}