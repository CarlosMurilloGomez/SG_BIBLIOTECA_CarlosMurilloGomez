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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (MdiChildren[0].Name != "FormAdministrarLibros")
                {
                    DialogResult rs = MessageBox.Show("¿Desea cerrar el formulario actual?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        FormAdministrarLibros form = new FormAdministrarLibros();
                        form.MdiParent = this;
                        form.Dock = DockStyle.Fill;
                        form.Show();
                    }
                }
            }
            else
            {
                FormAdministrarLibros form = new FormAdministrarLibros();
                form.MdiParent = this;
                form.Dock = DockStyle.Fill;
                form.Show();
            }
        }

        private void sociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (MdiChildren[0].Name != "FormAdministrarSocios")
                {
                    DialogResult rs = MessageBox.Show("¿Desea cerrar el formulario actual?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        FormAdministrarSocios form = new FormAdministrarSocios();
                        form.MdiParent = this;
                        form.Dock = DockStyle.Fill;
                        form.Show();
                    }
                }
            }
            else
            {
                FormAdministrarSocios form = new FormAdministrarSocios();
                form.MdiParent = this;
                form.Dock = DockStyle.Fill;
                form.Show();
            }
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (MdiChildren[0].Name != "FormPrestamos")
                {
                    DialogResult rs = MessageBox.Show("¿Desea cerrar el formulario actual?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        FormPrestamos form = new FormPrestamos();
                        form.MdiParent = this;
                        form.Dock = DockStyle.Fill;
                        form.Show();
                    }
                }
            }
            else
            {
                FormPrestamos form = new FormPrestamos();
                form.MdiParent = this;
                form.Dock = DockStyle.Fill;
                form.Show();
            }
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (MdiChildren[0].Name != "FormInformes")
                {
                    DialogResult rs = MessageBox.Show("¿Desea cerrar el formulario actual?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        FormInformes form = new FormInformes();
                        form.MdiParent = this;
                        form.Dock = DockStyle.Fill;
                        form.Show();
                    }
                }
            }
            else
            {
                FormInformes form = new FormInformes();
                form.MdiParent = this;
                form.Dock = DockStyle.Fill;
                form.Show();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("¿Desea salir de la aplicacion?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }
    }
}
