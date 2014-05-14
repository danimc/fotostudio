/*
 * Creado por SharpDevelop.
 * Usuario: Soporte
 * Fecha: 05/05/2014
 * Hora: 05:03 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace FotoStudio
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnservicios = new System.Windows.Forms.Button();
			this.btnsalida = new System.Windows.Forms.Button();
			this.btncliente = new System.Windows.Forms.Button();
			this.btnconfiguracion = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(264, 34);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(161, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Bienvenido al Sistema ";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(358, 58);
			this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(1);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(281, 26);
			this.dateTimePicker1.TabIndex = 1;
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripMenuItem1});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
			this.menuStrip1.Size = new System.Drawing.Size(648, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1ItemClicked);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.salirToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 22);
			this.toolStripMenuItem1.Text = "Archivo";
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItemClick);
			// 
			// btnservicios
			// 
			this.btnservicios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnservicios.BackgroundImage")));
			this.btnservicios.Location = new System.Drawing.Point(13, 58);
			this.btnservicios.Margin = new System.Windows.Forms.Padding(1);
			this.btnservicios.Name = "btnservicios";
			this.btnservicios.Size = new System.Drawing.Size(226, 60);
			this.btnservicios.TabIndex = 4;
			this.btnservicios.UseVisualStyleBackColor = true;
			this.btnservicios.Click += new System.EventHandler(this.Button1Click);
			// 
			// btnsalida
			// 
			this.btnsalida.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalida.BackgroundImage")));
			this.btnsalida.Location = new System.Drawing.Point(10, 289);
			this.btnsalida.Margin = new System.Windows.Forms.Padding(1);
			this.btnsalida.Name = "btnsalida";
			this.btnsalida.Size = new System.Drawing.Size(226, 58);
			this.btnsalida.TabIndex = 5;
			this.btnsalida.UseVisualStyleBackColor = true;
			this.btnsalida.Click += new System.EventHandler(this.Button2Click);
			// 
			// btncliente
			// 
			this.btncliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncliente.BackgroundImage")));
			this.btncliente.Location = new System.Drawing.Point(10, 136);
			this.btncliente.Margin = new System.Windows.Forms.Padding(1);
			this.btncliente.Name = "btncliente";
			this.btncliente.Size = new System.Drawing.Size(226, 59);
			this.btncliente.TabIndex = 6;
			this.btncliente.UseVisualStyleBackColor = true;
			this.btncliente.Click += new System.EventHandler(this.Button3Click);
			// 
			// btnconfiguracion
			// 
			this.btnconfiguracion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnconfiguracion.BackgroundImage")));
			this.btnconfiguracion.Location = new System.Drawing.Point(10, 212);
			this.btnconfiguracion.Margin = new System.Windows.Forms.Padding(1);
			this.btnconfiguracion.Name = "btnconfiguracion";
			this.btnconfiguracion.Size = new System.Drawing.Size(226, 57);
			this.btnconfiguracion.TabIndex = 7;
			this.btnconfiguracion.UseVisualStyleBackColor = true;
			this.btnconfiguracion.Click += new System.EventHandler(this.BtnconfiguracionClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(332, 136);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(295, 158);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(648, 385);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnconfiguracion);
			this.Controls.Add(this.btncliente);
			this.Controls.Add(this.btnsalida);
			this.Controls.Add(this.btnservicios);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "FotoStudio";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnconfiguracion;
		private System.Windows.Forms.Button btncliente;
		private System.Windows.Forms.Button btnsalida;
		private System.Windows.Forms.Button btnservicios;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label1;
	}
}
