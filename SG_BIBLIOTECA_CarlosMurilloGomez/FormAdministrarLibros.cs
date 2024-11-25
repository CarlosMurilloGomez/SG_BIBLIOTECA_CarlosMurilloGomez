using Microsoft.IdentityModel.Tokens;
using SG_BIBLIOTECA_CarlosMurilloGomez.bdDataSetTableAdapters;
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
    public partial class FormAdministrarLibros : Form
    {
        bdDataSet bdDataSetExtra = new bdDataSet();
        public FormAdministrarLibros()
        {
            InitializeComponent();
        }
        private void FormAdministrarLibros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdDataSet.GENEROS' Puede moverla o quitarla según sea necesario.
            this.gENEROSTableAdapter.Fill(this.bdDataSet.GENEROS);

            // TODO: esta línea de código carga datos en la tabla 'bdDataSet.LIBROS' Puede moverla o quitarla según sea necesario.
            this.lIBROSTableAdapter.Fill(this.bdDataSet.LIBROS);
        }

        private void lIBROSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lIBROSBindingSource.EndEdit();


            if (!comprobarCampos())
            {
                this.tableAdapterManager.UpdateAll(this.bdDataSet);
            }            

        }

        private bool comprobarCampos()
        {
            bool hayError = false; 
            epCampos.Clear();
            this.lIBROSTableAdapter.FillByISBN(bdDataSetExtra.LIBROS, iSBNTextBox.Text);
            int idActual = this.bdDataSet.LIBROS[int.Parse(lIBROSBindingNavigator.PositionItem.Text) - 1].Id_libro;

            if ((bdDataSetExtra.LIBROS.Rows.Count > 0) && (idActual.ToString() != bdDataSetExtra.LIBROS.Rows[0]["Id_libro"].ToString()))
            {
                epCampos.SetError(iSBNTextBox, "El ISBN ya existe");
                hayError = true;
            }
            if (String.IsNullOrEmpty(iSBNTextBox.Text))
            {
                epCampos.SetError(iSBNTextBox, "Este campo esta vacio");
                hayError = true;
            }
            if (String.IsNullOrEmpty(tituloTextBox.Text))
            {
                epCampos.SetError(tituloTextBox, "Este campo esta vacio");
                hayError = true;
            }
            if (String.IsNullOrEmpty(autorTextBox.Text))
            {
                epCampos.SetError(autorTextBox, "Este campo esta vacio");
                hayError = true;
            }
            if (generoComboBox.SelectedIndex == -1)
            {
                epCampos.SetError(generoComboBox, "Selecciona un género");
                hayError = true;
            }
            return hayError;

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            int idActual = this.bdDataSet.LIBROS[int.Parse(lIBROSBindingNavigator.PositionItem.Text) - 1].Id_libro;


            DialogResult rs = MessageBox.Show("¿Esta seguro de eliminar el libro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                PRESTAMOSTableAdapter pta = new PRESTAMOSTableAdapter();
                pta.FillByLibro(bdDataSet.PRESTAMOS, idActual);

                if (bdDataSet.PRESTAMOS.Count > 0)
                {
                    DialogResult rs2 = MessageBox.Show("El libro tiene prestamos, ¿Seguro que quieres eliminarlo junto con sus prestamos?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs2 == DialogResult.Yes)
                    {
                        pta.DeleteByLibro(idActual);
                        this.lIBROSTableAdapter.DeleteById(idActual);
                        this.lIBROSTableAdapter.Fill(this.bdDataSet.LIBROS);
                    }
                }
                else
                {
                    this.lIBROSTableAdapter.DeleteById(idActual);
                    this.lIBROSTableAdapter.Fill(this.bdDataSet.LIBROS);
                }

            }
        }

        private void btnCambiarCaratula_Click(object sender, EventArgs e)
        {
            DialogResult dr = ofdCaratula.ShowDialog();
            if (dr == DialogResult.OK)
            {
                caratulaPictureBox.Image = Image.FromFile(ofdCaratula.FileName);
            }
        }


    }
}
