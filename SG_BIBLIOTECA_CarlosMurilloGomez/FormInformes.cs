using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SG_BIBLIOTECA_CarlosMurilloGomez
{
    public partial class FormInformes : Form
    {
        public FormInformes()
        {
            InitializeComponent();
        }

        private void btnConsulta1_Click(object sender, EventArgs e)
        {
            using (bd_bibliotecaEntities objBD =  new bd_bibliotecaEntities())
            {
                var subquery = from pre in objBD.PRESTAMOS
                               group pre by pre.Libro into p
                               select new {libroId = p.Key, cantidadPre = p.Count()};
                var libroConMasPrestamos = from sub in subquery
                                           where sub.cantidadPre == subquery.Max(x => x.cantidadPre)
                                           select sub;
                var qGenero = from libMax in libroConMasPrestamos
                              from lib in objBD.LIBROS
                              from gen in objBD.GENEROS
                              where lib.Id_libro == libMax.libroId &&
                              gen.Id_genero == lib.Genero
                              select new { gen.Id_genero, gen.Nombre };
                dgvQueries.DataSource = qGenero.ToList();

                sfdConsultas.FileName = "";
                DialogResult dr = sfdConsultas.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    var dataSet = dgvQueries.ObtenerDataSet();   
                    StreamWriter stw = new StreamWriter(sfdConsultas.FileName);
                    dataSet.WriteXml(stw);
                    stw.Close();
                }

            }
        }

        private void btnConsulta2_Click(object sender, EventArgs e)
        {
            using (bd_bibliotecaEntities objBD = new bd_bibliotecaEntities())
            {
                var subquery = from pre in objBD.PRESTAMOS
                               where pre.Fecha_devolucion==null
                               select new { pre.Socio, pre.Fecha_prestamo };

                var socioConPrestamoMasAntiguo = from sub in subquery
                                                 where sub.Fecha_prestamo == subquery.Min(x => x.Fecha_prestamo)
                                                 select sub;
                var query = from socMin in socioConPrestamoMasAntiguo
                            from soc in objBD.SOCIOS
                            where socMin.Socio == soc.Dni
                            select new {soc.Dni, soc.Nombre, soc.Apellidos};
                dgvQueries.DataSource = query.ToList();

                sfdConsultas.FileName = "";
                DialogResult dr = sfdConsultas.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    var dataSet = dgvQueries.ObtenerDataSet();
                    StreamWriter stw = new StreamWriter(sfdConsultas.FileName);
                    dataSet.WriteXml(stw);
                    stw.Close();
                }
            }
        }
    }
}
