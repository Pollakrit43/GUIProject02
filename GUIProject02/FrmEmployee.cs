using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;



namespace GUIProject02
{
    public partial class FrmEmployee : Form
    {
        private string flagSave = "";
        private string empImageFileName = "";
        private DataTable dt = new DataTable(); //เอาไปใช้กับผลลัพธ์ที่เก็บอยู่ใน SQLDataAdapter
        private string empImageForUpdate = "";

        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {

        }

        private void tbGoToMainMenu_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            this.Hide();
            frmMainMenu.Show();
        }

        private void cbbEmpPosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            //กำหนดให้ combo box คีย์ไม่ได้
            e.Handled = true;
        }

        private void cbbEmpStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            //กำหนดให้ combo box คีย์ไม่ได้
            e.Handled = true;
        }

        private void tsbtCancel_Click(object sender, EventArgs e)
        {
            //clear ทุกอย่างให้เป็นเหมือนเดิม
            tbEmpId.Clear();
            mtbEmpIdCard.Clear();
            tbEmpName.Clear();
            rdoEmpSex1.Checked = true;
            tbEmpPhone.Clear();
            tbEmpEmail.Clear();
            cbbEmpPosition.Text = "-- เลือกตำแหน่งงาน";
            cbbEmpStatus.Text = "-- เลือกสถานะพนักงาน";
            dtpEmpDateIn.Value = DateTime.Now;
            tbEmpDateOut.Clear();
            tbEmpUser.Clear();
            tbEmpPassword.Clear();
            rdoEmpSex1.Checked = true;
            tbSearch.Clear();
            dgvShowEmployee.DataSource = null;
            //หรือใช้ 
            //dgvShowEmployee.Rows.Clear();
            //dgvShowEmployee.Refresh();
            pbEmpImage.Image = Properties.Resources.employee;
            flagSave = "";
            tbEmpId.Enabled = true;
            tbEmpDateOut.Enabled = true;
            empImageFileName = "";
            //Clear ข้อมูล DataTable ก่อนทุกครั้งที่กดปุ่มค้นหา
            dt.Clear();
        }
        private void warningMSG(string msg)
        {
            MessageBox.Show(msg, "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void tsbtAdd_Click(object sender, EventArgs e)
        {
            //clear ข้อมูลทุกอย่างบนหน้าจอก่อน
            tsbtCancel.PerformClick();

            //กำหนดค่า flagsave เพื่อไปใช้กับปุ่มบันทึก
            flagSave = "insert";


            //จะไปดูว่าตอนนี้ใน db รหัสพนักงานล่าสุดอนู่ที่รหัสอะไร
            //เเล้วก็เขียนโค้ดว่าสร้างรหัสพนักงานเเสดงที่หน้าจอ
            //โดยที่จะต้องล็อคไม่ให้ผู้ใช้คีย์รหัสพนักงานได้ คือ ไม่ให้ป้อนข้อมูล
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
                string strSql = "SELECT empId FROM employee_tb ORDER BY empId DESC";

                //4.สร้างออปเจค sqlcommand เพื่อใช้งานกับชุดคำสั่ง sql
                SqlTransaction sqlTransaction = conn.BeginTransaction();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = conn;
                sqlCommand.Transaction = sqlTransaction;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = strSql;

                //5.สั่งให้ sql ทำงาน โดยผลที่ได้จะเก็บในตัวเเปร sqlDataReader นี้
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                //6.นำผลที่ได้จากการสั่งให้ sql ทำงานมาใช้ ณ ที่นี้คือตรวจสอบว่ามีไหม
                if (sqlDataReader.HasRows)
                {
                    //เเปลว่ามีข้อมูล ให้เปิดหน้า จอ mainmenu
                    //ก่อนจะเปิดไปหน้่า mainmenu
                    sqlDataReader.Read();

                    //กำหนดค่าที่อยู่ใน sqldatareader หลังจากการอ่านข้อมูลให้กับตัวเเปรตัวหนึ่ง
                    string empIdCurrent = sqlDataReader["empId"].ToString();//emp00000
                    int numberIdCurrent = Convert.ToInt32(empIdCurrent.Substring(3, 5));
                    int newId = numberIdCurrent + 1;
                    string empIdNew = "emp" + newId.ToString("00000");
                    tbEmpId.Text = empIdNew;
                    tbEmpId.Enabled = false;
                    tbEmpDateOut.Enabled = false;

                }

            }
            catch (SqlException ex)
            {
                warningMSG("พบปัญหาในการทำงานกับฐานข้อมูล....!!!!" + ex.Message);
            }

            finally
            {
                //7.ยกเลิกการเชื่อมต่อ
                conn.Close();
            }




        }

        private void tsbtUpdate_Click(object sender, EventArgs e)
        {
            flagSave = "update";
        }

        private void tsbtSave_Click(object sender, EventArgs e)
        {
            if (flagSave == "insert")
            {
                //โค้ดบันทึกข้อมูลพนักงานใหม่
                //ต้อง validate (ตรวจสอบเบื้องต้น) ว่าผู้ใช้กรอกข้อมูลครบถ้วนไหม
                if (tbEmpId.Text.Trim().Length == 0)
                {
                    warningMSG("ตรวจสอบรหัสพนักงานด้วย");
                }
                else if (mtbEmpIdCard.MaskCompleted == false)
                {
                    warningMSG("ตรวจสอบรหัสบัตรประชาชนด้วยด้วย");
                }
                else if (tbEmpName.Text.Trim().Length == 0)
                {
                    warningMSG("ตรวจสอบชื่อด้วย");
                }
                else if (cbbEmpPosition.Text == "-- เลือกตำแหน่งงาน")
                {
                    warningMSG("ตรวจสอบเลือกตำแหน่งงานด้วย");
                }
                else if (cbbEmpStatus.Text == "-- เลือกสถานะพนักงาน")
                {
                    warningMSG("ตรวจสอบเลือกสถานะพนักงานด้วย");
                }
                else if (tbEmpUser.Text.Trim().Length == 0)
                {
                    warningMSG("ตรวจสอบชื่อผู้ใช้ด้วย");
                }
                else if (tbEmpPassword.Text.Trim().Length == 0)
                {
                    warningMSG("ตรวจสอบรหัสผ่านด้วย");
                }
                else if (tbEmpPassword.Text.Trim().Length < 6)
                {
                    warningMSG("ตรวจสอบรหัสผ่านด้วยต้อง 6 ตัวขึ้นไป");
                }
                else if (empImageFileName == "")//ตรวจสอบว่าได้เลือกรูปหรือยัง
                {
                    warningMSG("ตรวจสอบการเลือกรูปด้วย");
                }
                else
                {
                    //โค้ดบันทึกเพิ่ม insert ข้อมูลตาราง
                    //1.
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
                        string strSql = "INSERT INTO employee_tb";
                        strSql += "(empId, empIdCard, empName, empImage, empSex, empPhone, empEmail, empPosition, empStatus, empDateIn, empDateOut, empUsername, empPassword)";
                        strSql += "VALUES ";
                        strSql += "(@empId, @empIdCard, @empName, @empImage, @empSex, @empPhone, @empEmail, @empPosition, @empStatus, @empDateIn, @empDateOut, @empUsername, @empPassword)";

                        //4.สร้างออปเจค sqlcommand เพื่อใช้งานกับชุดคำสั่ง sql
                        SqlTransaction sqlTransaction = conn.BeginTransaction();
                        SqlCommand sqlCommand = new SqlCommand();
                        sqlCommand.Connection = conn;
                        sqlCommand.Transaction = sqlTransaction;
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.CommandText = strSql;
                        //ด้วยความที่มีพารามิเตอร์ @ ต้องนำข้อมูลมากำหนดให้กับพารามิเตอร์
                        sqlCommand.Parameters.Add("@empId", SqlDbType.NVarChar, 8).Value = tbEmpId.Text;
                        sqlCommand.Parameters.Add("@empIdCard", SqlDbType.NVarChar, 17).Value = mtbEmpIdCard.Text;
                        sqlCommand.Parameters.Add("@empName", SqlDbType.NVarChar, 30).Value = tbEmpName.Text;
                        //รูป
                        byte[] data = File.ReadAllBytes(empImageFileName);
                        string base64Image = Convert.ToBase64String(data);
                        sqlCommand.Parameters.Add("@empImage", SqlDbType.NVarChar).Value = base64Image;
                        //เพศ
                        int sex;
                        if (rdoEmpSex1.Checked == true)
                        {
                            sex = 1;
                        }
                        else if (rdoEmpSex2.Checked == true)
                        {
                            sex = 2;
                        }
                        else
                        {
                            sex = 3;
                        }
                        sqlCommand.Parameters.Add("@empSex", SqlDbType.Int).Value = sex;
                        sqlCommand.Parameters.Add("@empPhone", SqlDbType.NVarChar, 20).Value = tbEmpPhone.Text.Trim();
                        sqlCommand.Parameters.Add("@empEmail", SqlDbType.NVarChar, 30).Value = tbEmpEmail.Text.Trim();
                        sqlCommand.Parameters.Add("@empPosition", SqlDbType.NVarChar, 30).Value = cbbEmpPosition.Text.Trim();
                        //สถานะ
                        int empstatus;
                        if (cbbEmpStatus.Text == "ปกตื")
                        {
                            empstatus = 1;
                        }
                        else if (cbbEmpStatus.Text == "ลาออก")
                        {
                            empstatus = 2;
                        }
                        else
                        {
                            empstatus = 3;
                        }
                        sqlCommand.Parameters.Add("@empStatus", SqlDbType.Int).Value = empstatus;
                        sqlCommand.Parameters.Add("@empDateIn", SqlDbType.Date).Value = dtpEmpDateIn.Value.Date;
                        sqlCommand.Parameters.Add("@empDateOut", SqlDbType.NVarChar, 30).Value = tbEmpDateOut.Text.Trim();
                        sqlCommand.Parameters.Add("@empUserName", SqlDbType.NVarChar, 30).Value = tbEmpUser.Text.Trim();
                        sqlCommand.Parameters.Add("@empPassword", SqlDbType.NVarChar, 30).Value = tbEmpPassword.Text.Trim();

                        //5.สั่ง SQL ทำงาน ในที่นี้เพื่อบันทึก insert ข้อมูลลงตาราง
                        sqlCommand.ExecuteNonQuery();
                        sqlTransaction.Commit();


                        //6.เมื่อทำการบันทึกเสจเเจ้งผลการทำงานให้ผู้ใช้ทราบ
                        MessageBox.Show("บันทึกข้อมูลเรียบร้อยเเล้ว", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //เคลียหน้าจอหลังจากบันทึกเเล้ว
                        tsbtCancel.PerformClick();
                    }
                    catch (SqlException ex)
                    {
                        warningMSG("พบปัญหาในการทำงานกับฐานข้อมูล....!!!!" + ex.Message);

                    }
                    finally
                    {
                        //7.ยกเลิกการเชื่อมต่อ
                        conn.Close();
                    }
                } 
            }
            else if (flagSave == "update")
            {
                //โค้ดเเก้ไขข้อมูลพนักงาน
                if (tbEmpId.Text.Trim().Length == 0)
                {
                    warningMSG("กรุณาเลือกข้อมูลพนักงานที่จะเเก้ไขด้วย");
                }
                if (tbEmpId.Text.Trim().Length == 0)
                {
                    warningMSG("ตรวจสอบรหัสพนักงานด้วย");
                }
                else if (mtbEmpIdCard.MaskCompleted == false)
                {
                    warningMSG("ตรวจสอบรหัสบัตรประชาชนด้วยด้วย");
                }
                else if (tbEmpName.Text.Trim().Length == 0)
                {
                    warningMSG("ตรวจสอบชื่อด้วย");
                }
                else if (cbbEmpPosition.Text == "-- เลือกตำแหน่งงาน")
                {
                    warningMSG("ตรวจสอบเลือกตำแหน่งงานด้วย");
                }
                else if (cbbEmpStatus.Text == "-- เลือกสถานะพนักงาน")
                {
                    warningMSG("ตรวจสอบเลือกสถานะพนักงานด้วย");
                }
                else if (tbEmpUser.Text.Trim().Length == 0)
                {
                    warningMSG("ตรวจสอบชื่อผู้ใช้ด้วย");
                }
                else if (tbEmpPassword.Text.Trim().Length == 0)
                {
                    warningMSG("ตรวจสอบรหัสผ่านด้วย");
                }
                else if (tbEmpPassword.Text.Trim().Length < 6)
                {
                    warningMSG("ตรวจสอบรหัสผ่านด้วยต้อง 6 ตัวขึ้นไป");
                }
                else
                {
                    //โค้ดเเก้ UPDATE ไขข้อมูลในฐานข้อมูล
                    //1.
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
                        //string strSql = "INSERT INTO employee_tb";
                        //strSql += "(empId, empIdCard, empName, empImage, empSex, empPhone, empEmail, empPosition, empDateIn, empDateOut, empUsername, empPassword)";
                        //strSql += "VALUES ";
                        //strSql += "(@empId, @empIdCard, @empName, @empImage, @empSex, @empPhone, @empEmail, @empPosition, @empDateIn, @empDateOut, @empUsername, @empPassword)";
                        string strSql = "UPDATE employee_tb SET empIdCard=@empIdCard, empName=@empName, empImage=@empImage, empSex=@empSex, empPhone=@empPhone, empEmail=@empEmail, empPosition=@empPosition, empStatus=@empStatus, empDateIn=@empDateIn, empDateOut=@empDateOut, empUsername=@empUsername, empPassword=@empPassword WHERE empId=@empId";

                        //4.สร้างออปเจค sqlcommand เพื่อใช้งานกับชุดคำสั่ง sql
                        SqlTransaction sqlTransaction = conn.BeginTransaction();
                        SqlCommand sqlCommand = new SqlCommand();
                        sqlCommand.Connection = conn;
                        sqlCommand.Transaction = sqlTransaction;
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.CommandText = strSql;
                        //ด้วยความที่มีพารามิเตอร์ @ ต้องนำข้อมูลมากำหนดให้กับพารามิเตอร์
                        sqlCommand.Parameters.Add("@empId", SqlDbType.NVarChar, 8).Value = tbEmpId.Text;
                        sqlCommand.Parameters.Add("@empIdCard", SqlDbType.NVarChar, 17).Value = mtbEmpIdCard.Text;
                        sqlCommand.Parameters.Add("@empName", SqlDbType.NVarChar, 30).Value = tbEmpName.Text;
                        //รูป ตรวจรูปต้องตรวจสอบว่าได้กเเก้ไหม ถ้าไม่เเก้ก็๋ใช้รูปเดิม เเต่ถ้าเเก้ใช้รูปใหม่
                        if (empImageFileName.Length != 0)
                        {
                            //กรณีเลือกณูปใหม่
                            byte[] data = File.ReadAllBytes(empImageFileName);
                            string base64Image = Convert.ToBase64String(data);
                            sqlCommand.Parameters.Add("@empImage", SqlDbType.NVarChar).Value = base64Image;
                        }
                        else
                        {
                            //ใช้รูปเดิม
                            sqlCommand.Parameters.Add("@empImage", SqlDbType.NVarChar).Value = empImageForUpdate;

                        }
                        //เพศ
                        int sex;
                        if (rdoEmpSex1.Checked == true)
                        {
                            sex = 1;
                        }
                        else if (rdoEmpSex2.Checked == true)
                        {
                            sex = 2;
                        }
                        else
                        {
                            sex = 3;
                        }
                        sqlCommand.Parameters.Add("@empSex", SqlDbType.Int).Value = sex;
                        sqlCommand.Parameters.Add("@empPhone", SqlDbType.NVarChar, 20).Value = tbEmpPhone.Text.Trim();
                        sqlCommand.Parameters.Add("@empEmail", SqlDbType.NVarChar, 30).Value = tbEmpEmail.Text.Trim();
                        sqlCommand.Parameters.Add("@empPosition", SqlDbType.NVarChar, 30).Value = cbbEmpPosition.Text.Trim();
                        //สถานะ
                        int empstatus;
                        if (cbbEmpStatus.Text == "ปกตื")
                        {
                            empstatus = 1;
                        }
                        else if (cbbEmpStatus.Text == "ลาอกก")
                        {
                            empstatus = 2;
                        }
                        else
                        {
                            empstatus = 3;
                        }
                        sqlCommand.Parameters.Add("@empStatus", SqlDbType.Int).Value = empstatus;
                        sqlCommand.Parameters.Add("@empDateIn", SqlDbType.Date).Value = dtpEmpDateIn.Value.Date;
                        sqlCommand.Parameters.Add("@empDateOut", SqlDbType.NVarChar, 30).Value = tbEmpDateOut.Text.Trim();
                        sqlCommand.Parameters.Add("@empUserName", SqlDbType.NVarChar, 30).Value = tbEmpUser.Text.Trim();
                        sqlCommand.Parameters.Add("@empPassword", SqlDbType.NVarChar, 30).Value = tbEmpPassword.Text.Trim();

                        //5.สั่ง SQL ทำงาน ในที่นี้เพื่อบันทึก insert ข้อมูลลงตาราง
                        sqlCommand.ExecuteNonQuery();
                        sqlTransaction.Commit();


                        //6.เมื่อทำการบันทึกเสจเเจ้งผลการทำงานให้ผู้ใช้ทราบ
                        MessageBox.Show("บันทึกข้อมูลเรียบร้อยเเล้ว", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //เคลียหน้าจอหลังจากบันทึกเเล้ว
                        tsbtCancel.PerformClick();
                    }
                    catch (SqlException ex)
                    {
                        warningMSG("พบปัญหาในการทำงานกับฐานข้อมูล....!!!!" + ex.Message);

                    }
                    finally
                    {
                        //7.ยกเลิกการเชื่อมต่อ
                        conn.Close();
                    }

                }
            }
            else
            {
                //เเสดง MSG เพื่อเเจ้งผู้ใช้ว่าจะเพอ่มพนักงานใหม่หรือเเก้ไขข้อมูลกนักงาน
                warningMSG("กรุณาคลิกเลือก\"เพิ่ม\"หรือ\"เเก้ไข\"ก่อนกดปุ่มบันทึกด้วย");
            }             
        }

        private void btSelectEmpImage_Click(object sender, EventArgs e)
        {
            //ขะเปิด openfiledialog ให้ผู้ใช้เลือกรูป เเล้วเเดงที่ picture box 
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "กรุณาเลือกรูปพนักงาน";
            openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";

            //เเสดง openfiledialog โดยมีการตรวจสอบว่า
            //หลังจากเลือกเเล้วกด ok ให้นำรูปที่เลือกไปเเสดง picturebox -> pbEmpImage
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbEmpImage.Image = Image.FromFile(openFileDialog1.FileName);
                empImageFileName = openFileDialog1.FileName;
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            //Clear ข้อมูล DataTable ก่อนทุกครั้งที่กดปุ่มค้นหา
            dt.Clear();
            //ล้างหน้าจอด้วย คือเรียกใช้โค้ดปุ่มยกเลิกให้ทำงาน

            //ตรวจสอบว่าผู้ใช้เลือกค้นหาด้วยอะไร หากไม่ใช่เลือกเเสดงทั้งหมด
            //ต้องมีการป้อนที่ช่อง tbSearch
            if (rdoSearch1.Checked == false && tbSearch.Text.Trim().Length == 0)
            {
                warningMSG("ป้อนข้อมูลที่จะค้าหาด้วยย");
            }
            else
            {
                //ค้าหาข้อมูลในฐานข้อมูลตามเงื่อนไขที่เลือกเเล้วเเดงที่ datagridview : dvgshowemployee
                //ในที่นี้คือการไป SELECT 
                //1.
                SqlConnection conn = new SqlConnection(ShareDataValue.connStr);
                try
                {
                    //2.ทำงานติดต่อไปยังฐานข้อมูล โดยตรวจสอบว่ามี connection อะไรค้างอยู่ก่อนไหม
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                    conn.Open();
                    //3.สร้างคำสั่ง sql เพื่อคำงานกับฐานข้อมูล 
                    //คำสั่ง SQL SELECT ในส่วนนี้จะมีหลายเเบบ เพราะ การค้าหามีหลายเงือนไข

                    string strSql = "";
                    if (rdoSearch1.Checked == true)
                    {
                        strSql = "SELECT * FROM employee_tb";
                    }
                    else if (rdoSearch2.Checked == true)
                    {
                        strSql = "SELECT * FROM employee_tb WHERE empId = @value";
                    }
                    else if (rdoSearch3.Checked == true)
                    {
                        strSql = "SELECT * FROM employee_tb WHERE empName LIKE '%' + @value + '%'";
                    }
                    else
                    {
                        strSql = "SELECT * FROM employee_tb WHERE empPhone = @value";
                    }

                    //4.สร้างออปเจค sqlcommand เพื่อใช้งานกับชุดคำสั่ง sql
                    SqlTransaction sqlTransaction = conn.BeginTransaction();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = conn;
                    sqlCommand.Transaction = sqlTransaction;
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = strSql;
                    //ด้วยความที่มีพารามิเตอร์ @ ต้องนำข้อมูลมากำหนดให้กับพารามิเตอร์
                    //ในที่นี้กรณีไม่ได้เลือกค้นหาเเสดงข้อมูลทั้งหมด
                    if (rdoSearch1.Checked == false)
                    {
                        sqlCommand.Parameters.Add("@value", SqlDbType.VarChar).Value = tbSearch.Text;
                    }

                    //5.สั่งให้ SQL ทำงาน
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    //เอาข้อมูล SqlDataAdapter ไปกำหนดให้กับ DataTable เผื่อเอาไปใช้งาน
                    da.Fill(dt);
                    //ตรวจสอบข้อมูลว่ามีมั้ย ใน DataTable
                    if (dt.Rows.Count <= 0)
                    {
                        //ไม่มีขช้อมูลที่ค้นหา
                        warningMSG("ไม่มีข้อมูลที่ค้าหา");
                    }
                    else
                    {
                        //มีข้อมูล ในที่เราจะเอาข้อมูลไปกำหนดให้กับ DataGridView: dgvShowEmployee
                        dgvShowEmployee.AutoGenerateColumns = false;
                        dgvShowEmployee.Columns[0].DataPropertyName = "empId";
                        dgvShowEmployee.Columns[1].DataPropertyName = "empName";
                        dgvShowEmployee.Columns[2].DataPropertyName = "empPosition";
                        dgvShowEmployee.Columns[3].DataPropertyName = "empPhone";
                        //ผูก DataGridView:dgvShowEmployee เข้ากับ DataTable: dt
                        dgvShowEmployee.DataSource = dt;
                    }
                }
                catch (SqlException ex)
                {
                    warningMSG("พบปัญหาในการทำงานกับฐานข้อมูล....!!!!" + ex.Message);
                }
                finally
                {
                    //7.ยกเลิกการเชื่อมต่อ
                    conn.Close();
                }
            }          
        }
        private void dgvShowEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbEmpId.Enabled = false;
            tbEmpId.Text = dt.Rows[dgvShowEmployee.CurrentRow.Index]["empId"].ToString();
            tbEmpName.Text = dt.Rows[dgvShowEmployee.CurrentRow.Index]["empName"].ToString();
            mtbEmpIdCard.Text = dt.Rows[dgvShowEmployee.CurrentRow.Index]["empIdCard"].ToString();
            if (Convert.ToInt32(dt.Rows[dgvShowEmployee.CurrentRow.Index]["empSex"].ToString()) == 1)
            {
                rdoEmpSex1.Checked = true;
            }
            else if (Convert.ToInt32(dt.Rows[dgvShowEmployee.CurrentRow.Index]["empSex"].ToString()) == 2)
            {
                rdoEmpSex2.Checked = true;
            }
            else
            {
                rdoEmpSex3.Checked = true;
            }
            tbEmpPhone.Text = dt.Rows[dgvShowEmployee.CurrentRow.Index]["empPhone"].ToString();
            tbEmpEmail.Text = dt.Rows[dgvShowEmployee.CurrentRow.Index]["empEmail"].ToString();
            cbbEmpPosition.Text = dt.Rows[dgvShowEmployee.CurrentRow.Index]["empPosition"].ToString();
            if (Convert.ToInt32(dt.Rows[dgvShowEmployee.CurrentRow.Index]["empStatus"].ToString()) == 1)
            {
                cbbEmpStatus.Text = "ปกติ";
            }
            else if (Convert.ToInt32(dt.Rows[dgvShowEmployee.CurrentRow.Index]["empStatus"].ToString()) == 2)
            {
                cbbEmpStatus.Text = "ลาออก";
            }
            else
            {
                cbbEmpStatus.Text = "ไล่ออก";
            }
            dtpEmpDateIn.Value = Convert.ToDateTime(dt.Rows[dgvShowEmployee.CurrentRow.Index]["empDateIn"]);
            tbEmpDateOut.Text = dt.Rows[dgvShowEmployee.CurrentRow.Index]["empDateOut"].ToString();
            tbEmpUser.Text = dt.Rows[dgvShowEmployee.CurrentRow.Index]["empUsername"].ToString();
            tbEmpPassword.Text = dt.Rows[dgvShowEmployee.CurrentRow.Index]["empPassword"].ToString();
            //รูปในฐานข้อมูลเก็บเป็น base64 ดังนั้นเวลาเอามาเเดงที่ picture box ต้องเเปลง base64 เป็น รูปภาพ
            byte[] bytes = Convert.FromBase64String(dt.Rows[dgvShowEmployee.CurrentRow.Index]["empImage"].ToString());
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                pbEmpImage.Image = Image.FromStream(ms);
            }
            //เอารูปที่เป็น base64 เก็บในตัวเเปรเพื่อใช้ในการอัปเดจ
            empImageForUpdate = dt.Rows[dgvShowEmployee.CurrentRow.Index]["empImage"].ToString();

           
        }

        private void tsbtDelete_Click(object sender, EventArgs e)
        {
            //การลบข้อมูลจะชีเรียส ดังนั้นจึงควรจะยืนยันจากผู้ใช้งานก่อน
            if (MessageBox.Show("ต้องการลบข้อมูลใช่หรือไม่","ยืนยัน",MessageBoxButtons.YesNo,MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;//return ไม่ต้องทำข้างล่าง
            }
            //---------------------------------
            if(tbEmpId.Text.Trim().Length == 0)
            {
                warningMSG("กรุณาเลือกข้อมูลพนักงานที่จะลบด้วย");

            }
            else
            {
                //1.
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
                    string strSql = "DELETE FROM employee_tb WHERE empId=@empId";
                   
                    //4.สร้างออปเจค sqlcommand เพื่อใช้งานกับชุดคำสั่ง sql
                    SqlTransaction sqlTransaction = conn.BeginTransaction();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = conn;
                    sqlCommand.Transaction = sqlTransaction;
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = strSql;
                    //ด้วยความที่มีพารามิเตอร์ @ ต้องนำข้อมูลมากำหนดให้กับพารามิเตอร์
                    sqlCommand.Parameters.Add("@empId", SqlDbType.NVarChar, 8).Value = tbEmpId.Text;
                   
                    //5.สั่ง SQL ทำงาน ในที่นี้เพื่อบันทึก insert ข้อมูลลงตาราง
                    sqlCommand.ExecuteNonQuery();
                    sqlTransaction.Commit();


                    //6.เมื่อทำการบันทึกเสจเเจ้งผลการทำงานให้ผู้ใช้ทราบ
                    MessageBox.Show("ลบข้อมูลเรียบร้อยเเล้ว", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //เคลียหน้าจอหลังจากบันทึกเเล้ว
                    tsbtCancel.PerformClick();
                }
                catch (SqlException ex)
                {
                    warningMSG("พบปัญหาในการทำงานกับฐานข้อมูล....!!!!" + ex.Message);
                }
                finally
                {
                    //7.ยกเลิกการเชื่อมต่อ
                    conn.Close();
                }
            }
        }
    }
}
