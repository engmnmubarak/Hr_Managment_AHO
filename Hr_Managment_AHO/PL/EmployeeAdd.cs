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
        public static string Id;
        private bool IsUpdate;
        //DateTime DATE_OF_BIRTH, DATE_OF_DIE;
        Image PIRSONAL_IMAGE = null;

        BL.ClassEmployee classEmployee = new BL.ClassEmployee();
        BL.ClassJob classJob = new BL.ClassJob();
        BL.ClassDepartment classDepartment = new BL.ClassDepartment();
        BL.ClassDir classDir = new BL.ClassDir();
        
        public EmployeeAdd()
        {
            InitializeComponent();
            CombosDataSource();
        }

        public EmployeeAdd(string id)
        {
            InitializeComponent();
            CombosDataSource();
        }

        public EmployeeAdd(bool isUpdate, string id)
        {
            InitializeComponent();
            IsUpdate = isUpdate;
            Id = id;
            CombosDataSource();
            BindingInfo(id);
            SetUpdateForm();
        }

        //بداية قسم المعلومات الشخصية
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtNationalId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ImageFileDialog = new OpenFileDialog();
            ImageFileDialog.Filter = "ملفات الصور|*.PNG; *.JPG; *.BMP; *.GIF";
            if (ImageFileDialog.ShowDialog() == DialogResult.OK)
            {
                PIRSONAL_IMAGE = Image.FromFile(ImageFileDialog.FileName);
                picSelectEmpImg.Image = PIRSONAL_IMAGE;
            }
        }

        //بداية قسم المعلومات الوظيفية
        private void txtJobID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
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

        //بداية قسم معلومات الاتصال
        private void txtPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!IsValidEmail(txtEmail.Text))
            {
                lblEmail.BackColor = Color.Red;
            }
            else
                lblEmail.BackColor = SystemColors.Control;
        }

        //بداية قسم الازرة
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsUpdate)
            {
                if (MessageBox.Show("هل انت متاكد من انك تريد تعديل هذا الموظف", "تعديل موظف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    byte[] empImg = null;
                    if (PIRSONAL_IMAGE != null)
                    {
                        MemoryStream ms = new MemoryStream();
                        PIRSONAL_IMAGE.Save(ms, picSelectEmpImg.Image.RawFormat);
                        empImg = ms.ToArray();
                    }
                    classEmployee.UPDATE_EMPLOYEE
                        (
                        Id,
                        txtName.Text,
               txtNationalId.Text,
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
                    byte[] empImg = null;
                    if (PIRSONAL_IMAGE != null)
                    {
                        MemoryStream ms = new MemoryStream();
                        PIRSONAL_IMAGE.Save(ms, picSelectEmpImg.Image.RawFormat);
                        empImg = ms.ToArray();
                    }
                    

                    classEmployee.INSERT_EMP
                        (
               txtName.Text,
               txtNationalId.Text,
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من انك تريد اغلاق هذة الشاشة", "اضافة موظف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        //بداية العمليات
        private void CombosDataSource()
        {
            //comboJobStat
            comboJobStat.DataSource = classEmployee.GET_ALL_EMP_STAT();
            comboJobStat.DisplayMember = "EmpStatTit";
            comboJobStat.ValueMember = "EmpStatId";
            //comboDepType
            comboDepType.DataSource = classDepartment.GET_ALL_DEP_TYPE();
            comboDepType.DisplayMember = "DepTypeName";
            comboDepType.ValueMember = "DepTypeId";
            //comboDir
            comboDir.DataSource = classDir.GET_ALL_DIR();
            comboDir.DisplayMember = "dirName";
            comboDir.ValueMember = "DirId";
            //comboDep
            comboDep.DataSource = classDepartment.GET_ALL_DEPARTMENT();
            comboDep.DisplayMember = "DepName";
            comboDep.ValueMember = "DepId";
            //comboJob
            comboJob.DataSource = classJob.GET_ALL_JOB();
            comboJob.DisplayMember = "jobTit";
            comboJob.ValueMember = "JobTitId";
        }

        private void BindingInfo(string id)
        {
            DataTable EmployeeInfoDataTable = classEmployee.SELECT_EMPLOYEE(id);
            //المعلومات الشخصية
            txtName.DataBindings.Add("Text", EmployeeInfoDataTable, "empName");
            txtNationalId.DataBindings.Add("Text", EmployeeInfoDataTable, "empNid");
            txtIssue.DataBindings.Add("Text", EmployeeInfoDataTable, "empNidIssue");
            comboSex.DataBindings.Add("Text", EmployeeInfoDataTable, "empSex");
            comboRelation.DataBindings.Add("Text", EmployeeInfoDataTable, "empRelation");
            textPoB.DataBindings.Add("Text", EmployeeInfoDataTable, "empPoB");
            dateDoB.DataBindings.Add("Text", EmployeeInfoDataTable, "empDoB");
            byte[] image = (byte[])classEmployee.GET_EMP_IMAGE(id).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            picSelectEmpImg.Image = Image.FromStream(ms);
            PIRSONAL_IMAGE = Image.FromStream(ms);
            //معلومات الاتصال
            txtAddress.DataBindings.Add("Text", EmployeeInfoDataTable, "empAddress");
            txtPhone.DataBindings.Add("Text", EmployeeInfoDataTable, "empPhone");
            txtEmail.DataBindings.Add("Text", EmployeeInfoDataTable, "empEmail");
            //المعلومات الوظيفية
            txtJobID.DataBindings.Add("Text", EmployeeInfoDataTable, "empJobId");
            dateDoH.DataBindings.Add("Text", EmployeeInfoDataTable, "empDoH");
            comboJob.DataBindings.Add("SelectedValue", EmployeeInfoDataTable, "empJobTitId");
            comboJobStat.DataBindings.Add("SelectedValue", EmployeeInfoDataTable, "empJobStat");
            comboDepType.DataBindings.Add("SelectedValue", EmployeeInfoDataTable, "DepTypeId");
            comboDir.DataBindings.Add("SelectedValue", EmployeeInfoDataTable, "DirId");
            comboDep.DataBindings.Add("SelectedValue", EmployeeInfoDataTable, "empDep");
            dateDead.DataBindings.Add("Text", EmployeeInfoDataTable, "empDoD");
            //المؤهلات العلمية
            comboGrad.DataBindings.Add("Text", EmployeeInfoDataTable, "empGrad");
            comboGradTitle.DataBindings.Add("Text", EmployeeInfoDataTable, "empGradTitle");
            comboGradSpec.DataBindings.Add("Text", EmployeeInfoDataTable, "empGradSpec");
            comboGradAccSpec.DataBindings.Add("Text", EmployeeInfoDataTable, "empGradAccSpec");

        }

        private void SetUpdateForm()
        {
            Text = "تعديل موظف";
            btnAdd.Text = "تعديل";
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


    }
}
