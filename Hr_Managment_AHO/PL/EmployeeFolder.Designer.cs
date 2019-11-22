namespace Hr_Managment_AHO.PL
{
    partial class EmployeeFolder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DgvEmpFolder = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnShowImg = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddDoc = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pictureBoxEmp = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDep = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtJopTit = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpFolder)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(642, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "الاسم:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(368, 2);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(221, 20);
            this.txtName.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DgvEmpFolder);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 350);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "وثائق الموظف:";
            // 
            // DgvEmpFolder
            // 
            this.DgvEmpFolder.AllowUserToAddRows = false;
            this.DgvEmpFolder.AllowUserToDeleteRows = false;
            this.DgvEmpFolder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvEmpFolder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEmpFolder.Location = new System.Drawing.Point(-11, 19);
            this.DgvEmpFolder.Name = "DgvEmpFolder";
            this.DgvEmpFolder.ReadOnly = true;
            this.DgvEmpFolder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvEmpFolder.Size = new System.Drawing.Size(703, 325);
            this.DgvEmpFolder.TabIndex = 0;
            this.DgvEmpFolder.DoubleClick += new System.EventHandler(this.DgvEmpFolder_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnShowImg);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnAddDoc);
            this.groupBox2.Location = new System.Drawing.Point(12, 415);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(715, 53);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات:";
            // 
            // btnShowImg
            // 
            this.btnShowImg.Location = new System.Drawing.Point(247, 19);
            this.btnShowImg.Name = "btnShowImg";
            this.btnShowImg.Size = new System.Drawing.Size(111, 23);
            this.btnShowImg.TabIndex = 4;
            this.btnShowImg.Text = "عرض الوثيقة";
            this.btnShowImg.UseVisualStyleBackColor = true;
            this.btnShowImg.Click += new System.EventHandler(this.btnShowImg_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(481, 19);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(111, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "تعديل  ";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(6, 19);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "اغلاق";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(364, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "حدف ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddDoc
            // 
            this.btnAddDoc.Location = new System.Drawing.Point(598, 19);
            this.btnAddDoc.Name = "btnAddDoc";
            this.btnAddDoc.Size = new System.Drawing.Size(111, 23);
            this.btnAddDoc.TabIndex = 0;
            this.btnAddDoc.Text = "اضافة ";
            this.btnAddDoc.UseVisualStyleBackColor = true;
            this.btnAddDoc.Click += new System.EventHandler(this.btnAddDoc_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 40);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(47, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "تحديث";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pictureBoxEmp
            // 
            this.pictureBoxEmp.Location = new System.Drawing.Point(681, 0);
            this.pictureBoxEmp.Name = "pictureBoxEmp";
            this.pictureBoxEmp.Size = new System.Drawing.Size(54, 58);
            this.pictureBoxEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEmp.TabIndex = 11;
            this.pictureBoxEmp.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(635, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "المرفق:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDep
            // 
            this.txtDep.Location = new System.Drawing.Point(368, 22);
            this.txtDep.Name = "txtDep";
            this.txtDep.ReadOnly = true;
            this.txtDep.Size = new System.Drawing.Size(221, 20);
            this.txtDep.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(591, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "المسمى الوظيفي:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtJopTit
            // 
            this.txtJopTit.Location = new System.Drawing.Point(368, 42);
            this.txtJopTit.Name = "txtJopTit";
            this.txtJopTit.ReadOnly = true;
            this.txtJopTit.Size = new System.Drawing.Size(221, 20);
            this.txtJopTit.TabIndex = 14;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(1, 0);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(65, 20);
            this.txtId.TabIndex = 16;
            // 
            // EmployeeFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(739, 480);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtJopTit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDep);
            this.Controls.Add(this.pictureBoxEmp);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Name = "EmployeeFolder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعبئة ملف الموظف";
            this.Load += new System.EventHandler(this.EmployeeFolder_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpFolder)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddDoc;
        public System.Windows.Forms.DataGridView DgvEmpFolder;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnShowImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.PictureBox pictureBoxEmp;
        public System.Windows.Forms.TextBox txtDep;
        public System.Windows.Forms.TextBox txtJopTit;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtId;
    }
}