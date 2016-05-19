using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSeguridad
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            chkAutenticado.Checked = User.Identity.IsAuthenticated;
            txtUsuario.Text = User.Identity.Name;
        }
    }
}