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

		public ResponseRegistroEmpresa insertarEmpresa(RegistroEmpresaDTOEntity paramss)
		{
			try
			{
				string cs = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
				var lista = new ResponseRegistroEmpresa();

				using (SqlConnection conn = new SqlConnection(cs))
				{
					conn.Open();
					SqlCommand cmd = new SqlCommand("Usp_insertarEmpresa", conn);
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.Add(new SqlParameter("@razonSocial", paramss.paramsEmpresa.razonSocial));
					cmd.Parameters.Add(new SqlParameter("@ruc", paramss.paramsEmpresa.ruc));
					cmd.Parameters.Add(new SqlParameter("@email", paramss.paramsEmpresa.email));
					cmd.Parameters.Add(new SqlParameter("@idpais", paramss.paramsEmpresa.idPais));
					cmd.Parameters.Add(new SqlParameter("@idmoneda", paramss.paramsEmpresa.idMoneda));
					cmd.Parameters.Add(new SqlParameter("@direccion", paramss.paramsEmpresa.direccion));
					cmd.Parameters.Add(new SqlParameter("@idimpuesto", paramss.paramsEmpresa.idImpuesto));
					cmd.Parameters.Add(new SqlParameter("@idporcentaje", paramss.paramsEmpresa.idPorcentaje));
					cmd.Parameters.Add(new SqlParameter("@vendeimpuesto", paramss.paramsEmpresa.vendeImpuesto));
					cmd.Parameters.Add(new SqlParameter("@filename", paramss.filename));
					cmd.Parameters.Add(new SqlParameter("@proyecto", paramss.proyecto));

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


		public ResponseRegistroEmpresa insertarUserAdminEmpresa(RegistroEmpresaDTOEntity paramss)
		{
			try
			{
				string cs = ConfigurationManager.ConnectionStrings["ConexionAcceso"].ConnectionString;
				var lista = new ResponseRegistroEmpresa();

				using (SqlConnection conn = new SqlConnection(cs))
				{
					conn.Open();
					SqlCommand cmd = new SqlCommand("Usp_insertarUserAdminEmpresa", conn);
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.Add(new SqlParameter("@ruc", paramss.paramsEmpresa.ruc));
					cmd.Parameters.Add(new SqlParameter("@email", paramss.paramsEmpresa.email));
					cmd.Parameters.Add(new SqlParameter("@username", paramss.paramsEmpresa.username));
					cmd.Parameters.Add(new SqlParameter("@usuario", paramss.paramsEmpresa.usuario));
					cmd.Parameters.Add(new SqlParameter("@contrasena", paramss.paramsEmpresa.contrasena));
					cmd.Parameters.Add(new SqlParameter("@cargo", paramss.cargo));
					cmd.Parameters.Add(new SqlParameter("@cantUser", paramss.cantUser));
					cmd.Parameters.Add(new SqlParameter("@proyecto", paramss.proyecto));

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

		public ResponseRegistroEmpresa activarCuenta(string ruc)
		{
			try
			{
				string cs = ConfigurationManager.ConnectionStrings["ConexionAcceso"].ConnectionString;
				var lista = new ResponseRegistroEmpresa();

				using (SqlConnection conn = new SqlConnection(cs))
				{
					conn.Open();
					SqlCommand cmd = new SqlCommand("Usp_activarCuenta", conn);
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.Add(new SqlParameter("@ruc", ruc));

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
