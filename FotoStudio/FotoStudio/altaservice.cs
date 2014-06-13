/*
 * Creado por SharpDevelop.
 * Usuario: Soporte
 * Fecha: 26/05/2014
 * Hora: 04:37 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace FotoStudio
{
	/// <summary>
	/// Description of altaservice.
	/// </summary>
	public partial class altaservice : Form
	{
		  MySqlConnection con;
			MySqlCommand comando;
			MySqlDataReader read;
			
			public int id=0;
		public altaservice()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void AltaserviceLoad(object sender, EventArgs e)
		{
			 		  
			if(id==0){ //funcion que muestra todos los servicios si es que no se selecciono alguno en el menu
				
			con = new MySqlConnection("Server=localhost; Database=fotostudio; User ID=root; Password=123");
			con.Open();
			comando = new MySqlCommand("SELECT * FROM servicios", con);
			read = comando.ExecuteReader();
			while (read.Read()){
				comboBox1.Items.Add(read["nombre"]);
									
				}	
			}
			else{
				
			con = new MySqlConnection("Server=localhost; Database=fotostudio; User ID=root; Password=123");
			con.Open();
			comando = new MySqlCommand("SELECT * FROM servicios WHERE id= '"+id+"' ", con);
			read = comando.ExecuteReader();
			while (read.Read()){
				comboBox1.Items.Add(read["nombre"].ToString());
				prec.Text = "$"+Convert.ToString(read["Precio"]);
				iva.Text ="16%";
				double tota = (Convert.ToDouble(read["precio"])) * 1.16;
				total.Text = "$"+tota;
									
				}	
			comboBox1.SelectedIndex = 0;
			}
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			string seleccion = Convert.ToString(comboBox1.SelectedValue);
			con = new MySqlConnection("Server=localhost; Database=fotostudio; User ID=root; Password=123");
			con.Open();
			comando = new MySqlCommand("SELECT * FROM servicios WHERE nombre = '"+seleccion+"' ", con);
			read = comando.ExecuteReader();
			
			if(read.Read()){
				//prec.Text = "$" + Convert.ToString(read["precio"]);
									
			}	
			label6.Text= seleccion;
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
						
			string ids = id_cliente.Text;
			string nombres = nombre_cliente.Text;
			string apellidos = apellido_cliente.Text;
		
			con = new MySqlConnection("Server=localhost; Database=fotostudio; User ID=root; Password=123");
			con.Open();
			comando = new MySqlCommand("SELECT * FROM clientes WHERE id ='"+ ids+"' OR nombre ='" + nombres + "' OR apellido = '"+apellidos +"' ", con);
			read = comando.ExecuteReader();
			while (read.Read())		{
			
				id_cliente.Clear();
				nombre_cliente.Clear();
				apellido_cliente.Clear();
				
				id_cliente.Text = Convert.ToString(read["id"]);
				nombre_cliente.Text = Convert.ToString(read["nombre"]);
				apellido_cliente.Text = Convert.ToString(read["apellido"]);
				domicilio_cliente.Text = Convert.ToString(read["domicilio"])+ " #" + Convert.ToString(read["numero"]) + ". Col. " + Convert.ToString(read["colonia"]);
				string telefono = Convert.ToString(read["telefono"]);
				string celular = Convert.ToString(read["celular"]);
				if (telefono != "0")
					telefono_cliente.Text = telefono;
				else if(celular != "0")
					telefono_cliente.Text = celular;
				else
					telefono_cliente.Text = "Sin registrar";
			}
		}
		
		void PictureBox3Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void PictureBox2Click(object sender, EventArgs e)
		{
		string servicio = this.comboBox1.Text;
		string precio = this.prec.Text;
		string idc = this.id_cliente.Text;
		string fecha = this.monthCalendar1.SelectionStart.Date.ToShortDateString();
			
		DialogResult resultado = MessageBox.Show("Seguro que deseas apartar el servicio:" +servicio+ "?","Confirmacion",MessageBoxButtons.OKCancel);
		if (resultado == DialogResult.OK)	{
			con = new MySqlConnection("Server=localhost; Database=fotostudio; User ID=root; Password=123");
			con.Open();
			comando = new MySqlCommand("INSERT INTO altaservicios (idservicio,idcliente,fecha) VALUES ( "+id+","+idc+",'"+fecha+"')", con);
			read = comando.ExecuteReader();
			MessageBox.Show("Gracias por su preferencia");
			this.Close();
			}
		}
	}
}
