using comun.cache;
using datos;

namespace dominio
{
    public class DominioLoggin
    {
        UsuarioLoggin usuarioDatos = new UsuarioLoggin();
        TipoUsuarioDatos tipoUsuario = new TipoUsuarioDatos();

        string contrasenia;

        public bool LogginUser(string usuario, string pass)
        {
            contrasenia = pass;
            return usuarioDatos.Loggin(usuario, pass);
        }

        public void CargarTipoUsuario()
        {
            tipoUsuario.CargarTipoUsuario();
        }

        //Comprobamos si existe el usuario
        public bool LogginSeguro()
        {
            if (UserCache.IdUsuario >= 1)
            {
                if (usuarioDatos.ExisteUsuario(UserCache.IdUsuario, UserCache.UserName, contrasenia))
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }
    }
}
