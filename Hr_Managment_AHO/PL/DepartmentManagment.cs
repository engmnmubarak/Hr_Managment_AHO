using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hr_Managment_AHO.PL
{
    public partial class DepartmentManagment : Form
    {
        BL.ClassEmployee classEmployee = new BL.ClassEmployee();
        BL.ClassDepartment classDepartment = new BL.ClassDepartment();
        BL.ClassDir classDir = new BL.ClassDir();

        //private static DataTable dataTable;

        public DepartmentManagment()
        {
            InitializeComponent();
            DataRefresh(classDepartment.GET_DEPARTMENT_TABLE());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DepartmentAdd departmentAdd = new DepartmentAdd();
            departmentAdd.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                groupBox3.Enabled = true;

            }
            else
            {
                groupBox3.Enabled = false;
                DataRefresh(classDepartment.GET_ALL_DEPARTMENT());
            }

        }

        private void radioDir_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDir.Checked)
            {
                comboFilter.DataSource = classDir.GET_ALL_DIR();
                comboFilter.DisplayMember = "dirName";
                comboFilter.ValueMember = "DirId";
            }
        }

        
        private void radioType_CheckedChanged(object sender, EventArgs e)
        {
            if (radioType.Checked)
            {
                comboFilter.DataSource = classDepartment.GET_ALL_DEP_TYPE();
                comboFilter.DisplayMember = "DepTypeName";
                comboFilter.ValueMember = "DepTypeId";
            }
        }

        private void txtSearchDep_TextChanged(object sender, EventArgs e)
        {
            DataRefresh(classDepartment.SEARCH_DEPARTMENT(txtSearchDep.Text));
        }

        private void comboFilter_DropDownClosed(object sender, EventArgs e)
        {
            if (radioDir.Checked)
            {
                DataRefresh(classDepartment.GET_DEP_BY_DIR(Convert.ToInt32(comboFilter.SelectedValue)));
            }
            else if (radioType.Checked)
            {
                DataRefresh(classDepartment.GET_DEP_BY_TYPE(Convert.ToInt32(comboFilter.SelectedValue)));
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حدف المرفق المحدد", "عملية الحدف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                classDepartment.DELETE_DEPARTMENT(Convert.ToInt32(dataGridViewDep.CurrentRow.Cells[0].ToString()));
            }
            DataRefresh(classDepartment.GET_DEPARTMENT_TABLE());
        }

        private void DataRefresh(DataTable dt)
        {
            dataGridViewDep.DataSource = dt;
        }

        private void dataGridViewDep_DoubleClick(object sender, EventArgs e)
        {
            ShowDepartmentEmp();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DepartmentAdd departmentAdd = new DepartmentAdd(true, dataGridViewDep.CurrentRow.Cells[0].Value.ToString());
            byte[] image = (byte[])classDepartment.GET_DEP_IMAGE(dataGridViewDep.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            departmentAdd.pbxDepImg.Image = Image.FromStream(ms);
            departmentAdd.txtDepName.Text = dataGridViewDep.CurrentRow.Cells[1].Value.ToString();
            departmentAdd.comboDir.SelectedText = dataGridViewDep.CurrentRow.Cells[2].Value.ToString();
            departmentAdd.comboDepType.SelectedText = dataGridViewDep.CurrentRow.Cells[3].Value.ToString();
            departmentAdd.txtDepAddress.Text = dataGridViewDep.CurrentRow.Cells[4].Value.ToString();
            departmentAdd.txtDepPhone.Text = dataGridViewDep.CurrentRow.Cells[5].Value.ToString();
            departmentAdd.txtDepEmail.Text = dataGridViewDep.CurrentRow.Cells[6].Value.ToString();
            departmentAdd.txtFax.Text = dataGridViewDep.CurrentRow.Cells[7].Value.ToString();
            departmentAdd.Text = "تعديل مرفق";
            departmentAdd.btnAdd.Text = "تعديل";
            departmentAdd.ShowDialog();
        }
        private void ShowDepartmentEmp()
        {
            DepartmentEmp departmentEmp = new DepartmentEmp(dataGridViewDep.CurrentRow.Cells[0].Value.ToString());
            byte[] image = (byte[])classDepartment.GET_DEP_IMAGE(dataGridViewDep.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            departmentEmp.pictureBoxDep.Image = Image.FromStream(ms);
            departmentEmp.txtDepId.Text = dataGridViewDep.CurrentRow.Cells[0].Value.ToString();
            departmentEmp.txtDepName.Text = dataGridViewDep.CurrentRow.Cells[1].Value.ToString();
            departmentEmp.txtDepDir.Text = dataGridViewDep.CurrentRow.Cells[2].Value.ToString();
            departmentEmp.txtDepType.Text = dataGridViewDep.CurrentRow.Cells[3].Value.ToString();
            departmentEmp.txtDepAddress.Text = dataGridViewDep.CurrentRow.Cells[4].Value.ToString();
            departmentEmp.txtDepPhone.Text = dataGridViewDep.CurrentRow.Cells[5].Value.ToString();
            departmentEmp.txtDepMail.Text = dataGridViewDep.CurrentRow.Cells[6].Value.ToString();
            departmentEmp.txtDepOwner.Text = dataGridViewDep.CurrentRow.Cells[7].Value.ToString();
            departmentEmp.dataGridViewDepEmp.DataSource = classDepartment.GET_DEPARTMENT_EMPLOYEE(Convert.ToInt32(dataGridViewDep.CurrentRow.Cells[0].Value.ToString()));
            departmentEmp.ShowDialog();
        }
    }
}
