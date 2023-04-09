
namespace QLDThi
{
    partial class FormUser
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAdminSearch = new System.Windows.Forms.Button();
            this.txtAdminSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnTeacherResetPW = new System.Windows.Forms.Button();
            this.btnTeacherSearch = new System.Windows.Forms.Button();
            this.txtTeacherSearch = new System.Windows.Forms.TextBox();
            this.BtnDeleteTeacher = new System.Windows.Forms.Button();
            this.btnEditTeacher = new System.Windows.Forms.Button();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTeacherUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.dataGridViewTeacher = new System.Windows.Forms.DataGridView();
            this.idTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnResetPWStudent = new System.Windows.Forms.Button();
            this.btnStudentSearch = new System.Windows.Forms.Button();
            this.txtStudentSearch = new System.Windows.Forms.TextBox();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnEditStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStudentUsername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.idStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacher)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(917, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAdminSearch);
            this.tabPage1.Controls.Add(this.txtAdminSearch);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnEdit);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lblUsername);
            this.tabPage1.Controls.Add(this.txtUsername);
            this.tabPage1.Controls.Add(this.lblName);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.dataGridViewAdmin);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(909, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Admin";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAdminSearch
            // 
            this.btnAdminSearch.Location = new System.Drawing.Point(483, 7);
            this.btnAdminSearch.Name = "btnAdminSearch";
            this.btnAdminSearch.Size = new System.Drawing.Size(75, 23);
            this.btnAdminSearch.TabIndex = 12;
            this.btnAdminSearch.Text = "Tìm kiếm";
            this.btnAdminSearch.UseVisualStyleBackColor = true;
            this.btnAdminSearch.Click += new System.EventHandler(this.btnAdminSearch_Click);
            // 
            // txtAdminSearch
            // 
            this.txtAdminSearch.Location = new System.Drawing.Point(69, 9);
            this.txtAdminSearch.Name = "txtAdminSearch";
            this.txtAdminSearch.Size = new System.Drawing.Size(390, 20);
            this.txtAdminSearch.TabIndex = 11;
            this.txtAdminSearch.TextChanged += new System.EventHandler(this.txtAdminSearch_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(826, 116);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(729, 116);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(625, 116);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(703, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mật khẩu mặc định là Abcd@123";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(616, 50);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(84, 13);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Tên đăng nhập:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(706, 47);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(195, 20);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(616, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Họ tên:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(706, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(195, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nameAdmin,
            this.usernameAdmin,
            this.statusAdmin,
            this.role});
            this.dataGridViewAdmin.Location = new System.Drawing.Point(0, 36);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.Size = new System.Drawing.Size(610, 388);
            this.dataGridViewAdmin.TabIndex = 0;
            this.dataGridViewAdmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdmin_CellClick);
            this.dataGridViewAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdmin_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // nameAdmin
            // 
            this.nameAdmin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameAdmin.DataPropertyName = "name";
            this.nameAdmin.HeaderText = "Họ tên";
            this.nameAdmin.Name = "nameAdmin";
            this.nameAdmin.ReadOnly = true;
            // 
            // usernameAdmin
            // 
            this.usernameAdmin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usernameAdmin.DataPropertyName = "username";
            this.usernameAdmin.HeaderText = "Tên đăng nhập";
            this.usernameAdmin.Name = "usernameAdmin";
            this.usernameAdmin.ReadOnly = true;
            // 
            // statusAdmin
            // 
            this.statusAdmin.DataPropertyName = "status";
            this.statusAdmin.HeaderText = "status";
            this.statusAdmin.Name = "statusAdmin";
            this.statusAdmin.ReadOnly = true;
            this.statusAdmin.Visible = false;
            this.statusAdmin.Width = 50;
            // 
            // role
            // 
            this.role.DataPropertyName = "role";
            this.role.HeaderText = "Role";
            this.role.Name = "role";
            this.role.ReadOnly = true;
            this.role.Visible = false;
            this.role.Width = 50;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnTeacherResetPW);
            this.tabPage2.Controls.Add(this.btnTeacherSearch);
            this.tabPage2.Controls.Add(this.txtTeacherSearch);
            this.tabPage2.Controls.Add(this.BtnDeleteTeacher);
            this.tabPage2.Controls.Add(this.btnEditTeacher);
            this.tabPage2.Controls.Add(this.btnAddTeacher);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtTeacherUsername);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtTeacherName);
            this.tabPage2.Controls.Add(this.dataGridViewTeacher);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(909, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Giáo viên";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnTeacherResetPW
            // 
            this.btnTeacherResetPW.Location = new System.Drawing.Point(729, 165);
            this.btnTeacherResetPW.Name = "btnTeacherResetPW";
            this.btnTeacherResetPW.Size = new System.Drawing.Size(75, 23);
            this.btnTeacherResetPW.TabIndex = 23;
            this.btnTeacherResetPW.Text = "Reset MK";
            this.btnTeacherResetPW.UseVisualStyleBackColor = true;
            this.btnTeacherResetPW.Click += new System.EventHandler(this.btnTeacherResetPW_Click);
            // 
            // btnTeacherSearch
            // 
            this.btnTeacherSearch.Location = new System.Drawing.Point(481, 8);
            this.btnTeacherSearch.Name = "btnTeacherSearch";
            this.btnTeacherSearch.Size = new System.Drawing.Size(75, 23);
            this.btnTeacherSearch.TabIndex = 22;
            this.btnTeacherSearch.Text = "Tìm kiếm";
            this.btnTeacherSearch.UseVisualStyleBackColor = true;
            this.btnTeacherSearch.Click += new System.EventHandler(this.btnTeacherSearch_Click);
            // 
            // txtTeacherSearch
            // 
            this.txtTeacherSearch.Location = new System.Drawing.Point(67, 10);
            this.txtTeacherSearch.Name = "txtTeacherSearch";
            this.txtTeacherSearch.Size = new System.Drawing.Size(390, 20);
            this.txtTeacherSearch.TabIndex = 21;
            this.txtTeacherSearch.TextChanged += new System.EventHandler(this.txtTeacherSearch_TextChanged);
            // 
            // BtnDeleteTeacher
            // 
            this.BtnDeleteTeacher.Location = new System.Drawing.Point(826, 119);
            this.BtnDeleteTeacher.Name = "BtnDeleteTeacher";
            this.BtnDeleteTeacher.Size = new System.Drawing.Size(75, 23);
            this.BtnDeleteTeacher.TabIndex = 20;
            this.BtnDeleteTeacher.Text = "Xóa";
            this.BtnDeleteTeacher.UseVisualStyleBackColor = true;
            this.BtnDeleteTeacher.Click += new System.EventHandler(this.BtnDeleteTeacher_Click);
            // 
            // btnEditTeacher
            // 
            this.btnEditTeacher.Location = new System.Drawing.Point(729, 119);
            this.btnEditTeacher.Name = "btnEditTeacher";
            this.btnEditTeacher.Size = new System.Drawing.Size(75, 23);
            this.btnEditTeacher.TabIndex = 19;
            this.btnEditTeacher.Text = "Sửa";
            this.btnEditTeacher.UseVisualStyleBackColor = true;
            this.btnEditTeacher.Click += new System.EventHandler(this.btnEditTeacher_Click);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(625, 119);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(75, 23);
            this.btnAddTeacher.TabIndex = 18;
            this.btnAddTeacher.Text = "Thêm";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(703, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mật khẩu mặc định là Abcd@123";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(616, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tên đăng nhập:";
            // 
            // txtTeacherUsername
            // 
            this.txtTeacherUsername.Location = new System.Drawing.Point(706, 47);
            this.txtTeacherUsername.Name = "txtTeacherUsername";
            this.txtTeacherUsername.Size = new System.Drawing.Size(195, 20);
            this.txtTeacherUsername.TabIndex = 13;
            this.txtTeacherUsername.TextChanged += new System.EventHandler(this.txtTeacherUsername_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(616, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Họ tên:";
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Location = new System.Drawing.Point(706, 6);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(195, 20);
            this.txtTeacherName.TabIndex = 11;
            this.txtTeacherName.TextChanged += new System.EventHandler(this.txtTeacherName_TextChanged);
            // 
            // dataGridViewTeacher
            // 
            this.dataGridViewTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeacher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTeacher,
            this.nameTeacher,
            this.usernameTeacher,
            this.roleTeacher,
            this.statusTeacher});
            this.dataGridViewTeacher.Location = new System.Drawing.Point(0, 36);
            this.dataGridViewTeacher.Name = "dataGridViewTeacher";
            this.dataGridViewTeacher.Size = new System.Drawing.Size(610, 388);
            this.dataGridViewTeacher.TabIndex = 0;
            this.dataGridViewTeacher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTeacher_CellClick);
            this.dataGridViewTeacher.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTeacher_CellClick);
            // 
            // idTeacher
            // 
            this.idTeacher.DataPropertyName = "id";
            this.idTeacher.HeaderText = "Id";
            this.idTeacher.Name = "idTeacher";
            this.idTeacher.ReadOnly = true;
            this.idTeacher.Width = 50;
            // 
            // nameTeacher
            // 
            this.nameTeacher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameTeacher.DataPropertyName = "name";
            this.nameTeacher.HeaderText = "Họ tên";
            this.nameTeacher.Name = "nameTeacher";
            this.nameTeacher.ReadOnly = true;
            // 
            // usernameTeacher
            // 
            this.usernameTeacher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usernameTeacher.DataPropertyName = "username";
            this.usernameTeacher.HeaderText = "Tên đăng nhập";
            this.usernameTeacher.Name = "usernameTeacher";
            this.usernameTeacher.ReadOnly = true;
            // 
            // roleTeacher
            // 
            this.roleTeacher.DataPropertyName = "role";
            this.roleTeacher.HeaderText = "role";
            this.roleTeacher.Name = "roleTeacher";
            this.roleTeacher.ReadOnly = true;
            this.roleTeacher.Visible = false;
            // 
            // statusTeacher
            // 
            this.statusTeacher.DataPropertyName = "status";
            this.statusTeacher.HeaderText = "status";
            this.statusTeacher.Name = "statusTeacher";
            this.statusTeacher.ReadOnly = true;
            this.statusTeacher.Visible = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnResetPWStudent);
            this.tabPage4.Controls.Add(this.btnStudentSearch);
            this.tabPage4.Controls.Add(this.txtStudentSearch);
            this.tabPage4.Controls.Add(this.btnDeleteStudent);
            this.tabPage4.Controls.Add(this.btnEditStudent);
            this.tabPage4.Controls.Add(this.btnAddStudent);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.txtStudentUsername);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.txtStudentName);
            this.tabPage4.Controls.Add(this.dataGridViewStudent);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(909, 424);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Học sinh";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnResetPWStudent
            // 
            this.btnResetPWStudent.Location = new System.Drawing.Point(733, 162);
            this.btnResetPWStudent.Name = "btnResetPWStudent";
            this.btnResetPWStudent.Size = new System.Drawing.Size(75, 23);
            this.btnResetPWStudent.TabIndex = 35;
            this.btnResetPWStudent.Text = "Reset MK";
            this.btnResetPWStudent.UseVisualStyleBackColor = true;
            // 
            // btnStudentSearch
            // 
            this.btnStudentSearch.Location = new System.Drawing.Point(485, 5);
            this.btnStudentSearch.Name = "btnStudentSearch";
            this.btnStudentSearch.Size = new System.Drawing.Size(75, 23);
            this.btnStudentSearch.TabIndex = 34;
            this.btnStudentSearch.Text = "Tìm kiếm";
            this.btnStudentSearch.UseVisualStyleBackColor = true;
            this.btnStudentSearch.Click += new System.EventHandler(this.btnStudentSearch_Click);
            // 
            // txtStudentSearch
            // 
            this.txtStudentSearch.Location = new System.Drawing.Point(71, 7);
            this.txtStudentSearch.Name = "txtStudentSearch";
            this.txtStudentSearch.Size = new System.Drawing.Size(390, 20);
            this.txtStudentSearch.TabIndex = 33;
            this.txtStudentSearch.TextChanged += new System.EventHandler(this.txtStudentSearch_TextChanged);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(830, 116);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteStudent.TabIndex = 32;
            this.btnDeleteStudent.Text = "Xóa";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.Location = new System.Drawing.Point(733, 116);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(75, 23);
            this.btnEditStudent.TabIndex = 31;
            this.btnEditStudent.Text = "Sửa";
            this.btnEditStudent.UseVisualStyleBackColor = true;
            this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(629, 116);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 30;
            this.btnAddStudent.Text = "Thêm";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(707, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Mật khẩu mặc định là Abcd@123";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(620, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Tên đăng nhập:";
            // 
            // txtStudentUsername
            // 
            this.txtStudentUsername.Location = new System.Drawing.Point(710, 44);
            this.txtStudentUsername.Name = "txtStudentUsername";
            this.txtStudentUsername.Size = new System.Drawing.Size(195, 20);
            this.txtStudentUsername.TabIndex = 27;
            this.txtStudentUsername.TextChanged += new System.EventHandler(this.txtStudentUsername_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(620, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Họ tên:";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(710, 3);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(195, 20);
            this.txtStudentName.TabIndex = 25;
            this.txtStudentName.TextChanged += new System.EventHandler(this.txtStudentName_TextChanged);
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStudent,
            this.nameStudent,
            this.usernameStudent,
            this.roleStudent,
            this.statusStudent});
            this.dataGridViewStudent.Location = new System.Drawing.Point(0, 33);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.Size = new System.Drawing.Size(614, 391);
            this.dataGridViewStudent.TabIndex = 24;
            this.dataGridViewStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudent_CellClick);
            this.dataGridViewStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudent_CellClick);
            // 
            // idStudent
            // 
            this.idStudent.DataPropertyName = "id";
            this.idStudent.HeaderText = "Id";
            this.idStudent.Name = "idStudent";
            this.idStudent.ReadOnly = true;
            this.idStudent.Width = 50;
            // 
            // nameStudent
            // 
            this.nameStudent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameStudent.DataPropertyName = "name";
            this.nameStudent.HeaderText = "Họ tên";
            this.nameStudent.Name = "nameStudent";
            this.nameStudent.ReadOnly = true;
            // 
            // usernameStudent
            // 
            this.usernameStudent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usernameStudent.DataPropertyName = "username";
            this.usernameStudent.HeaderText = "Tên đăng nhập";
            this.usernameStudent.Name = "usernameStudent";
            this.usernameStudent.ReadOnly = true;
            // 
            // roleStudent
            // 
            this.roleStudent.DataPropertyName = "role";
            this.roleStudent.HeaderText = "role";
            this.roleStudent.Name = "roleStudent";
            this.roleStudent.ReadOnly = true;
            this.roleStudent.Visible = false;
            // 
            // statusStudent
            // 
            this.statusStudent.DataPropertyName = "status";
            this.statusStudent.HeaderText = "status";
            this.statusStudent.Name = "statusStudent";
            this.statusStudent.ReadOnly = true;
            this.statusStudent.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(703, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Mật khẩu mặc định là Abcd@123";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(616, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Tên đăng nhập:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(616, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Họ tên:";
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormUser";
            this.Text = "Danh mục người dùng";
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacher)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private System.Windows.Forms.DataGridView dataGridViewTeacher;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button BtnDeleteTeacher;
        private System.Windows.Forms.Button btnEditTeacher;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTeacherUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAdminSearch;
        private System.Windows.Forms.TextBox txtAdminSearch;
        private System.Windows.Forms.Button btnTeacherSearch;
        private System.Windows.Forms.TextBox txtTeacherSearch;
        private System.Windows.Forms.Button btnTeacherResetPW;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnResetPWStudent;
        private System.Windows.Forms.Button btnStudentSearch;
        private System.Windows.Forms.TextBox txtStudentSearch;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStudentUsername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusStudent;
    }
}