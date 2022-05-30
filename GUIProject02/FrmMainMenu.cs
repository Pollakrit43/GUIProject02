using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GUIProject02
{
    public partial class FrmMainMenu : Form
    {
        //กรณีการส่งข้อมูลมาพร้อมกับการเปิดหน้าจอ ให้กำหนดพรารมิเตอร์เพื่อเก็บข้อมูลที่จะส่งมา
        //public FrmMainMenu(string empId,string empName,string empPosition,string empImage)
        public FrmMainMenu()

        {
            InitializeComponent();
            lbEmpCode.Text = ShareDataValue.empId;
            lbEmpName.Text = ShareDataValue.empName;
            lbEmpPosition.Text = ShareDataValue.empPosition;
            //กรณีรูปภาพใน db เก็บป็น Base 64 ดังนั้นต้องเเปลง base 64 เป็น รูป
            byte[] bytes = Convert.FromBase64String(ShareDataValue.empImage);
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                pbEmpImage.Image = Image.FromStream(ms);
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string thMonth = "";
            switch (DateTime.Now.Month)
            {
                case 1: thMonth = "มกราคม";break;
                case 2: thMonth = "กุมภาพันธ์";break;
                case 3: thMonth = "มีนาคม";break;
                case 4: thMonth = "เมษายน";break;
                case 5: thMonth = "พฤษภาคม";break;
                case 6: thMonth = "มิถุนายน";break;
                case 7: thMonth = "กรกฎาคม";break;
                case 8: thMonth = "สิงหาคม";break;
                case 9: thMonth = "กันยายน";break;
                case 10: thMonth = "ตุลาคม";break;
                case 11: thMonth = "พฤศจิกายน";break;
                default : thMonth = "ธัยวาคม";break;
            }
            string showDataTime = DateTime.Now.Day.ToString() + " " + 
            thMonth + " พ.ศ. "  + 
            (DateTime.Now.Year + 543).ToString() + " " + 
            DateTime.Now.ToString("hh:mm:ss");


            //lbDateTime.Text = DateTime.Now.ToString("dd MMM yyyy hh:mm:ss");
            lbDateTime.Text = showDataTime;
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            this.Hide();
            frmLogin.Show();
        }

        private void btShop_Click(object sender, EventArgs e)
        {
            FrmShop frmShop = new FrmShop();
            this.Hide();
            frmShop.Show();
        }

        private void btCustomer_Click(object sender, EventArgs e)
        {
            FrmCustomer frmCustomer = new FrmCustomer();
            this.Hide();
            frmCustomer.Show();
        }

        private void btEmployee_Click(object sender, EventArgs e)
        {
            FrmEmployee frmEmployee = new FrmEmployee();
            this.Hide();
            frmEmployee.Show();
        }

        private void btReport_Click(object sender, EventArgs e)
        {
            FrmReport frmReport = new FrmReport();
            this.Hide();
            frmReport.Show();
        }
    }
}
