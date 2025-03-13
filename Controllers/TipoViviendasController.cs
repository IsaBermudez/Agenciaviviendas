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
    [RoutePrefix("api/TipoViviendas")]
    public class TipoViviendasController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<TIPoVivienda> ConsultarTodos()
        {
            clsTipoVivienda tipVivien = new clsTipoVivienda();
            return tipVivien.ConsultarTodos();
        }

        [HttpGet]
        [Route("Consultar")]
        public TIPoVivienda Consultar(int id)
        {
            clsTipoVivienda tipVivien = new clsTipoVivienda();
            return tipVivien.Consultar(id);
        }

        [HttpPost]
        [Route("Insertar")]
        public String Insertar([FromBody] TIPoVivienda tipovivi)
        {
            clsTipoVivienda tipVivien = new clsTipoVivienda();
            tipVivien.tipovivienda = tipovivi;
            return tipVivien.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public String Actualizar([FromBody] TIPoVivienda tipovivi)
        {
            clsTipoVivienda tipVivien = new clsTipoVivienda();
            tipVivien.tipovivienda = tipovivi;
            return tipVivien.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public String Eliminar(int id)
        {
            clsTipoVivienda tipVivien = new clsTipoVivienda();
            return tipVivien.Eliminar(id);
        }
    }
}