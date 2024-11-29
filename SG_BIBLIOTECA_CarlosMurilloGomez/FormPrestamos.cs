using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SG_BIBLIOTECA_CarlosMurilloGomez
{
    public partial class FormPrestamos : Form
    {
        public FormPrestamos()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void limpiar()
        {
            tbxIsbn.Clear();
            tbxGenero.Clear();
            tbxAutor.Clear();
            tbxTitulo.Clear();
            dgvLibros.DataSource = null;
            btnPrestar.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (bd_bibliotecaEntities objBD = new bd_bibliotecaEntities())
            {
                var qLibros = from lib in objBD.LIBROS
                              from gen in objBD.GENEROS
                              where lib.Genero == gen.Id_genero
                              orderby lib.Titulo, gen.Nombre
                              select new { lib.Id_libro, lib.ISBN,lib.Titulo, gen.Nombre, lib.Autor, lib.Ejemplares };
                if (!string.IsNullOrEmpty(tbxIsbn.Text.Trim()))
                {
                    qLibros = qLibros.Where(x => x.ISBN.ToLower().StartsWith(tbxIsbn.Text.ToLower().Trim()));

                }
                if (!string.IsNullOrEmpty(tbxTitulo.Text.Trim()))
                {
                    qLibros = qLibros.Where(x => x.Titulo.ToLower().StartsWith(tbxTitulo.Text.ToLower().Trim()));

                }
                if (!string.IsNullOrEmpty(tbxGenero.Text.Trim()))
                {
                    qLibros = qLibros.Where(x => x.Nombre.ToLower().StartsWith(tbxGenero.Text.ToLower().Trim()));
                }
                if (!string.IsNullOrEmpty(tbxAutor.Text.Trim()))
                {
                    qLibros = qLibros.Where(x => x.Autor.ToLower().StartsWith(tbxAutor.Text.ToLower().Trim()));
                }

                dgvLibros.DataSource = qLibros.ToList();
                dgvLibros.Columns[0].Visible = false;

                dgvLibros.Columns[2].HeaderText = "Título";
                dgvLibros.Columns[3].HeaderText = "Género";
                dgvLibros.Columns[5].HeaderText = "Nº Ejemplares";

                if (dgvLibros.Rows.Count > 0)
                {
                    btnPrestar.Enabled = true;
                }
                else
                {
                    btnPrestar.Enabled = false;
                }

            }
        }

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count > 0)
            {
                if ((int)dgvLibros.SelectedRows[0].Cells["Ejemplares"].Value > 0)
                {
                    FormDniPrestar form = new FormDniPrestar();
                    form.id_libro = (int)dgvLibros.SelectedRows[0].Cells["Id_libro"].Value;
                    form.ShowDialog();
                    limpiar();
                }
                else
                {
                    MessageBox.Show("No hay ejemplares de este libro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
