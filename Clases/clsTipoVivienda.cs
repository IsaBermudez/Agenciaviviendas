using Examen_AgenciaViviendas.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Examen_AgenciaViviendas.Clases
{
	public class clsTipoVivienda
	{
        private DBAgencia_viviendasEntities dbagencia = new DBAgencia_viviendasEntities();//objeto para gestionar los datos de la agencia 
        public TIPoVivienda tipovivienda { get; set; }
        public List<TIPoVivienda> ConsultarTodos()
        {

            return dbagencia.TIPoViviendas.OrderBy(t => t.Nombre).ToList();

        }
        public TIPoVivienda Consultar(int id)
        {
            return dbagencia.TIPoViviendas.FirstOrDefault(t => t.Codigo == id);
        }
        public String Insertar()
        {
            try
            {
                dbagencia.TIPoViviendas.Add(tipovivienda);//agrega un cliente a la lista de ef
                dbagencia.SaveChanges();//guarda los cambios a la base de datos
                return "Tipo de vivienda insertado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al insertar el tipo de vivienda " + ex.Message;
            }
        }

        public String Actualizar()
        {
            try
            {
                TIPoVivienda tipvivienda = Consultar(tipovivienda.Codigo);
                if (tipvivienda == null)
                {
                    return "El tipo de vivienda no existe";
                }
                dbagencia.TIPoViviendas.AddOrUpdate(tipovivienda);
                dbagencia.SaveChanges();//guarda los cambios a la base de datos
                return "Tipo de vivienda actualizado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el tipo de vivienda " + ex.Message;
            }
        }



        public String Eliminar(int id)
        {
            try
            {
                TIPoVivienda tipvivienda = Consultar(id);
                if (tipvivienda == null)
                {
                    return "El tipo de vivienda no existe";
                }
                dbagencia.TIPoViviendas.Remove(tipvivienda);
                dbagencia.SaveChanges();//guarda los cambios a la base de datos
                return "Tipo de vivienda eliminado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el tipo de vivienda " + ex.Message;
            }
        }
    }
}