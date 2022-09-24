using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        List<Estudiantes> listEstudents = new List<Estudiantes>();

        private readonly object txtApellido;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) )
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                int id = int.Parse(txtId.Text);
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                listEstudents.Add(new Estudiantes(){
                    Id = id,
                    Nombre = nombre,
                    Apelido = apellido
                });
                MessageBox.Show("Su registro fue agregado con exito")
                txtId.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
            }

        }

        private static void btnEnviar_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            if (listEstudents.Count > 0)
            {
                //enviar los datos
                f2.listEstudents = this.listEstudents;
                f2.Show();
            }
            else
            {
                MessageBox.Show("Debe agregar al menos un registro");
            }
        }
    }
}
