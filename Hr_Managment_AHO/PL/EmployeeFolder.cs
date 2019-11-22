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
    public partial class EmployeeFolder : Form
    {
        private static EmployeeFolder employeeFolder;
        BL.ClassEmployee classEmployee = new BL.ClassEmployee();
        BL.ClassDoc classDoc = new BL.ClassDoc();

        public static string ID;



        static void EmployeeFolder_FormClosed(object sender, FormClosedEventArgs e)
        {
            employeeFolder = null;
        }

        public static EmployeeFolder GetEmployeeFolder
        {
            get
            {
                if (employeeFolder == null)
                {
                    employeeFolder = new EmployeeFolder(ID);
                    employeeFolder.FormClosed += new FormClosedEventHandler(EmployeeFolder_FormClosed);
                }
               return employeeFolder;
            }
        }

        public EmployeeFolder(string id)
        {
            InitializeComponent();
            ID = id;
            RefreshDataTable();
            txtId.Text = ID;
        }

        private void empPicture_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeFolder_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddDoc_Click(object sender, EventArgs e)
        {
            EmployeeFolderAdd employeeFolderAdd = new EmployeeFolderAdd(Convert.ToInt32(ID));
            employeeFolderAdd.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.DgvEmpFolder.DataSource = classDoc.GET_EMP_FOLDER(Convert.ToInt32(ID));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حدف الوثيقة المحددة", "عملية الحدف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                classDoc.DELETE_EMPLOYEE_DOC(this.DgvEmpFolder.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تم الحدف بنجاح", "عملية الحدف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            DgvEmpFolder.DataSource = classEmployee.SELECT_EMPLOYEE();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EmployeeFolderAdd editDoc = new EmployeeFolderAdd(true,Convert.ToInt32(DgvEmpFolder.CurrentRow.Cells[0].Value.ToString()));
            editDoc.comboDocTit.Text = this.DgvEmpFolder.CurrentRow.Cells[1].Value.ToString();
            editDoc.txtDocDesc.Text = this.DgvEmpFolder.CurrentRow.Cells[2].Value.ToString();
            editDoc.DtpDoc.Text = this.DgvEmpFolder.CurrentRow.Cells[3].Value.ToString();
            editDoc.txtDocIssue.Text = this.DgvEmpFolder.CurrentRow.Cells[4].Value.ToString();
            editDoc.btnAddDoc.Text = "تعديل";
            editDoc.Text = "تعديل وثيقة";
            byte[] image = (byte[])classDoc.GET_DOC_IMAGE(DgvEmpFolder.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            editDoc.pictureBoxDoc.Image = Image.FromStream(ms);
            editDoc.ShowDialog();
        }

        private void btnShowImg_Click(object sender, EventArgs e)
        {
            ShowImage imgView = new ShowImage(); 
            byte[] image = (byte[])classDoc.GET_DOC_IMAGE(DgvEmpFolder.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            imgView.picShowImage.Image = Image.FromStream(ms);
            imgView.ShowDialog();
        }

        private void DgvEmpFolder_DoubleClick(object sender, EventArgs e)
        {
            ShowImage imgView = new ShowImage();
            byte[] image = (byte[])classDoc.GET_DOC_IMAGE(DgvEmpFolder.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            imgView.picShowImage.Image = Image.FromStream(ms);
            imgView.ShowDialog();
        }
        public void RefreshDataTable()
        {
            DgvEmpFolder.DataSource = classDoc.GET_EMP_FOLDER(Convert.ToInt32(ID));
        }
    }
}
