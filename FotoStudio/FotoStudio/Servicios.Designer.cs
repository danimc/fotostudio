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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.regresar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.Location = new System.Drawing.Point(40, 139);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(152, 48);
			this.button1.TabIndex = 0;
			this.button1.Text = "Fotografia";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.Location = new System.Drawing.Point(40, 236);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(152, 46);
			this.button2.TabIndex = 1;
			this.button2.Text = "Video";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.Location = new System.Drawing.Point(260, 139);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(160, 48);
			this.button3.TabIndex = 2;
			this.button3.Text = "Paquetes";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(188, 25);
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
			// Servicios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(468, 373);
			this.Controls.Add(this.regresar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "Servicios";
			this.Text = "Servicios";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button regresar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
	}
}
