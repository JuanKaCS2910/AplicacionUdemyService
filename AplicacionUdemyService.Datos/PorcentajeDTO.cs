using AplicacionUdemyService.Entity.Parametros;
using AplicacionUdemyService.Entity.Response;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionUdemyService.Datos
{
    public class PorcentajeDTO
	{
        public List<ResponsePorcentaje> listarPorcentaje(RegistroEmpresaEntity paramss)
        {
			try
			{
				string cs = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
				var lista = new List<ResponsePorcentaje>();

				using (SqlConnection conn = new SqlConnection(cs))
				{
					conn.Open();
					SqlCommand cmd = new SqlCommand("Usp_listarPorcImpuesto", conn);
					cmd.CommandType = CommandType.StoredProcedure;

					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						while (dr.Read())
						{
							var _result = new ResponsePorcentaje();
							_result.idPorcentaje = Convert.ToInt32(dr["IdImpuesto"]);
							_result.nombre = Convert.ToInt32(dr["PorcImpuesto"]).ToString();
							lista.Add(_result);
						}
					}
				}
				return lista;
			}
			catch (Exception ex)
			{

				throw ex;
			}

			
		}
    }
}
