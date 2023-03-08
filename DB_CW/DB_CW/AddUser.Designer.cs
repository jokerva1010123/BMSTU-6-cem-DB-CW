namespace DB_CW
{
    partial class AddUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddNameUser = new System.Windows.Forms.TextBox();
            this.AddUsername = new System.Windows.Forms.TextBox();
            this.AddPassword = new System.Windows.Forms.TextBox();
            this.ButtonAddUser = new System.Windows.Forms.Button();
            this.CancelAddTeacher = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TypeRole = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AddPhone = new System.Windows.Forms.TextBox();
            this.AddEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "password";
            // 
            // AddNameUser
            // 
            this.AddNameUser.Location = new System.Drawing.Point(238, 83);
            this.AddNameUser.Name = "AddNameUser";
            this.AddNameUser.Size = new System.Drawing.Size(274, 20);
            this.AddNameUser.TabIndex = 1;
            // 
            // AddUsername
            // 
            this.AddUsername.Location = new System.Drawing.Point(238, 123);
            this.AddUsername.Name = "AddUsername";
            this.AddUsername.Size = new System.Drawing.Size(274, 20);
            this.AddUsername.TabIndex = 2;
            // 
            // AddPassword
            // 
            this.AddPassword.Location = new System.Drawing.Point(238, 158);
            this.AddPassword.Name = "AddPassword";
            this.AddPassword.Size = new System.Drawing.Size(274, 20);
            this.AddPassword.TabIndex = 3;
            // 
            // ButtonAddUser
            // 
            this.ButtonAddUser.Location = new System.Drawing.Point(160, 351);
            this.ButtonAddUser.Name = "ButtonAddUser";
            this.ButtonAddUser.Size = new System.Drawing.Size(123, 36);
            this.ButtonAddUser.TabIndex = 7;
            this.ButtonAddUser.Text = "Add User";
            this.ButtonAddUser.UseVisualStyleBackColor = true;
            this.ButtonAddUser.Click += new System.EventHandler(this.AddUserForm_Click);
            // 
            // CancelAddTeacher
            // 
            this.CancelAddTeacher.Location = new System.Drawing.Point(403, 351);
            this.CancelAddTeacher.Name = "CancelAddTeacher";
            this.CancelAddTeacher.Size = new System.Drawing.Size(123, 36);
            this.CancelAddTeacher.TabIndex = 8;
            this.CancelAddTeacher.Text = "Cancel";
            this.CancelAddTeacher.UseVisualStyleBackColor = true;
            this.CancelAddTeacher.Click += new System.EventHandler(this.CancelAddUser_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Loai";
            // 
            // TypeRole
            // 
            this.TypeRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeRole.FormattingEnabled = true;
            this.TypeRole.Items.AddRange(new object[] {
            "Admin",
            "Giao vien",
            "Hoc sinh"});
            this.TypeRole.Location = new System.Drawing.Point(238, 199);
            this.TypeRole.Name = "TypeRole";
            this.TypeRole.Size = new System.Drawing.Size(133, 21);
            this.TypeRole.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(157, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Email";
            // 
            // AddPhone
            // 
            this.AddPhone.Location = new System.Drawing.Point(238, 246);
            this.AddPhone.Name = "AddPhone";
            this.AddPhone.Size = new System.Drawing.Size(139, 20);
            this.AddPhone.TabIndex = 5;
            // 
            // AddEmail
            // 
            this.AddEmail.Location = new System.Drawing.Point(238, 286);
            this.AddEmail.Name = "AddEmail";
            this.AddEmail.Size = new System.Drawing.Size(232, 20);
            this.AddEmail.TabIndex = 6;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddEmail);
            this.Controls.Add(this.AddPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TypeRole);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CancelAddTeacher);
            this.Controls.Add(this.ButtonAddUser);
            this.Controls.Add(this.AddPassword);
            this.Controls.Add(this.AddUsername);
            this.Controls.Add(this.AddNameUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddUser";
            this.Text = "Add User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddNameUser;
        private System.Windows.Forms.TextBox AddUsername;
        private System.Windows.Forms.TextBox AddPassword;
        private System.Windows.Forms.Button ButtonAddUser;
        private System.Windows.Forms.Button CancelAddTeacher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TypeRole;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AddPhone;
        private System.Windows.Forms.TextBox AddEmail;
    }
}