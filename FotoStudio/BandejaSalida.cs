/* Creado por L. Mora */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace FotoStudio
{
	/// <summary>
	/// Description of BandejaSalida.
	/// </summary>
	public partial class BandejaSalida : Form
	{
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
	}
}
