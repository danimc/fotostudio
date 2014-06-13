/*
 * Creado por SharpDevelop.
 * Usuario: Soporte
 * Fecha: 05/05/2014
 * Hora: 05:03 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FotoStudio
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
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
		
		void OpenFileDialog1FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			System.Environment.Exit(1);
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			BandejaSalida ban = new BandejaSalida();
			ban.Show();
		}
		
		void ToolTip1Popup(object sender, PopupEventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Servicios serv = new Servicios();
			serv.Show();
			
		}
		
		void MenuStrip1ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Clientes cl = new Clientes();
			cl.Show();
		}
		
		void BtnconfiguracionClick(object sender, EventArgs e)
		{
			Configuracion con = new Configuracion();
			con.Show();
		}
	}
}
