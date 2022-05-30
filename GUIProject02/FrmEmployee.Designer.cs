
namespace GUIProject02
{
    partial class FrmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployee));
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
            this.btSelectEmpImage = new System.Windows.Forms.Button();
            this.tbEmpDateOut = new System.Windows.Forms.TextBox();
            this.pbEmpImage = new System.Windows.Forms.PictureBox();
            this.dtpEmpDateIn = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbbEmpStatus = new System.Windows.Forms.ComboBox();
            this.cbbEmpPosition = new System.Windows.Forms.ComboBox();
            this.rdoEmpSex3 = new System.Windows.Forms.RadioButton();
            this.rdoEmpSex2 = new System.Windows.Forms.RadioButton();
            this.rdoEmpSex1 = new System.Windows.Forms.RadioButton();
            this.mtbEmpIdCard = new System.Windows.Forms.MaskedTextBox();
            this.tbEmpPassword = new System.Windows.Forms.TextBox();
            this.tbEmpUser = new System.Windows.Forms.TextBox();
            this.tbEmpPhone = new System.Windows.Forms.TextBox();
            this.tbEmpEmail = new System.Windows.Forms.TextBox();
            this.tbEmpName = new System.Windows.Forms.TextBox();
            this.tbEmpId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.rdoSearch4 = new System.Windows.Forms.RadioButton();
            this.rdoSearch3 = new System.Windows.Forms.RadioButton();
            this.rdoSearch2 = new System.Windows.Forms.RadioButton();
            this.rdoSearch1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvShowEmployee = new System.Windows.Forms.DataGridView();
            this.รหัสพนักงาน = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpImage)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowEmployee)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1183, 142);
            this.panel1.TabIndex = 0;
            // 
            // tbGoToMainMenu
            // 
            this.tbGoToMainMenu.Location = new System.Drawing.Point(939, 44);
            this.tbGoToMainMenu.Name = "tbGoToMainMenu";
            this.tbGoToMainMenu.Size = new System.Drawing.Size(163, 60);
            this.tbGoToMainMenu.TabIndex = 3;
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
            this.label1.Text = "จัดการข้อมูลพนักงาน";
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
            this.toolStrip1.Size = new System.Drawing.Size(1183, 63);
            this.toolStrip1.TabIndex = 1;
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
            this.groupBox1.Controls.Add(this.btSelectEmpImage);
            this.groupBox1.Controls.Add(this.tbEmpDateOut);
            this.groupBox1.Controls.Add(this.pbEmpImage);
            this.groupBox1.Controls.Add(this.dtpEmpDateIn);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbbEmpStatus);
            this.groupBox1.Controls.Add(this.cbbEmpPosition);
            this.groupBox1.Controls.Add(this.rdoEmpSex3);
            this.groupBox1.Controls.Add(this.rdoEmpSex2);
            this.groupBox1.Controls.Add(this.rdoEmpSex1);
            this.groupBox1.Controls.Add(this.mtbEmpIdCard);
            this.groupBox1.Controls.Add(this.tbEmpPassword);
            this.groupBox1.Controls.Add(this.tbEmpUser);
            this.groupBox1.Controls.Add(this.tbEmpPhone);
            this.groupBox1.Controls.Add(this.tbEmpEmail);
            this.groupBox1.Controls.Add(this.tbEmpName);
            this.groupBox1.Controls.Add(this.tbEmpId);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(21, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 349);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลส่วนตัว";
            // 
            // btSelectEmpImage
            // 
            this.btSelectEmpImage.Location = new System.Drawing.Point(493, 136);
            this.btSelectEmpImage.Name = "btSelectEmpImage";
            this.btSelectEmpImage.Size = new System.Drawing.Size(35, 31);
            this.btSelectEmpImage.TabIndex = 33;
            this.btSelectEmpImage.Text = "...";
            this.btSelectEmpImage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSelectEmpImage.UseVisualStyleBackColor = true;
            this.btSelectEmpImage.Click += new System.EventHandler(this.btSelectEmpImage_Click);
            // 
            // tbEmpDateOut
            // 
            this.tbEmpDateOut.Location = new System.Drawing.Point(431, 259);
            this.tbEmpDateOut.Name = "tbEmpDateOut";
            this.tbEmpDateOut.Size = new System.Drawing.Size(106, 31);
            this.tbEmpDateOut.TabIndex = 29;
            // 
            // pbEmpImage
            // 
            this.pbEmpImage.Image = global::GUIProject02.Properties.Resources.employee;
            this.pbEmpImage.Location = new System.Drawing.Point(366, 25);
            this.pbEmpImage.Name = "pbEmpImage";
            this.pbEmpImage.Size = new System.Drawing.Size(121, 142);
            this.pbEmpImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEmpImage.TabIndex = 3;
            this.pbEmpImage.TabStop = false;
            // 
            // dtpEmpDateIn
            // 
            this.dtpEmpDateIn.Location = new System.Drawing.Point(431, 218);
            this.dtpEmpDateIn.Name = "dtpEmpDateIn";
            this.dtpEmpDateIn.Size = new System.Drawing.Size(106, 31);
            this.dtpEmpDateIn.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(299, 259);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 26);
            this.label13.TabIndex = 27;
            this.label13.Text = "วันที่ออกจากงาน:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(314, 222);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 26);
            this.label12.TabIndex = 26;
            this.label12.Text = "วันที่เข้าทำงาน:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbEmpStatus
            // 
            this.cbbEmpStatus.FormattingEnabled = true;
            this.cbbEmpStatus.Items.AddRange(new object[] {
            "ปกติ",
            "ลาออก",
            "ไล่ออก"});
            this.cbbEmpStatus.Location = new System.Drawing.Point(173, 252);
            this.cbbEmpStatus.Name = "cbbEmpStatus";
            this.cbbEmpStatus.Size = new System.Drawing.Size(121, 33);
            this.cbbEmpStatus.TabIndex = 25;
            this.cbbEmpStatus.Text = "-- เลือกสถานะพนักงาน";
            this.cbbEmpStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbEmpStatus_KeyPress);
            // 
            // cbbEmpPosition
            // 
            this.cbbEmpPosition.FormattingEnabled = true;
            this.cbbEmpPosition.Items.AddRange(new object[] {
            "เจ้าของร้าน",
            "บาลิสต้า",
            "พนักงานแคชเชียร์",
            "แม่บ้าน"});
            this.cbbEmpPosition.Location = new System.Drawing.Point(173, 220);
            this.cbbEmpPosition.Name = "cbbEmpPosition";
            this.cbbEmpPosition.Size = new System.Drawing.Size(121, 33);
            this.cbbEmpPosition.TabIndex = 24;
            this.cbbEmpPosition.Text = "-- เลือกตำแหน่งงาน";
            this.cbbEmpPosition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbEmpPosition_KeyPress);
            // 
            // rdoEmpSex3
            // 
            this.rdoEmpSex3.AutoSize = true;
            this.rdoEmpSex3.Location = new System.Drawing.Point(285, 127);
            this.rdoEmpSex3.Name = "rdoEmpSex3";
            this.rdoEmpSex3.Size = new System.Drawing.Size(67, 29);
            this.rdoEmpSex3.TabIndex = 23;
            this.rdoEmpSex3.TabStop = true;
            this.rdoEmpSex3.Text = "LGBT";
            this.rdoEmpSex3.UseVisualStyleBackColor = true;
            // 
            // rdoEmpSex2
            // 
            this.rdoEmpSex2.AutoSize = true;
            this.rdoEmpSex2.Location = new System.Drawing.Point(224, 127);
            this.rdoEmpSex2.Name = "rdoEmpSex2";
            this.rdoEmpSex2.Size = new System.Drawing.Size(65, 29);
            this.rdoEmpSex2.TabIndex = 22;
            this.rdoEmpSex2.TabStop = true;
            this.rdoEmpSex2.Text = "หญิง";
            this.rdoEmpSex2.UseVisualStyleBackColor = true;
            // 
            // rdoEmpSex1
            // 
            this.rdoEmpSex1.AutoSize = true;
            this.rdoEmpSex1.Checked = true;
            this.rdoEmpSex1.Location = new System.Drawing.Point(172, 127);
            this.rdoEmpSex1.Name = "rdoEmpSex1";
            this.rdoEmpSex1.Size = new System.Drawing.Size(56, 29);
            this.rdoEmpSex1.TabIndex = 21;
            this.rdoEmpSex1.TabStop = true;
            this.rdoEmpSex1.Text = "ชาย";
            this.rdoEmpSex1.UseVisualStyleBackColor = true;
            // 
            // mtbEmpIdCard
            // 
            this.mtbEmpIdCard.Location = new System.Drawing.Point(172, 57);
            this.mtbEmpIdCard.Mask = "0-0000-00000-00-0";
            this.mtbEmpIdCard.Name = "mtbEmpIdCard";
            this.mtbEmpIdCard.Size = new System.Drawing.Size(178, 31);
            this.mtbEmpIdCard.TabIndex = 20;
            // 
            // tbEmpPassword
            // 
            this.tbEmpPassword.Location = new System.Drawing.Point(172, 318);
            this.tbEmpPassword.Name = "tbEmpPassword";
            this.tbEmpPassword.PasswordChar = '*';
            this.tbEmpPassword.Size = new System.Drawing.Size(178, 31);
            this.tbEmpPassword.TabIndex = 19;
            // 
            // tbEmpUser
            // 
            this.tbEmpUser.Location = new System.Drawing.Point(172, 288);
            this.tbEmpUser.Name = "tbEmpUser";
            this.tbEmpUser.Size = new System.Drawing.Size(178, 31);
            this.tbEmpUser.TabIndex = 18;
            // 
            // tbEmpPhone
            // 
            this.tbEmpPhone.Location = new System.Drawing.Point(172, 158);
            this.tbEmpPhone.Name = "tbEmpPhone";
            this.tbEmpPhone.Size = new System.Drawing.Size(178, 31);
            this.tbEmpPhone.TabIndex = 14;
            // 
            // tbEmpEmail
            // 
            this.tbEmpEmail.Location = new System.Drawing.Point(172, 187);
            this.tbEmpEmail.Name = "tbEmpEmail";
            this.tbEmpEmail.Size = new System.Drawing.Size(178, 31);
            this.tbEmpEmail.TabIndex = 15;
            // 
            // tbEmpName
            // 
            this.tbEmpName.Location = new System.Drawing.Point(172, 88);
            this.tbEmpName.Name = "tbEmpName";
            this.tbEmpName.Size = new System.Drawing.Size(178, 31);
            this.tbEmpName.TabIndex = 12;
            // 
            // tbEmpId
            // 
            this.tbEmpId.Location = new System.Drawing.Point(172, 30);
            this.tbEmpId.Name = "tbEmpId";
            this.tbEmpId.Size = new System.Drawing.Size(178, 31);
            this.tbEmpId.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(48, 320);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 26);
            this.label11.TabIndex = 9;
            this.label11.Text = "รหัสผ่าน:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(48, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 26);
            this.label10.TabIndex = 8;
            this.label10.Text = "ชื่อผู้ใช้:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(20, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 26);
            this.label9.TabIndex = 7;
            this.label9.Text = "สถานะพนักงาน:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(48, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 26);
            this.label8.TabIndex = 6;
            this.label8.Text = "ตำเเหน่งงาน:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(48, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 26);
            this.label7.TabIndex = 5;
            this.label7.Text = "อีเมล์:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(48, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "เบอร์โทรศัพท์:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(48, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "เพศ:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(48, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "ชื่อ:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "รหัสบัตรประชาชน:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(48, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "รหัสพนักงาน: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.groupBox2.Location = new System.Drawing.Point(582, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 145);
            this.groupBox2.TabIndex = 3;
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
            this.rdoSearch3.Size = new System.Drawing.Size(134, 29);
            this.rdoSearch3.TabIndex = 32;
            this.rdoSearch3.Text = "ด้วยชื่อพนักงาน";
            this.rdoSearch3.UseVisualStyleBackColor = true;
            // 
            // rdoSearch2
            // 
            this.rdoSearch2.AutoSize = true;
            this.rdoSearch2.Location = new System.Drawing.Point(177, 30);
            this.rdoSearch2.Name = "rdoSearch2";
            this.rdoSearch2.Size = new System.Drawing.Size(144, 29);
            this.rdoSearch2.TabIndex = 31;
            this.rdoSearch2.Text = "ด้วยรหัสพนักงาน";
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvShowEmployee);
            this.groupBox3.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(582, 374);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(594, 184);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ข้อมูลพนักงาน";
            // 
            // dgvShowEmployee
            // 
            this.dgvShowEmployee.AllowUserToDeleteRows = false;
            this.dgvShowEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.รหัสพนักงาน,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvShowEmployee.Location = new System.Drawing.Point(15, 31);
            this.dgvShowEmployee.Name = "dgvShowEmployee";
            this.dgvShowEmployee.ReadOnly = true;
            this.dgvShowEmployee.RowTemplate.Height = 25;
            this.dgvShowEmployee.Size = new System.Drawing.Size(555, 150);
            this.dgvShowEmployee.TabIndex = 0;
            this.dgvShowEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowEmployee_CellClick);
            // 
            // รหัสพนักงาน
            // 
            this.รหัสพนักงาน.HeaderText = "รหัสพนักงาน";
            this.รหัสพนักงาน.Name = "รหัสพนักงาน";
            this.รหัสพนักงาน.ReadOnly = true;
            this.รหัสพนักงาน.Width = 110;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ชื่อพนักงาน";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ตำเเหน่ง";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "เบอร์โทรศัพท์";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 579);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "หน้าจอจัดการข้อมูลพนักงาน - SAU Coffee V.1.0";
            this.Load += new System.EventHandler(this.FrmEmployee_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpImage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowEmployee)).EndInit();
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
        private System.Windows.Forms.TextBox tbEmpDateOut;
        private System.Windows.Forms.PictureBox pbEmpImage;
        private System.Windows.Forms.DateTimePicker dtpEmpDateIn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbbEmpStatus;
        private System.Windows.Forms.ComboBox cbbEmpPosition;
        private System.Windows.Forms.RadioButton rdoEmpSex3;
        private System.Windows.Forms.RadioButton rdoEmpSex2;
        private System.Windows.Forms.RadioButton rdoEmpSex1;
        private System.Windows.Forms.MaskedTextBox mtbEmpIdCard;
        private System.Windows.Forms.TextBox tbEmpPassword;
        private System.Windows.Forms.TextBox tbEmpUser;
        private System.Windows.Forms.TextBox tbEmpPhone;
        private System.Windows.Forms.TextBox tbEmpEmail;
        private System.Windows.Forms.TextBox tbEmpName;
        private System.Windows.Forms.TextBox tbEmpId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.RadioButton rdoSearch4;
        private System.Windows.Forms.RadioButton rdoSearch3;
        private System.Windows.Forms.RadioButton rdoSearch2;
        private System.Windows.Forms.RadioButton rdoSearch1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvShowEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn รหัสพนักงาน;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btSelectEmpImage;
        private System.Windows.Forms.Button tbGoToMainMenu;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}