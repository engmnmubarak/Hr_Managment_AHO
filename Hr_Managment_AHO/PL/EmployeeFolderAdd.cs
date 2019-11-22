using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hr_Managment_AHO.BL;
using System.IO;

namespace Hr_Managment_AHO.PL
{
    public partial class EmployeeFolderAdd : Form
    {
        private static int EmpId;
        private static int ImageId;
        private bool UpdateStatus;
        public EmployeeFolderAdd(bool updateStatus, int imageId )
        {
            InitializeComponent();
            UpdateStatus = updateStatus;
            ImageId = imageId;
        }

        public EmployeeFolderAdd(int empId)
        {
            InitializeComponent();
            EmpId = empId;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectDoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ImageFileDialog = new OpenFileDialog()
            {
                Filter = "ملفات الصور|*.PNG; *.JPG; *.BMP; *.GIF"
            };
            if (ImageFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxDoc.Image = Image.FromFile(ImageFileDialog.FileName);
            }
        }

        private void btnAddDoc_Click(object sender, EventArgs e)
        {
            if (UpdateStatus)
            {
                MemoryStream ms = new MemoryStream();
                pictureBoxDoc.Image.Save(ms, pictureBoxDoc.Image.RawFormat);
                byte[] docImg = ms.ToArray();

                if (Convert.ToInt32(comboDocTit.SelectedValue) >= 0 && docImg.Length > 1)
                {
                    ClassEmployee employee = new ClassEmployee();
                    employee.UPDATE_DOC
                        (
                        ImageId,
                        docImg,
                        comboDocTit.Text,
                        txtDocDesc.Text,
                        txtDocIssue.Text,
                        DtpDoc.Value,
                        ClassUserParam.UserId
                        );
                    MessageBox.Show("تم تعديل الوثيقة بنجاح", "تعديل وثيقة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();

                }
                else
                {
                    MessageBox.Show("البيانات غير مكتملة", "تعديل وثيقة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                pictureBoxDoc.Image.Save(ms, pictureBoxDoc.Image.RawFormat);
                byte[] docImg = ms.ToArray();

                if (Convert.ToInt32(comboDocTit.SelectedValue) >= 0 && docImg.Length > 1)
                {
                    ClassDoc classDoc = new ClassDoc();
                    classDoc.INSERT_DOC
                        (
                        docImg,
                        comboDocTit.Text,
                        txtDocDesc.Text,
                        txtDocIssue.Text,
                        DtpDoc.Value,
                        EmpId,
                        ClassUserParam.UserId
                        );
                    EmployeeFolder.GetEmployeeFolder.DgvEmpFolder.DataSource = classDoc.GET_EMP_FOLDER(Convert.ToInt32(EmpId));
                    this.Close();

                }
                else
                {
                    MessageBox.Show("البيانات غير مكتملة", "اضافة وثيقة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }
    }
}
