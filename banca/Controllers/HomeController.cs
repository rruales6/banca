using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace banca.Controllers
{
    public class HomeController: Controller
    {   
        //GET HOME
        [OutputCache(Duration = 60)]
        public string Index()
        {
            return "pagina principal";
        }


        [ActionName("login")]
        public string Login()
        {
            return "login";
        }

       
        }


    }
}