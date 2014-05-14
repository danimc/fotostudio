/* Creado por L. Mora */

namespace FotoStudio
{
	partial class Login
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.user = new System.Windows.Forms.TextBox();
			this.password = new System.Windows.Forms.MaskedTextBox();
			this.btnlogin = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(26, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(281, 38);
			this.label1.TabIndex = 0;
			this.label1.Text = "Bienvenido al Sistema FS V 1.0";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Usuario:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 97);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 25);
			this.label3.TabIndex = 2;
			this.label3.Text = "Contraseña:";
			// 
			// user
			// 
			this.user.Location = new System.Drawing.Point(99, 61);
			this.user.Name = "user";
			this.user.Size = new System.Drawing.Size(174, 20);
			this.user.TabIndex = 3;
			// 
			// password
			// 
			this.password.Location = new System.Drawing.Point(99, 94);
			this.password.Name = "password";
			this.password.PasswordChar = '*';
			this.password.Size = new System.Drawing.Size(174, 20);
			this.password.TabIndex = 4;
			// 
			// btnlogin
			// 
			this.btnlogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnlogin.Location = new System.Drawing.Point(137, 130);
			this.btnlogin.Name = "btnlogin";
			this.btnlogin.Size = new System.Drawing.Size(75, 25);
			this.btnlogin.TabIndex = 5;
			this.btnlogin.Text = "Ingresar";
			this.btnlogin.UseVisualStyleBackColor = false;
			this.btnlogin.Click += new System.EventHandler(this.Button1Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(328, 164);
			this.Controls.Add(this.btnlogin);
			this.Controls.Add(this.password);
			this.Controls.Add(this.user);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Login";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnlogin;
		private System.Windows.Forms.MaskedTextBox password;
		private System.Windows.Forms.TextBox user;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
