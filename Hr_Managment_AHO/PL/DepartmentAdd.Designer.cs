namespace Hr_Managment_AHO.PL
{
    partial class DepartmentAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentAdd));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddImg = new System.Windows.Forms.Button();
            this.pbxDepImg = new System.Windows.Forms.PictureBox();
            this.txtDepAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDepPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboDepType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboDir = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDepEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDepName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDepImg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddImg);
            this.groupBox1.Controls.Add(this.pbxDepImg);
            this.groupBox1.Controls.Add(this.txtDepAddress);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDepPhone);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtFax);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboDepType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboDir);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDepEmail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDepName);
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAddImg
            // 
            resources.ApplyResources(this.btnAddImg, "btnAddImg");
            this.btnAddImg.Name = "btnAddImg";
            this.btnAddImg.UseVisualStyleBackColor = true;
            this.btnAddImg.Click += new System.EventHandler(this.btnAddImg_Click);
            // 
            // pbxDepImg
            // 
            this.pbxDepImg.Image = global::Hr_Managment_AHO.Properties.Resources.images;
            resources.ApplyResources(this.pbxDepImg, "pbxDepImg");
            this.pbxDepImg.Name = "pbxDepImg";
            this.pbxDepImg.TabStop = false;
            // 
            // txtDepAddress
            // 
            resources.ApplyResources(this.txtDepAddress, "txtDepAddress");
            this.txtDepAddress.Name = "txtDepAddress";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // txtDepPhone
            // 
            resources.ApplyResources(this.txtDepPhone, "txtDepPhone");
            this.txtDepPhone.Name = "txtDepPhone";
            this.txtDepPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNo_KeyPress);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // txtFax
            // 
            resources.ApplyResources(this.txtFax, "txtFax");
            this.txtFax.Name = "txtFax";
            this.txtFax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFax_KeyPress);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // comboDepType
            // 
            this.comboDepType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDepType.FormattingEnabled = true;
            this.comboDepType.Items.AddRange(new object[] {
            resources.GetString("comboDepType.Items"),
            resources.GetString("comboDepType.Items1"),
            resources.GetString("comboDepType.Items2"),
            resources.GetString("comboDepType.Items3")});
            resources.ApplyResources(this.comboDepType, "comboDepType");
            this.comboDepType.Name = "comboDepType";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // comboDir
            // 
            this.comboDir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDir.FormattingEnabled = true;
            this.comboDir.Items.AddRange(new object[] {
            resources.GetString("comboDir.Items"),
            resources.GetString("comboDir.Items1"),
            resources.GetString("comboDir.Items2"),
            resources.GetString("comboDir.Items3"),
            resources.GetString("comboDir.Items4"),
            resources.GetString("comboDir.Items5"),
            resources.GetString("comboDir.Items6"),
            resources.GetString("comboDir.Items7"),
            resources.GetString("comboDir.Items8")});
            resources.ApplyResources(this.comboDir, "comboDir");
            this.comboDir.Name = "comboDir";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtDepEmail
            // 
            resources.ApplyResources(this.txtDepEmail, "txtDepEmail");
            this.txtDepEmail.Name = "txtDepEmail";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtDepName
            // 
            resources.ApplyResources(this.txtDepName, "txtDepName");
            this.txtDepName.Name = "txtDepName";
            this.txtDepName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtDepName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // DepartmentAdd
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.MaximizeBox = false;
            this.Name = "DepartmentAdd";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDepImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddImg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.PictureBox pbxDepImg;
        public System.Windows.Forms.TextBox txtDepName;
        public System.Windows.Forms.ComboBox comboDir;
        public System.Windows.Forms.TextBox txtDepEmail;
        public System.Windows.Forms.ComboBox comboDepType;
        public System.Windows.Forms.TextBox txtDepAddress;
        public System.Windows.Forms.TextBox txtDepPhone;
        public System.Windows.Forms.TextBox txtFax;
        public System.Windows.Forms.Button btnAdd;
    }
}