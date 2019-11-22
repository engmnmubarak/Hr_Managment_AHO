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
        string DepId;
        public DepartmentEmp()
        {
            InitializeComponent();
        }
        public DepartmentEmp(string depId)
        {
            DepId = depId;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewDepEmp_DoubleClick(object sender, EventArgs e)
        {
            ShowEmpFolder();
        }

        private void ShowEmpFolder()
        {
            BL.ClassEmployee classEmployee = new BL.ClassEmployee();
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

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeeAdd employeeAdd = new EmployeeAdd(true, dataGridViewDepEmp.CurrentRow.Cells[0].Value.ToString());
            employeeAdd.ShowDialog();
        }
    }
}
