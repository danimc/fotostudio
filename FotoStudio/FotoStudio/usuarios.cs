/* Creado por L. Mora */

using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace FotoStudio
{
	/// <summary>
	/// Description of usuarios.
	/// </summary>
	public partial class usuarios : Form
	{
		public usuarios()
		{
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			altausuarios alta = new altausuarios();
			alta.Show();
			this.Hide();
		}
		
		void UsuariosLoad(object sender, EventArgs e)
		{
			MySqlConnection con;
			MySqlCommand comando;
			MySqlDataReader read;
			
			
			con = new MySqlConnection("Server=localhost; Database=fotostudio; User ID=root; Password=123");
			con.Open();
			comando = new MySqlCommand("SELECT * FROM usuarios", con);
			read = comando.ExecuteReader();
			
			while (read.Read()){
				this.veruser.Rows.Add(read.GetValue(0),read.GetValue(1),read.GetValue(2),read.GetValue(3));			
		}
	}
		
		
		
		void Button2Click(object sender, EventArgs e)
		{
		    MySqlConnection con;
			MySqlCommand comando;
			MySqlDataReader read;
			
			string ids = this.idsearch.Text;
			string users = this.usersearch.Text;
			string rols = this.rolsearch.Text;
			
			veruser.Rows.Clear();
			
			con = new MySqlConnection("Server=localhost; Database=fotostudio; User ID=root; Password=123");
			con.Open();
			comando = new MySqlCommand("SELECT * FROM usuarios WHERE id ='"+ ids+"' OR nombre ='" + users+ "' OR rol = '"+rols +"' ", con);
			read = comando.ExecuteReader();
			while (read.Read()){
				this.veruser.Rows.Add(read.GetValue(0),read.GetValue(1),read.GetValue(2),read.GetValue(3));
		}
}
		
		void Button3Click(object sender, EventArgs e)
		{
			MySqlConnection con;
			MySqlCommand comando;
			MySqlDataReader read;
			
			veruser.Rows.Clear();
			
			con = new MySqlConnection("Server=localhost; Database=fotostudio; User ID=root; Password=123");
			con.Open();
			comando = new MySqlCommand("SELECT * FROM usuarios", con);
			read = comando.ExecuteReader();
			
			while (read.Read()){
				this.veruser.Rows.Add(read.GetValue(0),read.GetValue(1),read.GetValue(2),read.GetValue(3));			
		}					
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			string seleccion = veruser.CurrentRow.Cells[0].Value.ToString();
			string name =veruser.CurrentRow.Cells[1].Value.ToString();
			DialogResult resultado = MessageBox.Show("¿Modificar datos de: " +name+ "","",MessageBoxButtons.OKCancel);
			if (resultado == DialogResult.OK)
			{
				sqlu dat = new sqlu();
				dat.data(seleccion);
				
			}
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			altausuarios alta = new altausuarios();
			alta.Show();
			this.Hide();			
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
			
			string ids = this.idsearch.Text;
			string users = this.usersearch.Text;
			string rols = this.rolsearch.Text;
			
			veruser.Rows.Clear();
			
			con = new MySqlConnection("Server=localhost; Database=fotostudio; User ID=root; Password=123");
			con.Open();
			comando = new MySqlCommand("SELECT * FROM usuarios WHERE id ='"+ ids+"' OR nombre ='" + users+ "' OR rol = '"+rols +"' ", con);
			read = comando.ExecuteReader();
			while (read.Read()){
				this.veruser.Rows.Add(read.GetValue(0),read.GetValue(1),read.GetValue(2),read.GetValue(3));
		}			
		}
		
		void PictureBox4Click(object sender, EventArgs e)
		{
			MySqlConnection con;
			MySqlCommand comando;
			MySqlDataReader read;
			
			veruser.Rows.Clear();
			
			con = new MySqlConnection("Server=localhost; Database=fotostudio; User ID=root; Password=123");
			con.Open();
			comando = new MySqlCommand("SELECT * FROM usuarios", con);
			read = comando.ExecuteReader();
			
			while (read.Read()){
				this.veruser.Rows.Add(read.GetValue(0),read.GetValue(1),read.GetValue(2),read.GetValue(3));			
		}				
		}
	}}