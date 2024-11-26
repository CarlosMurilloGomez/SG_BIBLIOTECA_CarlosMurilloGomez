using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SG_BIBLIOTECA_CarlosMurilloGomez
{
    public partial class FormSocio : Form
    {
        public FormAdministrarSocios formAdmin {  set; get; }
        public bool labelVisible {  set; get; }
        public FormSocio()
        {
            InitializeComponent();
        }
        private void FormSocio_Load(object sender, EventArgs e)
        {
            lbDniContenido.Visible = labelVisible;
            tbxDni.Visible = !labelVisible;
            if (labelVisible)
            {
                lbDniContenido.Text = formAdmin.dni;
                tbxNombre.Text = formAdmin.nombre;
                tbxApellidos.Text = formAdmin.apellidos;
                tbxTelefono.Text = formAdmin.telefono;
                tbxEmail.Text = formAdmin.email;
                dtpFechaNac.Value = formAdmin.fechaNac;
                if (formAdmin.foto != null && formAdmin.foto.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(formAdmin.foto))
                    {
                        pbxFoto.Image = Image.FromStream(ms);
                    }
                }
            }
            
        }

        private void btnCambiarFoto_Click(object sender, EventArgs e)
        {
            DialogResult dr = ofdCaratula.ShowDialog();
            if (dr == DialogResult.OK)
            {
                pbxFoto.Image = Image.FromFile(ofdCaratula.FileName);
            }
        }
        private bool comprobarCampos()
        {
            bool hayError = false;
            epCampos.Clear();
            Regex comprobadorNombre = new Regex(@"^([a-zA-ZáéíóúÁÉÍÓÚ]+\s?)+$");
            Regex comprobadorApellidos = new Regex(@"^[a-zA-ZáéíóúÁÉÍÓÚ]+\s([a-zA-ZáéíóúÁÉÍÓÚ]+\s?)+$");

            if (tbxDni.Visible == true && String.IsNullOrEmpty(tbxDni.Text.Trim()))
            {
                epCampos.SetError(tbxDni, "Este campo esta vacio");
                hayError = true;
            }
            else if (tbxDni.Visible == true && !tbxDni.MaskFull)
            {
                epCampos.SetError(tbxDni, "El formato del DNI es incorrecto");
                hayError = true;
            }

            if (String.IsNullOrEmpty(tbxNombre.Text.Trim()))
            {
                epCampos.SetError(tbxNombre, "Este campo esta vacio");
                hayError = true;
            }
            else if (!comprobadorNombre.IsMatch(tbxNombre.Text))
            {
                epCampos.SetError(tbxNombre, "Solo se permiten letras y espacios");
                hayError = true;
            }

            if (String.IsNullOrEmpty(tbxApellidos.Text.Trim()))
            {
                epCampos.SetError(tbxApellidos, "Este campo esta vacio");
                hayError = true;
            }
            else if (!comprobadorApellidos.IsMatch(tbxApellidos.Text))
            {
                epCampos.SetError(tbxApellidos, "Solo se permiten letras y espacios");
                hayError = true;
            }

            if (String.IsNullOrEmpty(tbxTelefono.Text.Trim()))
            {
                epCampos.SetError(tbxTelefono, "Este campo esta vacio");
                hayError = true;
            }
            else if (!tbxTelefono.MaskFull)
            {
                epCampos.SetError(tbxTelefono, "El formato del teléfono es incorrecto");
                hayError = true;
            }

            return hayError;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!comprobarCampos())
            {
                using (bd_bibliotecaEntities objBD = new bd_bibliotecaEntities())
                {
                    if (labelVisible)
                    {
                        SOCIOS socio = objBD.SOCIOS.Find(lbDniContenido.Text);
                        if (socio != null)
                        {
                            socio.Nombre = tbxNombre.Text;
                            socio.Apellidos = tbxApellidos.Text;
                            socio.Telefono = tbxTelefono.Text;
                            socio.Email = tbxEmail.Text;
                            socio.Fecha_nacimiento = dtpFechaNac.Value;
                            if (pbxFoto.Image != null)
                            {
                                using (MemoryStream ms = new MemoryStream())
                                {
                                    pbxFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                                    socio.Foto = ms.ToArray();
                                }
                            }

                            objBD.SaveChanges();

                        }
                        else
                        {
                            MessageBox.Show("El socio con DNI: " + socio.Dni + " no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        SOCIOS socio = objBD.SOCIOS.Find(tbxDni.Text);
                        if (socio != null)
                        {
                            MessageBox.Show("Ya existe un socio con DNI: " + socio.Dni, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            socio = new SOCIOS();
                            socio.Dni = tbxDni.Text;
                            socio.Nombre = tbxNombre.Text;
                            socio.Apellidos = tbxApellidos.Text;
                            socio.Telefono = tbxTelefono.Text;
                            socio.Email = tbxEmail.Text;
                            socio.Fecha_nacimiento = dtpFechaNac.Value;
                            if (pbxFoto.Image != null)
                            {
                                using (MemoryStream ms = new MemoryStream())
                                {
                                    pbxFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                                    socio.Foto = ms.ToArray();
                                }
                            }
                            objBD.SOCIOS.Add(socio);
                            objBD.SaveChanges();

                        }
                    }

                }
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
