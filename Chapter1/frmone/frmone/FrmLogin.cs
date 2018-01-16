using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmone
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        public LoginInfo[] array;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmeinsert ii = new frmeinsert();
            ii.Show();
            //登录窗体隐藏
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            array=new  LoginInfo[10];
         LoginInfo info = new LoginInfo();
         info.Name1 = "孙丽丽";
         info.ID1 = "1234567890";
         info.Email1 = "lili1232qq.com";
         info.Pwd = "lili123";
         array [0] = info;
         //省略其他初始用户信息的代码
         //出事时将验证提示信息隐藏
         label1.Visible = false;

        }

        private void btndeng_Click(object sender, EventArgs e)
        {
            if (txtmail.Text.Trim() == "" || txtpwd.Text.Trim() == "")
            {
                MessageBox.Show("用户名不能为空！", "提示");
            }
            else
            {
                string userName = txtmail.Text;
                string pwd = txtpwd.Text;
                bool isOK = false;
                foreach (LoginInfo item in array)
                {
                    if (item != null)
                    {
                        if (item.Email1 == userName && item.Pwd == pwd)
                        {
                            label1.Visible = false;
                            isOK = true;
                            frmzhu zhu = new frmzhu();
                            //将信息传到主界面
                            zhu.textBox1.Text = "欢迎," + item.Name1;
                            zhu.Show();
                            break;
                        }
                    }
                }
                foreach (LoginInfo items in frmeinsert.aa)
                {
                    if (items != null)
                    {
                        if (items.Email1 == userName && items.Pwd == pwd)
                        {
                            label1.Visible = false;
                            isOK = true;
                            frmzhu zhu = new frmzhu();
                            //将信息传到主界面
                            zhu.textBox1.Text = "欢迎," + items.Name1;
                            zhu.Show();
                            break;
                        }
                    }
                }
                if (isOK == false)
                {
                    txtpwd.Text = "";
                    txtpwd.Focus();
                }
            }
        }
    }
}
