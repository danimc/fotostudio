/* Creado por L. Mora */

namespace FotoStudio
{
	partial class usuarios
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
			this.veruser = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.roller = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			this.idsearch = new System.Windows.Forms.TextBox();
			this.usersearch = new System.Windows.Forms.TextBox();
			this.rolsearch = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.veruser)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(211, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Usuarios";
			// 
			// veruser
			// 
			this.veruser.AllowUserToAddRows = false;
			this.veruser.AllowUserToDeleteRows = false;
			this.veruser.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.veruser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.veruser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.id,
									this.user,
									this.roller,
									this.Contraseña});
			this.veruser.Location = new System.Drawing.Point(70, 120);
			this.veruser.MultiSelect = false;
			this.veruser.Name = "veruser";
			this.veruser.ReadOnly = true;
			this.veruser.Size = new System.Drawing.Size(406, 150);
			this.veruser.TabIndex = 1;
			// 
			// id
			// 
			this.id.HeaderText = "ID";
			this.id.Name = "id";
			this.id.ReadOnly = true;
			this.id.Width = 50;
			// 
			// user
			// 
			this.user.HeaderText = "Usuario";
			this.user.Name = "user";
			this.user.ReadOnly = true;
			this.user.Width = 125;
			// 
			// roller
			// 
			this.roller.HeaderText = "Rol";
			this.roller.Name = "roller";
			this.roller.ReadOnly = true;
			// 
			// Contraseña
			// 
			this.Contraseña.HeaderText = "Contraseña";
			this.Contraseña.Name = "Contraseña";
			this.Contraseña.ReadOnly = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(376, 276);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Nuevo Usuario";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// idsearch
			// 
			this.idsearch.Location = new System.Drawing.Point(70, 94);
			this.idsearch.Name = "idsearch";
			this.idsearch.Size = new System.Drawing.Size(39, 20);
			this.idsearch.TabIndex = 3;
			// 
			// usersearch
			// 
			this.usersearch.Location = new System.Drawing.Point(115, 94);
			this.usersearch.Name = "usersearch";
			this.usersearch.Size = new System.Drawing.Size(93, 20);
			this.usersearch.TabIndex = 4;
			// 
			// rolsearch
			// 
			this.rolsearch.Location = new System.Drawing.Point(214, 94);
			this.rolsearch.Name = "rolsearch";
			this.rolsearch.Size = new System.Drawing.Size(97, 20);
			this.rolsearch.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(23, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "Buscar:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(70, 79);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(22, 12);
			this.label3.TabIndex = 7;
			this.label3.Text = "ID";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(115, 79);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 12);
			this.label4.TabIndex = 8;
			this.label4.Text = "Usuario";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(214, 79);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 12);
			this.label5.TabIndex = 9;
			this.label5.Text = "Rol";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(317, 91);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(59, 23);
			this.button2.TabIndex = 10;
			this.button2.Text = "filtrar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(382, 92);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(83, 23);
			this.button3.TabIndex = 11;
			this.button3.Text = "Mostrar Todos";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(17, 309);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 12;
			this.button4.Text = "Regresar";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(271, 276);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(99, 23);
			this.button5.TabIndex = 13;
			this.button5.Text = "Editar Usuario";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// usuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(512, 344);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.rolsearch);
			this.Controls.Add(this.usersearch);
			this.Controls.Add(this.idsearch);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.veruser);
			this.Controls.Add(this.label1);
			this.Name = "usuarios";
			this.Text = "usuarios";
			this.Load += new System.EventHandler(this.UsuariosLoad);
			((System.ComponentModel.ISupportInitialize)(this.veruser)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox rolsearch;
		private System.Windows.Forms.TextBox usersearch;
		private System.Windows.Forms.TextBox idsearch;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Contraseña;
		private System.Windows.Forms.DataGridViewTextBoxColumn roller;
		private System.Windows.Forms.DataGridViewTextBoxColumn user;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridView veruser;
		private System.Windows.Forms.Label label1;
	}
}
