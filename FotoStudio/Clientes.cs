﻿/* Creado por L. Mora */

using System;
using System.Data;
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

					
		
		
		
		
		void ClientesLoad(object sender, EventArgs e)
		{
			MySqlConnection con;
			MySqlCommand comando;
			MySqlDataReader read;
			
			
			con = new MySqlConnection("Server=localhost; Database=fotostudio; User ID=root; Password=123");
			con.Open();
			comando = new MySqlCommand("SELECT * FROM clientes", con);
			read = comando.ExecuteReader();
			
			while (read.Read()){
				this.vercliente.Rows.Add(read.GetValue(0),read.GetValue(1),read.GetValue(2),read.GetValue(3),read.GetValue(4));
			}
			

			
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			agregarclientes agregar = new agregarclientes();
			agregar.Show();
			this.Hide();			
		}
		
		void PictureBox1MouseUp(object sender, MouseEventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			this.Hide();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			MySqlConnection con;
			MySqlCommand comando;
			MySqlDataReader read;
			
			string ids = idc.Text;
			string nombres = nombrec.Text;
			string apellidos = apellidoc.Text;
			string direcciones = domicilioc.Text;
			string colonias = coloniac.Text;
			
			vercliente.Rows.Clear();
			
			con = new MySqlConnection("Server=localhost; Database=fotostudio; User ID=root; Password=123");
			con.Open();
			comando = new MySqlCommand("SELECT * FROM clientes WHERE id ='"+ ids+"' OR nombre ='" + nombres + "' OR apellido = '"+apellidos +"' OR domicilio = '"+ direcciones + "' OR colonia = '"+ colonias+"' ", con);
			read = comando.ExecuteReader();
			while (read.Read()){
				this.vercliente.Rows.Add(read.GetValue(0),read.GetValue(1),read.GetValue(2),read.GetValue(3),read.GetValue(4));
		}			
		
			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			MySqlConnection con;
			MySqlCommand comando;
			MySqlDataReader read;
			
			vercliente.Rows.Clear();
			
			con = new MySqlConnection("Server=localhost; Database=fotostudio; User ID=root; Password=123");
			con.Open();
			comando = new MySqlCommand("SELECT * FROM clientes", con);
			read = comando.ExecuteReader();
			
			while (read.Read()){
				this.vercliente.Rows.Add(read.GetValue(0),read.GetValue(1),read.GetValue(2),read.GetValue(3),read.GetValue(4));
		}						
		}
		}
}