namespace DB_CW
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
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAdminSearch = new System.Windows.Forms.Button();
            this.txtAdminSearch = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewTeacher = new System.Windows.Forms.DataGridView();
            this.txtTeacherUsername = new System.Windows.Forms.TextBox();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.txtTeacherSearch = new System.Windows.Forms.TextBox();
            this.bntTeacherReserPW = new System.Windows.Forms.Button();
            this.bntDeleteTeacher = new System.Windows.Forms.Button();
            this.bntEditTeacher = new System.Windows.Forms.Button();
            this.bntAddTeacher = new System.Windows.Forms.Button();
            this.bntTeacherSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtStudentUsername = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bntStudentResetPW = new System.Windows.Forms.Button();
            this.bntDeleteStudent = new System.Windows.Forms.Button();
            this.bntChangeStudent = new System.Windows.Forms.Button();
            this.bntAddStudent = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacher)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(927, 483);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewAdmin);
            this.tabPage1.Controls.Add(this.txtUsername);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnEdit);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.btnAdminSearch);
            this.tabPage1.Controls.Add(this.txtAdminSearch);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(919, 457);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Admin";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.AllowUserToAddRows = false;
            this.dataGridViewAdmin.AllowUserToDeleteRows = false;
            this.dataGridViewAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewAdmin.Location = new System.Drawing.Point(10, 50);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.ReadOnly = true;
            this.dataGridViewAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAdmin.Size = new System.Drawing.Size(575, 400);
            this.dataGridViewAdmin.TabIndex = 9;
            this.dataGridViewAdmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdmin_CellClick);
            this.dataGridViewAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdmin_CellClick);
            this.dataGridViewAdmin.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewAdmin_RowHeaderMouseClick);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(700, 55);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(195, 23);
            this.txtUsername.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(700, 15);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(195, 23);
            this.txtName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(620, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Логин:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(620, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ф. И. О:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(825, 120);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(725, 120);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(72, 25);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(625, 120);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAdminSearch
            // 
            this.btnAdminSearch.Location = new System.Drawing.Point(435, 15);
            this.btnAdminSearch.Name = "btnAdminSearch";
            this.btnAdminSearch.Size = new System.Drawing.Size(75, 25);
            this.btnAdminSearch.TabIndex = 1;
            this.btnAdminSearch.Text = "Найти";
            this.btnAdminSearch.UseVisualStyleBackColor = true;
            this.btnAdminSearch.Click += new System.EventHandler(this.btnAdminSearch_Click);
            // 
            // txtAdminSearch
            // 
            this.txtAdminSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminSearch.Location = new System.Drawing.Point(25, 15);
            this.txtAdminSearch.Name = "txtAdminSearch";
            this.txtAdminSearch.Size = new System.Drawing.Size(390, 23);
            this.txtAdminSearch.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewTeacher);
            this.tabPage2.Controls.Add(this.txtTeacherUsername);
            this.tabPage2.Controls.Add(this.txtTeacherName);
            this.tabPage2.Controls.Add(this.txtTeacherSearch);
            this.tabPage2.Controls.Add(this.bntTeacherReserPW);
            this.tabPage2.Controls.Add(this.bntDeleteTeacher);
            this.tabPage2.Controls.Add(this.bntEditTeacher);
            this.tabPage2.Controls.Add(this.bntAddTeacher);
            this.tabPage2.Controls.Add(this.bntTeacherSearch);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(919, 457);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Учитель";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTeacher
            // 
            this.dataGridViewTeacher.AllowUserToAddRows = false;
            this.dataGridViewTeacher.AllowUserToDeleteRows = false;
            this.dataGridViewTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeacher.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewTeacher.Location = new System.Drawing.Point(10, 50);
            this.dataGridViewTeacher.Name = "dataGridViewTeacher";
            this.dataGridViewTeacher.ReadOnly = true;
            this.dataGridViewTeacher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTeacher.Size = new System.Drawing.Size(575, 400);
            this.dataGridViewTeacher.TabIndex = 10;
            this.dataGridViewTeacher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTeacher_CellClick);
            this.dataGridViewTeacher.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdmin_CellClick);
            this.dataGridViewTeacher.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewTeacher_RowHeaderMouseClick);
            // 
            // txtTeacherUsername
            // 
            this.txtTeacherUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherUsername.Location = new System.Drawing.Point(700, 55);
            this.txtTeacherUsername.Name = "txtTeacherUsername";
            this.txtTeacherUsername.Size = new System.Drawing.Size(195, 23);
            this.txtTeacherUsername.TabIndex = 9;
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherName.Location = new System.Drawing.Point(700, 15);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(195, 23);
            this.txtTeacherName.TabIndex = 8;
            // 
            // txtTeacherSearch
            // 
            this.txtTeacherSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherSearch.Location = new System.Drawing.Point(25, 15);
            this.txtTeacherSearch.Name = "txtTeacherSearch";
            this.txtTeacherSearch.Size = new System.Drawing.Size(390, 23);
            this.txtTeacherSearch.TabIndex = 7;
            // 
            // bntTeacherReserPW
            // 
            this.bntTeacherReserPW.Location = new System.Drawing.Point(720, 190);
            this.bntTeacherReserPW.Name = "bntTeacherReserPW";
            this.bntTeacherReserPW.Size = new System.Drawing.Size(65, 45);
            this.bntTeacherReserPW.TabIndex = 6;
            this.bntTeacherReserPW.Text = "Cбросить пароль";
            this.bntTeacherReserPW.UseVisualStyleBackColor = true;
            this.bntTeacherReserPW.Click += new System.EventHandler(this.bntTeacherReserPW_Click);
            // 
            // bntDeleteTeacher
            // 
            this.bntDeleteTeacher.Location = new System.Drawing.Point(825, 120);
            this.bntDeleteTeacher.Name = "bntDeleteTeacher";
            this.bntDeleteTeacher.Size = new System.Drawing.Size(75, 25);
            this.bntDeleteTeacher.TabIndex = 5;
            this.bntDeleteTeacher.Text = "Удалить";
            this.bntDeleteTeacher.UseVisualStyleBackColor = true;
            this.bntDeleteTeacher.Click += new System.EventHandler(this.bntDeleteTeacher_Click);
            // 
            // bntEditTeacher
            // 
            this.bntEditTeacher.Location = new System.Drawing.Point(725, 120);
            this.bntEditTeacher.Name = "bntEditTeacher";
            this.bntEditTeacher.Size = new System.Drawing.Size(75, 25);
            this.bntEditTeacher.TabIndex = 4;
            this.bntEditTeacher.Text = "Изменить";
            this.bntEditTeacher.UseVisualStyleBackColor = true;
            this.bntEditTeacher.Click += new System.EventHandler(this.bntEditTeacher_Click);
            // 
            // bntAddTeacher
            // 
            this.bntAddTeacher.Location = new System.Drawing.Point(625, 120);
            this.bntAddTeacher.Name = "bntAddTeacher";
            this.bntAddTeacher.Size = new System.Drawing.Size(75, 25);
            this.bntAddTeacher.TabIndex = 3;
            this.bntAddTeacher.Text = "Добавить";
            this.bntAddTeacher.UseVisualStyleBackColor = true;
            this.bntAddTeacher.Click += new System.EventHandler(this.bntAddTeacher_Click);
            // 
            // bntTeacherSearch
            // 
            this.bntTeacherSearch.Location = new System.Drawing.Point(435, 15);
            this.bntTeacherSearch.Name = "bntTeacherSearch";
            this.bntTeacherSearch.Size = new System.Drawing.Size(75, 25);
            this.bntTeacherSearch.TabIndex = 2;
            this.bntTeacherSearch.Text = "Найти";
            this.bntTeacherSearch.UseVisualStyleBackColor = true;
            this.bntTeacherSearch.Click += new System.EventHandler(this.bntTeacherSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(620, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(620, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ф. И. О.";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtStudentUsername);
            this.tabPage3.Controls.Add(this.txtStudentName);
            this.tabPage3.Controls.Add(this.txtStudentSearch);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.bntStudentResetPW);
            this.tabPage3.Controls.Add(this.bntDeleteStudent);
            this.tabPage3.Controls.Add(this.bntChangeStudent);
            this.tabPage3.Controls.Add(this.bntAddStudent);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.dataGridViewStudent);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(919, 457);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Студент";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtStudentUsername
            // 
            this.txtStudentUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentUsername.Location = new System.Drawing.Point(700, 55);
            this.txtStudentUsername.Name = "txtStudentUsername";
            this.txtStudentUsername.Size = new System.Drawing.Size(195, 23);
            this.txtStudentUsername.TabIndex = 10;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.Location = new System.Drawing.Point(700, 15);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(195, 23);
            this.txtStudentName.TabIndex = 9;
            // 
            // txtStudentSearch
            // 
            this.txtStudentSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentSearch.Location = new System.Drawing.Point(25, 15);
            this.txtStudentSearch.Name = "txtStudentSearch";
            this.txtStudentSearch.Size = new System.Drawing.Size(390, 23);
            this.txtStudentSearch.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.Location = new System.Drawing.Point(620, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Логин";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(620, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ф. И. О.";
            // 
            // bntStudentResetPW
            // 
            this.bntStudentResetPW.Location = new System.Drawing.Point(720, 190);
            this.bntStudentResetPW.Name = "bntStudentResetPW";
            this.bntStudentResetPW.Size = new System.Drawing.Size(65, 45);
            this.bntStudentResetPW.TabIndex = 5;
            this.bntStudentResetPW.Text = "Сбросить пароль";
            this.bntStudentResetPW.UseVisualStyleBackColor = true;
            this.bntStudentResetPW.Click += new System.EventHandler(this.bntStudentResetPW_Click);
            // 
            // bntDeleteStudent
            // 
            this.bntDeleteStudent.Location = new System.Drawing.Point(825, 120);
            this.bntDeleteStudent.Name = "bntDeleteStudent";
            this.bntDeleteStudent.Size = new System.Drawing.Size(75, 25);
            this.bntDeleteStudent.TabIndex = 4;
            this.bntDeleteStudent.Text = "Удалить";
            this.bntDeleteStudent.UseVisualStyleBackColor = true;
            this.bntDeleteStudent.Click += new System.EventHandler(this.bntDeleteStudent_Click);
            // 
            // bntChangeStudent
            // 
            this.bntChangeStudent.Location = new System.Drawing.Point(725, 120);
            this.bntChangeStudent.Name = "bntChangeStudent";
            this.bntChangeStudent.Size = new System.Drawing.Size(75, 25);
            this.bntChangeStudent.TabIndex = 3;
            this.bntChangeStudent.Text = "Изменить";
            this.bntChangeStudent.UseVisualStyleBackColor = true;
            this.bntChangeStudent.Click += new System.EventHandler(this.bntChangeStudent_Click);
            // 
            // bntAddStudent
            // 
            this.bntAddStudent.Location = new System.Drawing.Point(625, 120);
            this.bntAddStudent.Name = "bntAddStudent";
            this.bntAddStudent.Size = new System.Drawing.Size(75, 25);
            this.bntAddStudent.TabIndex = 2;
            this.bntAddStudent.Text = "Добавить";
            this.bntAddStudent.UseVisualStyleBackColor = true;
            this.bntAddStudent.Click += new System.EventHandler(this.bntAddStudent_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bntStudentSearch_Click);
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.AllowUserToAddRows = false;
            this.dataGridViewStudent.AllowUserToDeleteRows = false;
            this.dataGridViewStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewStudent.Location = new System.Drawing.Point(10, 50);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.ReadOnly = true;
            this.dataGridViewStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudent.Size = new System.Drawing.Size(575, 400);
            this.dataGridViewStudent.TabIndex = 0;
            this.dataGridViewStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudent_CellClick);
            this.dataGridViewStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudent_CellClick);
            this.dataGridViewStudent.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewStudent_RowHeaderMouseClick);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 486);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormUser";
            this.Text = "Управление пользователей";
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacher)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAdminSearch;
        private System.Windows.Forms.TextBox txtAdminSearch;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewTeacher;
        private System.Windows.Forms.TextBox txtTeacherUsername;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.TextBox txtTeacherSearch;
        private System.Windows.Forms.Button bntTeacherReserPW;
        private System.Windows.Forms.Button bntDeleteTeacher;
        private System.Windows.Forms.Button bntEditTeacher;
        private System.Windows.Forms.Button bntAddTeacher;
        private System.Windows.Forms.Button bntTeacherSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStudentUsername;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bntStudentResetPW;
        private System.Windows.Forms.Button bntDeleteStudent;
        private System.Windows.Forms.Button bntChangeStudent;
        private System.Windows.Forms.Button bntAddStudent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
    }
}