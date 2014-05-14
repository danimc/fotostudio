/* Creado por L. Mora */

namespace FotoStudio
{
	partial class BandejaSalida
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
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(162, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Bandeja de Salida";
			// 
			// regresar
			// 
			this.regresar.Location = new System.Drawing.Point(24, 238);
			this.regresar.Name = "regresar";
			this.regresar.Size = new System.Drawing.Size(75, 23);
			this.regresar.TabIndex = 1;
			this.regresar.Text = "Regresar";
			this.regresar.UseVisualStyleBackColor = true;
			this.regresar.Click += new System.EventHandler(this.RegresarClick);
			// 
			// BandejaSalida
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(452, 273);
			this.Controls.Add(this.regresar);
			this.Controls.Add(this.label1);
			this.Name = "BandejaSalida";
			this.Text = "BandejaSalida";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button regresar;
		private System.Windows.Forms.Label label1;
	}
}
