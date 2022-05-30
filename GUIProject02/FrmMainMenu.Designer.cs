
namespace GUIProject02
{
    partial class FrmMainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btLogout = new System.Windows.Forms.Button();
            this.lbEmpPosition = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbEmpName = new System.Windows.Forms.Label();
            this.lbEmpCode = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbEmpImage = new System.Windows.Forms.PictureBox();
            this.lbDateTime = new System.Windows.Forms.Label();
            this.btShop = new System.Windows.Forms.Button();
            this.btCustomer = new System.Windows.Forms.Button();
            this.btEmployee = new System.Windows.Forms.Button();
            this.btReport = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btLogout);
            this.panel1.Controls.Add(this.lbEmpPosition);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbEmpName);
            this.panel1.Controls.Add(this.lbEmpCode);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbEmpImage);
            this.panel1.Controls.Add(this.lbDateTime);
            this.panel1.Location = new System.Drawing.Point(138, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 117);
            this.panel1.TabIndex = 1;
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.Color.Silver;
            this.btLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btLogout.Location = new System.Drawing.Point(415, 8);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(122, 97);
            this.btLogout.TabIndex = 9;
            this.btLogout.Text = "ออกจากระบบ";
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // lbEmpPosition
            // 
            this.lbEmpPosition.BackColor = System.Drawing.Color.NavajoWhite;
            this.lbEmpPosition.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmpPosition.Location = new System.Drawing.Point(197, 82);
            this.lbEmpPosition.Name = "lbEmpPosition";
            this.lbEmpPosition.Size = new System.Drawing.Size(181, 23);
            this.lbEmpPosition.TabIndex = 6;
            this.lbEmpPosition.Text = "XXXXX";
            this.lbEmpPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(122, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "ตำเเหน่ง:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbEmpName
            // 
            this.lbEmpName.BackColor = System.Drawing.Color.NavajoWhite;
            this.lbEmpName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmpName.Location = new System.Drawing.Point(197, 55);
            this.lbEmpName.Name = "lbEmpName";
            this.lbEmpName.Size = new System.Drawing.Size(181, 23);
            this.lbEmpName.TabIndex = 8;
            this.lbEmpName.Text = "XXXXX";
            this.lbEmpName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbEmpCode
            // 
            this.lbEmpCode.BackColor = System.Drawing.Color.NavajoWhite;
            this.lbEmpCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmpCode.Location = new System.Drawing.Point(197, 28);
            this.lbEmpCode.Name = "lbEmpCode";
            this.lbEmpCode.Size = new System.Drawing.Size(181, 23);
            this.lbEmpCode.TabIndex = 7;
            this.lbEmpCode.Text = "XXXXX";
            this.lbEmpCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(86, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "ชื่อพนักงาน:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(87, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "รหัสพนักงาน:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(122, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "วัน-เวลา:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbEmpImage
            // 
            this.pbEmpImage.Image = ((System.Drawing.Image)(resources.GetObject("pbEmpImage.Image")));
            this.pbEmpImage.Location = new System.Drawing.Point(3, 8);
            this.pbEmpImage.Name = "pbEmpImage";
            this.pbEmpImage.Size = new System.Drawing.Size(87, 104);
            this.pbEmpImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEmpImage.TabIndex = 0;
            this.pbEmpImage.TabStop = false;
            // 
            // lbDateTime
            // 
            this.lbDateTime.BackColor = System.Drawing.Color.NavajoWhite;
            this.lbDateTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDateTime.Location = new System.Drawing.Point(197, 0);
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(181, 23);
            this.lbDateTime.TabIndex = 5;
            this.lbDateTime.Text = "XXXXX";
            this.lbDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btShop
            // 
            this.btShop.Image = ((System.Drawing.Image)(resources.GetObject("btShop.Image")));
            this.btShop.Location = new System.Drawing.Point(12, 137);
            this.btShop.Name = "btShop";
            this.btShop.Size = new System.Drawing.Size(149, 170);
            this.btShop.TabIndex = 10;
            this.btShop.Text = "บริหารจัดการหน้าร้าน";
            this.btShop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btShop.UseVisualStyleBackColor = true;
            this.btShop.Click += new System.EventHandler(this.btShop_Click);
            // 
            // btCustomer
            // 
            this.btCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btCustomer.Image")));
            this.btCustomer.Location = new System.Drawing.Point(191, 137);
            this.btCustomer.Name = "btCustomer";
            this.btCustomer.Size = new System.Drawing.Size(149, 170);
            this.btCustomer.TabIndex = 11;
            this.btCustomer.Text = "จัดการข้อมูลลูกค้า";
            this.btCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCustomer.UseVisualStyleBackColor = true;
            this.btCustomer.Click += new System.EventHandler(this.btCustomer_Click);
            // 
            // btEmployee
            // 
            this.btEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btEmployee.Image")));
            this.btEmployee.Location = new System.Drawing.Point(368, 137);
            this.btEmployee.Name = "btEmployee";
            this.btEmployee.Size = new System.Drawing.Size(149, 170);
            this.btEmployee.TabIndex = 12;
            this.btEmployee.Text = "จัดการข้อมูลพนักงาน";
            this.btEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEmployee.UseVisualStyleBackColor = true;
            this.btEmployee.Click += new System.EventHandler(this.btEmployee_Click);
            // 
            // btReport
            // 
            this.btReport.Image = ((System.Drawing.Image)(resources.GetObject("btReport.Image")));
            this.btReport.Location = new System.Drawing.Point(551, 137);
            this.btReport.Name = "btReport";
            this.btReport.Size = new System.Drawing.Size(149, 170);
            this.btReport.TabIndex = 13;
            this.btReport.Text = "รายงาน";
            this.btReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btReport.UseVisualStyleBackColor = true;
            this.btReport.Click += new System.EventHandler(this.btReport_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(730, 319);
            this.Controls.Add(this.btReport);
            this.Controls.Add(this.btEmployee);
            this.Controls.Add(this.btCustomer);
            this.Controls.Add(this.btShop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "หน้าจอหลัก - SAU Coffee V.1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbEmpImage;
        private System.Windows.Forms.Label lbEmpName;
        private System.Windows.Forms.Label lbEmpCode;
        private System.Windows.Forms.Label lbEmpPosition;
        private System.Windows.Forms.Label lbDateTime;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btShop;
        private System.Windows.Forms.Button btCustomer;
        private System.Windows.Forms.Button btEmployee;
        private System.Windows.Forms.Button btReport;
        private System.Windows.Forms.Timer timer1;
    }
}