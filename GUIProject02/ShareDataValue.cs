using System;
using System.Collections.Generic;
using System.Text;

namespace GUIProject02
{
    class ShareDataValue
    {
        //สร้างตัวเเปรเก็บชื่อ DB Server เเละ DB ที่เราจะทำงานด้วย
        public static string connStr = @"Data Source=BOATPC\SQLEXPRESS;Initial Catalog=saucoffeeshop_db;Integrated Security=true";
        public static string empId = "";
        public static string empName = "";
        public static string empPosition = "";
        public static string empImage = "";
    }
}
