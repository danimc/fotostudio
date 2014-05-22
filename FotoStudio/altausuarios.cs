/* Creado por L. Mora */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace FotoStudio
{
	/// <summary>
	/// Description of altausuarios.
	/// </summary>
	public partial class altausuarios : Form
	{
		public altausuarios()
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
		
		}
		
		void Button2Click(object sender, EventArgs e)
		{
		
			
		}
		
		void AltausuariosLoad(object sender, EventArgs e)
		{
			
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			usuarios user = new usuarios();
			user.Show();
			this.Close();			
		}
		
		void PictureBox2Click(object sender, EventArgs e)
		{
				string roll = this.comboBox1.Text;
			string usuario = this.textBox1.Text;
			string contraseña1 = this.textBox2.Text;
			string contraseña2 = this.textBox3.Text;
			if (contraseña1 != contraseña2){
				MessageBox.Show("Las contraseñas no coinciden \n Intente de nuevo");
				return;
			}
			DialogResult resultado = MessageBox.Show("Seguro que deseas agregar: \n Usuario:" +usuario+"\n Rol: "+roll+" \n \t ¿Agregar?","",MessageBoxButtons.OKCancel);
			if (resultado == DialogResult.OK){
				sqlu user = new sqlu();
				user.agregarusuario(usuario,roll,contraseña1);
				label6.Text = "Usuario Agregado Satisfactoriamente";
				textBox1.Clear();
				textBox2.Clear();
				textBox3.Clear();
			}			
		}
	}
}
