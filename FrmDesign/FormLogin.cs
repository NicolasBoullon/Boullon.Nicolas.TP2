using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmDesign
{
    public partial class FormLogin : Form
    {
        List<Usuario> listUsuarios;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            listUsuarios = UsuarioDAO.GetUsuarios();
        }

        private void btnIngresarLogin_Click(object sender, EventArgs e)
        {
            string user = txtUserLogin.Text;
            string pass = txtPassLogin.Text;

            if (user == "" || pass == "")
            {
                MessageBox.Show("Debe rellenar los datos correspondientes!");
                return;
            }

            if (!Usuario.VerificarUsuarioExistente(user, pass))
            {
                MessageBox.Show("No hay ningun usuario con esos datos!");
                txtPassLogin.Clear();
                return;
            }

            if (Usuario.ConseguirUsuario(user, pass) is not null)
            {

            }
            FormInicio frmInicio = new FormInicio();
            this.Hide();
            frmInicio.ShowDialog();
            this.Close();
        }

        private void btnAutocompletadoLogin_Click(object sender, EventArgs e)
        {
            txtUserLogin.Text = "Nicolas Boullon";
            txtPassLogin.Text = "prueba123";
        }

        private void txtUserLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                MessageBox.Show("Solo Ingresar Letras");
                e.Handled = true;
            }
        }

        private void txtPassLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo Ingresar Letras y Numeros. Sin espacios");
                e.Handled = true;
            }
        }

        private void txtNombreCrear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                MessageBox.Show("Solo Ingresar Letras");
                e.Handled = true;
            }
        }

        private void txtUserCrear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                MessageBox.Show("Solo Ingresar Letras");
                e.Handled = true;
            }
        }

        private void txtPassCrear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo Ingresar Letras y Numeros. Sin espacios");
                e.Handled = true;
            }
        }

        private void txtPassConfirmarCrear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo Ingresar Letras y Numeros. Sin espacios");
                e.Handled = true;
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            string nombreCompletoUser = txtNombreCrear.Text;
            string nombreUsuarioCrear = txtUserCrear.Text;
            string contraUsuarioCrear = txtPassCrear.Text;
            string contraConfirmarUsuarioCrear = txtPassConfirmarCrear.Text;
            if (!VerificarUsuario(nombreUsuarioCrear))
            {
                if (contraUsuarioCrear == contraConfirmarUsuarioCrear)
                {
                    UsuarioDAO.CrearUsuario(nombreCompletoUser, nombreUsuarioCrear, contraUsuarioCrear);
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden!");
                }
            }
            else
            {
                MessageBox.Show("Nombre de Usuario en uso. Ingrese otro nombre de usuario.");
            }

        }

        private bool VerificarUsuario(string nombreUsuarioCrear)
        {
            listUsuarios = UsuarioDAO.GetUsuarios();
            foreach (Usuario user in listUsuarios)
            {
                if (user.UsuarioLogin == nombreUsuarioCrear)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
