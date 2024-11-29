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
    public partial class FormDniPrestar : Form
    {
        public int id_libro {  get; set; }
        public FormDniPrestar()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            epDni.Clear();
            if (!string.IsNullOrEmpty(tbxDni.Text))
            {
                using (bd_bibliotecaEntities objBD = new bd_bibliotecaEntities())
                {

                    var qDni = from soc in objBD.SOCIOS
                               where soc.Dni == tbxDni.Text
                               select soc;
                    if (qDni.Count() > 0)
                    {
                        var qPrestamos = from pre in objBD.PRESTAMOS
                                   where pre.Socio == tbxDni.Text
                                   && pre.Fecha_devolucion == null
                                   select pre;
                        if (qPrestamos.Count() > 0)
                        {
                            MessageBox.Show("A este socio no se le puede prestar un libro porque todavia tiene prestamos sin devolver", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tbxDni.Clear();
                        }
                        else
                        {
                            PRESTAMOS objPre = new PRESTAMOS();
                            objPre.Socio = tbxDni.Text;
                            objPre.Libro = id_libro;
                            objPre.Fecha_prestamo = DateTime.Now;

                            objBD.PRESTAMOS.Add(objPre);

                            LIBROS libro = objBD.LIBROS.Find(id_libro);
                            libro.Ejemplares -= 1;

                            objBD.SaveChanges();
                            MessageBox.Show("Prestamo realizado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            this.Close();

                        }
                    }
                    else
                    {
                        epDni.SetError(tbxDni, "No existe ningun socio con ese DNI");

                    }
                }
            }
            else
            {
                epDni.SetError(tbxDni, "Rellena el campo DNI");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
