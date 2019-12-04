namespace Hr_Managment_AHO.PL
{
    partial class DepartmentManagment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentManagment));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupFilter = new System.Windows.Forms.GroupBox();
            this.radioType = new System.Windows.Forms.RadioButton();
            this.comboFilter = new System.Windows.Forms.ComboBox();
            this.radioDir = new System.Windows.Forms.RadioButton();
            this.dataGridViewDep = new System.Windows.Forms.DataGridView();
            this.checkFilter = new System.Windows.Forms.CheckBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchDep = new System.Windows.Forms.TextBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1.SuspendLayout();
            this.groupFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDep)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupFilter);
            this.groupBox1.Controls.Add(this.dataGridViewDep);
            this.groupBox1.Controls.Add(this.checkFilter);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(872, 401);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "قائمة المرافق/";
            // 
            // groupFilter
            // 
            this.groupFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupFilter.Controls.Add(this.radioType);
            this.groupFilter.Controls.Add(this.comboFilter);
            this.groupFilter.Controls.Add(this.radioDir);
            this.groupFilter.Enabled = false;
            this.groupFilter.Location = new System.Drawing.Point(6, 9);
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupFilter.Size = new System.Drawing.Size(640, 38);
            this.groupFilter.TabIndex = 8;
            this.groupFilter.TabStop = false;
            // 
            // radioType
            // 
            this.radioType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioType.AutoSize = true;
            this.radioType.Location = new System.Drawing.Point(441, 13);
            this.radioType.Name = "radioType";
            this.radioType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioType.Size = new System.Drawing.Size(53, 17);
            this.radioType.TabIndex = 0;
            this.radioType.TabStop = true;
            this.radioType.Text = "الفئة  ";
            this.radioType.UseVisualStyleBackColor = true;
            this.radioType.CheckedChanged += new System.EventHandler(this.radioType_CheckedChanged);
            // 
            // comboFilter
            // 
            this.comboFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFilter.FormattingEnabled = true;
            this.comboFilter.Location = new System.Drawing.Point(6, 11);
            this.comboFilter.Name = "comboFilter";
            this.comboFilter.Size = new System.Drawing.Size(398, 21);
            this.comboFilter.TabIndex = 2;
            this.comboFilter.DropDownClosed += new System.EventHandler(this.comboFilter_DropDownClosed);
            // 
            // radioDir
            // 
            this.radioDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioDir.AutoSize = true;
            this.radioDir.Location = new System.Drawing.Point(529, 13);
            this.radioDir.Name = "radioDir";
            this.radioDir.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioDir.Size = new System.Drawing.Size(105, 17);
            this.radioDir.TabIndex = 1;
            this.radioDir.TabStop = true;
            this.radioDir.Text = "المديرية الصحية   ";
            this.radioDir.UseVisualStyleBackColor = true;
            this.radioDir.CheckedChanged += new System.EventHandler(this.radioDir_CheckedChanged);
            // 
            // dataGridViewDep
            // 
            this.dataGridViewDep.AllowUserToAddRows = false;
            this.dataGridViewDep.AllowUserToDeleteRows = false;
            this.dataGridViewDep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDep.Location = new System.Drawing.Point(6, 53);
            this.dataGridViewDep.Name = "dataGridViewDep";
            this.dataGridViewDep.ReadOnly = true;
            this.dataGridViewDep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDep.Size = new System.Drawing.Size(860, 342);
            this.dataGridViewDep.TabIndex = 0;
            this.dataGridViewDep.DoubleClick += new System.EventHandler(this.dataGridViewDep_DoubleClick);
            // 
            // checkFilter
            // 
            this.checkFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkFilter.AutoSize = true;
            this.checkFilter.Location = new System.Drawing.Point(652, 20);
            this.checkFilter.Name = "checkFilter";
            this.checkFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkFilter.Size = new System.Drawing.Size(76, 17);
            this.checkFilter.TabIndex = 9;
            this.checkFilter.Text = "فرز حسب/";
            this.checkFilter.UseVisualStyleBackColor = true;
            this.checkFilter.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(809, 438);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "إضـافـة";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(647, 438);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "حــذف";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.Gray;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(728, 438);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "تـعـديـل";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(18, 439);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "إلـغـاء";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(854, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "بحث";
            // 
            // txtSearchDep
            // 
            this.txtSearchDep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchDep.Location = new System.Drawing.Point(257, 6);
            this.txtSearchDep.Name = "txtSearchDep";
            this.txtSearchDep.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearchDep.Size = new System.Drawing.Size(591, 20);
            this.txtSearchDep.TabIndex = 6;
            this.txtSearchDep.TextChanged += new System.EventHandler(this.txtSearchDep_TextChanged);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // DepartmentManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(896, 473);
            this.Controls.Add(this.txtSearchDep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.groupBox1);
            this.Name = "DepartmentManagment";
            this.Text = "ادارة المرافق الصحية";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupFilter.ResumeLayout(false);
            this.groupFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchDep;
        private System.Windows.Forms.ComboBox comboFilter;
        private System.Windows.Forms.RadioButton radioDir;
        private System.Windows.Forms.RadioButton radioType;
        private System.Windows.Forms.GroupBox groupFilter;
        private System.Windows.Forms.CheckBox checkFilter;
        public System.Windows.Forms.DataGridView dataGridViewDep;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}