using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using KaraokeCurso.Logica;
using System.Windows.Forms;
namespace KaraokeCurso.Datos
{
    public class Dcanciones
    {
        public bool insertar_Canciones(Lcanciones parametros)
        {
			try
			{
				CONEXIONMAESTRA.abrir();
				SqlCommand cmd = new SqlCommand("insertar_Canciones", CONEXIONMAESTRA.conectar);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@Nombre", parametros.Nombre);
				cmd.ExecuteNonQuery();
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.StackTrace);
				return false;
			}
			finally
			{
				CONEXIONMAESTRA.cerrar();
			}
        }
		public bool eliminar_Canciones(Lcanciones parametros)
		{
			try
			{
				CONEXIONMAESTRA.abrir();
				SqlCommand cmd = new SqlCommand("eliminar_Canciones", CONEXIONMAESTRA.conectar);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@IdCancion", parametros.IdCancion);
				cmd.ExecuteNonQuery();
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.StackTrace);
				return false;
			}
			finally
			{
				CONEXIONMAESTRA.cerrar();
			}
		}
		public void buscarCanciones(ref DataTable dt,string buscador)
		{
			try
			{
				CONEXIONMAESTRA.abrir();
				SqlDataAdapter da = new SqlDataAdapter("buscarCanciones", CONEXIONMAESTRA.conectar);
				da.SelectCommand.CommandType = CommandType.StoredProcedure;
				da.SelectCommand.Parameters.AddWithValue("@letra", buscador);
				da.Fill(dt);
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.StackTrace);

			}
			finally
			{
				CONEXIONMAESTRA.cerrar();
			}
		}
		public void MostrarCanciones(ref DataTable dt)
		{
			try
			{
				CONEXIONMAESTRA.abrir();
				SqlDataAdapter da = new SqlDataAdapter("select top 50 * from Canciones where Nombre <>'!Happy Birthday!'", CONEXIONMAESTRA.conectar);
				da.Fill(dt);
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);

			}
			finally
			{
				CONEXIONMAESTRA.cerrar();
			}
		}
		public void TotalCanciones(ref int Total)
		{
			try
			{
				CONEXIONMAESTRA.abrir();
				SqlCommand cmd = new SqlCommand("select count(IdCancion) from Canciones", CONEXIONMAESTRA.conectar);
				Total = Convert.ToInt32(cmd.ExecuteScalar());
			}
			catch (Exception)
			{
				Total = 0;
				
			}
			finally
			{
				CONEXIONMAESTRA.cerrar();
			}
		}

		public bool EliminarTodasCanciones()
		{
			try
			{
				CONEXIONMAESTRA.abrir();
				SqlCommand cmd = new SqlCommand("delete from Canciones", CONEXIONMAESTRA.conectar);		
				cmd.ExecuteNonQuery();
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.StackTrace);
				return false;
			}
			finally
			{
				CONEXIONMAESTRA.cerrar();
			}
		}
	}
}
