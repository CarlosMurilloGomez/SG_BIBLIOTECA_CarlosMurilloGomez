using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SG_BIBLIOTECA_CarlosMurilloGomez
{
    public partial class FormAdministrarSocios : Form
    {
        public string dni { set; get; }
        public string nombre { set; get; }
        public string apellidos { set; get; }
        public string telefono { set; get; }
        public string email { set; get; }
        public DateTime fechaNac { set; get; }
        public byte[] foto { set; get; }


        public FormAdministrarSocios()
        {
            InitializeComponent();
        }

        private void FormAdministrarSocios_Load(object sender, EventArgs e)
        {
            cargarSocios();
        }
        private void cargarSocios()
        {
            using (bd_bibliotecaEntities objBD = new bd_bibliotecaEntities())
            {
                var qSocios = from soc in objBD.SOCIOS
                              orderby soc.Apellidos, soc.Nombre
                              select new { soc.Dni, soc.Nombre, soc.Apellidos, soc.Telefono, soc.Email, soc.Fecha_nacimiento, soc.Foto };
                dgvSocios.DataSource = qSocios.ToList();
                dgvSocios.Columns[0].Visible = false;
                dgvSocios.Columns[5].Visible = false;
                dgvSocios.Columns[6].Visible = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvSocios.SelectedRows.Count > 0)
            {
                using (bd_bibliotecaEntities objBD = new bd_bibliotecaEntities())
                {
                    SOCIOS socio = objBD.SOCIOS.Find(dgvSocios.SelectedRows[0].Cells["Dni"].Value);
                    if (socio != null)
                    {
                        DialogResult rs = MessageBox.Show("¿Esta seguro de eliminar el socio?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (rs == DialogResult.Yes)
                        {
                            if (socio.PRESTAMOS.IsNullOrEmpty())
                            {
                                objBD.SOCIOS.Remove(socio);
                                objBD.SaveChanges();
                                MessageBox.Show("Socio con DNI: " + socio.Dni + " eliminado correctamente", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cargarSocios();
                            }
                            else
                            {
                                rs = MessageBox.Show("¿Este socio tiene prestamos, desea eliminarlos a ambos?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (rs == DialogResult.Yes)
                                {
                                    objBD.PRESTAMOS.RemoveRange(socio.PRESTAMOS);
                                    objBD.SOCIOS.Remove(socio);
                                    objBD.SaveChanges();
                                    MessageBox.Show("Socio con DNI: " + socio.Dni + " y sus prestamos eliminados correctamente", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    cargarSocios();
                                }
                            }
                            
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Tienes que seleccionar un socio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvSocios.SelectedRows.Count > 0)
            {
                
                    dni = dgvSocios.SelectedRows[0].Cells["Dni"].Value.ToString();

                    FormSocio form = new FormSocio();
                    form.formAdminDni = dni;
                    form.labelVisible = true;
                    if (form.ShowDialog() == DialogResult.Cancel)
                    {
                        cargarSocios();
                    }
                
            }
            else
            {
                MessageBox.Show("Tienes que seleccionar un socio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormSocio form = new FormSocio();
            form.labelVisible = false;
            if (form.ShowDialog() == DialogResult.Cancel)
            {
                cargarSocios();
            }
        }
    }
}
