using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeTimer
{
    class UserStatement
    {
        /**
         * 使用者的資料
         */ 
        private static int ID = 0;
        private static string USERNAME;
        private static string PASSWORD;
        private static string EMAILADDRESS;
        private static int PHONENUMBER;

        /**
         * 以下皆是和這些資料連結的函式
         */ 

        public void inId(int input)
        {
            ID = input;
        }

        public void inUser(string input)
        {
            USERNAME = input;
        }

        public void inPassword(string input)
        {
            PASSWORD = input;
        }

        public void inEmail(string input)
        {
            EMAILADDRESS = input;
        }

        public void inPhone(int input)
        {
            PHONENUMBER = input;
        }

        public int getId()
        {
            return ID;
        }

        public string getUser()
        {
            return USERNAME;
        }

        public string getPassword()
        {
            return PASSWORD;
        }

        public string getEmail()
        {
            return EMAILADDRESS;
        }

        public int getPhone()
        {
            return PHONENUMBER;
        }
    }
}
