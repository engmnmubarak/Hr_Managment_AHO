using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hr_Managment_AHO.PL
{
    public partial class BackupForm : Form
    {
        bool Restore;
        public BackupForm()
        {
            InitializeComponent();
            Restore = false;
        }

        public BackupForm(bool restore)
        {
            InitializeComponent();
            Restore = restore;

        }


        private void BackupForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBackup_Click_1(object sender, EventArgs e)
        {

            if (Restore)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Backup Files (*.Bak) |*.bak";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    CommandExecuter("RESTORE DATABASE [AHO_DB] FROM  DISK ='" + openFileDialog.FileName + "'", Restore);
                    MessageBox.Show("تم استعادة النسخة بنجاح", "استعادة نسخة احتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Backup Files (*.Bak) |*.bak";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    CommandExecuter("BACKUP DATABASE [AHO_DB] TO  DISK ='" + sf.FileName + "'", Restore);
                    MessageBox.Show("تم انشاء النسخة بنجاح", "انشاء نسخة احتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }


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
    }
}
