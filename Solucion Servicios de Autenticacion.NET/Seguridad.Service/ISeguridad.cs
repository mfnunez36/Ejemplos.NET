using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Seguridad.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ISeguridad
    {
        /* Ajuste el contrato de servicio con el nombre ISeguridad y exponga una operación de 
         * nombre ValidarUsuario(), que retorne un valor de tipo string.*/

        [OperationContract]
        bool ValidarUsuario(string Nombre_usuario, string Password);


    }

}