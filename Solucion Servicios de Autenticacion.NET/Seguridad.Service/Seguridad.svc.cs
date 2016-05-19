using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Seguridad.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : ISeguridad
    {

        /*El método ValidarUsuario() de la implementación, debe utilizar la clase Usuario de la Capa de 
         * Negocio y solicitar la validación de las credenciales y retornar el resultado de esta validación. */
        public bool ValidarUsuario(string Nombre_usuario, string Password)
        {
            Seguridad.Negocio.Usuario usuario = new Negocio.Usuario();

            return usuario.ValidarUsuario(Nombre_usuario, Password);
        }
    }
}
