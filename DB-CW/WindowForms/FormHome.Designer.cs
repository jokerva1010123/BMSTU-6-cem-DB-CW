namespace DB_CW
{
    partial class FormHome
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
            this.btnSubject = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnLichSuThi = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnThi = new System.Windows.Forms.Button();
            this.btnQuanTri = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChangePW = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubject
            // 
            this.btnSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSubject.Location = new System.Drawing.Point(319, 194);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Size = new System.Drawing.Size(150, 60);
            this.btnSubject.TabIndex = 31;
            this.btnSubject.Text = "Управление \nпредметами";
            this.btnSubject.UseVisualStyleBackColor = true;
            this.btnSubject.Click += new System.EventHandler(this.btnSubject_Click);
            // 
            // btnUser
            // 
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(98, 194);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(150, 60);
            this.btnUser.TabIndex = 30;
            this.btnUser.Text = "Управление \nпользователями";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Visible = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnLichSuThi
            // 
            this.btnLichSuThi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLichSuThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLichSuThi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichSuThi.Location = new System.Drawing.Point(319, 123);
            this.btnLichSuThi.Name = "btnLichSuThi";
            this.btnLichSuThi.Size = new System.Drawing.Size(150, 60);
            this.btnLichSuThi.TabIndex = 29;
            this.btnLichSuThi.Text = "Результаты";
            this.btnLichSuThi.UseVisualStyleBackColor = false;
            this.btnLichSuThi.Visible = false;
            this.btnLichSuThi.Click += new System.EventHandler(this.btnLichSuThi_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblWelcome.Location = new System.Drawing.Point(12, 12);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(217, 18);
            this.lblWelcome.TabIndex = 26;
            this.lblWelcome.Text = "Добро пожаловать username!";
            // 
            // btnThi
            // 
            this.btnThi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnThi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThi.Location = new System.Drawing.Point(99, 123);
            this.btnThi.Name = "btnThi";
            this.btnThi.Size = new System.Drawing.Size(150, 60);
            this.btnThi.TabIndex = 25;
            this.btnThi.Text = "Сдавать тест";
            this.btnThi.UseVisualStyleBackColor = false;
            this.btnThi.Visible = false;
            this.btnThi.Click += new System.EventHandler(this.btnThi_Click);
            // 
            // btnQuanTri
            // 
            this.btnQuanTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnQuanTri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanTri.Location = new System.Drawing.Point(99, 123);
            this.btnQuanTri.Name = "btnQuanTri";
            this.btnQuanTri.Size = new System.Drawing.Size(150, 60);
            this.btnQuanTri.TabIndex = 24;
            this.btnQuanTri.Text = "Вопросы/Тесты";
            this.btnQuanTri.UseVisualStyleBackColor = true;
            this.btnQuanTri.Visible = false;
            this.btnQuanTri.Click += new System.EventHandler(this.btnQuanTri_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(129, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(326, 39);
            this.label5.TabIndex = 23;
            this.label5.Text = "Главные функции";
            // 
            // btnChangePW
            // 
            this.btnChangePW.BackColor = System.Drawing.SystemColors.Control;
            this.btnChangePW.Image = global::DB_CW.Properties.Resources.change_password;
            this.btnChangePW.Location = new System.Drawing.Point(477, 12);
            this.btnChangePW.Name = "btnChangePW";
            this.btnChangePW.Size = new System.Drawing.Size(42, 34);
            this.btnChangePW.TabIndex = 28;
            this.btnChangePW.UseVisualStyleBackColor = false;
            this.btnChangePW.Click += new System.EventHandler(this.btnChangePW_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogout.Image = global::DB_CW.Properties.Resources.logout1;
            this.btnLogout.Location = new System.Drawing.Point(530, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(42, 34);
            this.btnLogout.TabIndex = 27;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.btnSubject);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnLichSuThi);
            this.Controls.Add(this.btnChangePW);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnThi);
            this.Controls.Add(this.btnQuanTri);
            this.Controls.Add(this.label5);
            this.Name = "FormHome";
            this.Text = "Home Window";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubject;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnLichSuThi;
        private System.Windows.Forms.Button btnChangePW;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnThi;
        private System.Windows.Forms.Button btnQuanTri;
        private System.Windows.Forms.Label label5;
    }
}