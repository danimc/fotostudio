
using System;
using MySql.Data.MySqlClient;

namespace FotoStudio
{
	public class sql : MySQL
	{
		public sql ()
		{
		}

		public void mostrarTodos(){
			
			this.abrirConexion();
            MySqlCommand myCommand = new MySqlCommand(this.querySelect(), 
			                                          myConnection);
            MySqlDataReader myReader = myCommand.ExecuteReader();	
	        while (myReader.Read()){
	            string nombre = myReader["nombre"].ToString();
	            string apellido = myReader["apellido"].ToString();
	            string domicilio = myReader["domicilio"].ToString();
	                }

            myReader.Close();
			myReader = null;
            myCommand.Dispose();
			myCommand = null;
			this.cerrarConexion();
		}

		public void insertarRegistroNuevo(string nombrete, string apellidote, string domiciliote){
			this.abrirConexion();
			string sql = "INSERT INTO `clientes` (`nombre`, `apellido`, `domicilio`) VALUES ('" + nombrete + "', '" + apellidote + "','" + domiciliote + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}

		public void editarCodigoRegistro(string id, string codigo){
			this.abrirConexion();
			string sql = "UPDATE `usuario` SET `codigo`='" + codigo + "' WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}

		public void editarNombreRegistro(string id, string nombre){
			this.abrirConexion();
			string sql = "UPDATE `usuario` SET `nombre`='" + nombre + "' WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}

		public void eliminarRegistroPorId(string id){
			this.abrirConexion();
			string sql = "DELETE FROM `usuario` WHERE (`id`='" + id + "')";
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

		private string querySelect(){
			return "SELECT * " +
	           	"FROM usuario";
		}
	}
}