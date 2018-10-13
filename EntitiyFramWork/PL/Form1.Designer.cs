namespace EntitiyFramWork
{
    partial class Form1
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
            this.lblEmployeeTable = new System.Windows.Forms.Label();
            this.lblSkillsTable = new System.Windows.Forms.Label();
            this.lblSkillReferencesDescription = new System.Windows.Forms.Label();
            this.lblSearchForSkills = new System.Windows.Forms.Label();
            this.txtSerchForSkills = new System.Windows.Forms.TextBox();
            this.btnClearSearchSkills = new System.Windows.Forms.Button();
            this.btnSearchForSkills = new System.Windows.Forms.Button();
            this.gboxAddInfoToCurrentSkill = new System.Windows.Forms.GroupBox();
            this.btnSubmitNewInfo = new System.Windows.Forms.Button();
            this.txtNewURLToSkill = new System.Windows.Forms.TextBox();
            this.lblNewURLorUNC = new System.Windows.Forms.Label();
            this.gboxNewEmployee = new System.Windows.Forms.GroupBox();
            this.txtNewEmpEmail = new System.Windows.Forms.TextBox();
            this.lblNewEmployeeEmail = new System.Windows.Forms.Label();
            this.txtNewEmpAlias = new System.Windows.Forms.TextBox();
            this.lblNewEmployeeAlias = new System.Windows.Forms.Label();
            this.txtNewEmpLastName = new System.Windows.Forms.TextBox();
            this.lblNewEmployeeLastName = new System.Windows.Forms.Label();
            this.btnSubmitNewEmployee = new System.Windows.Forms.Button();
            this.txtNewEmpFirstName = new System.Windows.Forms.TextBox();
            this.lblNewEmployeeFirestName = new System.Windows.Forms.Label();
            this.gboxNewSkill = new System.Windows.Forms.GroupBox();
            this.txtNewBrief = new System.Windows.Forms.TextBox();
            this.lblBriefDescriptionOfNewSkill = new System.Windows.Forms.Label();
            this.btnSubmitNewSkill = new System.Windows.Forms.Button();
            this.txtNewSkillName = new System.Windows.Forms.TextBox();
            this.lblShortNameOfNewSkill = new System.Windows.Forms.Label();
            this.gboxAddReferencePersonToEmployee = new System.Windows.Forms.GroupBox();
            this.txtNewRefEmail = new System.Windows.Forms.TextBox();
            this.lblReferenceEmail = new System.Windows.Forms.Label();
            this.txtNewRefPosotion = new System.Windows.Forms.TextBox();
            this.lblReferencePosition = new System.Windows.Forms.Label();
            this.txtNewRefLastName = new System.Windows.Forms.TextBox();
            this.lblReferenceLastName = new System.Windows.Forms.Label();
            this.btnSubmitNewReferencePerson = new System.Windows.Forms.Button();
            this.txtNewRefFirestName = new System.Windows.Forms.TextBox();
            this.lblReferenceFirestName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.grvEmployees = new System.Windows.Forms.DataGridView();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvSkills = new System.Windows.Forms.DataGridView();
            this.SkillName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SkillId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BriefDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtxtSkillsAndReferences = new System.Windows.Forms.RichTextBox();
            this.gboxAddInfoToCurrentSkill.SuspendLayout();
            this.gboxNewEmployee.SuspendLayout();
            this.gboxNewSkill.SuspendLayout();
            this.gboxAddReferencePersonToEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSkills)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmployeeTable
            // 
            this.lblEmployeeTable.AutoSize = true;
            this.lblEmployeeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeTable.Location = new System.Drawing.Point(12, 25);
            this.lblEmployeeTable.Name = "lblEmployeeTable";
            this.lblEmployeeTable.Size = new System.Drawing.Size(282, 13);
            this.lblEmployeeTable.TabIndex = 0;
            this.lblEmployeeTable.Text = "Employees (Click to select an existing employee)";
            // 
            // lblSkillsTable
            // 
            this.lblSkillsTable.AutoSize = true;
            this.lblSkillsTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkillsTable.Location = new System.Drawing.Point(13, 147);
            this.lblSkillsTable.Name = "lblSkillsTable";
            this.lblSkillsTable.Size = new System.Drawing.Size(223, 13);
            this.lblSkillsTable.TabIndex = 2;
            this.lblSkillsTable.Text = "Skills (Click to get all skill information)";
            // 
            // lblSkillReferencesDescription
            // 
            this.lblSkillReferencesDescription.AutoSize = true;
            this.lblSkillReferencesDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkillReferencesDescription.Location = new System.Drawing.Point(379, 25);
            this.lblSkillReferencesDescription.Name = "lblSkillReferencesDescription";
            this.lblSkillReferencesDescription.Size = new System.Drawing.Size(108, 13);
            this.lblSkillReferencesDescription.TabIndex = 4;
            this.lblSkillReferencesDescription.Text = "Skills/References";
            // 
            // lblSearchForSkills
            // 
            this.lblSearchForSkills.AutoSize = true;
            this.lblSearchForSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchForSkills.Location = new System.Drawing.Point(30, 280);
            this.lblSearchForSkills.Name = "lblSearchForSkills";
            this.lblSearchForSkills.Size = new System.Drawing.Size(102, 13);
            this.lblSearchForSkills.TabIndex = 6;
            this.lblSearchForSkills.Text = "Search for skills:";
            // 
            // txtSerchForSkills
            // 
            this.txtSerchForSkills.Location = new System.Drawing.Point(134, 280);
            this.txtSerchForSkills.Name = "txtSerchForSkills";
            this.txtSerchForSkills.Size = new System.Drawing.Size(312, 20);
            this.txtSerchForSkills.TabIndex = 7;
            this.txtSerchForSkills.Text = " Add keywords separated by a space. Press <Enter> to search.";
            this.txtSerchForSkills.Click += new System.EventHandler(this.txtSerchForSkills_Click);
            this.txtSerchForSkills.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter);
            // 
            // btnClearSearchSkills
            // 
            this.btnClearSearchSkills.Location = new System.Drawing.Point(272, 306);
            this.btnClearSearchSkills.Name = "btnClearSearchSkills";
            this.btnClearSearchSkills.Size = new System.Drawing.Size(75, 23);
            this.btnClearSearchSkills.TabIndex = 8;
            this.btnClearSearchSkills.Text = "Clear";
            this.btnClearSearchSkills.UseVisualStyleBackColor = true;
            this.btnClearSearchSkills.Click += new System.EventHandler(this.btnClearSearchSkills_Click);
            // 
            // btnSearchForSkills
            // 
            this.btnSearchForSkills.Location = new System.Drawing.Point(371, 306);
            this.btnSearchForSkills.Name = "btnSearchForSkills";
            this.btnSearchForSkills.Size = new System.Drawing.Size(75, 23);
            this.btnSearchForSkills.TabIndex = 9;
            this.btnSearchForSkills.Text = "Search";
            this.btnSearchForSkills.UseVisualStyleBackColor = true;
            this.btnSearchForSkills.Click += new System.EventHandler(this.btnSearchForSkills_Click);
            // 
            // gboxAddInfoToCurrentSkill
            // 
            this.gboxAddInfoToCurrentSkill.Controls.Add(this.btnSubmitNewInfo);
            this.gboxAddInfoToCurrentSkill.Controls.Add(this.txtNewURLToSkill);
            this.gboxAddInfoToCurrentSkill.Controls.Add(this.lblNewURLorUNC);
            this.gboxAddInfoToCurrentSkill.Location = new System.Drawing.Point(471, 259);
            this.gboxAddInfoToCurrentSkill.Name = "gboxAddInfoToCurrentSkill";
            this.gboxAddInfoToCurrentSkill.Size = new System.Drawing.Size(263, 78);
            this.gboxAddInfoToCurrentSkill.TabIndex = 10;
            this.gboxAddInfoToCurrentSkill.TabStop = false;
            this.gboxAddInfoToCurrentSkill.Text = "Add Info to Current Skill";
            // 
            // btnSubmitNewInfo
            // 
            this.btnSubmitNewInfo.Location = new System.Drawing.Point(179, 47);
            this.btnSubmitNewInfo.Name = "btnSubmitNewInfo";
            this.btnSubmitNewInfo.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitNewInfo.TabIndex = 9;
            this.btnSubmitNewInfo.Text = "Submit Info";
            this.btnSubmitNewInfo.UseVisualStyleBackColor = true;
            this.btnSubmitNewInfo.Click += new System.EventHandler(this.btnSubmitNewInfo_Click);
            // 
            // txtNewURLToSkill
            // 
            this.txtNewURLToSkill.Location = new System.Drawing.Point(81, 23);
            this.txtNewURLToSkill.Name = "txtNewURLToSkill";
            this.txtNewURLToSkill.Size = new System.Drawing.Size(173, 20);
            this.txtNewURLToSkill.TabIndex = 8;
            // 
            // lblNewURLorUNC
            // 
            this.lblNewURLorUNC.AutoSize = true;
            this.lblNewURLorUNC.Location = new System.Drawing.Point(15, 26);
            this.lblNewURLorUNC.Name = "lblNewURLorUNC";
            this.lblNewURLorUNC.Size = new System.Drawing.Size(60, 13);
            this.lblNewURLorUNC.TabIndex = 7;
            this.lblNewURLorUNC.Text = "URL/UNC:";
            // 
            // gboxNewEmployee
            // 
            this.gboxNewEmployee.Controls.Add(this.txtNewEmpEmail);
            this.gboxNewEmployee.Controls.Add(this.lblNewEmployeeEmail);
            this.gboxNewEmployee.Controls.Add(this.txtNewEmpAlias);
            this.gboxNewEmployee.Controls.Add(this.lblNewEmployeeAlias);
            this.gboxNewEmployee.Controls.Add(this.txtNewEmpLastName);
            this.gboxNewEmployee.Controls.Add(this.lblNewEmployeeLastName);
            this.gboxNewEmployee.Controls.Add(this.btnSubmitNewEmployee);
            this.gboxNewEmployee.Controls.Add(this.txtNewEmpFirstName);
            this.gboxNewEmployee.Controls.Add(this.lblNewEmployeeFirestName);
            this.gboxNewEmployee.Location = new System.Drawing.Point(33, 351);
            this.gboxNewEmployee.Name = "gboxNewEmployee";
            this.gboxNewEmployee.Size = new System.Drawing.Size(221, 161);
            this.gboxNewEmployee.TabIndex = 11;
            this.gboxNewEmployee.TabStop = false;
            this.gboxNewEmployee.Text = "New Employee";
            // 
            // txtNewEmpEmail
            // 
            this.txtNewEmpEmail.Location = new System.Drawing.Point(83, 101);
            this.txtNewEmpEmail.Name = "txtNewEmpEmail";
            this.txtNewEmpEmail.Size = new System.Drawing.Size(110, 20);
            this.txtNewEmpEmail.TabIndex = 15;
            // 
            // lblNewEmployeeEmail
            // 
            this.lblNewEmployeeEmail.AutoSize = true;
            this.lblNewEmployeeEmail.Location = new System.Drawing.Point(10, 104);
            this.lblNewEmployeeEmail.Name = "lblNewEmployeeEmail";
            this.lblNewEmployeeEmail.Size = new System.Drawing.Size(38, 13);
            this.lblNewEmployeeEmail.TabIndex = 14;
            this.lblNewEmployeeEmail.Text = "E-mail:";
            // 
            // txtNewEmpAlias
            // 
            this.txtNewEmpAlias.Location = new System.Drawing.Point(83, 75);
            this.txtNewEmpAlias.Name = "txtNewEmpAlias";
            this.txtNewEmpAlias.Size = new System.Drawing.Size(110, 20);
            this.txtNewEmpAlias.TabIndex = 13;
            // 
            // lblNewEmployeeAlias
            // 
            this.lblNewEmployeeAlias.AutoSize = true;
            this.lblNewEmployeeAlias.Location = new System.Drawing.Point(10, 75);
            this.lblNewEmployeeAlias.Name = "lblNewEmployeeAlias";
            this.lblNewEmployeeAlias.Size = new System.Drawing.Size(32, 13);
            this.lblNewEmployeeAlias.TabIndex = 12;
            this.lblNewEmployeeAlias.Text = "Alias:";
            // 
            // txtNewEmpLastName
            // 
            this.txtNewEmpLastName.Location = new System.Drawing.Point(83, 49);
            this.txtNewEmpLastName.Name = "txtNewEmpLastName";
            this.txtNewEmpLastName.Size = new System.Drawing.Size(110, 20);
            this.txtNewEmpLastName.TabIndex = 11;
            // 
            // lblNewEmployeeLastName
            // 
            this.lblNewEmployeeLastName.AutoSize = true;
            this.lblNewEmployeeLastName.Location = new System.Drawing.Point(10, 52);
            this.lblNewEmployeeLastName.Name = "lblNewEmployeeLastName";
            this.lblNewEmployeeLastName.Size = new System.Drawing.Size(61, 13);
            this.lblNewEmployeeLastName.TabIndex = 10;
            this.lblNewEmployeeLastName.Text = "Last Name:";
            // 
            // btnSubmitNewEmployee
            // 
            this.btnSubmitNewEmployee.Location = new System.Drawing.Point(101, 132);
            this.btnSubmitNewEmployee.Name = "btnSubmitNewEmployee";
            this.btnSubmitNewEmployee.Size = new System.Drawing.Size(102, 23);
            this.btnSubmitNewEmployee.TabIndex = 9;
            this.btnSubmitNewEmployee.Text = "Submit Employee";
            this.btnSubmitNewEmployee.UseVisualStyleBackColor = true;
            this.btnSubmitNewEmployee.Click += new System.EventHandler(this.btnSubmitNewEmployee_Click);
            // 
            // txtNewEmpFirstName
            // 
            this.txtNewEmpFirstName.Location = new System.Drawing.Point(83, 23);
            this.txtNewEmpFirstName.Name = "txtNewEmpFirstName";
            this.txtNewEmpFirstName.Size = new System.Drawing.Size(110, 20);
            this.txtNewEmpFirstName.TabIndex = 8;
            // 
            // lblNewEmployeeFirestName
            // 
            this.lblNewEmployeeFirestName.AutoSize = true;
            this.lblNewEmployeeFirestName.Location = new System.Drawing.Point(6, 26);
            this.lblNewEmployeeFirestName.Name = "lblNewEmployeeFirestName";
            this.lblNewEmployeeFirestName.Size = new System.Drawing.Size(66, 13);
            this.lblNewEmployeeFirestName.TabIndex = 7;
            this.lblNewEmployeeFirestName.Text = "Firest Name:";
            // 
            // gboxNewSkill
            // 
            this.gboxNewSkill.Controls.Add(this.txtNewBrief);
            this.gboxNewSkill.Controls.Add(this.lblBriefDescriptionOfNewSkill);
            this.gboxNewSkill.Controls.Add(this.btnSubmitNewSkill);
            this.gboxNewSkill.Controls.Add(this.txtNewSkillName);
            this.gboxNewSkill.Controls.Add(this.lblShortNameOfNewSkill);
            this.gboxNewSkill.Location = new System.Drawing.Point(272, 351);
            this.gboxNewSkill.Name = "gboxNewSkill";
            this.gboxNewSkill.Size = new System.Drawing.Size(221, 161);
            this.gboxNewSkill.TabIndex = 16;
            this.gboxNewSkill.TabStop = false;
            this.gboxNewSkill.Text = "New Skill";
            // 
            // txtNewBrief
            // 
            this.txtNewBrief.Location = new System.Drawing.Point(17, 81);
            this.txtNewBrief.Multiline = true;
            this.txtNewBrief.Name = "txtNewBrief";
            this.txtNewBrief.Size = new System.Drawing.Size(186, 40);
            this.txtNewBrief.TabIndex = 15;
            // 
            // lblBriefDescriptionOfNewSkill
            // 
            this.lblBriefDescriptionOfNewSkill.AutoSize = true;
            this.lblBriefDescriptionOfNewSkill.Location = new System.Drawing.Point(14, 65);
            this.lblBriefDescriptionOfNewSkill.Name = "lblBriefDescriptionOfNewSkill";
            this.lblBriefDescriptionOfNewSkill.Size = new System.Drawing.Size(121, 13);
            this.lblBriefDescriptionOfNewSkill.TabIndex = 14;
            this.lblBriefDescriptionOfNewSkill.Text = "Brief Description of Skill:";
            // 
            // btnSubmitNewSkill
            // 
            this.btnSubmitNewSkill.Location = new System.Drawing.Point(128, 132);
            this.btnSubmitNewSkill.Name = "btnSubmitNewSkill";
            this.btnSubmitNewSkill.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitNewSkill.TabIndex = 9;
            this.btnSubmitNewSkill.Text = "Submit Skill";
            this.btnSubmitNewSkill.UseVisualStyleBackColor = true;
            this.btnSubmitNewSkill.Click += new System.EventHandler(this.btnSubmitNewSkill_Click);
            // 
            // txtNewSkillName
            // 
            this.txtNewSkillName.Location = new System.Drawing.Point(17, 32);
            this.txtNewSkillName.Name = "txtNewSkillName";
            this.txtNewSkillName.Size = new System.Drawing.Size(186, 20);
            this.txtNewSkillName.TabIndex = 8;
            // 
            // lblShortNameOfNewSkill
            // 
            this.lblShortNameOfNewSkill.AutoSize = true;
            this.lblShortNameOfNewSkill.Location = new System.Drawing.Point(17, 16);
            this.lblShortNameOfNewSkill.Name = "lblShortNameOfNewSkill";
            this.lblShortNameOfNewSkill.Size = new System.Drawing.Size(171, 13);
            this.lblShortNameOfNewSkill.TabIndex = 7;
            this.lblShortNameOfNewSkill.Text = "Short Name of Skill or Technology:";
            // 
            // gboxAddReferencePersonToEmployee
            // 
            this.gboxAddReferencePersonToEmployee.Controls.Add(this.txtNewRefEmail);
            this.gboxAddReferencePersonToEmployee.Controls.Add(this.lblReferenceEmail);
            this.gboxAddReferencePersonToEmployee.Controls.Add(this.txtNewRefPosotion);
            this.gboxAddReferencePersonToEmployee.Controls.Add(this.lblReferencePosition);
            this.gboxAddReferencePersonToEmployee.Controls.Add(this.txtNewRefLastName);
            this.gboxAddReferencePersonToEmployee.Controls.Add(this.lblReferenceLastName);
            this.gboxAddReferencePersonToEmployee.Controls.Add(this.btnSubmitNewReferencePerson);
            this.gboxAddReferencePersonToEmployee.Controls.Add(this.txtNewRefFirestName);
            this.gboxAddReferencePersonToEmployee.Controls.Add(this.lblReferenceFirestName);
            this.gboxAddReferencePersonToEmployee.Location = new System.Drawing.Point(513, 351);
            this.gboxAddReferencePersonToEmployee.Name = "gboxAddReferencePersonToEmployee";
            this.gboxAddReferencePersonToEmployee.Size = new System.Drawing.Size(259, 161);
            this.gboxAddReferencePersonToEmployee.TabIndex = 16;
            this.gboxAddReferencePersonToEmployee.TabStop = false;
            this.gboxAddReferencePersonToEmployee.Text = "Add Reference Person to Selected Employee";
            // 
            // txtNewRefEmail
            // 
            this.txtNewRefEmail.Location = new System.Drawing.Point(96, 101);
            this.txtNewRefEmail.Name = "txtNewRefEmail";
            this.txtNewRefEmail.Size = new System.Drawing.Size(142, 20);
            this.txtNewRefEmail.TabIndex = 15;
            // 
            // lblReferenceEmail
            // 
            this.lblReferenceEmail.AutoSize = true;
            this.lblReferenceEmail.Location = new System.Drawing.Point(24, 104);
            this.lblReferenceEmail.Name = "lblReferenceEmail";
            this.lblReferenceEmail.Size = new System.Drawing.Size(38, 13);
            this.lblReferenceEmail.TabIndex = 14;
            this.lblReferenceEmail.Text = "E-mail:";
            // 
            // txtNewRefPosotion
            // 
            this.txtNewRefPosotion.Location = new System.Drawing.Point(96, 75);
            this.txtNewRefPosotion.Name = "txtNewRefPosotion";
            this.txtNewRefPosotion.Size = new System.Drawing.Size(142, 20);
            this.txtNewRefPosotion.TabIndex = 13;
            // 
            // lblReferencePosition
            // 
            this.lblReferencePosition.AutoSize = true;
            this.lblReferencePosition.Location = new System.Drawing.Point(24, 78);
            this.lblReferencePosition.Name = "lblReferencePosition";
            this.lblReferencePosition.Size = new System.Drawing.Size(47, 13);
            this.lblReferencePosition.TabIndex = 12;
            this.lblReferencePosition.Text = "Position:";
            // 
            // txtNewRefLastName
            // 
            this.txtNewRefLastName.Location = new System.Drawing.Point(96, 49);
            this.txtNewRefLastName.Name = "txtNewRefLastName";
            this.txtNewRefLastName.Size = new System.Drawing.Size(142, 20);
            this.txtNewRefLastName.TabIndex = 11;
            // 
            // lblReferenceLastName
            // 
            this.lblReferenceLastName.AutoSize = true;
            this.lblReferenceLastName.Location = new System.Drawing.Point(24, 52);
            this.lblReferenceLastName.Name = "lblReferenceLastName";
            this.lblReferenceLastName.Size = new System.Drawing.Size(61, 13);
            this.lblReferenceLastName.TabIndex = 10;
            this.lblReferenceLastName.Text = "Last Name:";
            // 
            // btnSubmitNewReferencePerson
            // 
            this.btnSubmitNewReferencePerson.Location = new System.Drawing.Point(163, 127);
            this.btnSubmitNewReferencePerson.Name = "btnSubmitNewReferencePerson";
            this.btnSubmitNewReferencePerson.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitNewReferencePerson.TabIndex = 9;
            this.btnSubmitNewReferencePerson.Text = "Submit Ref";
            this.btnSubmitNewReferencePerson.UseVisualStyleBackColor = true;
            this.btnSubmitNewReferencePerson.Click += new System.EventHandler(this.btnSubmitNewReferencePerson_Click);
            // 
            // txtNewRefFirestName
            // 
            this.txtNewRefFirestName.Location = new System.Drawing.Point(96, 23);
            this.txtNewRefFirestName.Name = "txtNewRefFirestName";
            this.txtNewRefFirestName.Size = new System.Drawing.Size(142, 20);
            this.txtNewRefFirestName.TabIndex = 8;
            // 
            // lblReferenceFirestName
            // 
            this.lblReferenceFirestName.AutoSize = true;
            this.lblReferenceFirestName.Location = new System.Drawing.Point(24, 26);
            this.lblReferenceFirestName.Name = "lblReferenceFirestName";
            this.lblReferenceFirestName.Size = new System.Drawing.Size(66, 13);
            this.lblReferenceFirestName.TabIndex = 7;
            this.lblReferenceFirestName.Text = "Firest Name:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(659, 526);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(552, 526);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 18;
            this.btnRestart.Text = "Reset";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // grvEmployees
            // 
            this.grvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LastName,
            this.EmployeeId,
            this.FirstName,
            this.Alias,
            this.Email});
            this.grvEmployees.Location = new System.Drawing.Point(12, 41);
            this.grvEmployees.Name = "grvEmployees";
            this.grvEmployees.Size = new System.Drawing.Size(337, 90);
            this.grvEmployees.TabIndex = 1;
            this.grvEmployees.SelectionChanged += new System.EventHandler(this.grvEmployees_SelectionChanged);
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            // 
            // EmployeeId
            // 
            this.EmployeeId.DataPropertyName = "EmployeeId";
            this.EmployeeId.HeaderText = "EmployeeId";
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            // 
            // Alias
            // 
            this.Alias.DataPropertyName = "Alias";
            this.Alias.HeaderText = "Alias";
            this.Alias.Name = "Alias";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // grvSkills
            // 
            this.grvSkills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvSkills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SkillName,
            this.SkillId,
            this.BriefDescription});
            this.grvSkills.Location = new System.Drawing.Point(12, 163);
            this.grvSkills.Name = "grvSkills";
            this.grvSkills.Size = new System.Drawing.Size(337, 90);
            this.grvSkills.TabIndex = 3;
            this.grvSkills.SelectionChanged += new System.EventHandler(this.grvSkills_SelectionChanged);
            // 
            // SkillName
            // 
            this.SkillName.DataPropertyName = "SkillName";
            this.SkillName.HeaderText = "Skill Name";
            this.SkillName.Name = "SkillName";
            // 
            // SkillId
            // 
            this.SkillId.DataPropertyName = "SkillId";
            this.SkillId.HeaderText = "SkillId";
            this.SkillId.Name = "SkillId";
            this.SkillId.Visible = false;
            // 
            // BriefDescription
            // 
            this.BriefDescription.DataPropertyName = "BriefDescription";
            this.BriefDescription.HeaderText = "Brief Description";
            this.BriefDescription.Name = "BriefDescription";
            // 
            // rtxtSkillsAndReferences
            // 
            this.rtxtSkillsAndReferences.Location = new System.Drawing.Point(382, 42);
            this.rtxtSkillsAndReferences.Name = "rtxtSkillsAndReferences";
            this.rtxtSkillsAndReferences.ReadOnly = true;
            this.rtxtSkillsAndReferences.Size = new System.Drawing.Size(390, 211);
            this.rtxtSkillsAndReferences.TabIndex = 20;
            this.rtxtSkillsAndReferences.Text = "";
            this.rtxtSkillsAndReferences.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.mRichTextBox_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.rtxtSkillsAndReferences);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gboxAddReferencePersonToEmployee);
            this.Controls.Add(this.gboxNewSkill);
            this.Controls.Add(this.gboxNewEmployee);
            this.Controls.Add(this.gboxAddInfoToCurrentSkill);
            this.Controls.Add(this.btnSearchForSkills);
            this.Controls.Add(this.btnClearSearchSkills);
            this.Controls.Add(this.txtSerchForSkills);
            this.Controls.Add(this.lblSearchForSkills);
            this.Controls.Add(this.lblSkillReferencesDescription);
            this.Controls.Add(this.grvSkills);
            this.Controls.Add(this.lblSkillsTable);
            this.Controls.Add(this.grvEmployees);
            this.Controls.Add(this.lblEmployeeTable);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gboxAddInfoToCurrentSkill.ResumeLayout(false);
            this.gboxAddInfoToCurrentSkill.PerformLayout();
            this.gboxNewEmployee.ResumeLayout(false);
            this.gboxNewEmployee.PerformLayout();
            this.gboxNewSkill.ResumeLayout(false);
            this.gboxNewSkill.PerformLayout();
            this.gboxAddReferencePersonToEmployee.ResumeLayout(false);
            this.gboxAddReferencePersonToEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSkills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeTable;
        private System.Windows.Forms.Label lblSkillsTable;
        private System.Windows.Forms.Label lblSkillReferencesDescription;
        private System.Windows.Forms.Label lblSearchForSkills;
        private System.Windows.Forms.TextBox txtSerchForSkills;
        private System.Windows.Forms.Button btnClearSearchSkills;
        private System.Windows.Forms.Button btnSearchForSkills;
        private System.Windows.Forms.GroupBox gboxAddInfoToCurrentSkill;
        private System.Windows.Forms.Button btnSubmitNewInfo;
        private System.Windows.Forms.TextBox txtNewURLToSkill;
        private System.Windows.Forms.Label lblNewURLorUNC;
        private System.Windows.Forms.GroupBox gboxNewEmployee;
        private System.Windows.Forms.TextBox txtNewEmpEmail;
        private System.Windows.Forms.Label lblNewEmployeeEmail;
        private System.Windows.Forms.TextBox txtNewEmpAlias;
        private System.Windows.Forms.Label lblNewEmployeeAlias;
        private System.Windows.Forms.TextBox txtNewEmpLastName;
        private System.Windows.Forms.Label lblNewEmployeeLastName;
        private System.Windows.Forms.Button btnSubmitNewEmployee;
        private System.Windows.Forms.TextBox txtNewEmpFirstName;
        private System.Windows.Forms.Label lblNewEmployeeFirestName;
        private System.Windows.Forms.GroupBox gboxNewSkill;
        private System.Windows.Forms.TextBox txtNewBrief;
        private System.Windows.Forms.Label lblBriefDescriptionOfNewSkill;
        private System.Windows.Forms.Button btnSubmitNewSkill;
        private System.Windows.Forms.TextBox txtNewSkillName;
        private System.Windows.Forms.Label lblShortNameOfNewSkill;
        private System.Windows.Forms.GroupBox gboxAddReferencePersonToEmployee;
        private System.Windows.Forms.TextBox txtNewRefEmail;
        private System.Windows.Forms.Label lblReferenceEmail;
        private System.Windows.Forms.TextBox txtNewRefPosotion;
        private System.Windows.Forms.Label lblReferencePosition;
        private System.Windows.Forms.TextBox txtNewRefLastName;
        private System.Windows.Forms.Label lblReferenceLastName;
        private System.Windows.Forms.Button btnSubmitNewReferencePerson;
        private System.Windows.Forms.TextBox txtNewRefFirestName;
        private System.Windows.Forms.Label lblReferenceFirestName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.DataGridView grvEmployees;
        private System.Windows.Forms.DataGridView grvSkills;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkillName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkillId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BriefDescription;
        private System.Windows.Forms.RichTextBox rtxtSkillsAndReferences;
    }
}

