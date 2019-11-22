using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hr_Managment_AHO.PL
{
    public partial class JobManagment : Form
        
    {
        private static JobManagment jobManagment; //object for main form

        
        private static void JobManagment_FormClosed(object sender, FormClosedEventArgs e)
        {
            jobManagment = null;

        }
        public static JobManagment getJobManagment
        {
            get
            {
                // check if form is open or not
                if (jobManagment == null)
                {
                    jobManagment = new JobManagment();// creating the form
                    jobManagment.FormClosed += new FormClosedEventHandler(JobManagment_FormClosed);
                }
                    return jobManagment;
            }
        }
        public JobManagment()
        {
            InitializeComponent();
            if (jobManagment == null)
                jobManagment = this;
            SetDataSourceJob();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            SetDataSourceJob();
        }

        public void SetDataSourceJob()
        {
            BL.ClassJob Cjob = new BL.ClassJob();
            dataGridViewJob.DataSource = Cjob.GET_ALL_JOB();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            JobAdd jobAdd = new JobAdd();
            jobAdd.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حدف المسمى الوظيفي المحدد", "عملية الحدف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                BL.ClassJob classJob = new BL.ClassJob();
                classJob.DELETE_JOB(Convert.ToInt32(dataGridViewJob.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("تم الحدف بنجاح", "عملية الحدف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetDataSourceJob();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            JobAdd jobAdd = new JobAdd(Convert.ToInt32(dataGridViewJob.CurrentRow.Cells[0].Value.ToString()),true);
            jobAdd.Text = "تعديل مسمى وظيفي";
            jobAdd.txtJobTit.Text = dataGridViewJob.CurrentRow.Cells[1].Value.ToString();
            jobAdd.btnAdd.Text = "تعديل";
            jobAdd.ShowDialog();
        }

        
    }
}
