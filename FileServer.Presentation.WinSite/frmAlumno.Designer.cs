namespace FileServer.Presentation.WinSite
{
	partial class frmAlumno
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnGuardar = new System.Windows.Forms.Button();
			this.txtIdAlumno = new CashControl.TextBoxInteger();
			this.txtNombre = new CashControl.MyTextBox();
			this.txtApellidos = new CashControl.MyTextBox();
			this.txtDni = new CashControl.MyTextBox();
			this.Id = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(619, 203);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(94, 67);
			this.btnGuardar.TabIndex = 0;
			this.btnGuardar.Text = "Grabar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// txtIdAlumno
			// 
			this.txtIdAlumno.Location = new System.Drawing.Point(161, 169);
			this.txtIdAlumno.Name = "txtIdAlumno";
			this.txtIdAlumno.PermetreValorNegatiu = false;
			this.txtIdAlumno.Size = new System.Drawing.Size(100, 20);
			this.txtIdAlumno.TabIndex = 1;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(161, 210);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(274, 20);
			this.txtNombre.TabIndex = 2;
			// 
			// txtApellidos
			// 
			this.txtApellidos.Location = new System.Drawing.Point(161, 250);
			this.txtApellidos.Name = "txtApellidos";
			this.txtApellidos.Size = new System.Drawing.Size(274, 20);
			this.txtApellidos.TabIndex = 3;
			// 
			// txtDni
			// 
			this.txtDni.Location = new System.Drawing.Point(161, 299);
			this.txtDni.Name = "txtDni";
			this.txtDni.Size = new System.Drawing.Size(114, 20);
			this.txtDni.TabIndex = 4;
			// 
			// Id
			// 
			this.Id.AutoSize = true;
			this.Id.Location = new System.Drawing.Point(135, 172);
			this.Id.Name = "Id";
			this.Id.Size = new System.Drawing.Size(16, 13);
			this.Id.TabIndex = 5;
			this.Id.Text = "Id";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(107, 210);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Nombre";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(107, 253);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Apellidos";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(128, 302);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(23, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Dni";
			// 
			// frmAlumno
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Id);
			this.Controls.Add(this.txtDni);
			this.Controls.Add(this.txtApellidos);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtIdAlumno);
			this.Controls.Add(this.btnGuardar);
			this.Name = "frmAlumno";
			this.Text = "Form2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnGuardar;
		private CashControl.TextBoxInteger txtIdAlumno;
		private CashControl.MyTextBox txtNombre;
		private CashControl.MyTextBox txtApellidos;
		private CashControl.MyTextBox txtDni;
		private System.Windows.Forms.Label Id;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}