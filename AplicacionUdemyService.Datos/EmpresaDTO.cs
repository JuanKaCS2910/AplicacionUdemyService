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
    public class EmpresaDTO
    {
		public ResponseRegistroEmpresa validarRegistro(RegistroEmpresaEntity paramss)
		{
			try
			{
				string cs = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
				var lista = new ResponseRegistroEmpresa();

				using (SqlConnection conn = new SqlConnection(cs))
				{
					conn.Open();
					SqlCommand cmd = new SqlCommand("Usp_validarRegistroEmpresa", conn);
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.Add(new SqlParameter("@razonSocial", paramss.razonSocial));
					cmd.Parameters.Add(new SqlParameter("@ruc", paramss.ruc));
					cmd.Parameters.Add(new SqlParameter("@email", paramss.email));
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						while (dr.Read())
						{
							lista.response = Convert.ToString(dr["response"]).ToString();
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
