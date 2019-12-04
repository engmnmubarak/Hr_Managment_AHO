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
        }

        //بداية قسم البحث
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridViewEmp.DataSource = classEmployee.SEARCH_EMPLOYEE(txtSearch.Text);
        }
        //نهاية قسم البحث

        //بداية قسم الفرز
        private void checkFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFilter.Checked == true)
            {
                groupFilter.Enabled = true;

            }
            else
            {
                groupFilter.Enabled = false;
                dataGridViewEmp.DataSource = classEmployee.SELECT_EMPLOYEE();
            }
        }

        private void radioDepartment_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDepartment.Checked == true)
            {
                comboFilter.DataSource = classDepartment.GET_ALL_DEPARTMENT();
                comboFilter.DisplayMember = "DepName";
                comboFilter.ValueMember = "DepId";
            }
            else
            {

            }

        }

        private void radioDir_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDepartment.Checked == true)
            {
                comboFilter.DataSource = classDir.GET_ALL_DIR();
                comboFilter.DisplayMember = "dirName";
                comboFilter.ValueMember = "DirId";
            }
            else
            {

            }
        }

        private void radioStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDepartment.Checked == true)
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
            if (radioDepartment.Checked == true)
            {
                dataGridViewEmp.DataSource = classEmployee.GET_EMP_BY_DEP(Convert.ToInt32(comboFilter.SelectedValue));
            }
            else if (radioDir.Checked == true)
            {
                dataGridViewEmp.DataSource = classEmployee.GET_EMP_BY_DIR(Convert.ToInt32(comboFilter.SelectedValue));
            }
            else if (radioStatus.Checked == true)
            {
                dataGridViewEmp.DataSource = classEmployee.GET_EMP_BY_EMPJOBSTAT(Convert.ToInt32(comboFilter.SelectedValue));
            }
            else
            {

            }
        }
        //نهاية قسم الفرز

        //بداية قسم العرض
        private void dataGridViewEmp_DoubleClick(object sender, EventArgs e)
        {
            ShowEmpFolder();
        }
        //نهاية قسم العرض

        //بداية قسم الازرة
        private void btnAdd_Click(object sender, EventArgs e)
        {
            EmployeeAdd add = new EmployeeAdd();
            add.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حدف الموظف المحدد", "عملية الحدف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                classEmployee.DELETE_EMPLOYEE(this.dataGridViewEmp.CurrentRow.Cells[0].ToString());
            }
            else
            {

            }
            dataGridViewEmp.DataSource = classEmployee.SELECT_EMPLOYEE();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDocument_Click(object sender, EventArgs e)
        {
            ShowEmpFolder();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {            
            EmployeeAdd employeeAdd = new EmployeeAdd(true, dataGridViewEmp.CurrentRow.Cells[0].Value.ToString());
            employeeAdd.ShowDialog();
        }
    
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewEmp.DataSource = classEmployee.SELECT_EMPLOYEE();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            RPT.EMPLOYEE_REPORT report = new RPT.EMPLOYEE_REPORT();
            report.SetParameterValue("@ID", this.dataGridViewEmp.CurrentRow.Cells[0].Value.ToString());
            RPT.EmployeeRPT reportForm = new RPT.EmployeeRPT();
            reportForm.crystalReportViewer1.ReportSource = report;
            reportForm.ShowDialog();
        }
        //نهاية قسم الازرة

        //بداية العمليات
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
        //نهاية العمليات

    }
}
