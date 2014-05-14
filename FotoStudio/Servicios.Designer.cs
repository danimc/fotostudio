/*
 * Creado por SharpDevelop.
 * Usuario: Soporte
 * Fecha: 07/05/2014
 * Hora: 05:27 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace FotoStudio
{
	partial class Servicios
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
			this.label1 = new System.Windows.Forms.Label();
			this.regresar = new System.Windows.Forms.Button();
			this.btnserv = new System.Windows.Forms.Button();
			this.btnlevantarpedido = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(204, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Servicios";
			// 
			// regresar
			// 
			this.regresar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.regresar.Location = new System.Drawing.Point(12, 338);
			this.regresar.Name = "regresar";
			this.regresar.Size = new System.Drawing.Size(75, 23);
			this.regresar.TabIndex = 5;
			this.regresar.Text = "Regresar";
			this.regresar.UseVisualStyleBackColor = true;
			this.regresar.Click += new System.EventHandler(this.RegresarClick);
			// 
			// btnserv
			// 
			this.btnserv.Location = new System.Drawing.Point(137, 103);
			this.btnserv.Name = "btnserv";
			this.btnserv.Size = new System.Drawing.Size(181, 57);
			this.btnserv.TabIndex = 6;
			this.btnserv.Text = "Servicios";
			this.btnserv.UseVisualStyleBackColor = true;
			// 
			// btnlevantarpedido
			// 
			this.btnlevantarpedido.Location = new System.Drawing.Point(137, 239);
			this.btnlevantarpedido.Name = "btnlevantarpedido";
			this.btnlevantarpedido.Size = new System.Drawing.Size(181, 57);
			this.btnlevantarpedido.TabIndex = 7;
			this.btnlevantarpedido.Text = "Levantar Pedido";
			this.btnlevantarpedido.UseVisualStyleBackColor = true;
			// 
			// Servicios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(468, 373);
			this.Controls.Add(this.btnlevantarpedido);
			this.Controls.Add(this.btnserv);
			this.Controls.Add(this.regresar);
			this.Controls.Add(this.label1);
			this.Name = "Servicios";
			this.Text = "Servicios";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button regresar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnlevantarpedido;
		private System.Windows.Forms.Button btnserv;
	}
}
