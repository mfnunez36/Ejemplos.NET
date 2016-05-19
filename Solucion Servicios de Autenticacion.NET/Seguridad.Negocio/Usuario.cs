using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seguridad.Negocio
{
    public class Usuario
    {
        
        public bool ValidarUsuario(string Nombre_usuario, string Password)
        {
            try
            {
                Seguridad.DALC.Usuarios usuario = CommonBC.ModeloSeguridad.Usuarios.First(usu => usu.username == Nombre_usuario);

                return usuario.password == Password;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

    }
}
