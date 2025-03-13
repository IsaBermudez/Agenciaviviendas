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
    [RoutePrefix("api/Ventas")]
    public class VentasController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<VENta> ConsultarTodos()
        {
            clsVenta Venta = new clsVenta();
            return Venta.ConsultarTodos();
        }

        [HttpGet]
        [Route("Consultar")]
        public VENta consultar(int id)
        {
            clsVenta Venta = new clsVenta();
            return Venta.Consultar(id);
        }

        [HttpGet]
        [Route("ConsultarXIdCliente")]
        public VENta ConsultarXCliente(int id)
        {
            clsVenta Venta = new clsVenta();
            return Venta.ConsultarXIdCliente(id);
        }

        [HttpPost]
        [Route("Insertar")]
        public String Insertar([FromBody] VENta Vent)
        {
            clsVenta Venta = new clsVenta();
            Venta.venta = Vent;
            return Venta.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public String Actualizar([FromBody] VENta Vent)
        {
            clsVenta Venta = new clsVenta();
            Venta.venta = Vent;
            return Venta.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public String Eliminar(int id)
        {
            clsVenta Venta = new clsVenta();
            return Venta.Eliminar(id);
        }
    }
}