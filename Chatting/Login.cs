using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chatting
{
    public partial class Login : Form
    {
        MySqlConnection mycon;
        MySqlCommand mycmd;
        public Login()
        {
            InitializeComponent();
            Icon = Properties.Resources.iocn;
            string constr = "server=localhost;User Id=root;password=guo1cheng;Database=chatting";
            mycon = new MySqlConnection(constr);
            try
            {
                mycon.Open();
                Console.WriteLine("已建立连接");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("数据库连接失败");
            }
        }


        private void labelregister_MouseHover(object sender, EventArgs e)
        {
            labelregister.Font = new Font("微软雅黑", 12.10084F, FontStyle.Underline);
            labelregister.ForeColor = System.Drawing.SystemColors.HotTrack;
        }
        private void labelregister_MouseLeave(object sender, EventArgs e)
        {
            labelregister.Font = new Font("微软雅黑", 12.10084F, FontStyle.Regular);
            labelregister.ForeColor = System.Drawing.SystemColors.Highlight;
        }

        private void labelregister_Click(object sender, EventArgs e)
        {
            if (textBoxaccount.Text == "" || textBoxpwd.Text == "")
            {
                MessageBox.Show("请输入注册的用户名和密码");
                return;
            }
            
            mycmd = new MySqlCommand("select account from users", mycon);
            MySqlDataReader res = mycmd.ExecuteReader();

            bool isRegistered = false;
            while (res.Read())
            {
                Console.WriteLine(res.GetString("account"));
                if (res.GetString("account") == textBoxaccount.Text) {
                    isRegistered = true;
                    break;
                }
            }
            res.Close();
            if (isRegistered)
            {
                MessageBox.Show("用户名已被注册");
                return;
            }
            else
            {
                string sql = string.Format(@"insert into users(account,password) values('{0}', '{1}')", textBoxaccount.Text, textBoxpwd.Text);
                MessageBox.Show(sql);
                mycmd = new MySqlCommand(sql, mycon);
                if (mycmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("账户注册成功");
                }
                else
                {
                    MessageBox.Show("账户注册失败");
                }
                return;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            mycmd = new MySqlCommand("select * from users", mycon);
            MySqlDataReader res = mycmd.ExecuteReader();

            bool isRegistered = false;
            while (res.Read())
            {
                Console.WriteLine(res.GetString("account"));
                if (res.GetString("account") == textBoxaccount.Text)
                {
                    isRegistered = true;
                    break;
                }
            }
            if (isRegistered)
            {
                if (res.GetString("password") == textBoxpwd.Text)
                {
                    MessageBox.Show("登陆成功");
                }
                else
                {
                    MessageBox.Show("密码错误");
                }
            }
            else
            {
                MessageBox.Show("用户不存在");
            }


            res.Close();

        }
    }
    
}
