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
    [RoutePrefix("api/Clientes")]
    public class ClientesController : ApiController
    {
      
            [HttpGet]
            [Route("ConsultarTodos")]
            public List<CLIente> ConsultarTodos()
            {
                clsCliente Cliente = new clsCliente();
                return Cliente.ConsultarTodos();
            }

            [HttpGet]
            [Route("Consultar")]
            public CLIente Consultar(int id)
            {
                clsCliente Cliente = new clsCliente();
                return Cliente.Consultar(id);
            }

            [HttpPost]
            [Route("Insertar")]
            public String Insertar([FromBody] CLIente clien)
            {
                clsCliente Cliente = new clsCliente();
                Cliente.cliente = clien;
                return Cliente.Insertar();
            }

            [HttpPut]
            [Route("Actualizar")]
            public String Actualizar([FromBody] CLIente clien)
            {
                clsCliente Cliente = new clsCliente();
                Cliente.cliente = clien;
                return Cliente.Actualizar();
            }

            [HttpDelete]
            [Route("Eliminar")]
            public String Eliminar(int id)
            {
                clsCliente Cliente = new clsCliente();
                return Cliente.Eliminar(id);
            }
        }
}