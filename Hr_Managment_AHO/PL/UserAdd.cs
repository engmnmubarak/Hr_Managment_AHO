using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hr_Managment_AHO.PL
{
    public partial class UserAdd : Form
    {
        BL.ClassLogin login = new BL.ClassLogin();


        public UserAdd()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text!=null && txtUserName.TextLength>4 && txtPassword.Text.Equals(txtRePassword.Text)&&combxUserType.SelectedText!=null)
            {
                DialogResult result = MessageBox.Show(
                    " هل انت متاكد من اضافة المستخدم " + txtUserName.Text + " بصلاحيات " + combxUserType.Text + "?",
                    "تنبية",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                    );
                if (result == DialogResult.Yes)
                {
                    login.INSERT_USER(txtUserName.Text, txtPassword.Text, combxUserType.Text);
                    MessageBox.Show("تم اضافة المستخدم بنجاح ","عملية اضافة",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Clear();
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("تم الغاء عملية الاضافة ", "عملية اضافة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (txtUserName.Text == null || txtUserName.TextLength<=4)
                MessageBox.Show("يجب ادخال اسم المستخدم");
            else
                MessageBox.Show("كلمة السر غير متطابقة");
        }

        private void Clear()
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtRePassword.Clear();
            combxUserType.ResetText();
        }
    }
}
