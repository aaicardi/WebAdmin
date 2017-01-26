using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAdmin.webadmin_api.Controllers
{
    public class PruebaController : ApiController
    {

        [HttpPost]
        [Route("Prueba")]
        public string MetodPrueba(person person)
        {

            return person.name + "Hola";
        }


        [HttpPost]
        [Route("Pruebas")]
        public string MetodPrueba2(person person)
        {

            return person.name + "Hola";
        }
    }

    public class person

    {

        public string name { get; set; }

        public string surname { get; set; }

    }
}
