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
    public partial class DepartmentEmp : Form
    {
        string DepartmentId;

        BL.ClassEmployee classEmployee = new BL.ClassEmployee();
        BL.ClassJob classJob = new BL.ClassJob();
        BL.ClassDepartment classDepartment = new BL.ClassDepartment();

        public DepartmentEmp()
        {
            InitializeComponent();
        }

        public DepartmentEmp(string id)
        {
            DepartmentId = id;
            InitializeComponent();
        }

        //بداية قسم البحث
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridViewDepEmp.DataSource = (classEmployee.SEARCH_DEP_EMPLOYEE(Convert.ToInt32(DepartmentId), txtSearch.Text));
        }

        //بداية قسم الفرز
        private void checkFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFilter.Checked)
            {
                groupFilter.Enabled = true;
            }
            else
            {
                groupFilter.Enabled = false;
                dataGridViewDepEmp.DataSource = classDepartment.GET_DEPARTMENT_EMPLOYEE(Convert.ToInt32(DepartmentId));
            }
        }

        private void radioJobTitle_CheckedChanged(object sender, EventArgs e)
        {
            if (radioJobTitle.Checked == true)
            {
                comboFilter.DataSource = classJob.GET_ALL_JOB();
                comboFilter.DisplayMember = "jobTit";
                comboFilter.ValueMember = "JobTitId";
            }
            else
            {

            }
        }

        private void radioJobStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (radioJobStatus.Checked == true)
            {
                comboFilter.DataSource = classEmployee.GET_ALL_EMP_STAT();
                comboFilter.DisplayMember = "EmpStatTit";
                comboFilter.ValueMember = "EmpStatId";
            }
            else
            {

            }
        }

        private void comboFilter_DropDownClosed(object sender, EventArgs e)
        {
            if (radioJobTitle.Checked)
            {
                dataGridViewDepEmp.DataSource = (classEmployee.GET_EMP_BY_JOB_TITLE(Convert.ToInt32(comboFilter.SelectedValue)));
            }
            else if (radioJobStatus.Checked)
            {
                dataGridViewDepEmp.DataSource = (classEmployee.GET_EMP_BY_EMPJOBSTAT(Convert.ToInt32(comboFilter.SelectedValue)));
            }
        }

        //بداية قسم العرض
        private void dataGridViewDepEmp_DoubleClick(object sender, EventArgs e)
        {
            ShowEmployeeDocument();
        }

        //بداية قسم الازرة
        private void btnDocument_Click(object sender, EventArgs e)
        {
            ShowEmployeeDocument();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EmployeeAdd employeeAdd = new EmployeeAdd();
            employeeAdd.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EmployeeAdd employeeAdd = new EmployeeAdd(true, dataGridViewDepEmp.CurrentRow.Cells[0].Value.ToString());
            employeeAdd.comboDep.Enabled = false;
            employeeAdd.comboDepType.Enabled = false;
            employeeAdd.comboDir.Enabled = false;
            employeeAdd.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حدف الموظف المحدد", "عملية الحدف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                classEmployee.DELETE_EMPLOYEE(dataGridViewDepEmp.CurrentRow.Cells[0].ToString());
            }
            else
            {

            }
            dataGridViewDepEmp.DataSource = classDepartment.GET_DEPARTMENT_EMPLOYEE(Convert.ToInt32(DepartmentId));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            RPT.EMPLOYEE_REPORT report = new RPT.EMPLOYEE_REPORT();
            report.SetParameterValue("@ID", dataGridViewDepEmp.CurrentRow.Cells[0].Value.ToString());
            RPT.EmployeeRPT reportForm = new RPT.EmployeeRPT();
            reportForm.crystalReportViewer1.ReportSource = report;
            reportForm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        //بداية العمليات
        private void ShowEmployeeDocument()
        {
            EmployeeFolder folder = new EmployeeFolder(dataGridViewDepEmp.CurrentRow.Cells[0].Value.ToString());
            byte[] image = (byte[])classEmployee.GET_EMP_IMAGE(dataGridViewDepEmp.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            folder.pictureBoxEmp.Image = Image.FromStream(ms);
            folder.txtId.Text = dataGridViewDepEmp.CurrentRow.Cells[0].Value.ToString();
            folder.txtName.Text = dataGridViewDepEmp.CurrentRow.Cells[1].Value.ToString();
            folder.txtDep.Text = txtDepName.Text;
            folder.txtJopTit.Text = dataGridViewDepEmp.CurrentRow.Cells[5].Value.ToString();
            folder.ShowDialog();
        }
        
    }
}
