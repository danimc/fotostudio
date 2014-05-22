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
			this.desc = new System.Windows.Forms.RichTextBox();
			this.preci = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.verservicos = new System.Windows.Forms.DataGridView();
			this.service = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.verservicos)).BeginInit();
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
			// desc
			// 
			this.desc.Enabled = false;
			this.desc.Location = new System.Drawing.Point(236, 84);
			this.desc.Name = "desc";
			this.desc.Size = new System.Drawing.Size(295, 89);
			this.desc.TabIndex = 6;
			this.desc.Text = "Descripcion: (selecciona un Servicio para ver:";
			// 
			// preci
			// 
			this.preci.Enabled = false;
			this.preci.Location = new System.Drawing.Point(393, 179);
			this.preci.Name = "preci";
			this.preci.Size = new System.Drawing.Size(138, 20);
			this.preci.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(342, 180);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 23);
			this.label2.TabIndex = 9;
			this.label2.Text = "Precio:";
			// 
			// verservicos
			// 
			this.verservicos.AllowUserToAddRows = false;
			this.verservicos.AllowUserToDeleteRows = false;
			this.verservicos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.verservicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.verservicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.service});
			this.verservicos.Location = new System.Drawing.Point(12, 84);
			this.verservicos.Name = "verservicos";
			this.verservicos.ReadOnly = true;
			this.verservicos.Size = new System.Drawing.Size(218, 233);
			this.verservicos.TabIndex = 10;
			this.verservicos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VerservicosCellContentClick);
			// 
			// service
			// 
			this.service.HeaderText = "Servicios";
			this.service.Name = "service";
			this.service.ReadOnly = true;
			this.service.Width = 200;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(251, 225);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(305, 92);
			this.label3.TabIndex = 11;
			// 
			// Servicios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(568, 373);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.verservicos);
			this.Controls.Add(this.preci);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.desc);
			this.Controls.Add(this.regresar);
			this.Controls.Add(this.label1);
			this.Name = "Servicios";
			this.Text = "Servicios";
			this.Load += new System.EventHandler(this.ServiciosLoad);
			((System.ComponentModel.ISupportInitialize)(this.verservicos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridViewTextBoxColumn service;
		private System.Windows.Forms.DataGridView verservicos;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox preci;
		private System.Windows.Forms.RichTextBox desc;
		private System.Windows.Forms.Button regresar;
		private System.Windows.Forms.Label label1;
	}
}
