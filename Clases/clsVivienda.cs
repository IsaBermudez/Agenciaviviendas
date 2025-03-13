using Examen_AgenciaViviendas.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Examen_AgenciaViviendas.Clases
{
	public class clsVivienda
	{
        private DBAgencia_viviendasEntities dbagencia = new DBAgencia_viviendasEntities();//objeto para gestionar los datos de la agencia 
        public VIVienda vivienda { get; set; }
        public List<VIVienda> ConsultarTodos()
        {

            return dbagencia.VIViendas.OrderBy(t => t.Valor).ToList();

        }
        public VIVienda Consultar(int id)
        {
            return dbagencia.VIViendas.FirstOrDefault(t => t.Id == id);
        }
        public String Insertar()
        {
            try
            {
                dbagencia.VIViendas.Add(vivienda);//agrega un cliente a la lista de ef
                dbagencia.SaveChanges();//guarda los cambios a la base de datos
                return "vivienda insertada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al insertar la vivienda " + ex.Message;
            }
        }

        public String Actualizar()
        {
            try
            {
                VIVienda vivi = Consultar(vivienda.Id);
                if (vivi == null)
                {
                    return "La vivienda no existe";
                }
                dbagencia.VIViendas.AddOrUpdate(vivienda);
                dbagencia.SaveChanges();//guarda los cambios a la base de datos
                return "La vivienda se actualizo correctamente";
            }
            catch (Exception ex)
            {
                return "Error al actualizar la vivienda " + ex.Message;
            }
        }



        public String Eliminar(int id)
        {
            try
            {
                VIVienda vivi = Consultar(id);
                if (vivi == null)
                {
                    return "La vivienda no existe";
                }
                dbagencia.VIViendas.Remove(vivi);
                dbagencia.SaveChanges();//guarda los cambios a la base de datos
                return "Vivienda eliminada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al eliminar la vivienda " + ex.Message;
            }
        }
    }
}