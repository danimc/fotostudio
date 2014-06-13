/* Creado por L. Mora */

using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace FotoStudio
{
	/// <summary>
	/// Description of BandejaSalida.
	/// </summary>
	public partial class BandejaSalida : Form
	{
		  MySqlConnection con;
			MySqlCommand comando;
			MySqlDataReader read;
		public BandejaSalida()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void RegresarClick(object sender, EventArgs e)
		{
			this.Hide();
		}
		
		void BandejaSalidaLoad(object sender, EventArgs e)
		{
			
			con = new MySqlConnection("Server=localhost; Database=fotostudio; User ID=root; Password=123");
			con.Open();
			comando = new MySqlCommand("SELECT * FROM altaservicios WHERE idservicios = (SELECT *FROM servicios) " , con);
			read = comando.ExecuteReader();
			while (read.Read()){
				
				this.dataGridView1.Rows.Add(read.GetValue(0),read.GetValue(1));
									
				}				
			
		}
	}
}
