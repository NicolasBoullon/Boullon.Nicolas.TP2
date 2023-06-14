using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Usuario
    {
        private int id;
        private string nombreCompleto;
        private string usuarioLogin;
        private string usuarioPassword;
        //List<Usuario> listUsuarios = UsuarioDAO.GetUsuarios();
        public Usuario(int id, string nombreCompleto, string usuarioLogin, string usuarioPassword)
        {
            this.nombreCompleto = nombreCompleto;
            this.usuarioLogin = usuarioLogin;
            this.usuarioPassword = usuarioPassword;
            this.id = id;
        }

        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public string UsuarioLogin { get => usuarioLogin; set => usuarioLogin = value; }
        public string UsuarioPassword { get => usuarioPassword; set => usuarioPassword = value; }
        public int Id { get => id; set => id = value; }




        public static bool VerificarUsuarioExistente(string user, string pass)
        {
            List<Usuario> listUsuarios = UsuarioDAO.GetUsuarios();

            foreach (Usuario u in listUsuarios)
            {
                if (u.UsuarioLogin == user && u.UsuarioPassword == pass)
                {
                    return true;
                }
            }
            return false;
        }

        public static Usuario ConseguirUsuario(string user, string pass)
        {
            List<Usuario> listUsuarios = UsuarioDAO.GetUsuarios();

            foreach (Usuario u in listUsuarios)
            {
                if (u.UsuarioLogin == user && u.UsuarioPassword == pass)
                {
                    return u;
                }
            }
            return null;
        }

        public static bool operator ==(Usuario u1, Usuario u2)
        {
            return u1.UsuarioLogin == u2.UsuarioLogin && u1.UsuarioPassword == u2.UsuarioPassword;
        }

        public static bool operator !=(Usuario u1, Usuario u2)
        {
            return !(u1 == u2);
        }
    }
}
