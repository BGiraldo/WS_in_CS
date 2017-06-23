using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ws2
{
    public partial class ConsumoWS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        } 


        protected void obtenerFecha(Object sender, EventArgs e)
        {
            ServiceReference.WebS1SoapClient wbServiceCliente =
                new ServiceReference.WebS1SoapClient();
            lb2.Text = wbServiceCliente.obtainDate();
        }

         protected void saludar(Object sender, EventArgs e)
        {
            String nombre = txt1.Text;
            ServiceReference.WebS1SoapClient wbServiceCliente =
                new ServiceReference.WebS1SoapClient();
            lb3.Text = wbServiceCliente.saludo(nombre);
        }

        protected void helloWord(Object sender, EventArgs e)
        {
            ServiceReference.WebS1SoapClient wbServiceCliente =
                new ServiceReference.WebS1SoapClient();
            lb1.Text = wbServiceCliente.HelloWorld();
        }

    }
}