/* Creado por L. Mora */

using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;


namespace FotoStudio
{
	public partial class Clientes : Form 
		{
	MySqlConnection con;
			MySqlCommand comando;
			MySqlDataReader read;
		public Clientes()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

					
		
		
		
		
		void ClientesLoad(object sender, EventArgs e)
		{
			MySqlConnection con;
			MySqlCommand comando;
			MySqlDataReader read;
			
			
			con = new MySqlConnection("Server=localhost; Database=fotostudio; User ID=root; Password=123");
			con.Open();
			comando = new MySqlCommand("SELECT * FROM clientes", con);
			read = comando.ExecuteReader();
			
			while (read.Read()){
				this.vercliente.Rows.Add(read.GetValue(0),read.GetValue(5),read.GetValue(1),read.GetValue(2),read.GetValue(6),read.GetValue(7),read.GetValue(3),read.GetValue(8),read.GetValue(9),read.GetValue(4));
			}
			

			
		}
		
			void VerclienteCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		string seleccion = vercliente.CurrentRow.Cells[0].Value.ToString();
		con = new MySqlConnection("Server=localhost; Database=fotostudio; User ID=root; Password=123");
			con.Open();
			comando = new MySqlCommand("SELECT * FROM clientes WHERE id = "+seleccion+" ", con);
			read = comando.ExecuteReader();
			
			while(read.Read()){
				idc.Text = Convert.ToString(read["id"]);
				nombrec.Text = Convert.ToString(read["nombre"]);
				apellidoc.Text = Convert.ToString(read["apellido"]);
				domicilioc.Text = Convert.ToString(read["domicilio"]);
				coloniac.Text = Convert.ToString(read["colonia"]);
			}
		
		
		label3.Text=seleccion;
		
	}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			agregarclientes agregar = new agregarclientes();
			agregar.Show();
			this.Hide();			
		}
		
		void PictureBox1MouseUp(object sender, MouseEventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			
			string nom =	nombrec.Text; 
			string ape	=	 apellidoc.Text;
			string dom =	domicilioc.Text;
			string col =	coloniac.Text;
			string id = idc.Text;
			con = new MySqlConnection("Server=localhost; Database=fotostudio; User ID=root; Password=123");
			con.Open();
			comando = new MySqlCommand("UPDATE clientes SET nombre='"+nom+"', apellido ='"+ape+"',domicilio= '"+dom+"',colonia = '"+col+"' where (id = "+id+") ", con);
			read = comando.ExecuteReader();
			
			if(read.Read()){
			
				label1.Text = "done";
			}									
			
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			MySqlConnection con;
			MySqlCommand comando;
			MySqlDataReader read;
			
			vercliente.Update();
			string id = idc.Text;
			con = new MySqlConnection("Server=localhost; Database=fotostudio; User ID=root; Password=123");
			con.Open();
			comando = new MySqlCommand("DELETE FROM clientes where id = '"+id+"' ", con);
			read = comando.ExecuteReader();
			vercliente.Update();
			
		//	while (read.Read()){
		//	this.vercliente.Rows.Add(read.GetValue(0),read.GetValue(1),read.GetValue(2),read.GetValue(3),read.GetValue(4));
								
			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			MySqlConnection con;
			MySqlCommand comando;
			MySqlDataReader read;
			
			vercliente.Rows.Clear();
			
			con = new MySqlConnection("Server=localhost; Database=fotostudio; User ID=root; Password=123");
			con.Open();
			comando = new MySqlCommand("SELECT * FROM clientes", con);
			read = comando.ExecuteReader();
			
			while (read.Read()){
				this.vercliente.Rows.Add(read.GetValue(0),read.GetValue(1),read.GetValue(2),read.GetValue(3),read.GetValue(4));
		}						
		}
		
		void PictureBox2Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void PictureBox3Click(object sender, EventArgs e)
		{
			MySqlConnection con;
			MySqlCommand comando;
			MySqlDataReader read;
			
			string ids = idc.Text;
			string nombres = nombrec.Text;
			string apellidos = apellidoc.Text;
			string direcciones = domicilioc.Text;
			string colonias = coloniac.Text;
			
			vercliente.Rows.Clear();
			
			con = new MySqlConnection("Server=localhost; Database=fotostudio; User ID=root; Password=123");
			con.Open();
			comando = new MySqlCommand("SELECT * FROM clientes WHERE id  ='"+ ids+"' OR nombre ='" + nombres + "' OR apellido = '"+apellidos +"' OR domicilio = '"+ direcciones + "' OR colonia = '"+ colonias+"' ", con);
			read = comando.ExecuteReader();
			while (read.Read()){
				this.vercliente.Rows.Add(read.GetValue(0),read.GetValue(5),read.GetValue(1),read.GetValue(2),read.GetValue(6),read.GetValue(7),read.GetValue(3),read.GetValue(8),read.GetValue(9),read.GetValue(4));
		}			
		
			
		}
		
	
		}
}