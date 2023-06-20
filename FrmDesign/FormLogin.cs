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
    public delegate void DelegadoMensaje(string mensaje);
    public partial class FormLogin : Form
    {
        List<Usuario> listUsuarios;
        DelegadoMensaje alerta;
        public FormLogin()
        {
            InitializeComponent();
            alerta = MensajeError;
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
                alerta("Debe rellenar los datos correspondientes!");
                return;
            }

            if (!Usuario.VerificarUsuarioExistente(user, pass))
            {
                alerta("No hay ningun usuario con esos datos!");
                txtPassLogin.Clear();
                return;
            }


            FormInicio frmInicio = new FormInicio();
            this.Hide();
            frmInicio.ShowDialog();
            this.Close();
        }


        public void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje);
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
                alerta("Solo Ingresar Letras");
                e.Handled = true;
            }
        }

        private void txtPassLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                alerta("Solo Ingresar Letras y Numeros. Sin espacios");
                e.Handled = true;
            }
        }

        private void txtNombreCrear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                alerta("Solo Ingresar Letras");
                e.Handled = true;
            }
        }

        private void txtUserCrear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                alerta("Solo Ingresar Letras");
                e.Handled = true;
            }
        }

        private void txtPassCrear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                alerta("Solo Ingresar Letras y Numeros. Sin espacios");
                e.Handled = true;
            }
        }

        private void txtPassConfirmarCrear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                alerta("Solo Ingresar Letras y Numeros. Sin espacios");
                e.Handled = true;
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            string nombreCompletoUser = txtNombreCrear.Text;
            string nombreUsuarioCrear = txtUserCrear.Text;
            string contraUsuarioCrear = txtPassCrear.Text;
            string contraConfirmarUsuarioCrear = txtPassConfirmarCrear.Text;
            if (VerificarDatos(nombreCompletoUser, nombreUsuarioCrear, contraUsuarioCrear, contraConfirmarUsuarioCrear))
            {
                if (!VerificarUsuario(nombreUsuarioCrear))
                {
                    if (contraUsuarioCrear == contraConfirmarUsuarioCrear)
                    {
                        UsuarioDAO.CrearUsuario(nombreCompletoUser, nombreUsuarioCrear, contraUsuarioCrear);
                        txtNombreCrear.Clear();
                        txtUserCrear.Clear();
                        txtPassCrear.Clear();
                        txtPassConfirmarCrear.Clear();
                        alerta("Usuario creado con exito!");
                    }
                    else
                    {
                        alerta("Las contraseñas no coinciden!");
                    }
                }
                else
                {
                    alerta("Nombre de Usuario en uso. Ingrese otro nombre de usuario.");
                }
            }
            else
            {
                alerta("Debe llenar todos los campos primero");
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

        private bool VerificarDatos(string nombreCompleto, string nombreUsuario, string pass, string passConfimar)
        {
            if (nombreCompleto is not null && nombreCompleto != "" && nombreUsuario is not null && nombreUsuario != "" &&
                pass is not null && pass != "" && passConfimar is not null && passConfimar != "")
            {
                return true;
            }
            return false;
        }
    }
}
