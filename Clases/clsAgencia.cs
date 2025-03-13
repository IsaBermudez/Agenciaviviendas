using Examen_AgenciaViviendas.Models;
using System.Data.Entity.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen_AgenciaViviendas.Clases
{
	public class clsAgencia
	{
        private DBAgencia_viviendasEntities dbagencia = new DBAgencia_viviendasEntities();//objeto para gestionar los datos de la agencia 
        public AGEncia agencia{ get; set; }

        public List<AGEncia> ConsultarTodos()
        {
            return dbagencia.AGEncias
                .OrderBy(c => c.Nombre)
                .ToList();
        }

        public AGEncia Consultar(int id)
        {
            return dbagencia.AGEncias.FirstOrDefault(c => c.Id == id);
        }

        public String Insertar()
        {
            try
            {
                dbagencia.AGEncias.Add(agencia);
                dbagencia.SaveChanges();
                return "Se grabo la agencia: " + agencia.Nombre + " en la base de datos ";
            }
            catch (Exception ex)
            {
                return "La agencia no se pudo insertar" + ex.Message;
            }
        }

        public String Actualizar()
        {
            try
            {
                AGEncia agen = Consultar(agencia.Id);
                if (agen == null)
                {
                    return "La agencia no esta definida en la base de datos";
                }
               dbagencia.AGEncias.AddOrUpdate(agencia);
                dbagencia.SaveChanges();
                return "Se actualiazo la agencia: " + agencia.Nombre + " en la base de datos ";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int id)
        {
            try
            {
                AGEncia agen = Consultar(id);
                if (agen == null)
                {
                    return "La agencia no esta definida en la base de datos";
                }
                dbagencia.AGEncias.Remove(agen);
                dbagencia.SaveChanges();
                return "Se elimino la agencia: " + agen.Nombre + " en la base de datos ";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}