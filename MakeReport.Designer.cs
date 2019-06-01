namespace LoginPanel
{
	partial class MakeReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeReport));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_check = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txb_plname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txb_pfname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txb_pid = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_print = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.show_price = new MaterialSkin.Controls.MaterialLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.phone = new MaterialSkin.Controls.MaterialLabel();
            this.genre = new MaterialSkin.Controls.MaterialLabel();
            this.type = new MaterialSkin.Controls.MaterialLabel();
            this.address = new MaterialSkin.Controls.MaterialLabel();
            this.dob = new MaterialSkin.Controls.MaterialLabel();
            this.id = new MaterialSkin.Controls.MaterialLabel();
            this.pname = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(464, 427);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(889, 344);
            this.dataGridView1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_check);
            this.panel1.Controls.Add(this.txb_plname);
            this.panel1.Controls.Add(this.txb_pfname);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.txb_pid);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.btn_print);
            this.panel1.Location = new System.Drawing.Point(12, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 307);
            this.panel1.TabIndex = 3;
            // 
            // btn_check
            // 
            this.btn_check.Depth = 0;
            this.btn_check.Location = new System.Drawing.Point(37, 243);
            this.btn_check.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_check.Name = "btn_check";
            this.btn_check.Primary = true;
            this.btn_check.Size = new System.Drawing.Size(119, 44);
            this.btn_check.TabIndex = 13;
            this.btn_check.Text = "Check";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.Btn_check_Click);
            // 
            // txb_plname
            // 
            this.txb_plname.Depth = 0;
            this.txb_plname.Hint = "";
            this.txb_plname.Location = new System.Drawing.Point(201, 167);
            this.txb_plname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txb_plname.Name = "txb_plname";
            this.txb_plname.PasswordChar = '\0';
            this.txb_plname.SelectedText = "";
            this.txb_plname.SelectionLength = 0;
            this.txb_plname.SelectionStart = 0;
            this.txb_plname.Size = new System.Drawing.Size(290, 28);
            this.txb_plname.TabIndex = 2;
            this.txb_plname.UseSystemPasswordChar = false;
            // 
            // txb_pfname
            // 
            this.txb_pfname.Depth = 0;
            this.txb_pfname.Hint = "";
            this.txb_pfname.Location = new System.Drawing.Point(201, 95);
            this.txb_pfname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txb_pfname.Name = "txb_pfname";
            this.txb_pfname.PasswordChar = '\0';
            this.txb_pfname.SelectedText = "";
            this.txb_pfname.SelectionLength = 0;
            this.txb_pfname.SelectionStart = 0;
            this.txb_pfname.Size = new System.Drawing.Size(290, 28);
            this.txb_pfname.TabIndex = 1;
            this.txb_pfname.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(3, 171);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(171, 24);
            this.materialLabel3.TabIndex = 12;
            this.materialLabel3.Text = "Patient Last Name:";
            // 
            // txb_pid
            // 
            this.txb_pid.Depth = 0;
            this.txb_pid.Hint = "";
            this.txb_pid.Location = new System.Drawing.Point(201, 25);
            this.txb_pid.MouseState = MaterialSkin.MouseState.HOVER;
            this.txb_pid.Name = "txb_pid";
            this.txb_pid.PasswordChar = '\0';
            this.txb_pid.SelectedText = "";
            this.txb_pid.SelectionLength = 0;
            this.txb_pid.SelectionStart = 0;
            this.txb_pid.Size = new System.Drawing.Size(290, 28);
            this.txb_pid.TabIndex = 0;
            this.txb_pid.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(1, 99);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(173, 24);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Patient First Name:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(1, 29);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(96, 24);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Patient ID:";
            // 
            // btn_print
            // 
            this.btn_print.Depth = 0;
            this.btn_print.Location = new System.Drawing.Point(270, 243);
            this.btn_print.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_print.Name = "btn_print";
            this.btn_print.Primary = true;
            this.btn_print.Size = new System.Drawing.Size(119, 44);
            this.btn_print.TabIndex = 3;
            this.btn_print.Text = "PRINT";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.Btn_print_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(49, 788);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(89, 32);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1356, 52);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(81, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(343, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "MAKE PAYMENT REPORT";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(19, 9);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(111, 24);
            this.materialLabel4.TabIndex = 10;
            this.materialLabel4.Text = "Total Price: ";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(136, 9);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(0, 24);
            this.materialLabel5.TabIndex = 11;
            // 
            // show_price
            // 
            this.show_price.AutoSize = true;
            this.show_price.Depth = 0;
            this.show_price.Font = new System.Drawing.Font("Roboto", 11F);
            this.show_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.show_price.Location = new System.Drawing.Point(155, 9);
            this.show_price.MouseState = MaterialSkin.MouseState.HOVER;
            this.show_price.Name = "show_price";
            this.show_price.Size = new System.Drawing.Size(21, 24);
            this.show_price.TabIndex = 12;
            this.show_price.Text = "0";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.materialLabel4);
            this.panel3.Controls.Add(this.materialLabel5);
            this.panel3.Controls.Add(this.show_price);
            this.panel3.Location = new System.Drawing.Point(1097, 777);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(256, 43);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.phone);
            this.panel4.Controls.Add(this.genre);
            this.panel4.Controls.Add(this.type);
            this.panel4.Controls.Add(this.address);
            this.panel4.Controls.Add(this.dob);
            this.panel4.Controls.Add(this.id);
            this.panel4.Controls.Add(this.pname);
            this.panel4.Controls.Add(this.materialLabel13);
            this.panel4.Controls.Add(this.materialLabel12);
            this.panel4.Controls.Add(this.materialLabel11);
            this.panel4.Controls.Add(this.materialLabel10);
            this.panel4.Controls.Add(this.materialLabel9);
            this.panel4.Controls.Add(this.materialLabel8);
            this.panel4.Controls.Add(this.materialLabel7);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(464, 82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(881, 265);
            this.panel4.TabIndex = 15;
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Depth = 0;
            this.phone.Font = new System.Drawing.Font("Roboto", 11F);
            this.phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.phone.Location = new System.Drawing.Point(598, 176);
            this.phone.MouseState = MaterialSkin.MouseState.HOVER;
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(62, 24);
            this.phone.TabIndex = 28;
            this.phone.Text = "phone";
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.Depth = 0;
            this.genre.Font = new System.Drawing.Font("Roboto", 11F);
            this.genre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.genre.Location = new System.Drawing.Point(598, 130);
            this.genre.MouseState = MaterialSkin.MouseState.HOVER;
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(57, 24);
            this.genre.TabIndex = 27;
            this.genre.Text = "genre";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Depth = 0;
            this.type.Font = new System.Drawing.Font("Roboto", 11F);
            this.type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.type.Location = new System.Drawing.Point(598, 81);
            this.type.MouseState = MaterialSkin.MouseState.HOVER;
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(46, 24);
            this.type.TabIndex = 26;
            this.type.Text = "type";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Depth = 0;
            this.address.Font = new System.Drawing.Font("Roboto", 11F);
            this.address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.address.Location = new System.Drawing.Point(134, 227);
            this.address.MouseState = MaterialSkin.MouseState.HOVER;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(78, 24);
            this.address.TabIndex = 25;
            this.address.Text = "address";
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.Depth = 0;
            this.dob.Font = new System.Drawing.Font("Roboto", 11F);
            this.dob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dob.Location = new System.Drawing.Point(134, 176);
            this.dob.MouseState = MaterialSkin.MouseState.HOVER;
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(43, 24);
            this.dob.TabIndex = 24;
            this.dob.Text = "dob";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Depth = 0;
            this.id.Font = new System.Drawing.Font("Roboto", 11F);
            this.id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.id.Location = new System.Drawing.Point(134, 130);
            this.id.MouseState = MaterialSkin.MouseState.HOVER;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(26, 24);
            this.id.TabIndex = 23;
            this.id.Text = "id";
            // 
            // pname
            // 
            this.pname.AutoSize = true;
            this.pname.Depth = 0;
            this.pname.Font = new System.Drawing.Font("Roboto", 11F);
            this.pname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pname.Location = new System.Drawing.Point(134, 81);
            this.pname.MouseState = MaterialSkin.MouseState.HOVER;
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(68, 24);
            this.pname.TabIndex = 22;
            this.pname.Text = "pname";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(3, 227);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(85, 24);
            this.materialLabel13.TabIndex = 21;
            this.materialLabel13.Text = "Address:";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(512, 176);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(68, 24);
            this.materialLabel12.TabIndex = 20;
            this.materialLabel12.Text = "Phone:";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(512, 130);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(64, 24);
            this.materialLabel11.TabIndex = 19;
            this.materialLabel11.Text = "Genre:";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(3, 176);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(113, 24);
            this.materialLabel10.TabIndex = 18;
            this.materialLabel10.Text = "Day of Birth:";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(512, 81);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(56, 24);
            this.materialLabel9.TabIndex = 17;
            this.materialLabel9.Text = "Type:";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(3, 130);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(32, 24);
            this.materialLabel8.TabIndex = 16;
            this.materialLabel8.Text = "ID:";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(3, 81);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(66, 24);
            this.materialLabel7.TabIndex = 15;
            this.materialLabel7.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 39);
            this.label1.TabIndex = 29;
            this.label1.Text = "Patient Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(466, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 26);
            this.label2.TabIndex = 30;
            this.label2.Text = "Payment Info:";
            // 
            // MakeReport
            // 
            this.AcceptButton = this.btn_check;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1354, 860);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MakeReport";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Patient";
            this.Load += new System.EventHandler(this.MakeReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_back;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label4;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private MaterialSkin.Controls.MaterialLabel materialLabel2;
		private MaterialSkin.Controls.MaterialLabel materialLabel3;
		private MaterialSkin.Controls.MaterialSingleLineTextField txb_pfname;
		private MaterialSkin.Controls.MaterialSingleLineTextField txb_pid;
		private MaterialSkin.Controls.MaterialSingleLineTextField txb_plname;
		private MaterialSkin.Controls.MaterialRaisedButton btn_print;
        private MaterialSkin.Controls.MaterialRaisedButton btn_check;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel show_price;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialLabel phone;
        private MaterialSkin.Controls.MaterialLabel genre;
        private MaterialSkin.Controls.MaterialLabel type;
        private MaterialSkin.Controls.MaterialLabel address;
        private MaterialSkin.Controls.MaterialLabel dob;
        private MaterialSkin.Controls.MaterialLabel id;
        private MaterialSkin.Controls.MaterialLabel pname;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}