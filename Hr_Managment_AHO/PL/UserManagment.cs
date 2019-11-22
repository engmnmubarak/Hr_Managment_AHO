using Hr_Managment_AHO.BL;
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
    public partial class UserManagment : Form
    {
        BL.ClassLogin login = new BL.ClassLogin();
        public UserManagment()
        {
            InitializeComponent();
            this.GridViewUsers.DataSource = login.GET_ALL_USERS();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserAdd AddUser = new UserAdd();
            AddUser.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = login.SEARCH_USER(txtSearch.Text);
            this.GridViewUsers.DataSource = Dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("هل تريد فعلا حدف المستخدم المحدد","عملية الحدف",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes)
            {
                login.DELETE_USER(this.GridViewUsers.CurrentRow.Cells[0].ToString());
                MessageBox.Show("تم الحدف بنجاح", "عملية الحدف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("تم الغاء عملة الحدف ", "عملية الحدف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.GridViewUsers.DataSource = login.GET_ALL_USERS();

            }
        }

        private void GridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
