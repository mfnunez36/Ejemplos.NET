using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Services_Cliente
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSumar_Click(object sender, EventArgs e)
        {
            MatematicasSvc.MatematicasClient serv = new MatematicasSvc.MatematicasClient();

            /*Solicita la Operacion de Suma del Servicio*/
            int operador1 = int.Parse(txtNum1.Text);
            int operador2 = int.Parse(txtNum2.Text);
            int resultadoS = serv.sumar(operador1, operador2);

            /*Despliega el resultado de la operacion*/

            txtResultado.Text = resultadoS.ToString();

            /*Libera La coneccion al servicio*/

            serv.Close();
           
        }

        protected void btnRestar_Click(object sender, EventArgs e)
        {
            MatematicasSvc.MatematicasClient serv = new MatematicasSvc.MatematicasClient();

            /*Solicita la Operacion de Resta del Servicio*/
            int operador1 = int.Parse(txtNum1.Text);
            int operador2 = int.Parse(txtNum2.Text);
            int resultadoR = serv.Restar(operador1, operador2);

            /*Despliega el resultado de la operacion*/

            txtResultado.Text = resultadoR.ToString();

            /*Libera La coneccion al servicio*/

            serv.Close();
           


        }
    }
}