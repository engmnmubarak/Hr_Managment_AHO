namespace Hr_Managment_AHO.PL
{
    partial class EmployeeFolderAdd
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
            this.btnSelectDoc = new System.Windows.Forms.Button();
            this.txtDocDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboDocTit = new System.Windows.Forms.ComboBox();
            this.txtDocIssue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpDoc = new System.Windows.Forms.DateTimePicker();
            this.pictureBoxDoc = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddDoc = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectDoc
            // 
            this.btnSelectDoc.BackColor = System.Drawing.Color.Gray;
            this.btnSelectDoc.FlatAppearance.BorderSize = 0;
            this.btnSelectDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectDoc.ForeColor = System.Drawing.Color.White;
            this.btnSelectDoc.Location = new System.Drawing.Point(5, 197);
            this.btnSelectDoc.Name = "btnSelectDoc";
            this.btnSelectDoc.Size = new System.Drawing.Size(140, 24);
            this.btnSelectDoc.TabIndex = 1;
            this.btnSelectDoc.Text = "إختيـار الـوثيقـة";
            this.btnSelectDoc.UseVisualStyleBackColor = false;
            this.btnSelectDoc.Click += new System.EventHandler(this.btnSelectDoc_Click);
            // 
            // txtDocDesc
            // 
            this.txtDocDesc.Location = new System.Drawing.Point(172, 57);
            this.txtDocDesc.Multiline = true;
            this.txtDocDesc.Name = "txtDocDesc";
            this.txtDocDesc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDocDesc.Size = new System.Drawing.Size(201, 98);
            this.txtDocDesc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 25);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "اسم الوثيقة:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 60);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "وصف الوثيقة:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 172);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "الجهة:";
            // 
            // comboDocTit
            // 
            this.comboDocTit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDocTit.FormattingEnabled = true;
            this.comboDocTit.Items.AddRange(new object[] {
            "بطاقة شخصية",
            "فتوى تعيين",
            "امر اداري",
            "قرار تعيين",
            "افادة"});
            this.comboDocTit.Location = new System.Drawing.Point(170, 22);
            this.comboDocTit.Name = "comboDocTit";
            this.comboDocTit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboDocTit.Size = new System.Drawing.Size(201, 21);
            this.comboDocTit.TabIndex = 6;
            // 
            // txtDocIssue
            // 
            this.txtDocIssue.Location = new System.Drawing.Point(172, 169);
            this.txtDocIssue.Name = "txtDocIssue";
            this.txtDocIssue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDocIssue.Size = new System.Drawing.Size(201, 20);
            this.txtDocIssue.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 209);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "التاريخ:";
            // 
            // DtpDoc
            // 
            this.DtpDoc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDoc.Location = new System.Drawing.Point(173, 203);
            this.DtpDoc.Name = "DtpDoc";
            this.DtpDoc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DtpDoc.RightToLeftLayout = true;
            this.DtpDoc.Size = new System.Drawing.Size(200, 20);
            this.DtpDoc.TabIndex = 9;
            this.DtpDoc.Value = new System.DateTime(2019, 10, 21, 0, 0, 0, 0);
            // 
            // pictureBoxDoc
            // 
            this.pictureBoxDoc.Location = new System.Drawing.Point(5, 19);
            this.pictureBoxDoc.Name = "pictureBoxDoc";
            this.pictureBoxDoc.Size = new System.Drawing.Size(140, 172);
            this.pictureBoxDoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDoc.TabIndex = 0;
            this.pictureBoxDoc.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboDocTit);
            this.groupBox1.Controls.Add(this.DtpDoc);
            this.groupBox1.Controls.Add(this.pictureBoxDoc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnSelectDoc);
            this.groupBox1.Controls.Add(this.txtDocIssue);
            this.groupBox1.Controls.Add(this.txtDocDesc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(464, 228);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "وثيقة موظف/";
            // 
            // btnAddDoc
            // 
            this.btnAddDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.btnAddDoc.FlatAppearance.BorderSize = 0;
            this.btnAddDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDoc.ForeColor = System.Drawing.Color.White;
            this.btnAddDoc.Location = new System.Drawing.Point(173, 261);
            this.btnAddDoc.Name = "btnAddDoc";
            this.btnAddDoc.Size = new System.Drawing.Size(201, 23);
            this.btnAddDoc.TabIndex = 11;
            this.btnAddDoc.Text = "إضــــافــــة";
            this.btnAddDoc.UseVisualStyleBackColor = false;
            this.btnAddDoc.Click += new System.EventHandler(this.btnAddDoc_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(12, 261);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "إلـغــاء";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // EmployeeFolderAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(471, 296);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddDoc);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmployeeFolderAdd";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة وثيقة";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSelectDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.PictureBox pictureBoxDoc;
        public System.Windows.Forms.TextBox txtDocDesc;
        public System.Windows.Forms.ComboBox comboDocTit;
        public System.Windows.Forms.TextBox txtDocIssue;
        public System.Windows.Forms.DateTimePicker DtpDoc;
        public System.Windows.Forms.Button btnAddDoc;
    }
}