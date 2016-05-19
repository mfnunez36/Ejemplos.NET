using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace WebSeguridad
{
    public partial class LoginService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            SeguridadSvc.SeguridadClient seguridad = new SeguridadSvc.SeguridadClient();

            //Utiliza el servicio de autenticacion con las credenciales ingresadas

            bool valid = seguridad.ValidarUsuario(Login1.UserName, Login1.Password);


            if (valid)
            { 
                //Asegura el estado de autenticacion

                e.Authenticated = true;


                //Reenvia al usuario a la pagina solicitada originalmente en la llamada

                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);


            }





            /*En el evento Authenticate del control Login, hacemos uso de la operación de validación del 
             * servicio para realizar la autenticación:

            if (FormsAuthentication.Authenticate(Login1.UserName, Login1.Password))
            {
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, Login1.RememberMeSet);
            }

            */
        }
    }
}