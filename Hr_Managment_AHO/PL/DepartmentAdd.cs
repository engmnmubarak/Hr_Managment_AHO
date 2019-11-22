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

    public partial class DepartmentAdd : Form
    {
        BL.ClassEmployee classEmployee = new BL.ClassEmployee();
        BL.ClassDepartment classDepartment = new BL.ClassDepartment();
        BL.ClassDir classDir = new BL.ClassDir();

        private bool UpdateStatus;
        string DepartmentId;

        public DepartmentAdd()
        {
            InitializeComponent();

            comboDepType.DataSource = classDepartment.GET_ALL_DEP_TYPE();
            comboDepType.DisplayMember = "DepTypeName";
            comboDepType.ValueMember = "DepTypeId";

            comboDir.DataSource = classDir.GET_ALL_DIR();
            comboDir.DisplayMember = "dirName";
            comboDir.ValueMember = "DirId";
        }

        public DepartmentAdd(bool updateStatus, string departmentId)
        {
            InitializeComponent();
            DepartmentId = departmentId;
            UpdateStatus = updateStatus;

            comboDepType.DataSource = classDepartment.GET_ALL_DEP_TYPE();
            comboDepType.DisplayMember = "DepTypeName";
            comboDepType.ValueMember = "DepTypeId";

            comboDir.DataSource = classDir.GET_ALL_DIR();
            comboDir.DisplayMember = "dirName";
            comboDir.ValueMember = "DirId";
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txtFax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
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
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void btnAddImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ImageFileDialog = new OpenFileDialog()
            {
                Filter = "ملفات الصور|*.PNG; *.JPG; *.BMP; *.GIF"
            };
            if (ImageFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbxDepImg.Image = Image.FromFile(ImageFileDialog.FileName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (UpdateStatus)
            {
                if (MessageBox.Show("هل انت متاكد من انك تريد تعديل هذا المرفق", "تعديل مرفق", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                }
                else
                {
                    MessageBox.Show("تم الغاء العملية", "تعديل مرفق", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                pbxDepImg.Image.Save(ms, pbxDepImg.Image.RawFormat);
                byte[] DepImg = ms.ToArray();
                int.TryParse(txtDepPhone.Text, out int DepPhone);
                classDepartment.ADD_DEP(

                txtDepName.Text
               , txtDepAddress.Text
               , DepPhone
               , txtDepEmail.Text
               , DepImg
               , txtFax.Text
               , Convert.ToInt32(comboDepType.SelectedValue)
               , Convert.ToInt32(comboDir.SelectedValue));
                MessageBox.Show("تم اضافة مرفق بنجاح", "اضافة مرفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
        }
        private void ClearForm()
        {
            txtDepName.Text = string.Empty;
            txtDepAddress.Text = string.Empty;
            txtDepPhone.Text = string.Empty;
            txtDepEmail.Text = string.Empty;
            txtFax.Text = string.Empty;
            comboDepType.SelectedText = string.Empty;
            comboDir.SelectedText = string.Empty;
        }
    }
}
