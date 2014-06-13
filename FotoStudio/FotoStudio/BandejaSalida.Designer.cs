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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.NoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.eventofecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Facturar = new System.Windows.Forms.DataGridViewButtonColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(244, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Bandeja de Salida";
			// 
			// regresar
			// 
			this.regresar.Location = new System.Drawing.Point(12, 367);
			this.regresar.Name = "regresar";
			this.regresar.Size = new System.Drawing.Size(75, 23);
			this.regresar.TabIndex = 1;
			this.regresar.Text = "Regresar";
			this.regresar.UseVisualStyleBackColor = true;
			this.regresar.Click += new System.EventHandler(this.RegresarClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.NoServicio,
									this.Column1,
									this.Column2,
									this.eventofecha,
									this.Facturar});
			this.dataGridView1.Location = new System.Drawing.Point(28, 87);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(547, 252);
			this.dataGridView1.TabIndex = 2;
			// 
			// NoServicio
			// 
			this.NoServicio.HeaderText = "No. de Servicio";
			this.NoServicio.Name = "NoServicio";
			this.NoServicio.ReadOnly = true;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Tipo de Servicio";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Cliente";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// eventofecha
			// 
			this.eventofecha.HeaderText = "Fecha del evento";
			this.eventofecha.Name = "eventofecha";
			this.eventofecha.ReadOnly = true;
			// 
			// Facturar
			// 
			this.Facturar.HeaderText = "Entregar y Facturar";
			this.Facturar.Name = "Facturar";
			this.Facturar.ReadOnly = true;
			this.Facturar.Text = "Facturar";
			// 
			// BandejaSalida
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(611, 402);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.regresar);
			this.Controls.Add(this.label1);
			this.Name = "BandejaSalida";
			this.Text = "BandejaSalida";
			this.Load += new System.EventHandler(this.BandejaSalidaLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewButtonColumn Facturar;
		private System.Windows.Forms.DataGridViewTextBoxColumn eventofecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn NoServicio;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button regresar;
		private System.Windows.Forms.Label label1;
	}
}
