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
    public partial class EmployeeAdd : Form
    {
        //public static String empName;
        //public static String empNid;
        public static string EmployeeId;
        BL.ClassEmployee classEmployee = new BL.ClassEmployee();
        BL.ClassJob classJob = new BL.ClassJob();
        BL.ClassDepartment classDepartment = new BL.ClassDepartment();
        BL.ClassDir classDir = new BL.ClassDir();
        private bool UpdateStatus;

        //PERSONAL_INFO
        //string NAME, NATIONAL_ID, ISSUING_AUTHORITY, SEX, RELATIONSHIP, PLACE_OF_BIRTH;
        //DateTime DATE_OF_BIRTH, DATE_OF_DIE;
        //Image PIRSONAL_IMAGE;

        //CALL_INFO
        //string HOME_ADDRESS, PHONE, EMAIL;

        //JOB_INFO

        //CUALIFICATION


        public EmployeeAdd()
        {
            InitializeComponent();

            //empName = null;
            //empNid = null;

            comboJobStat.DataSource = classEmployee.GET_ALL_EMP_STAT();
            comboJobStat.DisplayMember = "EmpStatTit";
            comboJobStat.ValueMember = "EmpStatId";

            comboDepType.DataSource = classDepartment.GET_ALL_DEP_TYPE();
            comboDepType.DisplayMember = "DepTypeName";
            comboDepType.ValueMember = "DepTypeId";


            comboDir.DataSource = classDir.GET_ALL_DIR();
            comboDir.DisplayMember = "dirName";
            comboDir.ValueMember = "DirId";

            comboDep.DataSource = classDepartment.GET_ALL_DEPARTMENT();
            comboDep.DisplayMember = "DepName";
            comboDep.ValueMember = "DepId";


            comboJob.DataSource = classJob.GET_ALL_JOB();
            comboJob.DisplayMember = "jobTit";
            comboJob.ValueMember = "JobTitId";
        }

        public EmployeeAdd(bool updateStatus, string employeeId)
        {
            InitializeComponent();
            comboJobStat.DataSource = classEmployee.GET_ALL_EMP_STAT();
            comboJobStat.DisplayMember = "EmpStatTit";
            comboJobStat.ValueMember = "EmpStatId";

            comboDepType.DataSource = classDepartment.GET_ALL_DEP_TYPE();
            comboDepType.DisplayMember = "DepTypeName";
            comboDepType.ValueMember = "DepTypeId";


            comboDir.DataSource = classDir.GET_ALL_DIR();
            comboDir.DisplayMember = "dirName";
            comboDir.ValueMember = "DirId";

            comboDep.DataSource = classDepartment.GET_ALL_DEPARTMENT();
            comboDep.DisplayMember = "DepName";
            comboDep.ValueMember = "DepId";


            comboJob.DataSource = classJob.GET_ALL_JOB();
            comboJob.DisplayMember = "jobTit";
            comboJob.ValueMember = "JobTitId";
            UpdateStatus = updateStatus;
            EmployeeId = employeeId;
            DataTable EmployeeInfoDataTable = new DataTable();
            EmployeeInfoDataTable = classEmployee.SELECT_EMPLOYEE(employeeId);
            txtName.DataBindings.Add("Text", EmployeeInfoDataTable, "empName");
            txtNid.DataBindings.Add("Text", EmployeeInfoDataTable, "empNid");
            txtIssue.DataBindings.Add("Text", EmployeeInfoDataTable, "empNidIssue");
            comboSex.DataBindings.Add("Text", EmployeeInfoDataTable, "empSex");
            comboRelation.DataBindings.Add("Text", EmployeeInfoDataTable, "empRelation");
            textPoB.DataBindings.Add("Text", EmployeeInfoDataTable, "empPoB");
            dateDoB.DataBindings.Add("Text", EmployeeInfoDataTable, "empDoB");
            txtAddress.DataBindings.Add("Text", EmployeeInfoDataTable, "empAddress");
            txtPhone.DataBindings.Add("Text", EmployeeInfoDataTable, "empPhone");
            txtEmail.DataBindings.Add("Text", EmployeeInfoDataTable, "empEmail");
            txtJobID.DataBindings.Add("Text", EmployeeInfoDataTable, "empJobId");
            dateDoH.DataBindings.Add("Text", EmployeeInfoDataTable, "empDoH");
            comboJob.DataBindings.Add("SelectedValue", EmployeeInfoDataTable, "empJobTitId");
            comboJobStat.DataBindings.Add("SelectedValue", EmployeeInfoDataTable, "empJobStat");
            comboDepType.DataBindings.Add("SelectedValue", EmployeeInfoDataTable, "DepTypeId");
            comboDir.DataBindings.Add("SelectedValue", EmployeeInfoDataTable, "DirId");
            comboDep.DataBindings.Add("SelectedValue", EmployeeInfoDataTable, "empDep");
            dateDead.DataBindings.Add("Text", EmployeeInfoDataTable, "empDoD");
            comboGrad.DataBindings.Add("Text", EmployeeInfoDataTable, "empGrad");
            comboGradTitle.DataBindings.Add("Text", EmployeeInfoDataTable, "empGradTitle");
            comboGradSpec.DataBindings.Add("Text", EmployeeInfoDataTable, "empGradSpec");
            comboGradAccSpec.DataBindings.Add("Text", EmployeeInfoDataTable, "empGradAccSpec");
            //picSelectEmpImg.DataBindings.Add("Image", EmployeeInfoDataTable, "empImage");
            Text = "تعديل موظف";
            btnAddEmp.Text = "تعديل";


            byte[] image = (byte[])classEmployee.GET_EMP_IMAGE(EmployeeId).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            picSelectEmpImg.Image = Image.FromStream(ms);
        }

        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ImageFileDialog = new OpenFileDialog();
            ImageFileDialog.Filter = "ملفات الصور|*.PNG; *.JPG; *.BMP; *.GIF";
            if ( ImageFileDialog.ShowDialog() == DialogResult.OK)
            {
                picSelectEmpImg.Image = Image.FromFile(ImageFileDialog.FileName);
            }
        }

        private void comboJobStat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboJobStat.Text == "متوفي")
            {
                labelDead.Show();
                dateDead.Show();
            }
            else
            {
                labelDead.Hide();
                dateDead.Hide();
            }
        }
       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من انك تريد اغلاق هذة الشاشة", "اضافة موظف", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Close();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtJobID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (!IsValidEmail(txtEmail.Text))
            {
                lblEmail.BackColor = Color.Red;
            }
            else
                lblEmail.BackColor = SystemColors.Control;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (UpdateStatus)
            {
                if (MessageBox.Show("هل انت متاكد من انك تريد تعديل هذا الموظف", "تعديل موظف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                }
                else
                {
                    MessageBox.Show("تم الغاء العملية", "تعديل موظف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                if (MessageBox.Show("هل انت متاكد من انك تريد اضافة هذا الموظف", "اضافة موظف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MemoryStream ms = new MemoryStream();
                    picSelectEmpImg.Image.Save(ms, picSelectEmpImg.Image.RawFormat);
                    byte[] empImg = ms.ToArray();

                    classEmployee.INSERT_EMP
                        (
               txtName.Text,
               txtNid.Text,
               txtIssue.Text,
               comboSex.Text,
               comboRelation.Text,
               dateDoB.Value,
               textPoB.Text,
               txtAddress.Text,
               txtPhone.Text,
               txtEmail.Text,
               empImg,
               txtJobID.Text,
               dateDoH.Value,
               Convert.ToInt32(comboJob.SelectedValue),
               Convert.ToInt32(comboJobStat.SelectedValue),
               Convert.ToInt32(comboDir.SelectedValue),
               dateDead.Value,
               comboGrad.Text,
               comboGradTitle.Text,
               comboGradSpec.Text,
               comboGradAccSpec.Text,
               BL.ClassUserParam.UserId,
               Convert.ToInt32(comboDepType.SelectedValue),
               Convert.ToInt32(comboDep.SelectedValue)
                            );
                    MessageBox.Show("تم اضافة الموظف بنجاح", "اضافة موظف", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("تم الغاء العملية", "اضافة موظف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
                
        }
              
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void EmployeeAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
