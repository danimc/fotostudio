/* Creado por L. Mora */

using System;
using System.Drawing;
using System.Windows.Forms;

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
			string usuario, contraseña;
			usuario = user.Text;
			contraseña = password.Text;
			
			
			if(usuario == "administrador" && contraseña == "123"){
				MainForm menu = new MainForm();
				menu.Show();
				this.Hide();
				
			}else{
				MessageBox.Show("Usuario o contraseña incorrectas");
			}
		}
	}
}
