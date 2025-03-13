using Examen_AgenciaViviendas.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Examen_AgenciaViviendas.Clases
{
	public class clsCliente
	{
        private DBAgencia_viviendasEntities dbagencia = new DBAgencia_viviendasEntities();//objeto para gestionar los datos de la agencia 
        public CLIente cliente { get; set; }
        public List<CLIente> ConsultarTodos()
        {

            return dbagencia.CLIentes.OrderBy(t => t.Nombre).ToList();

        }
        public CLIente Consultar(int id)
        {
            return dbagencia.CLIentes.FirstOrDefault(t => t.Id == id);
        }
        public String Insertar()
        {
            try
            {
                dbagencia.CLIentes.Add(cliente);//agrega un cliente a la lista de ef
                dbagencia.SaveChanges();//guarda los cambios a la base de datos
                return "cliente insertado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al insertar el cliente " + ex.Message;
            }
        }

        public String Actualizar()
        {
            try
            {
                CLIente cli = Consultar(cliente.Id);
                if (cli == null)
                {
                    return "El cliente no existe";
                }
                dbagencia.CLIentes.AddOrUpdate(cliente);
                dbagencia.SaveChanges();//guarda los cambios a la base de datos
                return "Cliente actualizado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el cliente " + ex.Message;
            }
        }

     

        public String Eliminar(int id)
        {
            try
            {
                CLIente cli = Consultar(id);
                if (cli == null)
                {
                    return "El cliente no existe";
                }
                dbagencia.CLIentes.Remove(cli);
                dbagencia.SaveChanges();//guarda los cambios a la base de datos
                return "Cliente eliminado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el cliente " + ex.Message;
            }
        }
    }
}