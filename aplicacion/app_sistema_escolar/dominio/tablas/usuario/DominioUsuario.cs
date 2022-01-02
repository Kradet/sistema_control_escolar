using comun.Entidades;
using System.Collections.Generic;
using datos;
using comun.cache;

namespace dominio.tablas
{
    public class DominioUsuario
    {
        DatosUsuarios usuarios = new DatosUsuarios();

        public List<EntidadVistaUsuarios> ListarUsuarios(string buscar)
        {
            return usuarios.ListarUsuario(buscar);
        }

        /*
        public List<EntidadUsuarios> ListarUsuarios(string buscar)
        {
            return usuarios.ListarUsuario(buscar);
        }
        */

        public bool InsertarUsuario(EntidadUsuarios usuario)
        {
            try
            {
                usuarios.InsertarUsuario(usuario);
                return true;
            }
            catch (System.Exception)
            {
                return false;
                throw;
            }
        }

        public bool EditarUsuario(EntidadUsuarios usuario)
        {
            if (usuario.Id_usuario == UserCache.IdUsuario)
            {
                return false;
            }
            else
            {
                try
                {
                    usuarios.EditarUsuario(usuario);
                    return true;
                }
                catch (System.Exception)
                {
                    return false;
                    throw;
                }
            }
        }

        public bool EliminarUsuario(EntidadUsuarios usuario)
        {
            if (usuario.Id_usuario == UserCache.IdUsuario)
            {
                return false;
            }
            else
            {
                try
                {
                    usuarios.EliminarUsuario(usuario);
                    return true;
                }
                catch (System.Exception)
                {
                    return false;
                    throw;
                }
            }
        }

        public EntidadUsuarios ObtenerUsuarioPorId(int id)
        {
            return usuarios.ObtenerUsuarioPorId(id);
        }
    }
}
