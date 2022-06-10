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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void CargarGrid()
        {
            try
            {
                using(dbEjemploEntities db = new dbEjemploEntities())
                {
                    var Lst = db.Persona.ToList();
                    dgvEjemplo.DataSource = Lst;
                    dgvEjemplo.Columns["Id"].DisplayIndex = 0;
                    dgvEjemplo.Columns["Nombre"].DisplayIndex = 1;
                    dgvEjemplo.Columns["Apellido"].DisplayIndex = 2;
                    dgvEjemplo.Columns["Correo"].DisplayIndex = 3;
                    dgvEjemplo.Columns["Editar"].DisplayIndex = 4;
                    dgvEjemplo.Columns["Eliminar"].DisplayIndex = 5;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarGrid();
            DGVDisenio.Formato(dgvEjemplo, 1);
            dgvEjemplo.Columns["Editar"].Width = 75;
            dgvEjemplo.Columns["Eliminar"].Width = 75;
        }
        int Id;
        private void EliminarPersona(int pId)
        {
            try
            {
                using(dbEjemploEntities db = new dbEjemploEntities())
                {
                    db.Persona.Remove(db.Persona.
                        Single(p => p.Id == pId));
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvEjemplo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEjemplo.Columns[e.ColumnIndex].Name == "Editar")
            {
                Id = Convert.ToInt32(dgvEjemplo.CurrentRow.
                    Cells["Id"].Value.ToString());
                Form2 f2 = new Form2(Id);
                f2.ShowDialog();
                CargarGrid();
            }
            if(dgvEjemplo.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                Id = Convert.ToInt32(dgvEjemplo.CurrentRow.
                   Cells["Id"].Value.ToString());
                MsgBox msg = new MsgBox("question",
                    "Desea eliminar?\nSe eliminará de forma permanente");
                msg.ShowDialog();
                if (msg.DialogResult == DialogResult.OK)
                {
                    EliminarPersona(Id);
                    CargarGrid();
                }
            }
        }
    }
}
