
using System;
using MySql.Data.MySqlClient;

namespace FotoStudio
{
	public class sqlu : MySQL
	{
		public sqlu ()
		{
		}
		
		
		public void agregarusuario(string usuario, string roll, string contraseña1){
			this.abrirConexion();
			string sql = "INSERT INTO `usuarios` (`nombre`, `rol`, `contrasena`) VALUES ('" + usuario + "', '" + roll + "','" + contraseña1 + "')";
				this.ejecutarComando(sql);
				this.cerrarConexion();	
		}
		
		
		
		private int ejecutarComando(string sql){
			MySqlCommand myCommand = new MySqlCommand(sql,this.myConnection);
			int afectadas = myCommand.ExecuteNonQuery();
			myCommand.Dispose();
			myCommand = null;
			return afectadas;
		}
	}
}
			