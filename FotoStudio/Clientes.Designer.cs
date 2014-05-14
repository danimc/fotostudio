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
			this.btnclientenuevo = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
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
			// btnclientenuevo
			// 
			this.btnclientenuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclientenuevo.BackgroundImage")));
			this.btnclientenuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnclientenuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnclientenuevo.Location = new System.Drawing.Point(357, 293);
			this.btnclientenuevo.Name = "btnclientenuevo";
			this.btnclientenuevo.Size = new System.Drawing.Size(167, 36);
			this.btnclientenuevo.TabIndex = 1;
			this.btnclientenuevo.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(26, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Buscar:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(104, 67);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(371, 20);
			this.textBox1.TabIndex = 3;
			// 
			// Clientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(536, 332);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnclientenuevo);
			this.Controls.Add(this.label1);
			this.Name = "Clientes";
			this.Text = "Clientes";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnclientenuevo;
		private System.Windows.Forms.Label label1;
	}
}
