/* Creado por L. Mora */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace FotoStudio
{
	/// <summary>
	/// Description of agregarclientes.
	/// </summary>
	public partial class agregarclientes : Form
	{
		public agregarclientes()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void TextBox3TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string nombrete = this.textBox1.Text;
			string apellidote = this.textBox2.Text;
			string domiciliote = this.textBox3.Text;
			
			sql po = new sql();
			po.insertarRegistroNuevo(nombrete,apellidote,domiciliote);			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Clientes ventana = new Clientes();
			ventana.Show();
			this.Close();
		}
	}
}
