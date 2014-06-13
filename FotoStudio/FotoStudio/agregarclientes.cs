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
			string nombrete = this.textName.Text;
			if (nombrete == ""){
				errorNom.Text= "Capture Nombre";
				return;
			}
			errorNom.Hide();
			string apellidote = this.textApe.Text;
			if (apellidote == ""){
				errApe.Text= "Capture Apellido";
				return;}
			errApe.Hide();
			string domiciliote = this.textDom.Text;
			if (domiciliote == ""){
				errorDom.Text = "Capture Domicilio";
				return;
			}
			errorDom.Hide();
			string colon = this.textCol.Text;
			if (colon == ""){
				errorCol.Text="Capture Colonia";			
				return;
			}
			errorCol.Hide();
			string numerote = this.textNum.Text;
			if (numerote == ""){
				ErrorNum.Text = "Capture el numero del domicilio";
				return;
			}
			ErrorNum.Hide();
			// validacion de los campos opcionales
			
			string ninter = this.textInt.Text;
			if (ninter == "")
				ninter = "null";
			string telefonote = this.textTel.Text;
			if (telefonote == "")
				telefonote = "00000000";
			string celular = this.textCel.Text;
			if (celular == "")
				celular = "0000000000";
			string rfc = this.textRFC.Text;
			if (rfc == "")
				rfc = "XAXX010101000";
			
			DialogResult resultado = MessageBox.Show("Seguro que deseas agregar: \n Nombre: " +nombrete+ "\n Apellido: "+apellidote+"\n Domicilio: "+domiciliote+ "\n Colonia: "+colon+"\n ¿Agregar?","Confirmacion",MessageBoxButtons.OKCancel);
			if (resultado == DialogResult.OK){
				sql po = new sql();
			po.insertarRegistroNuevo(rfc,nombrete,apellidote,domiciliote,numerote,ninter,colon,telefonote,celular);
				label6.Text = "Cliente " +nombrete +" Agregado Satisfactoriamente";
				textName.Clear();
				textApe.Clear();
				textDom.Clear();
				textNum.Clear(); 
				textCol.Clear();
				textTel.Clear();
				textCel.Clear();
				textInt.Clear();
				textRFC.Clear();
			}
							
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Clientes ventana = new Clientes();
			ventana.Show();
			this.Close();
		}
		
		
	
	}
}
