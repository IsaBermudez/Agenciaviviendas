using Examen_AgenciaViviendas.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Examen_AgenciaViviendas.Clases
{
	public class clsVenta
	{
		private DBAgencia_viviendasEntities dbagencia = new DBAgencia_viviendasEntities();//objeto para gestionar los datos de la agencia 
		public VENta venta { get; set; }

        public List<VENta> ConsultarTodos()
        {
            return dbagencia.VENtas
                .OrderBy(c => c.Codigo)
                .ToList();
        }

        public VENta Consultar(int id)
        {
            return dbagencia.VENtas.FirstOrDefault(c => c.Codigo == id);
        }

        public VENta ConsultarXIdCliente(int id)
        {
            return dbagencia.VENtas.FirstOrDefault(c => c.ClienteId== id);
        }

        public String Insertar()
        {
            try
            {
                dbagencia.VENtas.Add(venta);
                dbagencia.SaveChanges();
                return "Se grabo la venta en la base de datos ";
            }
            catch (Exception ex)
            {
                return "La venta no se pudo insertar" + ex.Message;
            }
        }

        public String Actualizar()
        {
            try
            {
                VENta vent = Consultar(venta.Codigo);
                if (vent == null)
                {
                    return "La venta no esta definido en la base de datos";
                }
                dbagencia.VENtas.AddOrUpdate(venta);
                dbagencia.SaveChanges();
                return "Se actualiazo la venta en la base de datos ";
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
                VENta vent = Consultar(id);
                if (vent == null)
                {
                    return "La venta no esta definida en la base de datos";
                }
                dbagencia.VENtas.Remove(vent);
                dbagencia.SaveChanges();
                return "Se elimino la venta: en la base de datos ";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}