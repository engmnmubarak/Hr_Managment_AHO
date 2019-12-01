using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hr_Managment_AHO.BL;
using Hr_Managment_AHO.PL;
using System.Data.SqlClient;

namespace Hr_Managment_AHO
{
    public partial class MainForm : Form
    {
        private static MainForm mainForm; //object for main form

        private static void frm_FormClosed(object sender,FormClosedEventArgs e)
        {
            mainForm = null;
        }

        public static MainForm getMainForm 
        {
            get
            {
                // check if form is open or not
                if (mainForm==null)
                {
                    mainForm = new MainForm();// creating the form
                    mainForm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return mainForm; 
            }
        }

        public MainForm()
        {
            
            InitializeComponent();
            if (mainForm == null)
            {
                mainForm = this;
                UserLogin userLogin = new UserLogin();
                userLogin.ShowDialog();
            }
            
        }

        
        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserLogin login = new UserLogin();
            login.ShowDialog();
        }

        private void إضافةموظفجديدToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EmployeeAdd addEmpForm = new EmployeeAdd();
            addEmpForm.ShowDialog();
        }

        private void AddNewDepartment_Click(object sender, EventArgs e)
        {
            DepartmentAdd AddDepForm = new DepartmentAdd();
            AddDepForm.Show();
        }

        private void TsmiAddNewUser_Click(object sender, EventArgs e)
        {
            UserAdd UserAdd = new UserAdd();
            UserAdd.Show();
        }

        private void خــــروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TsmiEntry.Enabled = false;
            TsmiManagment.Enabled = false;
            ResetUser();
            Close();
        }

        private void تسجيلالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainForm == null)
                mainForm = this;

            // to control enable and disable krys in menu strip in main form
            TsmiEntry.Enabled = false;
            TsmiManagment.Enabled = false;
            ResetUser();
        }

        private void tsmiMngUsers_Click(object sender, EventArgs e)
        {
            UserManagment UserManagment = new UserManagment();
            UserManagment.Show();
        }

        public void ResetUser()
        {
            ClassUserParam.UserId = Convert.ToInt32("0");
            ClassUserParam.UserName = Convert.ToString("");
            ClassUserParam.UserPassword = Convert.ToString("");
            ClassUserParam.UserType = Convert.ToString("");
        }

        private void CheckUser(string userType)
        {
            if (userType == "مدير")
            {
                MainForm.getMainForm.TsmiEntry.Enabled = true;
                MainForm.getMainForm.TsmiManagment.Enabled = true;
            }
            else if (userType == "مدخل")
            {
                MainForm.getMainForm.TsmiEntry.Enabled = true;
                MainForm.getMainForm.TsmiManagment.Enabled = false;
            }
            else
            {
                MainForm.getMainForm.TsmiEntry.Enabled = false;
                MainForm.getMainForm.TsmiManagment.Enabled = false;
            }
        }

        private void AddNewDepartment_Click_1(object sender, EventArgs e)
        {
            DepartmentAdd departmentAdd = new DepartmentAdd();
            departmentAdd.ShowDialog();
        }

        private void tsmiMngEmps_Click(object sender, EventArgs e)
        {
            EmployeeManagment employeeManagment = new EmployeeManagment();
            employeeManagment.Show();
        }

        private void tsmiMngUsers_Click_1(object sender, EventArgs e)
        {
            UserManagment userManagment = new UserManagment();
            userManagment.Show();
        }

        private void TsmiAddNewUser_Click_1(object sender, EventArgs e)
        {
            UserAdd userAdd = new UserAdd();
            userAdd.Show();
        }

        private void tsmiJobManagment_Click(object sender, EventArgs e)
        {
            JobManagment jobManagment = new JobManagment();
            jobManagment.Show();
        }

        private void tsmiAddJob_Click(object sender, EventArgs e)
        {
            JobAdd jobAdd = new JobAdd();
            jobAdd.Show();

        }

        private void إدارةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartmentManagment departmentManagment = new DepartmentManagment();
            departmentManagment.Show();
        }

        private void إنشاءنسخةإحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Backup Files (*.Bak) |*.bak";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                CommandExecuter("BACKUP DATABASE [AHO_DB] TO  DISK ='" + sf.FileName + "'", false);
                MessageBox.Show("تم انشاء النسخة بنجاح", "انشاء نسخة احتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //BackupForm backup = new BackupForm();
            //backup.Show();
        }

        private void إستعادةنسخةإحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Backup Files (*.Bak) |*.bak";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                CommandExecuter("RESTORE DATABASE [AHO_DB] FROM  DISK ='" + openFileDialog.FileName + "'", true);
                MessageBox.Show("تم استعادة النسخة بنجاح", "استعادة نسخة احتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //BackupForm restore = new BackupForm(true);
            //restore.Show();
        }

        private void CommandExecuter(string sqlCommand, bool restore)
        {
            if (restore)
            {
                DAL.DataAccessLayer DAL = new DAL.DataAccessLayer(restore);
                SqlCommand command;
                command = new SqlCommand(sqlCommand, DAL.sqlconnection);
                DAL.Open();
                command.ExecuteNonQuery();
                DAL.Close();
            }
            else
            {
                DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
                SqlCommand command;
                command = new SqlCommand(sqlCommand, DAL.sqlconnection);
                DAL.Open();
                command.ExecuteNonQuery();
                DAL.Close();
            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
