using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;
namespace GUIProject02
{
    public partial class FrmCustomer : Form
    {
        private string flagsave = "";
        private string cusImageFileName = "";
        private string cusImageForUpdate = "";
        private DataTable dt = new DataTable();
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbGoToMainMenu_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            this.Hide();
            frmMainMenu.Show();
        }
        private void warningMSG(string msg)
        {
            MessageBox.Show(msg, "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void tsbtCancel_Click(object sender, EventArgs e)
        {
            tbCusId.Clear();
            tbCusName.Clear();
            rdoCusSex1.Checked = true;
            tbCusPhone.Clear();
            tbCusEmail.Clear();
            cbbCusStatus.Text = "-- เลือกสถานะลูกค้า --";
            dtpCusDateIn.Value = DateTime.Now;
            tbCusDateOut.Clear();
            tbCusNote.Text = "";
            rdoSearch1.Checked = true;
            tbSearch.Clear();
            dgvShowCustomer.Refresh();
            pbCusImage.Image = Properties.Resources.customer;
            flagsave = "";
            tbCusId.Enabled = true;
            tbCusDateOut.Enabled = true;
            cusImageFileName = "";
            //Clear ข้อมูล DataTable ก่อนทุกครั้งที่กดปุ่มค้นหา
            dt.Clear();
        }

        private void tsbtAdd_Click(object sender, EventArgs e)
        {
            tsbtCancel.PerformClick();
            flagsave = "insert";

            SqlConnection conn = new SqlConnection(ShareDataValue.connStr);
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                string strSql = "SELECT cusId FROM customer_tb ORDER BY cusId DESC";
                SqlTransaction sqlTransaction = conn.BeginTransaction();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = conn;
                sqlCommand.Transaction = sqlTransaction;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = strSql;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Read();
                    string cusIdCurrent = sqlDataReader["cusId"].ToString();
                    int numberIdCurrent = Convert.ToInt32(cusIdCurrent.Substring(3, 5));
                    int newId = numberIdCurrent + 1;
                    string empIdNew = "cus" + newId.ToString("00000");
                    tbCusId.Text = empIdNew;
                    tbCusId.Enabled = false;
                    tbCusDateOut.Enabled = false;
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
            flagsave = "update";
        }

        private void tsbtDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการลบข้อมูลใช่หรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;//return ไม่ต้องทำข้างล่าง
            }
            //---------------------------------
            if (tbCusId.Text.Trim().Length == 0)
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
                    string strSql = "DELETE FROM customer_tb WHERE cusId=@cusId";

                    //4.สร้างออปเจค sqlcommand เพื่อใช้งานกับชุดคำสั่ง sql
                    SqlTransaction sqlTransaction = conn.BeginTransaction();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = conn;
                    sqlCommand.Transaction = sqlTransaction;
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = strSql;
                    //ด้วยความที่มีพารามิเตอร์ @ ต้องนำข้อมูลมากำหนดให้กับพารามิเตอร์
                    sqlCommand.Parameters.Add("@cusId", SqlDbType.NVarChar, 8).Value = tbCusId.Text;

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

        private void tsbtSave_Click(object sender, EventArgs e)
        {
            if (flagsave == "insert")
            {
                //โค้ดบันทึกข้อมูลพนักงานใหม่
                //ต้อง validate (ตรวจสอบเบื้องต้น) ว่าผู้ใช้กรอกข้อมูลครบถ้วนไหม
                if (tbCusId.Text.Trim().Length == 0)
                {
                    warningMSG("ตรวจสอบรหัสพนักงานด้วย");
                }
                else if (tbCusName.Text.Trim().Length == 0)
                {
                    warningMSG("ตรวจสอบชื่อด้วย");
                }
                else if (cbbCusStatus.Text == "-- เลือกสถานะพนักงาน")
                {
                    warningMSG("ตรวจสอบเลือกสถานะพนักงานด้วย");
                }
                else if (cusImageFileName == "")//ตรวจสอบว่าได้เลือกรูปหรือยัง
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
                        string strSql = "INSERT INTO customer_tb";
                        strSql += "(cusId, cusName, cusImage, cusSex, cusPhone, cusEmail, cusStatus, CusNote, cusDateIn, cusDateOut)";
                        strSql += "VALUES ";
                        strSql += "(@cusId, @cusName, @cusImage, @cusSex, @cusPhone, @cusEmail, @cusStatus, @CusNote, @cusDateIn, @cusDateOut)";

                        //4.สร้างออปเจค sqlcommand เพื่อใช้งานกับชุดคำสั่ง sql
                        SqlTransaction sqlTransaction = conn.BeginTransaction();
                        SqlCommand sqlCommand = new SqlCommand();
                        sqlCommand.Connection = conn;
                        sqlCommand.Transaction = sqlTransaction;
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.CommandText = strSql;
                        //ด้วยความที่มีพารามิเตอร์ @ ต้องนำข้อมูลมากำหนดให้กับพารามิเตอร์
                        sqlCommand.Parameters.Add("@cusId", SqlDbType.NVarChar, 8).Value = tbCusId.Text;
                        sqlCommand.Parameters.Add("@cusName", SqlDbType.NVarChar, 17).Value = tbCusName.Text;
                        //รูป
                        byte[] data = File.ReadAllBytes(cusImageFileName);
                        string base64Image = Convert.ToBase64String(data);
                        sqlCommand.Parameters.Add("@cusImage", SqlDbType.NVarChar).Value = base64Image;
                        //เพศ
                        int sex;
                        if (rdoCusSex1.Checked == true)
                        {
                            sex = 1;
                        }
                        else if (rdoCusSex2.Checked == true)
                        {
                            sex = 2;
                        }
                        else
                        {
                            sex = 3;
                        }
                        sqlCommand.Parameters.Add("@cusSex", SqlDbType.Int).Value = sex;
                        sqlCommand.Parameters.Add("@cusPhone", SqlDbType.NVarChar, 20).Value = tbCusPhone.Text.Trim();
                        sqlCommand.Parameters.Add("@cusEmail", SqlDbType.NVarChar, 30).Value = tbCusEmail.Text.Trim();

                        int cusstatus;
                        if (cbbCusStatus.Text == "เป็นสมาชิกอยู่")
                        {
                            cusstatus = 1;
                        }
                        else
                        {
                            cusstatus = 2;
                        }
                        sqlCommand.Parameters.Add("@cusStatus", SqlDbType.Int).Value = cusstatus;
                        sqlCommand.Parameters.Add("@CusNote", SqlDbType.Text).Value = tbCusNote.Text;
                        sqlCommand.Parameters.Add("@cusDateIn", SqlDbType.Date).Value = dtpCusDateIn.Value.Date;
                        sqlCommand.Parameters.Add("@cusDateOut", SqlDbType.NVarChar, 30).Value = tbCusDateOut.Text.Trim();
                        sqlCommand.ExecuteNonQuery();
                        sqlTransaction.Commit();
                        MessageBox.Show("บันทึกข้อมูลเรียบร้อยเเล้ว", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else if (flagsave == "update")
            {
                //โค้ดเเก้ไขข้อมูลพนักงาน
                if (tbCusId.Text.Trim().Length == 0)
                {
                    warningMSG("กรุณาเลือกข้อมูลลูกค้าที่จะเเก้ไขด้วย");
                }
                if (tbCusId.Text.Trim().Length == 0)
                {
                    warningMSG("ตรวจสอบรหัสลูกค้าด้วย");
                }
                else if (tbCusName.Text.Trim().Length == 0)
                {
                    warningMSG("ตรวจสอบชื่อด้วย");
                }
                else if (cbbCusStatus.Text == "-- เลือกสถานะพนักงาน")
                {
                    warningMSG("ตรวจสอบเลือกสถานะพนักงานด้วย");
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
                        string strSql = "UPDATE customer_tb SET cusName=@cusName, cusImage=@cusImage, cusSex=@cusSex, cusPhone=@cusPhone, cusEmail=@cusEmail, cusStatus=@cusStatus, CusNote=@CusNote, cusDateIn=@cusDateIn, cusDateOut=@cusDateOut WHERE cusId=@cusId";

                        //4.สร้างออปเจค sqlcommand เพื่อใช้งานกับชุดคำสั่ง sql
                        SqlTransaction sqlTransaction = conn.BeginTransaction();
                        SqlCommand sqlCommand = new SqlCommand();
                        sqlCommand.Connection = conn;
                        sqlCommand.Transaction = sqlTransaction;
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.CommandText = strSql;
                        //ด้วยความที่มีพารามิเตอร์ @ ต้องนำข้อมูลมากำหนดให้กับพารามิเตอร์
                        sqlCommand.Parameters.Add("@cusId", SqlDbType.NVarChar, 8).Value = tbCusId.Text;
                        sqlCommand.Parameters.Add("@cusName", SqlDbType.NVarChar, 17).Value = tbCusName.Text;
                        //รูป ตรวจรูปต้องตรวจสอบว่าได้กเเก้ไหม ถ้าไม่เเก้ก็๋ใช้รูปเดิม เเต่ถ้าเเก้ใช้รูปใหม่
                        if (cusImageFileName.Length != 0)
                        {
                            //กรณีเลือกณูปใหม่
                            byte[] data = File.ReadAllBytes(cusImageFileName);
                            string base64Image = Convert.ToBase64String(data);
                            sqlCommand.Parameters.Add("@cusImage", SqlDbType.NVarChar).Value = base64Image;
                        }
                        else
                        {
                            //ใช้รูปเดิม
                            sqlCommand.Parameters.Add("@cusImage", SqlDbType.NVarChar).Value = cusImageForUpdate;

                        }
                        //เพศ
                        int sex;
                        if (rdoCusSex1.Checked == true)
                        {
                            sex = 1;
                        }
                        else if (rdoCusSex2.Checked == true)
                        {
                            sex = 2;
                        }
                        else
                        {
                            sex = 3;
                        }
                        sqlCommand.Parameters.Add("@cusSex", SqlDbType.Int).Value = sex;
                        sqlCommand.Parameters.Add("@cusPhone", SqlDbType.NVarChar, 20).Value = tbCusPhone.Text.Trim();
                        sqlCommand.Parameters.Add("@cusEmail", SqlDbType.NVarChar, 30).Value = tbCusEmail.Text.Trim();
                        //สถานะ
                        int cusstatus;
                        if (cbbCusStatus.Text == "เป็นสมาชิกอยู่")
                        {
                            cusstatus = 1;
                        }
                        else
                        {
                            cusstatus = 2;
                        }
                        sqlCommand.Parameters.Add("@cusStatus", SqlDbType.Int).Value = cusstatus;
                        sqlCommand.Parameters.Add("@CusNote", SqlDbType.Text).Value = tbCusNote.Text;
                        sqlCommand.Parameters.Add("@cusDateIn", SqlDbType.Date).Value = dtpCusDateIn.Value.Date;
                        sqlCommand.Parameters.Add("@cusDateOut", SqlDbType.NVarChar, 30).Value = tbCusDateOut.Text.Trim();
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

        private void btSelectCusImage_Click(object sender, EventArgs e)
        {
            //ขะเปิด openfiledialog ให้ผู้ใช้เลือกรูป เเล้วเเดงที่ picture box 
            openFileDialog2.InitialDirectory = @"C:\";
            openFileDialog2.Title = "กรุณาเลือกรูปพนักงาน";
            openFileDialog2.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";

            //เเสดง openfiledialog โดยมีการตรวจสอบว่า
            //หลังจากเลือกเเล้วกด ok ให้นำรูปที่เลือกไปเเสดง picturebox -> pbEmpImage
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                pbCusImage.Image = Image.FromFile(openFileDialog2.FileName);
                cusImageFileName = openFileDialog2.FileName;
            }
        }

        private void cbbCusStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            dt.Clear();
            if (rdoSearch1.Checked == false && tbSearch.Text.Trim().Length == 0)
            {
                warningMSG("ป้อนข้อมูลที่จะค้าหาด้วยย");
            }
            else
            {

                SqlConnection conn = new SqlConnection(ShareDataValue.connStr);
                try
                {

                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                    conn.Open();


                    string strSql = "";
                    if (rdoSearch1.Checked == true)
                    {
                        strSql = "SELECT * FROM customer_tb";
                    }
                    else if (rdoSearch2.Checked == true)
                    {
                        strSql = "SELECT * FROM customer_tb WHERE cusId = @value";
                    }
                    else if (rdoSearch3.Checked == true)
                    {
                        strSql = "SELECT * FROM customer_tb WHERE cusName LIKE '%' + @value + '%'";
                    }
                    else
                    {
                        strSql = "SELECT * FROM customer_tb WHERE cusPhone = @value";
                    }


                    SqlTransaction sqlTransaction = conn.BeginTransaction();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = conn;
                    sqlCommand.Transaction = sqlTransaction;
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = strSql;

                    if (rdoSearch1.Checked == false)
                    {
                        sqlCommand.Parameters.Add("@value", SqlDbType.VarChar).Value = tbSearch.Text;
                    }


                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

                    da.Fill(dt);

                    if (dt.Rows.Count <= 0)
                    {

                        warningMSG("ไม่มีข้อมูลที่ค้าหา");
                    }
                    else
                    {

                        dgvShowCustomer.AutoGenerateColumns = false;
                        dgvShowCustomer.Columns[0].DataPropertyName = "cusId";
                        dgvShowCustomer.Columns[1].DataPropertyName = "cusName";
                        dgvShowCustomer.Columns[2].DataPropertyName = "cusPhone";
                        dgvShowCustomer.Columns[3].DataPropertyName = "cusEmail";

                        dgvShowCustomer.DataSource = dt;
                    }
                }
                catch (SqlException ex)
                {
                    warningMSG("พบปัญหาในการทำงานกับฐานข้อมูล....!!!!" + ex.Message);
                }
                finally
                {

                    conn.Close();
                }
            }
        }

        private void dgvShowCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbCusId.Enabled = false;
            tbCusId.Text = dt.Rows[dgvShowCustomer.CurrentRow.Index]["cusId"].ToString();
            tbCusName.Text = dt.Rows[dgvShowCustomer.CurrentRow.Index]["cusName"].ToString();
            if (Convert.ToInt32(dt.Rows[dgvShowCustomer.CurrentRow.Index]["cusSex"].ToString()) == 1)
            {
                rdoCusSex1.Checked = true;
            }
            else if (Convert.ToInt32(dt.Rows[dgvShowCustomer.CurrentRow.Index]["cusSex"].ToString()) == 2)
            {
                rdoCusSex2.Checked = true;
            }
            else
            {
                rdoCusSex3.Checked = true;
            }
            tbCusPhone.Text = dt.Rows[dgvShowCustomer.CurrentRow.Index]["cusPhone"].ToString();
            tbCusEmail.Text = dt.Rows[dgvShowCustomer.CurrentRow.Index]["cusEmail"].ToString();
            if (Convert.ToInt32(dt.Rows[dgvShowCustomer.CurrentRow.Index]["cusStatus"].ToString()) == 1)
            {
                cbbCusStatus.Text = "เป็นสมาชิกอยู่";
            }            
            else
            {
                cbbCusStatus.Text = "ยังไม่เป็นสมาชิก";
            }
            tbCusNote.Text = dt.Rows[dgvShowCustomer.CurrentRow.Index]["CusNote"].ToString();
            dtpCusDateIn.Value = Convert.ToDateTime(dt.Rows[dgvShowCustomer.CurrentRow.Index]["cusDateIn"]);
            tbCusDateOut.Text = dt.Rows[dgvShowCustomer.CurrentRow.Index]["cusDateOut"].ToString();
            //รูปในฐานข้อมูลเก็บเป็น base64 ดังนั้นเวลาเอามาเเดงที่ picture box ต้องเเปลง base64 เป็น รูปภาพ
            byte[] bytes = Convert.FromBase64String(dt.Rows[dgvShowCustomer.CurrentRow.Index]["cusImage"].ToString());
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                pbCusImage.Image = Image.FromStream(ms);
            }
            //เอารูปที่เป็น base64 เก็บในตัวเเปรเพื่อใช้ในการอัปเดจ
            cusImageForUpdate = dt.Rows[dgvShowCustomer.CurrentRow.Index]["cusImage"].ToString();
        }
    }
}
