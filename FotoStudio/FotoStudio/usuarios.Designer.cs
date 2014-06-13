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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usuarios));
			this.label1 = new System.Windows.Forms.Label();
			this.veruser = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.roller = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idsearch = new System.Windows.Forms.TextBox();
			this.usersearch = new System.Windows.Forms.TextBox();
			this.rolsearch = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.veruser)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
			this.veruser.Location = new System.Drawing.Point(96, 121);
			this.veruser.MultiSelect = false;
			this.veruser.Name = "veruser";
			this.veruser.ReadOnly = true;
			this.veruser.Size = new System.Drawing.Size(416, 150);
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
			// idsearch
			// 
			this.idsearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.idsearch.Location = new System.Drawing.Point(82, 92);
			this.idsearch.Name = "idsearch";
			this.idsearch.Size = new System.Drawing.Size(60, 22);
			this.idsearch.TabIndex = 3;
			// 
			// usersearch
			// 
			this.usersearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usersearch.Location = new System.Drawing.Point(148, 92);
			this.usersearch.Name = "usersearch";
			this.usersearch.Size = new System.Drawing.Size(140, 22);
			this.usersearch.TabIndex = 4;
			// 
			// rolsearch
			// 
			this.rolsearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rolsearch.Location = new System.Drawing.Point(300, 92);
			this.rolsearch.Name = "rolsearch";
			this.rolsearch.Size = new System.Drawing.Size(97, 22);
			this.rolsearch.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(23, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "Buscar:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(82, 70);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(22, 16);
			this.label3.TabIndex = 7;
			this.label3.Text = "ID";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(148, 70);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 19);
			this.label4.TabIndex = 8;
			this.label4.Text = "Usuario";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(300, 71);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(31, 18);
			this.label5.TabIndex = 9;
			this.label5.Text = "Rol";
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(266, 287);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(142, 32);
			this.button5.TabIndex = 13;
			this.button5.Text = "Editar Usuario";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(431, 287);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(144, 32);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(-3, 333);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(145, 34);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox2.TabIndex = 15;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.PictureBox2Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(432, 84);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(143, 31);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox3.TabIndex = 16;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new System.EventHandler(this.PictureBox3Click);
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(117, 284);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(143, 35);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox4.TabIndex = 17;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Click += new System.EventHandler(this.PictureBox4Click);
			// 
			// usuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(622, 369);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.rolsearch);
			this.Controls.Add(this.usersearch);
			this.Controls.Add(this.idsearch);
			this.Controls.Add(this.veruser);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox3);
			this.Name = "usuarios";
			this.Text = "usuarios";
			this.Load += new System.EventHandler(this.UsuariosLoad);
			((System.ComponentModel.ISupportInitialize)(this.veruser)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox rolsearch;
		private System.Windows.Forms.TextBox usersearch;
		private System.Windows.Forms.TextBox idsearch;
		private System.Windows.Forms.DataGridViewTextBoxColumn Contraseña;
		private System.Windows.Forms.DataGridViewTextBoxColumn roller;
		private System.Windows.Forms.DataGridViewTextBoxColumn user;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridView veruser;
		private System.Windows.Forms.Label label1;
	}
}
