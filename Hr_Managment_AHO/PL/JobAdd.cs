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
    public partial class JobAdd : Form
    {
        public static bool UpdateStatus;
        public static int JobId;

        public JobAdd()
        {
            InitializeComponent();
        }
        public JobAdd(int jobId,bool updateStatus)
        {
            InitializeComponent();
            JobId = jobId;
            UpdateStatus = updateStatus;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BL.ClassJob classJob = new BL.ClassJob();

            if (UpdateStatus)
            {
                DataTable dt = classJob.SELECT_SAME_JOB(txtJobTit.Text);
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("المسمى الوظيفي موجود من قبل", "عملية تعديل", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    classJob.UPDATE_JOB(JobId, txtJobTit.Text);
                    JobManagment.getJobManagment.SetDataSourceJob();
                    Close();
                }
            }
            else
            {
                DataTable dt = classJob.SELECT_SAME_JOB(txtJobTit.Text);
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("المسمى الوظيفي موجود من قبل", "عملية اضافة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    classJob.INSERT_JOB_TIT(txtJobTit.Text);
                    JobManagment.getJobManagment.SetDataSourceJob();
                    Close();
                }
            }
        }
    }
}
