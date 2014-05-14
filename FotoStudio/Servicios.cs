/*
 * Creado por SharpDevelop.
 * Usuario: Soporte
 * Fecha: 07/05/2014
 * Hora: 05:27 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FotoStudio
{
	/// <summary>
	/// Description of Servicios.
	/// </summary>
	public partial class Servicios : Form
	{
		public Servicios()
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
	}
}
