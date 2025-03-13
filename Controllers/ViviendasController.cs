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
    [RoutePrefix("api/Viviendas")]

    public class ViviendasController : ApiController
    {

        [HttpGet]
        [Route("ConsultarTodos")]
        public List<VIVienda> ConsultarTodos()
        {
            clsVivienda Vivienda = new clsVivienda();
            return Vivienda.ConsultarTodos();
        }

        [HttpGet]
        [Route("Consultar")]
        public VIVienda Consultar(int id)
        {
            clsVivienda Vivienda = new clsVivienda();
            return Vivienda.Consultar(id);
        }

        [HttpPost]
        [Route("Insertar")]
        public String Insertar([FromBody] VIVienda Vivien)
        {
            clsVivienda Vivienda = new clsVivienda();
            Vivienda.vivienda = Vivien;
            return Vivienda.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public String Actualizar([FromBody] VIVienda Vivien)
        {
            clsVivienda Vivienda = new clsVivienda();
            Vivienda.vivienda = Vivien;
            return Vivienda.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public String Eliminar(int id)
        {
            clsVivienda Vivienda = new clsVivienda(); ;
            return Vivienda.Eliminar(id);
        }
    }
}