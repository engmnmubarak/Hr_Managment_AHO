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

    public partial class EmployeeManagment : Form
    {
        BL.ClassEmployee classEmployee = new BL.ClassEmployee();
        BL.ClassDepartment classDepartment = new BL.ClassDepartment();
        BL.ClassDir classDir = new BL.ClassDir();

        public EmployeeManagment()
        {
            InitializeComponent();
            dataGridViewEmp.DataSource = classEmployee.SELECT_EMPLOYEE();

            comboDep.DataSource = classDepartment.GET_ALL_DEPARTMENT();
            comboDep.DisplayMember = "DepName";
            comboDep.ValueMember = "DepId";

            comboDir.DataSource = classDir.GET_ALL_DIR();
            comboDir.DisplayMember = "dirName";
            comboDir.ValueMember = "DirId";

            comboJobStat.DataSource = classEmployee.GET_ALL_EMP_STAT();
            comboJobStat.DisplayMember = "EmpStatTit";
            comboJobStat.ValueMember = "EmpStatId";

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = classEmployee.SEARCH_EMPLOYEE(txtSearch.Text);
            dataGridViewEmp.DataSource = Dt;
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            EmployeeAdd add = new EmployeeAdd();
            add.ShowDialog();
        }

        private void btnDelEmp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حدف الموظف المحدد", "عملية الحدف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                classEmployee.DELETE_EMPLOYEE(this.dataGridViewEmp.CurrentRow.Cells[0].ToString());
            }
            dataGridViewEmp.DataSource = classEmployee.SELECT_EMPLOYEE();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            ShowEmpFolder();
        }

        private void EmployeeManagment_Load(object sender, EventArgs e)
        {

        }

        private void comboDep_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridViewEmp_DoubleClick(object sender, EventArgs e)
        {
            ShowEmpFolder();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {            
            EmployeeAdd employeeAdd = new EmployeeAdd(true, dataGridViewEmp.CurrentRow.Cells[0].Value.ToString());
            employeeAdd.ShowDialog();
        }

        private void ShowEmpFolder()
        {
            EmployeeFolder folder = new EmployeeFolder(dataGridViewEmp.CurrentRow.Cells[0].Value.ToString());
            byte[] image = (byte[])classEmployee.GET_EMP_IMAGE(dataGridViewEmp.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            folder.pictureBoxEmp.Image = Image.FromStream(ms);
            folder.txtJopTit.Text = dataGridViewEmp.CurrentRow.Cells[0].Value.ToString();
            folder.txtName.Text = dataGridViewEmp.CurrentRow.Cells[1].Value.ToString();
            folder.txtDep.Text = dataGridViewEmp.CurrentRow.Cells[5].Value.ToString();
            folder.txtJopTit.Text = dataGridViewEmp.CurrentRow.Cells[3].Value.ToString();
            folder.ShowDialog();
        }

        private void comboDep_DropDownClosed(object sender, EventArgs e)
        {
            dataGridViewEmp.DataSource = classEmployee.GET_EMP_BY_DEP(Convert.ToInt32(comboDep.SelectedValue));
        }
        private void comboDir_DropDownClosed(object sender, EventArgs e)
        {
            dataGridViewEmp.DataSource = classEmployee.GET_EMP_BY_DIR(Convert.ToInt32(comboDir.SelectedValue));
        }
        private void comboJobStat_DropDownClosed(object sender, EventArgs e)
        {
            dataGridViewEmp.DataSource = classEmployee.GET_EMP_BY_EMPJOBSTAT(Convert.ToInt32(comboJobStat.SelectedValue));
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewEmp.DataSource = classEmployee.SELECT_EMPLOYEE();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = false;
            }
        }
    }
}
