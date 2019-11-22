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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboJobStat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboDir = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboDep = new System.Windows.Forms.ComboBox();
            this.dataGridViewEmp = new System.Windows.Forms.DataGridView();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.btnDelEmp = new System.Windows.Forms.Button();
            this.btnDoc = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmp)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(787, 30);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(183, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "قم بادخال الكلمة المراد البحث عنها هنا:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(312, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(469, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dataGridViewEmp);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(964, 361);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "قائمة الموظفين:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(903, 36);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(42, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "فرز";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboJobStat);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboDir);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboDep);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(225, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(661, 45);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "فرز الموظفين حسب/";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 17);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnRefresh.Size = new System.Drawing.Size(63, 23);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "الغاء الفرز";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "الوضع الوظيفي:";
            // 
            // comboJobStat
            // 
            this.comboJobStat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboJobStat.FormattingEnabled = true;
            this.comboJobStat.Location = new System.Drawing.Point(81, 13);
            this.comboJobStat.Name = "comboJobStat";
            this.comboJobStat.Size = new System.Drawing.Size(121, 21);
            this.comboJobStat.TabIndex = 4;
            this.comboJobStat.DropDownClosed += new System.EventHandler(this.comboJobStat_DropDownClosed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "المديرية:";
            // 
            // comboDir
            // 
            this.comboDir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDir.FormattingEnabled = true;
            this.comboDir.Location = new System.Drawing.Point(308, 13);
            this.comboDir.Name = "comboDir";
            this.comboDir.Size = new System.Drawing.Size(121, 21);
            this.comboDir.TabIndex = 2;
            this.comboDir.DropDownClosed += new System.EventHandler(this.comboDir_DropDownClosed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(617, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "المرفق:";
            // 
            // comboDep
            // 
            this.comboDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDep.FormattingEnabled = true;
            this.comboDep.Location = new System.Drawing.Point(487, 13);
            this.comboDep.Name = "comboDep";
            this.comboDep.Size = new System.Drawing.Size(121, 21);
            this.comboDep.TabIndex = 0;
            this.comboDep.SelectedIndexChanged += new System.EventHandler(this.comboDep_SelectedIndexChanged);
            this.comboDep.DropDownClosed += new System.EventHandler(this.comboDep_DropDownClosed);
            // 
            // dataGridViewEmp
            // 
            this.dataGridViewEmp.AllowUserToAddRows = false;
            this.dataGridViewEmp.AllowUserToDeleteRows = false;
            this.dataGridViewEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmp.Location = new System.Drawing.Point(4, 59);
            this.dataGridViewEmp.Name = "dataGridViewEmp";
            this.dataGridViewEmp.ReadOnly = true;
            this.dataGridViewEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmp.Size = new System.Drawing.Size(955, 296);
            this.dataGridViewEmp.TabIndex = 0;
            this.dataGridViewEmp.DoubleClick += new System.EventHandler(this.dataGridViewEmp_DoubleClick);
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Location = new System.Drawing.Point(193, 13);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddEmp.Size = new System.Drawing.Size(75, 23);
            this.btnAddEmp.TabIndex = 3;
            this.btnAddEmp.Text = "اضافة ";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // btnDelEmp
            // 
            this.btnDelEmp.Location = new System.Drawing.Point(104, 13);
            this.btnDelEmp.Name = "btnDelEmp";
            this.btnDelEmp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDelEmp.Size = new System.Drawing.Size(75, 23);
            this.btnDelEmp.TabIndex = 4;
            this.btnDelEmp.Text = "حدف ";
            this.btnDelEmp.UseVisualStyleBackColor = true;
            this.btnDelEmp.Click += new System.EventHandler(this.btnDelEmp_Click);
            // 
            // btnDoc
            // 
            this.btnDoc.Location = new System.Drawing.Point(892, 435);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDoc.Size = new System.Drawing.Size(75, 23);
            this.btnDoc.TabIndex = 5;
            this.btnDoc.Text = "عرض الوثائق";
            this.btnDoc.UseVisualStyleBackColor = true;
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 422);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "اغلاق";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(15, 13);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "تعديل";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddEmp);
            this.groupBox3.Controls.Add(this.btnDelEmp);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Location = new System.Drawing.Point(444, 422);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 41);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "العمليات/";
            // 
            // EmployeeManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(988, 475);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDoc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeManagment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ادارة الموظفين";
            this.Load += new System.EventHandler(this.EmployeeManagment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmp)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewEmp;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Button btnDelEmp;
        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboJobStat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboDep;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}