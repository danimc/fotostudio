/* Creado por L. Mora */

namespace FotoStudio
{
	partial class agregarclientes
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
			this.textName = new System.Windows.Forms.TextBox();
			this.textApe = new System.Windows.Forms.TextBox();
			this.textDom = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.textNum = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textRFC = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.textInt = new System.Windows.Forms.TextBox();
			this.textCol = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.textTel = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.textCel = new System.Windows.Forms.TextBox();
			this.errorNom = new System.Windows.Forms.Label();
			this.errApe = new System.Windows.Forms.Label();
			this.errorDom = new System.Windows.Forms.Label();
			this.ErrorNum = new System.Windows.Forms.Label();
			this.errorCol = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textName
			// 
			this.textName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textName.Location = new System.Drawing.Point(90, 121);
			this.textName.Name = "textName";
			this.textName.Size = new System.Drawing.Size(148, 21);
			this.textName.TabIndex = 0;
			// 
			// textApe
			// 
			this.textApe.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textApe.Location = new System.Drawing.Point(331, 124);
			this.textApe.Name = "textApe";
			this.textApe.Size = new System.Drawing.Size(149, 21);
			this.textApe.TabIndex = 1;
			// 
			// textDom
			// 
			this.textDom.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textDom.Location = new System.Drawing.Point(90, 177);
			this.textDom.Name = "textDom";
			this.textDom.Size = new System.Drawing.Size(148, 21);
			this.textDom.TabIndex = 2;
			this.textDom.TextChanged += new System.EventHandler(this.TextBox3TextChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(25, 120);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 19);
			this.label1.TabIndex = 3;
			this.label1.Text = "Nombre:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(269, 124);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "Apellido:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(14, 177);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 26);
			this.label3.TabIndex = 5;
			this.label3.Text = "Domicilio:";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(235, 302);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(74, 27);
			this.button1.TabIndex = 6;
			this.button1.Text = "Enviar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(179, 33);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(166, 27);
			this.label4.TabIndex = 7;
			this.label4.Text = "Agregar Nuevo Cliente";
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(25, 347);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(76, 27);
			this.button2.TabIndex = 8;
			this.button2.Text = "regresar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// textNum
			// 
			this.textNum.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textNum.Location = new System.Drawing.Point(331, 174);
			this.textNum.Name = "textNum";
			this.textNum.Size = new System.Drawing.Size(70, 21);
			this.textNum.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(13, 222);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(70, 17);
			this.label5.TabIndex = 10;
			this.label5.Text = "Colonia:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(161, 347);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(208, 24);
			this.label6.TabIndex = 11;
			// 
			// textRFC
			// 
			this.textRFC.Location = new System.Drawing.Point(89, 78);
			this.textRFC.Name = "textRFC";
			this.textRFC.Size = new System.Drawing.Size(148, 21);
			this.textRFC.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(41, 81);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(42, 23);
			this.label7.TabIndex = 13;
			this.label7.Text = "RFC:";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(262, 177);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(63, 30);
			this.label8.TabIndex = 14;
			this.label8.Text = "Numero:";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(406, 177);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 15;
			this.label9.Text = "Int:";
			// 
			// textInt
			// 
			this.textInt.Location = new System.Drawing.Point(432, 174);
			this.textInt.Name = "textInt";
			this.textInt.Size = new System.Drawing.Size(74, 21);
			this.textInt.TabIndex = 16;
			// 
			// textCol
			// 
			this.textCol.Location = new System.Drawing.Point(89, 222);
			this.textCol.Name = "textCol";
			this.textCol.Size = new System.Drawing.Size(149, 21);
			this.textCol.TabIndex = 17;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(25, 267);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 18;
			this.label10.Text = "Telefono:";
			// 
			// textTel
			// 
			this.textTel.Location = new System.Drawing.Point(89, 264);
			this.textTel.Name = "textTel";
			this.textTel.Size = new System.Drawing.Size(148, 21);
			this.textTel.TabIndex = 19;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(269, 267);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 23);
			this.label11.TabIndex = 20;
			this.label11.Text = "Celular:";
			// 
			// textCel
			// 
			this.textCel.Location = new System.Drawing.Point(331, 264);
			this.textCel.Name = "textCel";
			this.textCel.Size = new System.Drawing.Size(175, 21);
			this.textCel.TabIndex = 21;
			// 
			// errorNom
			// 
			this.errorNom.ForeColor = System.Drawing.Color.Red;
			this.errorNom.Location = new System.Drawing.Point(90, 145);
			this.errorNom.Name = "errorNom";
			this.errorNom.Size = new System.Drawing.Size(136, 17);
			this.errorNom.TabIndex = 22;
			// 
			// errApe
			// 
			this.errApe.ForeColor = System.Drawing.Color.Red;
			this.errApe.Location = new System.Drawing.Point(331, 145);
			this.errApe.Name = "errApe";
			this.errApe.Size = new System.Drawing.Size(149, 17);
			this.errApe.TabIndex = 23;
			// 
			// errorDom
			// 
			this.errorDom.ForeColor = System.Drawing.Color.Red;
			this.errorDom.Location = new System.Drawing.Point(90, 201);
			this.errorDom.Name = "errorDom";
			this.errorDom.Size = new System.Drawing.Size(148, 14);
			this.errorDom.TabIndex = 24;
			// 
			// ErrorNum
			// 
			this.ErrorNum.ForeColor = System.Drawing.Color.Red;
			this.ErrorNum.Location = new System.Drawing.Point(331, 201);
			this.ErrorNum.Name = "ErrorNum";
			this.ErrorNum.Size = new System.Drawing.Size(149, 42);
			this.ErrorNum.TabIndex = 25;
			// 
			// errorCol
			// 
			this.errorCol.ForeColor = System.Drawing.Color.Red;
			this.errorCol.Location = new System.Drawing.Point(90, 246);
			this.errorCol.Name = "errorCol";
			this.errorCol.Size = new System.Drawing.Size(100, 14);
			this.errorCol.TabIndex = 26;
			// 
			// agregarclientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(542, 386);
			this.Controls.Add(this.errorCol);
			this.Controls.Add(this.ErrorNum);
			this.Controls.Add(this.errorDom);
			this.Controls.Add(this.errApe);
			this.Controls.Add(this.errorNom);
			this.Controls.Add(this.textCel);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.textTel);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.textCol);
			this.Controls.Add(this.textInt);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textRFC);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textNum);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textDom);
			this.Controls.Add(this.textApe);
			this.Controls.Add(this.textName);
			this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Black;
			this.Name = "agregarclientes";
			this.Text = "agregarclientes";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label errorCol;
		private System.Windows.Forms.Label ErrorNum;
		private System.Windows.Forms.Label errorDom;
		private System.Windows.Forms.Label errApe;
		private System.Windows.Forms.Label errorNom;
		private System.Windows.Forms.TextBox textCel;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textTel;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textCol;
		private System.Windows.Forms.TextBox textInt;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textRFC;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textNum;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textDom;
		private System.Windows.Forms.TextBox textApe;
		private System.Windows.Forms.TextBox textName;
	}
}
