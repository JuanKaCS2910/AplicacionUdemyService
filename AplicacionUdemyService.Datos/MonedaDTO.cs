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
    public class MonedaDTO
	{
        public List<ResponseMoneda> listarMonedas(RegistroEmpresaEntity paramss)
        {
			try
			{
				string cs = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
				var lista = new List<ResponseMoneda>();

				using (SqlConnection conn = new SqlConnection(cs))
				{
					conn.Open();
					SqlCommand cmd = new SqlCommand("Usp_listarMonedas",conn);
					cmd.CommandType = CommandType.StoredProcedure;

					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						while (dr.Read())
						{
							var _result = new ResponseMoneda();
							_result.idMoneda = Convert.ToInt32(dr["IdMoneda"]);
							_result.nombre = Convert.ToString(dr["NombreMoneda"]);
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
