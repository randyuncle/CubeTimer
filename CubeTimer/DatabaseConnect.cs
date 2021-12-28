using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CubeTimer
{
    class DatabaseConnect
    {
        UserStatement us = new UserStatement();

        /**
         * 把用戶註冊資料存進資料庫
         */
        public void InsertNewUserToDatabase()
        {
            try
            {
                SqlConnection scn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename = |DataDirectory|\Database1.mdf;Integrated Security=True");
                scn.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = scn;
                cmd.CommandText = "INSERT INTO [會員資料](Id, Name, Password, Email, PhoneNumber) VALUES(@Id, @Name, @Password, @Email, @PhoneNumber)";

                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = us.getId();
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = us.getUser();
                cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = us.getPassword();
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = us.getEmail();
                cmd.Parameters.Add("@PhoneNumber", SqlDbType.Int).Value = us.getPhone();

                cmd.ExecuteNonQuery();

                scn.Close();
                scn.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("連線失敗，請再嘗試一次\r\n" + ex.Message, "警告", MessageBoxButtons.OK , MessageBoxIcon.Warning);
            }
        }

        /**
         * 提取用戶資料
         */
        public bool PickUserFromDatabase(string user)
        {
            try
            {
                SqlConnection scn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename = |DataDirectory|\Database1.mdf;Integrated Security=True");
                scn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = scn;
                cmd.CommandText = "SELECT * FROM [會員資料] WHERE Name = @Name";
                cmd.Parameters.Add("@Name",SqlDbType.NVarChar).Value = us.getUser();

                SqlDataReader sdr = cmd.ExecuteReader();

                // Insert data to user statement
                while (sdr.Read())
                {
                    us.inId(Convert.ToInt32(sdr["Id"]));
                    us.inUser(sdr["Name"].ToString());
                    us.inPassword(sdr["Password"].ToString());
                    us.inEmail(sdr["Email"].ToString());
                    us.inPhone(Convert.ToInt32(sdr["PhoneNumber"]));
                }

                sdr.Close();
                scn.Close();
                scn.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("找不到使用者資料\r\n" + ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
