/* Creado por L. Mora */

using System;
using System.Drawing;
using System.Windows.Forms;


using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace FotoStudio
{
	public partial class Clientes : Form 
	{
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

		
	
		void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
		}
		
		void BtnclientenuevoClick(object sender, EventArgs e)
		{
			agregarclientes agregar = new agregarclientes();
			agregar.Show();
			this.Hide();
		}
			
		}
	}
