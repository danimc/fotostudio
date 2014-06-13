/* Creado por L. Mora */

namespace FotoStudio
{
	partial class Clientes
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.vercliente = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rfc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.inter = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.idc = new System.Windows.Forms.TextBox();
			this.nombrec = new System.Windows.Forms.TextBox();
			this.apellidoc = new System.Windows.Forms.TextBox();
			this.domicilioc = new System.Windows.Forms.TextBox();
			this.coloniac = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.vercliente)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(251, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Clientes";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(10, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Buscar:";
			// 
			// vercliente
			// 
			this.vercliente.AllowUserToAddRows = false;
			this.vercliente.AllowUserToDeleteRows = false;
			this.vercliente.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.vercliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vercliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.id,
									this.rfc,
									this.nombre,
									this.apellido,
									this.Telefono,
									this.Cel,
									this.domicilio,
									this.num,
									this.inter,
									this.col});
			this.vercliente.Location = new System.Drawing.Point(22, 133);
			this.vercliente.Name = "vercliente";
			this.vercliente.ReadOnly = true;
			this.vercliente.Size = new System.Drawing.Size(681, 246);
			this.vercliente.TabIndex = 3;
			this.vercliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VerclienteCellContentClick);
			// 
			// id
			// 
			this.id.HeaderText = "Id";
			this.id.Name = "id";
			this.id.ReadOnly = true;
			this.id.Width = 35;
			// 
			// rfc
			// 
			this.rfc.HeaderText = "RFC";
			this.rfc.Name = "rfc";
			this.rfc.ReadOnly = true;
			// 
			// nombre
			// 
			this.nombre.HeaderText = "Nombre";
			this.nombre.Name = "nombre";
			this.nombre.ReadOnly = true;
			this.nombre.Width = 150;
			// 
			// apellido
			// 
			this.apellido.HeaderText = "Apellido";
			this.apellido.Name = "apellido";
			this.apellido.ReadOnly = true;
			this.apellido.Width = 150;
			// 
			// Telefono
			// 
			this.Telefono.HeaderText = "Telefono";
			this.Telefono.Name = "Telefono";
			this.Telefono.ReadOnly = true;
			// 
			// Cel
			// 
			this.Cel.HeaderText = "Celular";
			this.Cel.Name = "Cel";
			this.Cel.ReadOnly = true;
			// 
			// domicilio
			// 
			this.domicilio.HeaderText = "Domicilio";
			this.domicilio.Name = "domicilio";
			this.domicilio.ReadOnly = true;
			this.domicilio.Width = 200;
			// 
			// num
			// 
			this.num.HeaderText = "Numero";
			this.num.Name = "num";
			this.num.ReadOnly = true;
			// 
			// inter
			// 
			this.inter.HeaderText = "No. Interno";
			this.inter.Name = "inter";
			this.inter.ReadOnly = true;
			// 
			// col
			// 
			this.col.HeaderText = "Colonia";
			this.col.Name = "col";
			this.col.ReadOnly = true;
			this.col.Width = 150;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(581, 385);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(122, 29);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1Click);
			this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1MouseUp);
			// 
			// idc
			// 
			this.idc.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.idc.Location = new System.Drawing.Point(70, 94);
			this.idc.Name = "idc";
			this.idc.Size = new System.Drawing.Size(25, 22);
			this.idc.TabIndex = 7;
			// 
			// nombrec
			// 
			this.nombrec.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nombrec.Location = new System.Drawing.Point(101, 95);
			this.nombrec.Name = "nombrec";
			this.nombrec.Size = new System.Drawing.Size(100, 22);
			this.nombrec.TabIndex = 8;
			// 
			// apellidoc
			// 
			this.apellidoc.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.apellidoc.Location = new System.Drawing.Point(207, 95);
			this.apellidoc.Name = "apellidoc";
			this.apellidoc.Size = new System.Drawing.Size(113, 22);
			this.apellidoc.TabIndex = 9;
			// 
			// domicilioc
			// 
			this.domicilioc.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.domicilioc.Location = new System.Drawing.Point(326, 95);
			this.domicilioc.Name = "domicilioc";
			this.domicilioc.Size = new System.Drawing.Size(129, 22);
			this.domicilioc.TabIndex = 10;
			// 
			// coloniac
			// 
			this.coloniac.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.coloniac.Location = new System.Drawing.Point(461, 95);
			this.coloniac.Name = "coloniac";
			this.coloniac.Size = new System.Drawing.Size(114, 22);
			this.coloniac.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(70, 77);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 14);
			this.label3.TabIndex = 12;
			this.label3.Text = "Id";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(101, 77);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 15);
			this.label4.TabIndex = 13;
			this.label4.Text = "Nombre";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(207, 77);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 15);
			this.label5.TabIndex = 14;
			this.label5.Text = "Apellido";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(326, 77);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 15);
			this.label6.TabIndex = 15;
			this.label6.Text = "Domicilio";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(461, 77);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 15);
			this.label7.TabIndex = 16;
			this.label7.Text = "Colonia";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(148, 396);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(115, 23);
			this.button3.TabIndex = 18;
			this.button3.Text = "Mostrar Todos";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(10, 390);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(132, 29);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 19;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.PictureBox2Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(581, 91);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(111, 27);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 20;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new System.EventHandler(this.PictureBox3Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(284, 396);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 21;
			this.button1.Text = "Editar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(393, 396);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(95, 23);
			this.button2.TabIndex = 22;
			this.button2.Text = "Eliminar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// Clientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(726, 431);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.coloniac);
			this.Controls.Add(this.domicilioc);
			this.Controls.Add(this.apellidoc);
			this.Controls.Add(this.nombrec);
			this.Controls.Add(this.idc);
			this.Controls.Add(this.vercliente);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Clientes";
			this.Text = "Clientes";
			this.Load += new System.EventHandler(this.ClientesLoad);
			((System.ComponentModel.ISupportInitialize)(this.vercliente)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.DataGridViewTextBoxColumn inter;
		private System.Windows.Forms.DataGridViewTextBoxColumn num;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cel;
		private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
		private System.Windows.Forms.DataGridViewTextBoxColumn rfc;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox coloniac;
		private System.Windows.Forms.TextBox domicilioc;
		private System.Windows.Forms.TextBox apellidoc;
		private System.Windows.Forms.TextBox nombrec;
		private System.Windows.Forms.TextBox idc;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn col;
		private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
		private System.Windows.Forms.DataGridViewTextBoxColumn domicilio;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridView vercliente;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
