using Examen_AgenciaViviendas.Clases;
using Examen_AgenciaViviendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Examen_AgenciaViviendas.Controllers
{
    [RoutePrefix("api/Agencias")]
    public class AgenciasController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<AGEncia> ConsultarTodos()
        {
            clsAgencia Agencia = new clsAgencia();
            return Agencia.ConsultarTodos();
        }

        [HttpGet]
        [Route("Consultar")]
        public AGEncia consultar(int id)
        {
            clsAgencia Agencia = new clsAgencia();
            return Agencia.Consultar(id);
        }

        [HttpPost]
        [Route("Insertar")]
        public String Insertar([FromBody] AGEncia Agen)
        {
            clsAgencia Agencia = new clsAgencia();
            Agencia.agencia = Agen;
            return Agencia.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public String Actualizar([FromBody] AGEncia Agen)
        {
            clsAgencia Agencia = new clsAgencia();
            Agencia.agencia = Agen;
            return Agencia.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public String Eliminar(int id)
        {
            clsAgencia Agencia = new clsAgencia();           
            return Agencia.Eliminar(id);
        }
    }
}
