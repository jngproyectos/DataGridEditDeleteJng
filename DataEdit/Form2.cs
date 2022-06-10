using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataEdit
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(int pId)
        {
            InitializeComponent();
            Buscar(pId);
        }
        private void Buscar(int pId)
        {
            try
            {
                using(dbEjemploEntities db = new dbEjemploEntities())
                {
                    var Lst = db.Persona.Where(p => p.Id == pId).ToList();
                    if (Lst.Count > 0)
                    {
                        foreach(Persona persona in Lst)
                        {
                            txtId.Text = persona.Id.ToString();
                            txtNombre.Text = persona.Nombre;
                            txtApellido.Text = persona.Apellido;
                            txtCorreo.Text = persona.Correo;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Persona pPersona = new Persona();
        private void EditarPersona(Persona pPersona)
        {
            try
            {
                using(dbEjemploEntities db = new dbEjemploEntities())
                {
                    db.Entry(pPersona).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CargarDatos()
        {
            pPersona.Id = Convert.ToInt32(txtId.Text);
            pPersona.Nombre = txtNombre.Text;
            pPersona.Apellido = txtApellido.Text;
            pPersona.Correo = txtCorreo.Text;
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            CargarDatos();
            EditarPersona(pPersona);
            this.Close();
        }
    }
}
