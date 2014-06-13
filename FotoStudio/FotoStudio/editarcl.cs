/* Creado por L. Mora */

using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace FotoStudio
{
	/// <summary>
	/// Description of editarcl.
	/// </summary>
	public partial class editarcl : Form
	{
		
		
			MySqlConnection con;
			MySqlCommand comando;
			MySqlDataReader read;
		
			public int id=0;
		
		public editarcl()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void EditarclLoad(object sender, EventArgs e)
		{
			con = new MySqlConnection("Server=localhost; Database=fotostudio; User ID=root; Password=123");
			con.Open();
			comando = new MySqlCommand("SELECT * FROM clientes WHERE id= '"+id+"' ", con);
			read = comando.ExecuteReader();
			if (read.Read()){
				textRFC.Text = Convert.ToString(read["RFC"]);
				textName.Text = Convert.ToString(read["nombre"]);
				textApe.Text = Convert.ToString(read["apellido"]);
				textDom.Text = Convert.ToString(read["domicilio"]);	
				textNum.Text = Convert.ToString(read["numero"]);				
				textInt.Text = Convert.ToString(read["interior"]);
				textCol.Text = Convert.ToString(read["colonia"]);
				textTel.Text = Convert.ToString(read["telefono"]);
				textCel.Text = Convert.ToString(read["celular"]);
			}
			else{
				textRFC.Text = "valemadre";
			}
	}
}
}