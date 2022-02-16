using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService2022_A
{
    /// <summary>
    /// Summary description for WebService2022_A
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService2022_A : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int add(int num1, int num2)
        {
            return num1 + num2;
        }

        //[WebMethod]
        //public int add(int [] numArray)
        //{
        //    Console.WriteLine(numArray.Length);
        //    return numArray[0] + numArray[1];
        //}

        [WebMethod]
        public int subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        [WebMethod]
        public int multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        [WebMethod]
        public int divide(int num1, int num2)
        {
            return num1 / num2;

        }
    }
}
