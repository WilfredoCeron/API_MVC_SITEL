using API_MVC_SITEL.Conexiones;
using API_MVC_SITEL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_MVC_SITEL.Controllers
{
    public class DevelopersController : ApiController
    {
        // GET: api/Developers
        public List<Developer> Get()
        {
            Security security = new Security();
            security = SecurityConsulta.securitiesApp();
            return (List<Developer>)DeveloperConsultas.lstDevelopers(security);
        }

        // POST: api/Developers
        public string Post([FromBody] Developer developer, Security security)
        {
            return DeveloperConsultas.insertarDeveloper(developer, security);
        }

        // PUT: api/Developers/5
        public string Put(int id, [FromBody] Developer developer, Security security)
        {
            return DeveloperConsultas.actualizarDeveloper(developer, security);
        }

        // DELETE: api/Developers/5
        public string Delete(int idDeveloper, Security security)
        {
            return DeveloperConsultas.eliminarDeveloper(idDeveloper, security);
        }
    }
}
