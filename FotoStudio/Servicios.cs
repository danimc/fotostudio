/*
 * Creado por SharpDevelop.
 * Usuario: Soporte
 * Fecha: 07/05/2014
 * Hora: 05:27 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace FotoStudio
{
	/// <summary>
	/// Description of Servicios.
	/// </summary>
	public partial class Servicios : Form
	{
		public Servicios()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
			MySqlConnection con;
			MySqlCommand comando;
			MySqlDataReader read;
		
		void RegresarClick(object sender, EventArgs e)
		{
			this.Hide();
		}
		
		void ServiciosLoad(object sender, EventArgs e)
		{
			
			
						
			con = new MySqlConnection("Server=localhost; Database=fotostudio; User ID=root; Password=123");
			con.Open();
			comando = new MySqlCommand("SELECT nombre FROM servicios", con);
			read = comando.ExecuteReader();
			
			while (read.Read()){
				this.verservicos.Rows.Add(read.GetValue(0));			
		}								
		}
		
		void VerservicosCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		string seleccion = verservicos.CurrentRow.Cells[0].Value.ToString();
		con = new MySqlConnection("Server=localhost; Database=fotostudio; User ID=root; Password=123");
			con.Open();
			comando = new MySqlCommand("SELECT descripcion FROM servicios WHERE nombre = '"+seleccion+"' ", con);
			read = comando.ExecuteReader();
			
			if(read.Read()){
				desc.Text = Convert.ToString(read["descripcion"]);
			}
		
		
		label3.Text=seleccion;
		}
	}
}
