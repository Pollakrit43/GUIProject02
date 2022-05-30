using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace GUIProject02
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void warningMSG(string msg)
        {
            MessageBox.Show(msg,"คำเตือน",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            //ตรวจสอบก่อนว่าผู้ใช้ได้ป้อนข้อมูลครบหรือยัง
            if (tbUsername.Text.Trim().Length==0)
            {
                warningMSG("ป้อนชื่อผู้ใช้ด้วย");
            }
            else if (tbPassword.Text.Trim().Length ==0)
            {
                warningMSG("ป้อนรหัสด้วย");
            }
            else
            {
                //เมื่อป้อนครบหมด ต่อไปก็ติดต่อไปยังฐานข้อมูล saucoffeeshop_db
                //เพื่อดูว่า ชื่อผู้ใช้เเละรหัสนี้มีไหมที่ตาราง employee_tb
                //การทำงานกับฐานข้อมูล
                //1.สร้างออปเจคเพื่อติดต่อไปยังฐานข้อมูล
                SqlConnection conn = new SqlConnection(ShareDataValue.connStr);
                try
                {
                    //2.ทำงานติดต่อไปยังฐานข้อมูล โดยตรวจสอบว่ามี connection อะไรค้างอยู่ก่อนไหม
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                    conn.Open();

                    //3.สร้างคำสั่ง sql เพื่อคำงานกับฐานข้อมูล ในที่นี้คือหาดูว่า username/password ที่ป้อนมามีไหม
                    string strSql = "SELECT * FROM employee_tb WHERE empUsername=@empUsername and empPassword=@empPassword";

                    //4.สร้างออปเจค sqlcommand เพื่อใช้งานกับชุดคำสั่ง sql
                    SqlTransaction sqlTransaction = conn.BeginTransaction();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = conn;
                    sqlCommand.Transaction = sqlTransaction;
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = strSql;
                    //กำหนดค่าให้กับพารามีเตอร์ @ ที่คำสั่ง SQL ถ้ามี
                    sqlCommand.Parameters.Add("@empUsername",SqlDbType.NVarChar,30).Value = tbUsername.Text.Trim();
                    sqlCommand.Parameters.Add("@empPassword",SqlDbType.NVarChar,30).Value = tbPassword.Text.Trim();

                    //5.สั่งให้ sql ทำงาน โดยผลที่ได้จะเก็บในตัวเเปร sqlDataReader นี้
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    //6.นำผลที่ได้จากการสั่งให้ sql ทำงานมาใช้ ณ ที่นี้คือตรวจสอบว่ามีไหม
                    if (sqlDataReader.HasRows)
                    {
                        sqlDataReader.Read();
                        ShareDataValue.empId = sqlDataReader["empId"].ToString(); 
                        ShareDataValue.empName = sqlDataReader["empName"].ToString(); 
                        ShareDataValue.empPosition = sqlDataReader["empPosition"].ToString(); 
                        ShareDataValue.empImage = sqlDataReader["empImage"].ToString(); 
                        //เเปลว่ามีข้อมูล ให้เปิดหน้าจอ Mainmenu
                        //ก่อนจะเปิดไปหน้า Mainmenu เราต้องส่งข้อมูลไปด้วย ชึ่งอยู่ใน sqldatareader
                        //FrmMainMenu frmMainMenu = new FrmMainMenu(
                        //sqlDataReader["empId"].ToString(),
                        //sqlDataReader["empName"].ToString(),
                        //sqlDataReader["empPosition"].ToString(),
                        //sqlDataReader["empImage"].ToString()
                        //);
                        FrmMainMenu frmMainMenu = new FrmMainMenu();
                        this.Hide();
                        frmMainMenu.Show();
                        //
                    }
                    else
                    {
                        //เเปลว่าไม่มีข้อมูล ให้เเสดง warningMSG เตือน
                        warningMSG("ชื่อผู้ใช้เเละรหัสผ่านไม่ถูกต้อง....!!!!");

                    }


                }
                catch (SqlException ex)
                {
                    warningMSG("พบปัญหาในการทำงานกับฐานข้อมูล....!!!!");
                }

                //7.ยกเลิกการเชื่อมต่อ
                conn.Close();


            }
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ตรวจสอบว่าเป็นการกดปุ่ม Enter หรือไม่
            if (e.KeyChar == (char)Keys.Enter  )
            {
                btLogin.PerformClick();
            }
        }
    }
}
