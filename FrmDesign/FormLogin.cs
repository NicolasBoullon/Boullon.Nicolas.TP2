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
    }
}
