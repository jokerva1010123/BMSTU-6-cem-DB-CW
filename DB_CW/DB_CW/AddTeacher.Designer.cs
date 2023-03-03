namespace DB_CW
{
    partial class AddTeacher
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
            this.AddNameTeacher = new System.Windows.Forms.TextBox();
            this.AddUsernameTeacher = new System.Windows.Forms.TextBox();
            this.AddPasswordTeacher = new System.Windows.Forms.TextBox();
            this.AddTeacherFromForm = new System.Windows.Forms.Button();
            this.CancelAddTeacher = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 90);
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
            this.label3.Location = new System.Drawing.Point(157, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "password";
            // 
            // AddNameTeacher
            // 
            this.AddNameTeacher.Location = new System.Drawing.Point(238, 83);
            this.AddNameTeacher.Name = "AddNameTeacher";
            this.AddNameTeacher.Size = new System.Drawing.Size(274, 20);
            this.AddNameTeacher.TabIndex = 3;
            // 
            // AddUsernameTeacher
            // 
            this.AddUsernameTeacher.Location = new System.Drawing.Point(238, 123);
            this.AddUsernameTeacher.Name = "AddUsernameTeacher";
            this.AddUsernameTeacher.Size = new System.Drawing.Size(274, 20);
            this.AddUsernameTeacher.TabIndex = 4;
            // 
            // AddPasswordTeacher
            // 
            this.AddPasswordTeacher.Location = new System.Drawing.Point(238, 165);
            this.AddPasswordTeacher.Name = "AddPasswordTeacher";
            this.AddPasswordTeacher.Size = new System.Drawing.Size(274, 20);
            this.AddPasswordTeacher.TabIndex = 5;
            // 
            // AddTeacherFromForm
            // 
            this.AddTeacherFromForm.Location = new System.Drawing.Point(160, 242);
            this.AddTeacherFromForm.Name = "AddTeacherFromForm";
            this.AddTeacherFromForm.Size = new System.Drawing.Size(123, 36);
            this.AddTeacherFromForm.TabIndex = 6;
            this.AddTeacherFromForm.Text = "Add";
            this.AddTeacherFromForm.UseVisualStyleBackColor = true;
            this.AddTeacherFromForm.Click += new System.EventHandler(this.AddTeacherFromForm_Click);
            // 
            // CancelAddTeacher
            // 
            this.CancelAddTeacher.Location = new System.Drawing.Point(389, 242);
            this.CancelAddTeacher.Name = "CancelAddTeacher";
            this.CancelAddTeacher.Size = new System.Drawing.Size(123, 36);
            this.CancelAddTeacher.TabIndex = 7;
            this.CancelAddTeacher.Text = "Cancel";
            this.CancelAddTeacher.UseVisualStyleBackColor = true;
            this.CancelAddTeacher.Click += new System.EventHandler(this.CancelAddTeacher_Click);
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Giao vien",
            "Hoc sinh"});
            this.comboBox1.Location = new System.Drawing.Point(238, 199);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // AddTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CancelAddTeacher);
            this.Controls.Add(this.AddTeacherFromForm);
            this.Controls.Add(this.AddPasswordTeacher);
            this.Controls.Add(this.AddUsernameTeacher);
            this.Controls.Add(this.AddNameTeacher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddTeacher";
            this.Text = "AddTeacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddNameTeacher;
        private System.Windows.Forms.TextBox AddUsernameTeacher;
        private System.Windows.Forms.TextBox AddPasswordTeacher;
        private System.Windows.Forms.Button AddTeacherFromForm;
        private System.Windows.Forms.Button CancelAddTeacher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}