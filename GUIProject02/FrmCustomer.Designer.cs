
namespace GUIProject02
{
    partial class FrmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbGoToMainMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbtUpdate = new System.Windows.Forms.ToolStripButton();
            this.tsbtDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbtSave = new System.Windows.Forms.ToolStripButton();
            this.tsbtCancel = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btSelectCusImage = new System.Windows.Forms.Button();
            this.tbCusNote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCusDateOut = new System.Windows.Forms.TextBox();
            this.pbCusImage = new System.Windows.Forms.PictureBox();
            this.dtpCusDateIn = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbbCusStatus = new System.Windows.Forms.ComboBox();
            this.rdoCusSex3 = new System.Windows.Forms.RadioButton();
            this.rdoCusSex2 = new System.Windows.Forms.RadioButton();
            this.rdoCusSex1 = new System.Windows.Forms.RadioButton();
            this.tbCusPhone = new System.Windows.Forms.TextBox();
            this.tbCusEmail = new System.Windows.Forms.TextBox();
            this.tbCusName = new System.Windows.Forms.TextBox();
            this.tbCusId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvShowCustomer = new System.Windows.Forms.DataGridView();
            this.รหัสพนักงาน = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.rdoSearch4 = new System.Windows.Forms.RadioButton();
            this.rdoSearch3 = new System.Windows.Forms.RadioButton();
            this.rdoSearch2 = new System.Windows.Forms.RadioButton();
            this.rdoSearch1 = new System.Windows.Forms.RadioButton();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCusImage)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowCustomer)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(16)))), ((int)(((byte)(1)))));
            this.panel1.Controls.Add(this.tbGoToMainMenu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1171, 142);
            this.panel1.TabIndex = 1;
            // 
            // tbGoToMainMenu
            // 
            this.tbGoToMainMenu.Location = new System.Drawing.Point(937, 43);
            this.tbGoToMainMenu.Name = "tbGoToMainMenu";
            this.tbGoToMainMenu.Size = new System.Drawing.Size(163, 60);
            this.tbGoToMainMenu.TabIndex = 7;
            this.tbGoToMainMenu.Text = "กลับหน้าจอเมนู";
            this.tbGoToMainMenu.UseVisualStyleBackColor = true;
            this.tbGoToMainMenu.Click += new System.EventHandler(this.tbGoToMainMenu_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(154, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "จัดการข้อมูลลูกค้า";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(21, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(104, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(154, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtAdd,
            this.tsbtUpdate,
            this.tsbtDelete,
            this.tsbtSave,
            this.tsbtCancel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 142);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(4);
            this.toolStrip1.Size = new System.Drawing.Size(1171, 63);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtAdd
            // 
            this.tsbtAdd.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tsbtAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbtAdd.Image")));
            this.tsbtAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtAdd.Name = "tsbtAdd";
            this.tsbtAdd.Size = new System.Drawing.Size(91, 52);
            this.tsbtAdd.Text = "เพิ่ม";
            this.tsbtAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbtAdd.Click += new System.EventHandler(this.tsbtAdd_Click);
            // 
            // tsbtUpdate
            // 
            this.tsbtUpdate.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tsbtUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsbtUpdate.Image")));
            this.tsbtUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtUpdate.Name = "tsbtUpdate";
            this.tsbtUpdate.Size = new System.Drawing.Size(99, 52);
            this.tsbtUpdate.Text = "เเก้ไข";
            this.tsbtUpdate.Click += new System.EventHandler(this.tsbtUpdate_Click);
            // 
            // tsbtDelete
            // 
            this.tsbtDelete.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tsbtDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbtDelete.Image")));
            this.tsbtDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtDelete.Name = "tsbtDelete";
            this.tsbtDelete.Size = new System.Drawing.Size(84, 52);
            this.tsbtDelete.Text = "ลบ";
            this.tsbtDelete.Click += new System.EventHandler(this.tsbtDelete_Click);
            // 
            // tsbtSave
            // 
            this.tsbtSave.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tsbtSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbtSave.Image")));
            this.tsbtSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtSave.Name = "tsbtSave";
            this.tsbtSave.Size = new System.Drawing.Size(104, 52);
            this.tsbtSave.Text = "บันทึก";
            this.tsbtSave.Click += new System.EventHandler(this.tsbtSave_Click);
            // 
            // tsbtCancel
            // 
            this.tsbtCancel.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tsbtCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbtCancel.Image")));
            this.tsbtCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtCancel.Name = "tsbtCancel";
            this.tsbtCancel.Size = new System.Drawing.Size(109, 52);
            this.tsbtCancel.Text = "ยกเลิก";
            this.tsbtCancel.Click += new System.EventHandler(this.tsbtCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btSelectCusImage);
            this.groupBox1.Controls.Add(this.tbCusNote);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbCusDateOut);
            this.groupBox1.Controls.Add(this.pbCusImage);
            this.groupBox1.Controls.Add(this.dtpCusDateIn);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbbCusStatus);
            this.groupBox1.Controls.Add(this.rdoCusSex3);
            this.groupBox1.Controls.Add(this.rdoCusSex2);
            this.groupBox1.Controls.Add(this.rdoCusSex1);
            this.groupBox1.Controls.Add(this.tbCusPhone);
            this.groupBox1.Controls.Add(this.tbCusEmail);
            this.groupBox1.Controls.Add(this.tbCusName);
            this.groupBox1.Controls.Add(this.tbCusId);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 349);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลส่วนตัว";
            // 
            // btSelectCusImage
            // 
            this.btSelectCusImage.Location = new System.Drawing.Point(493, 88);
            this.btSelectCusImage.Name = "btSelectCusImage";
            this.btSelectCusImage.Size = new System.Drawing.Size(35, 31);
            this.btSelectCusImage.TabIndex = 32;
            this.btSelectCusImage.Text = "...";
            this.btSelectCusImage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSelectCusImage.UseVisualStyleBackColor = true;
            this.btSelectCusImage.Click += new System.EventHandler(this.btSelectCusImage_Click);
            // 
            // tbCusNote
            // 
            this.tbCusNote.Location = new System.Drawing.Point(174, 267);
            this.tbCusNote.Multiline = true;
            this.tbCusNote.Name = "tbCusNote";
            this.tbCusNote.Size = new System.Drawing.Size(142, 82);
            this.tbCusNote.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(26, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 26);
            this.label3.TabIndex = 30;
            this.label3.Text = "หมายเหตุ:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbCusDateOut
            // 
            this.tbCusDateOut.Location = new System.Drawing.Point(418, 260);
            this.tbCusDateOut.Name = "tbCusDateOut";
            this.tbCusDateOut.Size = new System.Drawing.Size(120, 31);
            this.tbCusDateOut.TabIndex = 29;
            // 
            // pbCusImage
            // 
            this.pbCusImage.Image = ((System.Drawing.Image)(resources.GetObject("pbCusImage.Image")));
            this.pbCusImage.Location = new System.Drawing.Point(362, 25);
            this.pbCusImage.Name = "pbCusImage";
            this.pbCusImage.Size = new System.Drawing.Size(125, 120);
            this.pbCusImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCusImage.TabIndex = 3;
            this.pbCusImage.TabStop = false;
            // 
            // dtpCusDateIn
            // 
            this.dtpCusDateIn.Location = new System.Drawing.Point(418, 219);
            this.dtpCusDateIn.Name = "dtpCusDateIn";
            this.dtpCusDateIn.Size = new System.Drawing.Size(121, 31);
            this.dtpCusDateIn.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(286, 260);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 26);
            this.label13.TabIndex = 27;
            this.label13.Text = "วันที่ยกเลิก:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(301, 223);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 26);
            this.label12.TabIndex = 26;
            this.label12.Text = "วันที่สมัคร:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbCusStatus
            // 
            this.cbbCusStatus.FormattingEnabled = true;
            this.cbbCusStatus.Items.AddRange(new object[] {
            "เป็นสมาชิกอยู่",
            "ยังไม่เป็นสมาชิก"});
            this.cbbCusStatus.Location = new System.Drawing.Point(174, 222);
            this.cbbCusStatus.Name = "cbbCusStatus";
            this.cbbCusStatus.Size = new System.Drawing.Size(121, 33);
            this.cbbCusStatus.TabIndex = 25;
            this.cbbCusStatus.Text = "-- เลือกสถานะ --";
            this.cbbCusStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbCusStatus_KeyPress);
            // 
            // rdoCusSex3
            // 
            this.rdoCusSex3.AutoSize = true;
            this.rdoCusSex3.Location = new System.Drawing.Point(289, 110);
            this.rdoCusSex3.Name = "rdoCusSex3";
            this.rdoCusSex3.Size = new System.Drawing.Size(67, 29);
            this.rdoCusSex3.TabIndex = 23;
            this.rdoCusSex3.Text = "LGBT";
            this.rdoCusSex3.UseVisualStyleBackColor = true;
            // 
            // rdoCusSex2
            // 
            this.rdoCusSex2.AutoSize = true;
            this.rdoCusSex2.Location = new System.Drawing.Point(229, 109);
            this.rdoCusSex2.Name = "rdoCusSex2";
            this.rdoCusSex2.Size = new System.Drawing.Size(65, 29);
            this.rdoCusSex2.TabIndex = 22;
            this.rdoCusSex2.Text = "หญิง";
            this.rdoCusSex2.UseVisualStyleBackColor = true;
            // 
            // rdoCusSex1
            // 
            this.rdoCusSex1.AutoSize = true;
            this.rdoCusSex1.Checked = true;
            this.rdoCusSex1.Location = new System.Drawing.Point(173, 109);
            this.rdoCusSex1.Name = "rdoCusSex1";
            this.rdoCusSex1.Size = new System.Drawing.Size(56, 29);
            this.rdoCusSex1.TabIndex = 21;
            this.rdoCusSex1.TabStop = true;
            this.rdoCusSex1.Text = "ชาย";
            this.rdoCusSex1.UseVisualStyleBackColor = true;
            // 
            // tbCusPhone
            // 
            this.tbCusPhone.Location = new System.Drawing.Point(174, 140);
            this.tbCusPhone.Name = "tbCusPhone";
            this.tbCusPhone.Size = new System.Drawing.Size(178, 31);
            this.tbCusPhone.TabIndex = 14;
            this.tbCusPhone.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // tbCusEmail
            // 
            this.tbCusEmail.Location = new System.Drawing.Point(173, 177);
            this.tbCusEmail.Name = "tbCusEmail";
            this.tbCusEmail.Size = new System.Drawing.Size(178, 31);
            this.tbCusEmail.TabIndex = 15;
            // 
            // tbCusName
            // 
            this.tbCusName.Location = new System.Drawing.Point(172, 70);
            this.tbCusName.Name = "tbCusName";
            this.tbCusName.Size = new System.Drawing.Size(178, 31);
            this.tbCusName.TabIndex = 12;
            // 
            // tbCusId
            // 
            this.tbCusId.Location = new System.Drawing.Point(172, 30);
            this.tbCusId.Name = "tbCusId";
            this.tbCusId.Size = new System.Drawing.Size(178, 31);
            this.tbCusId.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(21, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 26);
            this.label9.TabIndex = 7;
            this.label9.Text = "สถานะลูกค้า:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(49, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 26);
            this.label7.TabIndex = 5;
            this.label7.Text = "อีเมล์:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(54, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "เบอร์โทรศัพท์:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(48, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "เพศ:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(48, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "ชื่อ:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(48, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "รหัสลูกค้า:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvShowCustomer);
            this.groupBox3.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(565, 348);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(594, 198);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ข้อมูลพนักงาน";
            // 
            // dgvShowCustomer
            // 
            this.dgvShowCustomer.AllowUserToDeleteRows = false;
            this.dgvShowCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.รหัสพนักงาน,
            this.Column1,
            this.Column3,
            this.Column2});
            this.dgvShowCustomer.Location = new System.Drawing.Point(14, 28);
            this.dgvShowCustomer.Name = "dgvShowCustomer";
            this.dgvShowCustomer.ReadOnly = true;
            this.dgvShowCustomer.RowTemplate.Height = 25;
            this.dgvShowCustomer.Size = new System.Drawing.Size(580, 150);
            this.dgvShowCustomer.TabIndex = 0;
            this.dgvShowCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowCustomer_CellClick);
            // 
            // รหัสพนักงาน
            // 
            this.รหัสพนักงาน.HeaderText = "รหัสลูกค้า";
            this.รหัสพนักงาน.Name = "รหัสพนักงาน";
            this.รหัสพนักงาน.ReadOnly = true;
            this.รหัสพนักงาน.Width = 110;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ชื่อลูกค้า";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "เบอร์โทรศัพท์";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "อีเมล์";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btSearch);
            this.groupBox2.Controls.Add(this.tbSearch);
            this.groupBox2.Controls.Add(this.rdoSearch4);
            this.groupBox2.Controls.Add(this.rdoSearch3);
            this.groupBox2.Controls.Add(this.rdoSearch2);
            this.groupBox2.Controls.Add(this.rdoSearch1);
            this.groupBox2.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(565, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 145);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ค้นหา";
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(356, 77);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(142, 31);
            this.btSearch.TabIndex = 34;
            this.btSearch.Text = "ค้นหา";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(15, 77);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(306, 31);
            this.tbSearch.TabIndex = 30;
            // 
            // rdoSearch4
            // 
            this.rdoSearch4.AutoSize = true;
            this.rdoSearch4.Location = new System.Drawing.Point(439, 30);
            this.rdoSearch4.Name = "rdoSearch4";
            this.rdoSearch4.Size = new System.Drawing.Size(117, 29);
            this.rdoSearch4.TabIndex = 33;
            this.rdoSearch4.Text = "เบอร์โทรศัพท์";
            this.rdoSearch4.UseVisualStyleBackColor = true;
            // 
            // rdoSearch3
            // 
            this.rdoSearch3.AutoSize = true;
            this.rdoSearch3.Location = new System.Drawing.Point(314, 30);
            this.rdoSearch3.Name = "rdoSearch3";
            this.rdoSearch3.Size = new System.Drawing.Size(113, 29);
            this.rdoSearch3.TabIndex = 32;
            this.rdoSearch3.Text = "ด้วยชื่อลูกค้า";
            this.rdoSearch3.UseVisualStyleBackColor = true;
            // 
            // rdoSearch2
            // 
            this.rdoSearch2.AutoSize = true;
            this.rdoSearch2.Location = new System.Drawing.Point(177, 30);
            this.rdoSearch2.Name = "rdoSearch2";
            this.rdoSearch2.Size = new System.Drawing.Size(123, 29);
            this.rdoSearch2.TabIndex = 31;
            this.rdoSearch2.Text = "ด้วยรหัสลูกค้า";
            this.rdoSearch2.UseVisualStyleBackColor = true;
            // 
            // rdoSearch1
            // 
            this.rdoSearch1.AutoSize = true;
            this.rdoSearch1.Checked = true;
            this.rdoSearch1.Location = new System.Drawing.Point(15, 30);
            this.rdoSearch1.Name = "rdoSearch1";
            this.rdoSearch1.Size = new System.Drawing.Size(156, 29);
            this.rdoSearch1.TabIndex = 30;
            this.rdoSearch1.TabStop = true;
            this.rdoSearch1.Text = "เเสดงข้อมูลทั้งหมด";
            this.rdoSearch1.UseVisualStyleBackColor = true;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog1";
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 582);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "หน้าจอจัดการข้อมูลลูกค้า - SAU Coffee V.1.0";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCusImage)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowCustomer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtAdd;
        private System.Windows.Forms.ToolStripButton tsbtUpdate;
        private System.Windows.Forms.ToolStripButton tsbtDelete;
        private System.Windows.Forms.ToolStripButton tsbtSave;
        private System.Windows.Forms.ToolStripButton tsbtCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCusDateOut;
        private System.Windows.Forms.PictureBox pbCusImage;
        private System.Windows.Forms.DateTimePicker dtpCusDateIn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbbCusStatus;
        private System.Windows.Forms.RadioButton rdoCusSex3;
        private System.Windows.Forms.RadioButton rdoCusSex2;
        private System.Windows.Forms.RadioButton rdoCusSex1;
        private System.Windows.Forms.TextBox tbCusPhone;
        private System.Windows.Forms.TextBox tbCusEmail;
        private System.Windows.Forms.TextBox tbCusName;
        private System.Windows.Forms.TextBox tbCusId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvShowCustomer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.RadioButton rdoSearch4;
        private System.Windows.Forms.RadioButton rdoSearch3;
        private System.Windows.Forms.RadioButton rdoSearch2;
        private System.Windows.Forms.RadioButton rdoSearch1;
        private System.Windows.Forms.TextBox tbCusNote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn รหัสพนักงาน;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btSelectCusImage;
        private System.Windows.Forms.Button tbGoToMainMenu;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}