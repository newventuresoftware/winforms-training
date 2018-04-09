namespace John.SocialClub.Desktop.Forms.Membership
{
    partial class Manage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabRegistration = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabRegister = new System.Windows.Forms.TabPage();
            this.lblHealthStatusRequired = new System.Windows.Forms.Label();
            this.lblMaritalStatusRequired = new System.Windows.Forms.Label();
            this.lblOccupationRequired = new System.Windows.Forms.Label();
            this.lblDOBRequired = new System.Windows.Forms.Label();
            this.lblNameRequired = new System.Windows.Forms.Label();
            this.lblNoOfChildren = new System.Windows.Forms.Label();
            this.txtNoOfChildren = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.cmbHealthStatus = new System.Windows.Forms.ComboBox();
            this.lblHealthStatus = new System.Windows.Forms.Label();
            this.dtDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.btnRegister = new System.Windows.Forms.Button();
            this.cmbMaritalStatus = new System.Windows.Forms.ComboBox();
            this.lblMaritalStatus = new System.Windows.Forms.Label();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.cmbOccupation = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tabSearchManage = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl2NoOfChildren = new System.Windows.Forms.Label();
            this.txt2NoOfChildren = new System.Windows.Forms.TextBox();
            this.cmb2HealthStatus = new System.Windows.Forms.ComboBox();
            this.lbl2HealthStatus = new System.Windows.Forms.Label();
            this.cmb2MaritalStatus = new System.Windows.Forms.ComboBox();
            this.lbl2MaritalStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl2Salary = new System.Windows.Forms.Label();
            this.txt2Salary = new System.Windows.Forms.TextBox();
            this.dt2DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lbl2Occupation = new System.Windows.Forms.Label();
            this.cmb2Occupation = new System.Windows.Forms.ComboBox();
            this.txt2Name = new System.Windows.Forms.TextBox();
            this.lbl2DateOfBirth = new System.Windows.Forms.Label();
            this.lbl2Name = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrintPreview = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cmbOperand = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbSearchMaritalStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSearchOccupation = new System.Windows.Forms.ComboBox();
            this.dataGridViewMembers = new System.Windows.Forms.DataGridView();
            this.Header = new System.Windows.Forms.TextBox();
            this.PrintReport = new System.Drawing.Printing.PrintDocument();
            this.tab.SuspendLayout();
            this.tabRegistration.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabRegister.SuspendLayout();
            this.tabSearchManage.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabRegistration);
            this.tab.Controls.Add(this.tabSearchManage);
            this.tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab.Location = new System.Drawing.Point(6, 35);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(1035, 494);
            this.tab.TabIndex = 0;
            this.tab.SelectedIndexChanged += new System.EventHandler(this.Tab_SelectedIndexChanged);
            // 
            // tabRegistration
            // 
            this.tabRegistration.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabRegistration.Controls.Add(this.tabControl2);
            this.tabRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRegistration.Location = new System.Drawing.Point(4, 24);
            this.tabRegistration.Name = "tabRegistration";
            this.tabRegistration.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistration.Size = new System.Drawing.Size(1027, 466);
            this.tabRegistration.TabIndex = 0;
            this.tabRegistration.Text = "New Registration";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabRegister);
            this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(8, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(567, 213);
            this.tabControl2.TabIndex = 5;
            // 
            // tabRegister
            // 
            this.tabRegister.Controls.Add(this.lblHealthStatusRequired);
            this.tabRegister.Controls.Add(this.lblMaritalStatusRequired);
            this.tabRegister.Controls.Add(this.lblOccupationRequired);
            this.tabRegister.Controls.Add(this.lblDOBRequired);
            this.tabRegister.Controls.Add(this.lblNameRequired);
            this.tabRegister.Controls.Add(this.lblNoOfChildren);
            this.tabRegister.Controls.Add(this.txtNoOfChildren);
            this.tabRegister.Controls.Add(this.lblSalary);
            this.tabRegister.Controls.Add(this.txtSalary);
            this.tabRegister.Controls.Add(this.cmbHealthStatus);
            this.tabRegister.Controls.Add(this.lblHealthStatus);
            this.tabRegister.Controls.Add(this.dtDateOfBirth);
            this.tabRegister.Controls.Add(this.btnRegister);
            this.tabRegister.Controls.Add(this.cmbMaritalStatus);
            this.tabRegister.Controls.Add(this.lblMaritalStatus);
            this.tabRegister.Controls.Add(this.lblOccupation);
            this.tabRegister.Controls.Add(this.cmbOccupation);
            this.tabRegister.Controls.Add(this.txtName);
            this.tabRegister.Controls.Add(this.lblDateOfBirth);
            this.tabRegister.Controls.Add(this.lblName);
            this.tabRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRegister.Location = new System.Drawing.Point(4, 25);
            this.tabRegister.Name = "tabRegister";
            this.tabRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegister.Size = new System.Drawing.Size(559, 184);
            this.tabRegister.TabIndex = 0;
            this.tabRegister.Text = "Member";
            this.tabRegister.UseVisualStyleBackColor = true;
            // 
            // lblHealthStatusRequired
            // 
            this.lblHealthStatusRequired.AutoSize = true;
            this.lblHealthStatusRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealthStatusRequired.ForeColor = System.Drawing.Color.Red;
            this.lblHealthStatusRequired.Location = new System.Drawing.Point(360, 57);
            this.lblHealthStatusRequired.Name = "lblHealthStatusRequired";
            this.lblHealthStatusRequired.Size = new System.Drawing.Size(21, 25);
            this.lblHealthStatusRequired.TabIndex = 22;
            this.lblHealthStatusRequired.Text = "*";
            // 
            // lblMaritalStatusRequired
            // 
            this.lblMaritalStatusRequired.AutoSize = true;
            this.lblMaritalStatusRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaritalStatusRequired.ForeColor = System.Drawing.Color.Red;
            this.lblMaritalStatusRequired.Location = new System.Drawing.Point(362, 17);
            this.lblMaritalStatusRequired.Name = "lblMaritalStatusRequired";
            this.lblMaritalStatusRequired.Size = new System.Drawing.Size(21, 25);
            this.lblMaritalStatusRequired.TabIndex = 21;
            this.lblMaritalStatusRequired.Text = "*";
            // 
            // lblOccupationRequired
            // 
            this.lblOccupationRequired.AutoSize = true;
            this.lblOccupationRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccupationRequired.ForeColor = System.Drawing.Color.Red;
            this.lblOccupationRequired.Location = new System.Drawing.Point(84, 87);
            this.lblOccupationRequired.Name = "lblOccupationRequired";
            this.lblOccupationRequired.Size = new System.Drawing.Size(21, 25);
            this.lblOccupationRequired.TabIndex = 20;
            this.lblOccupationRequired.Text = "*";
            // 
            // lblDOBRequired
            // 
            this.lblDOBRequired.AutoSize = true;
            this.lblDOBRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOBRequired.ForeColor = System.Drawing.Color.Red;
            this.lblDOBRequired.Location = new System.Drawing.Point(89, 52);
            this.lblDOBRequired.Name = "lblDOBRequired";
            this.lblDOBRequired.Size = new System.Drawing.Size(21, 25);
            this.lblDOBRequired.TabIndex = 19;
            this.lblDOBRequired.Text = "*";
            // 
            // lblNameRequired
            // 
            this.lblNameRequired.AutoSize = true;
            this.lblNameRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameRequired.ForeColor = System.Drawing.Color.Red;
            this.lblNameRequired.Location = new System.Drawing.Point(53, 17);
            this.lblNameRequired.Name = "lblNameRequired";
            this.lblNameRequired.Size = new System.Drawing.Size(21, 25);
            this.lblNameRequired.TabIndex = 18;
            this.lblNameRequired.Text = "*";
            // 
            // lblNoOfChildren
            // 
            this.lblNoOfChildren.AutoSize = true;
            this.lblNoOfChildren.Location = new System.Drawing.Point(283, 95);
            this.lblNoOfChildren.Name = "lblNoOfChildren";
            this.lblNoOfChildren.Size = new System.Drawing.Size(86, 15);
            this.lblNoOfChildren.TabIndex = 17;
            this.lblNoOfChildren.Text = "No. of children";
            // 
            // txtNoOfChildren
            // 
            this.txtNoOfChildren.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoOfChildren.Location = new System.Drawing.Point(382, 92);
            this.txtNoOfChildren.MaxLength = 2;
            this.txtNoOfChildren.Name = "txtNoOfChildren";
            this.txtNoOfChildren.Size = new System.Drawing.Size(53, 21);
            this.txtNoOfChildren.TabIndex = 8;
            this.txtNoOfChildren.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Children_KeyPress);
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(17, 126);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(41, 15);
            this.lblSalary.TabIndex = 15;
            this.lblSalary.Text = "Salary";
            // 
            // txtSalary
            // 
            this.txtSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalary.Location = new System.Drawing.Point(111, 122);
            this.txtSalary.MaxLength = 12;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(152, 21);
            this.txtSalary.TabIndex = 5;
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Salary_KeyPress);
            // 
            // cmbHealthStatus
            // 
            this.cmbHealthStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHealthStatus.FormattingEnabled = true;
            this.cmbHealthStatus.Location = new System.Drawing.Point(382, 56);
            this.cmbHealthStatus.Name = "cmbHealthStatus";
            this.cmbHealthStatus.Size = new System.Drawing.Size(152, 23);
            this.cmbHealthStatus.TabIndex = 7;
            // 
            // lblHealthStatus
            // 
            this.lblHealthStatus.AutoSize = true;
            this.lblHealthStatus.Location = new System.Drawing.Point(282, 56);
            this.lblHealthStatus.Name = "lblHealthStatus";
            this.lblHealthStatus.Size = new System.Drawing.Size(78, 15);
            this.lblHealthStatus.TabIndex = 12;
            this.lblHealthStatus.Text = "Health status";
            // 
            // dtDateOfBirth
            // 
            this.dtDateOfBirth.AllowDrop = true;
            this.dtDateOfBirth.CustomFormat = "dd/MM/yyyy";
            this.dtDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateOfBirth.Location = new System.Drawing.Point(111, 46);
            this.dtDateOfBirth.MaxDate = new System.DateTime(2012, 12, 25, 0, 0, 0, 0);
            this.dtDateOfBirth.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dtDateOfBirth.Name = "dtDateOfBirth";
            this.dtDateOfBirth.Size = new System.Drawing.Size(152, 21);
            this.dtDateOfBirth.TabIndex = 3;
            this.dtDateOfBirth.Value = new System.DateTime(2012, 12, 25, 0, 0, 0, 0);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(384, 139);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(115, 28);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.Register_Click);
            // 
            // cmbMaritalStatus
            // 
            this.cmbMaritalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaritalStatus.FormattingEnabled = true;
            this.cmbMaritalStatus.Location = new System.Drawing.Point(384, 16);
            this.cmbMaritalStatus.Name = "cmbMaritalStatus";
            this.cmbMaritalStatus.Size = new System.Drawing.Size(152, 23);
            this.cmbMaritalStatus.TabIndex = 6;
            // 
            // lblMaritalStatus
            // 
            this.lblMaritalStatus.AutoSize = true;
            this.lblMaritalStatus.Location = new System.Drawing.Point(282, 16);
            this.lblMaritalStatus.Name = "lblMaritalStatus";
            this.lblMaritalStatus.Size = new System.Drawing.Size(80, 15);
            this.lblMaritalStatus.TabIndex = 6;
            this.lblMaritalStatus.Text = "Marital status";
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.Location = new System.Drawing.Point(16, 86);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(69, 15);
            this.lblOccupation.TabIndex = 5;
            this.lblOccupation.Text = "Occupation";
            // 
            // cmbOccupation
            // 
            this.cmbOccupation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOccupation.FormattingEnabled = true;
            this.cmbOccupation.Location = new System.Drawing.Point(111, 81);
            this.cmbOccupation.Name = "cmbOccupation";
            this.cmbOccupation.Size = new System.Drawing.Size(152, 23);
            this.cmbOccupation.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(111, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(152, 21);
            this.txtName.TabIndex = 2;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(16, 51);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(74, 15);
            this.lblDateOfBirth.TabIndex = 1;
            this.lblDateOfBirth.Text = "Date of Birth";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // tabSearchManage
            // 
            this.tabSearchManage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabSearchManage.Controls.Add(this.label10);
            this.tabSearchManage.Controls.Add(this.label11);
            this.tabSearchManage.Controls.Add(this.lbl2NoOfChildren);
            this.tabSearchManage.Controls.Add(this.txt2NoOfChildren);
            this.tabSearchManage.Controls.Add(this.cmb2HealthStatus);
            this.tabSearchManage.Controls.Add(this.lbl2HealthStatus);
            this.tabSearchManage.Controls.Add(this.cmb2MaritalStatus);
            this.tabSearchManage.Controls.Add(this.lbl2MaritalStatus);
            this.tabSearchManage.Controls.Add(this.label1);
            this.tabSearchManage.Controls.Add(this.label2);
            this.tabSearchManage.Controls.Add(this.label5);
            this.tabSearchManage.Controls.Add(this.lbl2Salary);
            this.tabSearchManage.Controls.Add(this.txt2Salary);
            this.tabSearchManage.Controls.Add(this.dt2DateOfBirth);
            this.tabSearchManage.Controls.Add(this.lbl2Occupation);
            this.tabSearchManage.Controls.Add(this.cmb2Occupation);
            this.tabSearchManage.Controls.Add(this.txt2Name);
            this.tabSearchManage.Controls.Add(this.lbl2DateOfBirth);
            this.tabSearchManage.Controls.Add(this.lbl2Name);
            this.tabSearchManage.Controls.Add(this.btnUpdate);
            this.tabSearchManage.Controls.Add(this.btnDelete);
            this.tabSearchManage.Controls.Add(this.btnPrintPreview);
            this.tabSearchManage.Controls.Add(this.btnExport);
            this.tabSearchManage.Controls.Add(this.btnPrint);
            this.tabSearchManage.Controls.Add(this.tabControl1);
            this.tabSearchManage.Controls.Add(this.dataGridViewMembers);
            this.tabSearchManage.Location = new System.Drawing.Point(4, 24);
            this.tabSearchManage.Name = "tabSearchManage";
            this.tabSearchManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearchManage.Size = new System.Drawing.Size(1027, 466);
            this.tabSearchManage.TabIndex = 1;
            this.tabSearchManage.Text = "Search / Manage Members";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(803, 356);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 25);
            this.label10.TabIndex = 39;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(805, 316);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 25);
            this.label11.TabIndex = 38;
            this.label11.Text = "*";
            // 
            // lbl2NoOfChildren
            // 
            this.lbl2NoOfChildren.AutoSize = true;
            this.lbl2NoOfChildren.Location = new System.Drawing.Point(726, 395);
            this.lbl2NoOfChildren.Name = "lbl2NoOfChildren";
            this.lbl2NoOfChildren.Size = new System.Drawing.Size(86, 15);
            this.lbl2NoOfChildren.TabIndex = 37;
            this.lbl2NoOfChildren.Text = "No. of children";
            // 
            // txt2NoOfChildren
            // 
            this.txt2NoOfChildren.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt2NoOfChildren.Location = new System.Drawing.Point(851, 389);
            this.txt2NoOfChildren.MaxLength = 2;
            this.txt2NoOfChildren.Name = "txt2NoOfChildren";
            this.txt2NoOfChildren.Size = new System.Drawing.Size(53, 21);
            this.txt2NoOfChildren.TabIndex = 35;
            // 
            // cmb2HealthStatus
            // 
            this.cmb2HealthStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb2HealthStatus.FormattingEnabled = true;
            this.cmb2HealthStatus.Location = new System.Drawing.Point(846, 352);
            this.cmb2HealthStatus.Name = "cmb2HealthStatus";
            this.cmb2HealthStatus.Size = new System.Drawing.Size(152, 23);
            this.cmb2HealthStatus.TabIndex = 34;
            // 
            // lbl2HealthStatus
            // 
            this.lbl2HealthStatus.AutoSize = true;
            this.lbl2HealthStatus.Location = new System.Drawing.Point(725, 355);
            this.lbl2HealthStatus.Name = "lbl2HealthStatus";
            this.lbl2HealthStatus.Size = new System.Drawing.Size(78, 15);
            this.lbl2HealthStatus.TabIndex = 36;
            this.lbl2HealthStatus.Text = "Health status";
            // 
            // cmb2MaritalStatus
            // 
            this.cmb2MaritalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb2MaritalStatus.FormattingEnabled = true;
            this.cmb2MaritalStatus.Location = new System.Drawing.Point(845, 312);
            this.cmb2MaritalStatus.Name = "cmb2MaritalStatus";
            this.cmb2MaritalStatus.Size = new System.Drawing.Size(152, 23);
            this.cmb2MaritalStatus.TabIndex = 32;
            // 
            // lbl2MaritalStatus
            // 
            this.lbl2MaritalStatus.AutoSize = true;
            this.lbl2MaritalStatus.Location = new System.Drawing.Point(725, 315);
            this.lbl2MaritalStatus.Name = "lbl2MaritalStatus";
            this.lbl2MaritalStatus.Size = new System.Drawing.Size(80, 15);
            this.lbl2MaritalStatus.TabIndex = 33;
            this.lbl2MaritalStatus.Text = "Marital status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(794, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(799, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(763, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "*";
            // 
            // lbl2Salary
            // 
            this.lbl2Salary.AutoSize = true;
            this.lbl2Salary.Location = new System.Drawing.Point(727, 281);
            this.lbl2Salary.Name = "lbl2Salary";
            this.lbl2Salary.Size = new System.Drawing.Size(41, 15);
            this.lbl2Salary.TabIndex = 28;
            this.lbl2Salary.Text = "Salary";
            // 
            // txt2Salary
            // 
            this.txt2Salary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt2Salary.Location = new System.Drawing.Point(843, 278);
            this.txt2Salary.MaxLength = 12;
            this.txt2Salary.Name = "txt2Salary";
            this.txt2Salary.Size = new System.Drawing.Size(114, 21);
            this.txt2Salary.TabIndex = 26;
            // 
            // dt2DateOfBirth
            // 
            this.dt2DateOfBirth.AllowDrop = true;
            this.dt2DateOfBirth.CustomFormat = "dd/MM/yyyy";
            this.dt2DateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt2DateOfBirth.Location = new System.Drawing.Point(843, 208);
            this.dt2DateOfBirth.MaxDate = new System.DateTime(2012, 12, 25, 0, 0, 0, 0);
            this.dt2DateOfBirth.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dt2DateOfBirth.Name = "dt2DateOfBirth";
            this.dt2DateOfBirth.Size = new System.Drawing.Size(114, 21);
            this.dt2DateOfBirth.TabIndex = 24;
            this.dt2DateOfBirth.Value = new System.DateTime(2012, 12, 25, 0, 0, 0, 0);
            // 
            // lbl2Occupation
            // 
            this.lbl2Occupation.AutoSize = true;
            this.lbl2Occupation.Location = new System.Drawing.Point(726, 246);
            this.lbl2Occupation.Name = "lbl2Occupation";
            this.lbl2Occupation.Size = new System.Drawing.Size(69, 15);
            this.lbl2Occupation.TabIndex = 27;
            this.lbl2Occupation.Text = "Occupation";
            // 
            // cmb2Occupation
            // 
            this.cmb2Occupation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb2Occupation.FormattingEnabled = true;
            this.cmb2Occupation.Location = new System.Drawing.Point(843, 241);
            this.cmb2Occupation.Name = "cmb2Occupation";
            this.cmb2Occupation.Size = new System.Drawing.Size(152, 23);
            this.cmb2Occupation.TabIndex = 25;
            // 
            // txt2Name
            // 
            this.txt2Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt2Name.Location = new System.Drawing.Point(843, 178);
            this.txt2Name.Name = "txt2Name";
            this.txt2Name.Size = new System.Drawing.Size(152, 21);
            this.txt2Name.TabIndex = 23;
            // 
            // lbl2DateOfBirth
            // 
            this.lbl2DateOfBirth.AutoSize = true;
            this.lbl2DateOfBirth.Location = new System.Drawing.Point(726, 213);
            this.lbl2DateOfBirth.Name = "lbl2DateOfBirth";
            this.lbl2DateOfBirth.Size = new System.Drawing.Size(74, 15);
            this.lbl2DateOfBirth.TabIndex = 22;
            this.lbl2DateOfBirth.Text = "Date of Birth";
            // 
            // lbl2Name
            // 
            this.lbl2Name.AutoSize = true;
            this.lbl2Name.Location = new System.Drawing.Point(723, 180);
            this.lbl2Name.Name = "lbl2Name";
            this.lbl2Name.Size = new System.Drawing.Size(41, 15);
            this.lbl2Name.TabIndex = 21;
            this.lbl2Name.Text = "Name";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(845, 429);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 27);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(935, 429);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 27);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Location = new System.Drawing.Point(390, 126);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(100, 28);
            this.btnPrintPreview.TabIndex = 8;
            this.btnPrintPreview.Text = "Print Preview";
            this.btnPrintPreview.UseVisualStyleBackColor = true;
            this.btnPrintPreview.Click += new System.EventHandler(this.PrintPreview_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(602, 126);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 28);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.Export_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(496, 126);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 28);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.Print_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(7, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1014, 105);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cmbOperand);
            this.tabPage3.Controls.Add(this.btnRefresh);
            this.tabPage3.Controls.Add(this.btnSearch);
            this.tabPage3.Controls.Add(this.cmbSearchMaritalStatus);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.cmbSearchOccupation);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1006, 77);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Search";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cmbOperand
            // 
            this.cmbOperand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperand.FormattingEnabled = true;
            this.cmbOperand.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.cmbOperand.Location = new System.Drawing.Point(156, 33);
            this.cmbOperand.Name = "cmbOperand";
            this.cmbOperand.Size = new System.Drawing.Size(65, 23);
            this.cmbOperand.TabIndex = 10;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(479, 33);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 28);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(364, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.Search_Click);
            // 
            // cmbSearchMaritalStatus
            // 
            this.cmbSearchMaritalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchMaritalStatus.FormattingEnabled = true;
            this.cmbSearchMaritalStatus.Location = new System.Drawing.Point(227, 33);
            this.cmbSearchMaritalStatus.Name = "cmbSearchMaritalStatus";
            this.cmbSearchMaritalStatus.Size = new System.Drawing.Size(121, 23);
            this.cmbSearchMaritalStatus.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Marital status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Occupation";
            // 
            // cmbSearchOccupation
            // 
            this.cmbSearchOccupation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchOccupation.FormattingEnabled = true;
            this.cmbSearchOccupation.Location = new System.Drawing.Point(29, 33);
            this.cmbSearchOccupation.Name = "cmbSearchOccupation";
            this.cmbSearchOccupation.Size = new System.Drawing.Size(121, 23);
            this.cmbSearchOccupation.TabIndex = 4;
            // 
            // dataGridViewMembers
            // 
            this.dataGridViewMembers.AllowUserToAddRows = false;
            this.dataGridViewMembers.AllowUserToOrderColumns = true;
            this.dataGridViewMembers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMembers.Location = new System.Drawing.Point(3, 166);
            this.dataGridViewMembers.Name = "dataGridViewMembers";
            this.dataGridViewMembers.ReadOnly = true;
            this.dataGridViewMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMembers.Size = new System.Drawing.Size(699, 297);
            this.dataGridViewMembers.TabIndex = 3;
            this.dataGridViewMembers.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridView_CellFormatting);
            this.dataGridViewMembers.SelectionChanged += new System.EventHandler(this.dataGridViewMembers_SelectionChanged);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.SystemColors.Control;
            this.Header.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Header.Enabled = false;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.Color.DimGray;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1050, 31);
            this.Header.TabIndex = 0;
            this.Header.Text = "Social club";
            this.Header.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PrintReport
            // 
            this.PrintReport.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1050, 537);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.tab);
            this.IsMdiContainer = true;
            this.Name = "Manage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Social Club - Membership Manager";
            this.tab.ResumeLayout(false);
            this.tabRegistration.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabRegister.ResumeLayout(false);
            this.tabRegister.PerformLayout();
            this.tabSearchManage.ResumeLayout(false);
            this.tabSearchManage.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabRegistration;
        private System.Windows.Forms.TabPage tabSearchManage;
        private System.Windows.Forms.DataGridView dataGridViewMembers;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbSearchMaritalStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSearchOccupation;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabRegister;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox cmbMaritalStatus;
        private System.Windows.Forms.Label lblMaritalStatus;
        private System.Windows.Forms.Label lblOccupation;
        private System.Windows.Forms.ComboBox cmbOccupation;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DateTimePicker dtDateOfBirth;
        private System.Windows.Forms.Label lblNoOfChildren;
        private System.Windows.Forms.TextBox txtNoOfChildren;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.ComboBox cmbHealthStatus;
        private System.Windows.Forms.Label lblHealthStatus;
        private System.Windows.Forms.Label lblHealthStatusRequired;
        private System.Windows.Forms.Label lblMaritalStatusRequired;
        private System.Windows.Forms.Label lblOccupationRequired;
        private System.Windows.Forms.Label lblDOBRequired;
        private System.Windows.Forms.Label lblNameRequired;
        private System.Windows.Forms.TextBox Header;
        private System.Windows.Forms.ComboBox cmbOperand;
        private System.Drawing.Printing.PrintDocument PrintReport;
        private System.Windows.Forms.Button btnPrintPreview;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl2Salary;
        private System.Windows.Forms.TextBox txt2Salary;
        private System.Windows.Forms.DateTimePicker dt2DateOfBirth;
        private System.Windows.Forms.Label lbl2Occupation;
        private System.Windows.Forms.ComboBox cmb2Occupation;
        private System.Windows.Forms.TextBox txt2Name;
        private System.Windows.Forms.Label lbl2DateOfBirth;
        private System.Windows.Forms.Label lbl2Name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl2NoOfChildren;
        private System.Windows.Forms.TextBox txt2NoOfChildren;
        private System.Windows.Forms.ComboBox cmb2HealthStatus;
        private System.Windows.Forms.Label lbl2HealthStatus;
        private System.Windows.Forms.ComboBox cmb2MaritalStatus;
        private System.Windows.Forms.Label lbl2MaritalStatus;
    }
}