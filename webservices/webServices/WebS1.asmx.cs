using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace webServices
{
    /// <summary>
    /// Summary description for WebS1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     [System.Web.Script.Services.ScriptService]
    public class WebS1 : System.Web.Services.WebService
    {

        [WebMethod (Description = "Metodo que muestra hello world")]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod(Description = "Metodo que muestra la fecha")]
        public String obtainDate()
        {
            return DateTime.Now.ToString();
        }

        // Utilizando variable de sesión
        [WebMethod(Description = "Metodo que muestra el saludo, indicandole un nombre"
            , EnableSession = true)]
        public String saludo(String name)
        {
            Session["nombre"] = name;
            return "Hi " + Session["nombre"];
        }

        [WebMethod(Description = "Metodo para consumirse desde JS")]
        public String consumirDesdeJavaScript(String data)
        {
            return "este es tu " + data;
        }


        [WebMethod(Description = "Metodo para consumirse desde JS")]
        public String HelloWorldo(String nombre)
        {
            return "Hola " + nombre + ", que Mas";
        }


    }
}
