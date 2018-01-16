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
    public partial class frmeinsert : Form
    {
        public frmeinsert()
        {
            InitializeComponent();
        }
       public static LoginInfo[]aa=new LoginInfo[10];
        
        private void frmeinsert_Load(object sender, EventArgs e)
        {
         
           
   
        }
        public FrmLogin f = new FrmLogin();
        private void btnmian_Click(object sender, EventArgs e)
        {
            //省略验证用户注册信息有效的代码



            LoginInfo fo = new LoginInfo();
            for (int i = 0; i < aa.Length; i++)
            { 
               
                if (aa[i] == null)
                {                  
                    fo.Name1 = txtname.Text;
                    fo.Email1 = txtid.Text;
                    fo.ID1 = txtmail.Text;
                    fo.Pwd = txtpwd.Text;
                    aa[i] = fo;
                    MessageBox.Show("恭喜，通过验证！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }                
            }
            lbltxt.Visible = true;
            this.Hide();
            FrmLogin longin = new FrmLogin();
            longin.Show();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
