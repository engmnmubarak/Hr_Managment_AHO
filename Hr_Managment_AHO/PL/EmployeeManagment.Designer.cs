namespace Hr_Managment_AHO.PL
{
    partial class EmployeeManagment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeManagment));
            this.labelSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkFilter = new System.Windows.Forms.CheckBox();
            this.groupFilter = new System.Windows.Forms.GroupBox();
            this.radioStatus = new System.Windows.Forms.RadioButton();
            this.radioDir = new System.Windows.Forms.RadioButton();
            this.radioDepartment = new System.Windows.Forms.RadioButton();
            this.comboFilter = new System.Windows.Forms.ComboBox();
            this.dataGridViewEmp = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDocument = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmp)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(888, 30);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelSearch.Size = new System.Drawing.Size(33, 17);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "بحث:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(189, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(674, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkFilter);
            this.groupBox1.Controls.Add(this.groupFilter);
            this.groupBox1.Controls.Add(this.dataGridViewEmp);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(964, 361);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "قائمة الموظفين:";
            // 
            // checkFilter
            // 
            this.checkFilter.AutoSize = true;
            this.checkFilter.Location = new System.Drawing.Point(775, 26);
            this.checkFilter.Name = "checkFilter";
            this.checkFilter.Size = new System.Drawing.Size(76, 17);
            this.checkFilter.TabIndex = 12;
            this.checkFilter.Text = "فرز حسب/";
            this.checkFilter.UseVisualStyleBackColor = true;
            this.checkFilter.CheckedChanged += new System.EventHandler(this.checkFilter_CheckedChanged);
            // 
            // groupFilter
            // 
            this.groupFilter.Controls.Add(this.radioStatus);
            this.groupFilter.Controls.Add(this.radioDir);
            this.groupFilter.Controls.Add(this.radioDepartment);
            this.groupFilter.Controls.Add(this.comboFilter);
            this.groupFilter.Enabled = false;
            this.groupFilter.Location = new System.Drawing.Point(6, 9);
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.Size = new System.Drawing.Size(763, 45);
            this.groupFilter.TabIndex = 11;
            this.groupFilter.TabStop = false;
            // 
            // radioStatus
            // 
            this.radioStatus.AutoSize = true;
            this.radioStatus.Location = new System.Drawing.Point(448, 17);
            this.radioStatus.Name = "radioStatus";
            this.radioStatus.Size = new System.Drawing.Size(93, 17);
            this.radioStatus.TabIndex = 8;
            this.radioStatus.TabStop = true;
            this.radioStatus.Text = "الوضع الوظيفي";
            this.radioStatus.UseVisualStyleBackColor = true;
            this.radioStatus.CheckedChanged += new System.EventHandler(this.radioStatus_CheckedChanged);
            // 
            // radioDir
            // 
            this.radioDir.AutoSize = true;
            this.radioDir.Location = new System.Drawing.Point(571, 17);
            this.radioDir.Name = "radioDir";
            this.radioDir.Size = new System.Drawing.Size(64, 17);
            this.radioDir.TabIndex = 7;
            this.radioDir.TabStop = true;
            this.radioDir.Text = "المديرية ";
            this.radioDir.UseVisualStyleBackColor = true;
            this.radioDir.CheckedChanged += new System.EventHandler(this.radioDir_CheckedChanged);
            // 
            // radioDepartment
            // 
            this.radioDepartment.AutoSize = true;
            this.radioDepartment.Location = new System.Drawing.Point(692, 17);
            this.radioDepartment.Name = "radioDepartment";
            this.radioDepartment.Size = new System.Drawing.Size(58, 17);
            this.radioDepartment.TabIndex = 6;
            this.radioDepartment.TabStop = true;
            this.radioDepartment.Text = "المرفق";
            this.radioDepartment.UseVisualStyleBackColor = true;
            this.radioDepartment.CheckedChanged += new System.EventHandler(this.radioDepartment_CheckedChanged);
            // 
            // comboFilter
            // 
            this.comboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFilter.FormattingEnabled = true;
            this.comboFilter.Location = new System.Drawing.Point(6, 15);
            this.comboFilter.Name = "comboFilter";
            this.comboFilter.Size = new System.Drawing.Size(427, 21);
            this.comboFilter.TabIndex = 4;
            this.comboFilter.DropDownClosed += new System.EventHandler(this.comboFilter_DropDownClosed);
            // 
            // dataGridViewEmp
            // 
            this.dataGridViewEmp.AllowUserToAddRows = false;
            this.dataGridViewEmp.AllowUserToDeleteRows = false;
            this.dataGridViewEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmp.Location = new System.Drawing.Point(4, 60);
            this.dataGridViewEmp.Name = "dataGridViewEmp";
            this.dataGridViewEmp.ReadOnly = true;
            this.dataGridViewEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmp.Size = new System.Drawing.Size(955, 295);
            this.dataGridViewEmp.TabIndex = 0;
            this.dataGridViewEmp.DoubleClick += new System.EventHandler(this.dataGridViewEmp_DoubleClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Gray;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(12, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnRefresh.Size = new System.Drawing.Size(50, 26);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "تحديث";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(285, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "إضـافـة ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(105, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "حــذف ";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDocument
            // 
            this.btnDocument.BackColor = System.Drawing.Color.Gray;
            this.btnDocument.FlatAppearance.BorderSize = 0;
            this.btnDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocument.ForeColor = System.Drawing.Color.White;
            this.btnDocument.Location = new System.Drawing.Point(860, 435);
            this.btnDocument.Name = "btnDocument";
            this.btnDocument.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDocument.Size = new System.Drawing.Size(107, 26);
            this.btnDocument.TabIndex = 5;
            this.btnDocument.Text = "عـرض الـوثائـق";
            this.btnDocument.UseVisualStyleBackColor = false;
            this.btnDocument.Click += new System.EventHandler(this.btnDocument_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(12, 440);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "إلــغــاء";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gray;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(195, 13);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "تعـديـل";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPrint);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Location = new System.Drawing.Point(361, 422);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 41);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "العمليات/";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Gray;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(15, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // EmployeeManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(988, 475);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDocument);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.labelSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeManagment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ادارة الموظفين";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupFilter.ResumeLayout(false);
            this.groupFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmp)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewEmp;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDocument;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox groupFilter;
        private System.Windows.Forms.ComboBox comboFilter;
        private System.Windows.Forms.CheckBox checkFilter;
        private System.Windows.Forms.RadioButton radioStatus;
        private System.Windows.Forms.RadioButton radioDir;
        private System.Windows.Forms.RadioButton radioDepartment;
    }
}