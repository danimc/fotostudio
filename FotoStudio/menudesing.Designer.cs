/* Creado por L. Mora */

namespace FotoStudio
{
	partial class menudesing
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menudesing));
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnalmacen = new System.Windows.Forms.Button();
			this.btntrabajos = new System.Windows.Forms.Button();
			this.btnsalida = new System.Windows.Forms.Button();
			this.btnconfig = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(153, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(275, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "Bienvenido al sistema, usuario de Diseño";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(306, 115);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(258, 135);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// btnalmacen
			// 
			this.btnalmacen.Location = new System.Drawing.Point(12, 103);
			this.btnalmacen.Name = "btnalmacen";
			this.btnalmacen.Size = new System.Drawing.Size(166, 53);
			this.btnalmacen.TabIndex = 2;
			this.btnalmacen.Text = "Almacen de Fotos";
			this.btnalmacen.UseVisualStyleBackColor = true;
			
			// 
			// btntrabajos
			// 
			this.btntrabajos.Location = new System.Drawing.Point(12, 197);
			this.btntrabajos.Name = "btntrabajos";
			this.btntrabajos.Size = new System.Drawing.Size(166, 53);
			this.btntrabajos.TabIndex = 3;
			this.btntrabajos.Text = "Trabajos Terminados";
			this.btntrabajos.UseVisualStyleBackColor = true;
			// 
			// btnsalida
			// 
			this.btnsalida.Location = new System.Drawing.Point(12, 285);
			this.btnsalida.Name = "btnsalida";
			this.btnsalida.Size = new System.Drawing.Size(166, 50);
			this.btnsalida.TabIndex = 4;
			this.btnsalida.Text = "Bandeja de Salida";
			this.btnsalida.UseVisualStyleBackColor = true;
			// 
			// btnconfig
			// 
			this.btnconfig.Location = new System.Drawing.Point(358, 285);
			this.btnconfig.Name = "btnconfig";
			this.btnconfig.Size = new System.Drawing.Size(166, 49);
			this.btnconfig.TabIndex = 5;
			this.btnconfig.Text = "Configuracion";
			this.btnconfig.UseVisualStyleBackColor = true;
			// 
			// menudesing
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(576, 361);
			this.Controls.Add(this.btnconfig);
			this.Controls.Add(this.btnsalida);
			this.Controls.Add(this.btntrabajos);
			this.Controls.Add(this.btnalmacen);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Name = "menudesing";
			this.Text = "menudesing";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnconfig;
		private System.Windows.Forms.Button btnsalida;
		private System.Windows.Forms.Button btntrabajos;
		private System.Windows.Forms.Button btnalmacen;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
	}
}
