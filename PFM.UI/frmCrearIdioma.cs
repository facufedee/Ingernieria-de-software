using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Abstraccion;
using ABSTRACCION;
using BE;
using BLL;

namespace UI
{
    public partial class frmCrearIdioma : Form, ITraducible
    {

        public delegate void DelIdioma();
        public event DelIdioma EvIdioma;
        private List<BEPalabra> Palabras;
        public frmCrearIdioma()
        {
            InitializeComponent();
            Registrarse();
            Actualizar();
            CargarTags();
        }

        private void CargarTags()
        {
            BLLTraductor bllTraductor = new BLLTraductor();
            Palabras = bllTraductor.ObtenerPalabrasTag();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Palabras;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Tag"].ReadOnly = true;

        }


        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            string NombreIdioma = metroTextBox1.Text;

            if (NombreIdioma == "")
            {
                MessageBox.Show("Ingrese el nombre de su idioma");
                return;
            }

            Palabras = (List<BEPalabra>)dataGridView1.DataSource;
            BLLTraductor bllTraductor = new BLLTraductor();

            BEIdioma Idioma = new BEIdioma(NombreIdioma);
            Idioma.Palabras = Palabras;
            Idioma.Id = bllTraductor.ObtenerIdiomas().Count + 1;

            if (bllTraductor.ExisteIdioma(Idioma))
            {
                MessageBox.Show("El idioma ya esta registrado");
                return;
            }
            bllTraductor.AgregarIdioma(Idioma);

            EvIdioma();

            CargarTags();
            metroTextBox1.Clear();
        }

        public void Registrarse()
        {
            BLLTraductor BllTraductor = new BLLTraductor();
            BllTraductor.RegistrarForm(this);
        }

        public void Actualizar()
        {
            BLLTraductor bllTraductor = new BLLTraductor();
            List<BEPalabra> Palabras = bllTraductor.ObtenerPalabras();

            try
            {
                if (this.Tag != null & this.Tag != "")
                {
                    this.Text = Palabras.Find(pal => pal.Tag.Equals(Tag)).Texto;
                }
                foreach (Control control in Controls)
                {
                    if (control.Tag != null & control.Tag != "")
                    {
                        control.Text = Palabras.Find(pal => pal.Tag.Equals(control.Tag)).Texto;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Faltan traducciones");
            }
        }
    }
}
