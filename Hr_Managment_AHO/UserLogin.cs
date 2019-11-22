using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hr_Managment_AHO.BL;
using Hr_Managment_AHO.PL;

namespace Hr_Managment_AHO
{
    public partial class UserLogin : Form
    {
        ClassLogin login = new ClassLogin();
        ClassUserParam user = new ClassUserParam();
        MainForm mainForm = new MainForm();


        public UserLogin()
        {

            InitializeComponent();
        }

        
        private void login_form_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable Dt = login.SELECT_USER(txtName.Text, txtPassword.Text);
            if (Dt.Rows.Count > 0)
            {
                SetUser(Dt);
                CheckUser(ClassUserParam.UserType);
                Close();
            }
            else
                {
                MessageBox.Show("اسم المستخدم او كلمة المرور غير صحيحة");
                }  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CheckUser(string userType)
        {
            if (userType == "مدير")
            {
                mainForm.TsmiEntry.Enabled = true;
                mainForm.TsmiManagment.Enabled = true;
            }
            else if (userType == "مدخل")
            {
                mainForm.TsmiEntry.Enabled = true;
                mainForm.TsmiManagment.Enabled = false;
            }
            else
            {
                mainForm.TsmiEntry.Enabled = false;
                mainForm.TsmiManagment.Enabled = false;
            }
        }

        private void SetUser(DataTable dataTable)
        {
            ClassUserParam.UserId = Convert.ToInt32(dataTable.Rows[0][0]);
            ClassUserParam.UserName = Convert.ToString(dataTable.Rows[0][1]);
            ClassUserParam.UserPassword = Convert.ToString(dataTable.Rows[0][2]);
            ClassUserParam.UserType = Convert.ToString(dataTable.Rows[0][3]);
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false ;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;

        }
    }
}
