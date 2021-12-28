﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubeTimer
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        /**
         * 登入
         */
        private void loginButton_Click(object sender, EventArgs e)
        {
            if ((nameBox.Text.Length > 0) && (passwordBox.Text.Length > 0))
            {
                if (DatabaseCall())
                {
                    if (checkPassSame())
                    {
                        Form1 form1 = new Form1();
                        form1.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("密碼錯誤，請再試一次", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("此帳號不存在，請再嘗試", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("請確認是否填寫完帳號密碼", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /**
         * 前往申請帳號
         */ 
        private void applyButton_Click(object sender, EventArgs e)
        {
            ApplyForm af = new ApplyForm();
            af.Show();
            this.Hide();
        }

        /**
         * 呼叫資料庫連結器
         */
        public bool DatabaseCall()
        {
            DatabaseConnect dbc = new DatabaseConnect();
            bool isExist = dbc.PickUserFromDatabase(nameBox.Text);

            return isExist;
        }

        /**
         * 檢查密碼是否相同
         */ 
        public bool checkPassSame()
        {
            UserStatement us = new UserStatement();

            if (!us.getPassword().Equals(passwordBox.Text))
            {
                return false;
            }

            return true;
        }
    }
}
