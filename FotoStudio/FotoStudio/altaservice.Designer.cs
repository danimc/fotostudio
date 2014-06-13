/*
 * Creado por SharpDevelop.
 * Usuario: Soporte
 * Fecha: 26/05/2014
 * Hora: 04:37 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace FotoStudio
{
	partial class altaservice
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(altaservice));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.prec = new System.Windows.Forms.TextBox();
			this.iva = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.total = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.id_cliente = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.nombre_cliente = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.apellido_cliente = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.domicilio_cliente = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.telefono_cliente = new System.Windows.Forms.TextBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(205, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Alta de Servicios";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Servicio:";
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(68, 65);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(185, 23);
			this.comboBox1.TabIndex = 2;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(319, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Precio:";
			// 
			// prec
			// 
			this.prec.Enabled = false;
			this.prec.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.prec.Location = new System.Drawing.Point(362, 61);
			this.prec.Name = "prec";
			this.prec.Size = new System.Drawing.Size(126, 21);
			this.prec.TabIndex = 4;
			// 
			// iva
			// 
			this.iva.Enabled = false;
			this.iva.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.iva.Location = new System.Drawing.Point(362, 88);
			this.iva.Name = "iva";
			this.iva.Size = new System.Drawing.Size(69, 21);
			this.iva.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(319, 91);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 17);
			this.label4.TabIndex = 6;
			this.label4.Text = "I.V.A.";
			// 
			// total
			// 
			this.total.Enabled = false;
			this.total.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.total.Location = new System.Drawing.Point(362, 115);
			this.total.Name = "total";
			this.total.Size = new System.Drawing.Size(126, 21);
			this.total.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(319, 115);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Total:";
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label6.Location = new System.Drawing.Point(96, 138);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(370, 18);
			this.label6.TabIndex = 9;
			this.label6.Text = "_________________________________________________________________________________" +
			"";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(226, 169);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(136, 23);
			this.label7.TabIndex = 10;
			this.label7.Text = "Datos del Cliente:";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(70, 209);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(30, 19);
			this.label8.TabIndex = 11;
			this.label8.Text = "ID:";
			// 
			// id_cliente
			// 
			this.id_cliente.Location = new System.Drawing.Point(90, 205);
			this.id_cliente.Name = "id_cliente";
			this.id_cliente.Size = new System.Drawing.Size(40, 21);
			this.id_cliente.TabIndex = 12;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(146, 208);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(51, 23);
			this.label9.TabIndex = 13;
			this.label9.Text = "Nombre:";
			// 
			// nombre_cliente
			// 
			this.nombre_cliente.Location = new System.Drawing.Point(193, 205);
			this.nombre_cliente.Name = "nombre_cliente";
			this.nombre_cliente.Size = new System.Drawing.Size(112, 21);
			this.nombre_cliente.TabIndex = 14;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(311, 208);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 15;
			this.label10.Text = "Apellido:";
			// 
			// apellido_cliente
			// 
			this.apellido_cliente.Location = new System.Drawing.Point(359, 205);
			this.apellido_cliente.Name = "apellido_cliente";
			this.apellido_cliente.Size = new System.Drawing.Size(135, 21);
			this.apellido_cliente.TabIndex = 16;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(382, 231);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(112, 25);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 17;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// domicilio_cliente
			// 
			this.domicilio_cliente.Enabled = false;
			this.domicilio_cliente.Location = new System.Drawing.Point(136, 275);
			this.domicilio_cliente.Name = "domicilio_cliente";
			this.domicilio_cliente.Size = new System.Drawing.Size(358, 21);
			this.domicilio_cliente.TabIndex = 18;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(70, 278);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(60, 23);
			this.label11.TabIndex = 19;
			this.label11.Text = "Domicilio:";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(70, 316);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(60, 23);
			this.label12.TabIndex = 20;
			this.label12.Text = "Telefono:";
			// 
			// telefono_cliente
			// 
			this.telefono_cliente.Enabled = false;
			this.telefono_cliente.Location = new System.Drawing.Point(146, 314);
			this.telefono_cliente.Name = "telefono_cliente";
			this.telefono_cliente.Size = new System.Drawing.Size(124, 21);
			this.telefono_cliente.TabIndex = 21;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(405, 605);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(144, 32);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox2.TabIndex = 22;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.PictureBox2Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(3, 582);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(127, 32);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 23;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new System.EventHandler(this.PictureBox3Click);
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Location = new System.Drawing.Point(184, 399);
			this.monthCalendar1.MinDate = new System.DateTime(2014, 6, 3, 0, 0, 0, 0);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 24;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(55, 419);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(108, 46);
			this.label13.TabIndex = 25;
			this.label13.Text = "Seleccione la Fecha del Evento";
			// 
			// label14
			// 
			this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label14.Location = new System.Drawing.Point(96, 362);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(370, 18);
			this.label14.TabIndex = 26;
			this.label14.Text = "_________________________________________________________________________________" +
			"";
			// 
			// altaservice
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(561, 636);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.monthCalendar1);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.telefono_cliente);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.domicilio_cliente);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.apellido_cliente);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.nombre_cliente);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.id_cliente);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.total);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.iva);
			this.Controls.Add(this.prec);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "altaservice";
			this.Text = "altaservice";
			this.Load += new System.EventHandler(this.AltaserviceLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.TextBox telefono_cliente;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox domicilio_cliente;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox apellido_cliente;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox nombre_cliente;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox id_cliente;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox total;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox iva;
		private System.Windows.Forms.TextBox prec;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
