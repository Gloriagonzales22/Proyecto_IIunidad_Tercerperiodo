using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Entrada : Form
    {
        public Entrada()
        {
            InitializeComponent();
        }

        private async void aceptarbutton_Click(object sender, EventArgs e)
        {
            //Usuario=GLO Y Contraseña=1234 o Usuario=GGONZA y Contraseña=1478
            if (usuariotextBox1.Text == String.Empty)
            {
                errorProvider1.SetError(usuariotextBox1,"Ingrese un codigo de usuario");
                usuariotextBox1.Focus();
                return;
            }
            errorProvider1.Clear();
            if (contraseñatextBox2.Text == String.Empty)
            {
                errorProvider1.SetError(contraseñatextBox2, "Ingrese una contraseña");
                contraseñatextBox2.Focus();
                return;
            }
            errorProvider1.Clear();

            UsuarioDatos userDatos = new UsuarioDatos();
            bool valido = await userDatos.LoginAsync(usuariotextBox1.Text, contraseñatextBox2.Text);

            if (valido)
            {
                Bienvenido formulario = new Bienvenido();
                Hide();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Datos de usuario incorrecto", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void cancelarbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
