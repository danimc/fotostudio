/* Creado por L. Mora */

using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FotoStudio
{
	/// <summary>
	/// Description of Login.
	/// </summary>
	public partial class Login : Form
	{
		public Login()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			MySqlConnection con;
			MySqlCommand comando;
			MySqlDataReader read;
			
			string usuario, contrasena;
			usuario = user.Text;
			contrasena = password.Text;
			
			con = new MySqlConnection("Server=localhost; Database=fotostudio; User ID=root; Password=123");
			con.Open();
			comando = new MySqlCommand("SELECT * FROM usuarios WHERE (nombre ='" + usuario + "' AND contrasena='" + contrasena +"')", con);
			read = comando.ExecuteReader();
			
			if (read.Read()){
				string rol = Convert.ToString(read["rol"]);
				if (rol == "Administrador"){
					MainForm men = new MainForm();
					men.Show();
					this.Hide();
				}
				else{
					menudesing men = new menudesing();
					men.Show();
					this.Hide();
				}
			}
			else {
				MessageBox.Show("Usuario o Contraseña Erronea");
			}
			
			
		}
	}
}
