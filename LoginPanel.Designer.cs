namespace LoginPanel
{
	partial class LoginPanel
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPanel));
			this.btn_login = new MaterialSkin.Controls.MaterialRaisedButton();
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txb_username = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.txb_password = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_login
			// 
			this.btn_login.Depth = 0;
			this.btn_login.Location = new System.Drawing.Point(218, 234);
			this.btn_login.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_login.Name = "btn_login";
			this.btn_login.Primary = true;
			this.btn_login.Size = new System.Drawing.Size(115, 42);
			this.btn_login.TabIndex = 2;
			this.btn_login.Text = "LOGIN";
			this.btn_login.UseVisualStyleBackColor = true;
			this.btn_login.Click += new System.EventHandler(this.Btn_login_Click);
			// 
			// materialLabel1
			// 
			this.materialLabel1.AutoSize = true;
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel1.Location = new System.Drawing.Point(87, 126);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(95, 24);
			this.materialLabel1.TabIndex = 6;
			this.materialLabel1.Text = "Username";
			// 
			// materialLabel2
			// 
			this.materialLabel2.AutoSize = true;
			this.materialLabel2.Depth = 0;
			this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel2.Location = new System.Drawing.Point(87, 178);
			this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel2.Name = "materialLabel2";
			this.materialLabel2.Size = new System.Drawing.Size(94, 24);
			this.materialLabel2.TabIndex = 7;
			this.materialLabel2.Text = "Password";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 30);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(533, 52);
			this.panel1.TabIndex = 8;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(81, 10);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(44, 29);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(131, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(289, 29);
			this.label1.TabIndex = 9;
			this.label1.Text = "LOGIN TO DATABASE";
			// 
			// txb_username
			// 
			this.txb_username.Depth = 0;
			this.txb_username.Hint = "";
			this.txb_username.Location = new System.Drawing.Point(223, 122);
			this.txb_username.MouseState = MaterialSkin.MouseState.HOVER;
			this.txb_username.Name = "txb_username";
			this.txb_username.PasswordChar = '\0';
			this.txb_username.SelectedText = "";
			this.txb_username.SelectionLength = 0;
			this.txb_username.SelectionStart = 0;
			this.txb_username.Size = new System.Drawing.Size(290, 28);
			this.txb_username.TabIndex = 0;
			this.txb_username.UseSystemPasswordChar = false;
			// 
			// txb_password
			// 
			this.txb_password.Depth = 0;
			this.txb_password.Hint = "";
			this.txb_password.Location = new System.Drawing.Point(223, 174);
			this.txb_password.MouseState = MaterialSkin.MouseState.HOVER;
			this.txb_password.Name = "txb_password";
			this.txb_password.PasswordChar = '\0';
			this.txb_password.SelectedText = "";
			this.txb_password.SelectionLength = 0;
			this.txb_password.SelectionStart = 0;
			this.txb_password.Size = new System.Drawing.Size(290, 28);
			this.txb_password.TabIndex = 1;
			this.txb_password.UseSystemPasswordChar = true;
			// 
			// LoginPanel
			// 
			this.AcceptButton = this.btn_login;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(530, 308);
			this.Controls.Add(this.txb_password);
			this.Controls.Add(this.txb_username);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.materialLabel2);
			this.Controls.Add(this.materialLabel1);
			this.Controls.Add(this.btn_login);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(530, 308);
			this.MinimumSize = new System.Drawing.Size(530, 308);
			this.Name = "LoginPanel";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login to Database";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private MaterialSkin.Controls.MaterialRaisedButton btn_login;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private MaterialSkin.Controls.MaterialLabel materialLabel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private MaterialSkin.Controls.MaterialSingleLineTextField txb_username;
		private MaterialSkin.Controls.MaterialSingleLineTextField txb_password;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

