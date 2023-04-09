namespace QLDThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.label5 = new System.Windows.Forms.Label();
            this.btnQuanTri = new System.Windows.Forms.Button();
            this.btnThi = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLichSuThi = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnChangePW = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSubject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(149, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 39);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quản Lý Thi";
            // 
            // btnQuanTri
            // 
            this.btnQuanTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnQuanTri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanTri.Location = new System.Drawing.Point(311, 200);
            this.btnQuanTri.Name = "btnQuanTri";
            this.btnQuanTri.Size = new System.Drawing.Size(136, 54);
            this.btnQuanTri.TabIndex = 12;
            this.btnQuanTri.Text = "CÂU HỎI/ĐỀ THÌ";
            this.btnQuanTri.UseVisualStyleBackColor = true;
            this.btnQuanTri.Visible = false;
            this.btnQuanTri.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnThi
            // 
            this.btnThi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnThi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThi.Location = new System.Drawing.Point(91, 129);
            this.btnThi.Name = "btnThi";
            this.btnThi.Size = new System.Drawing.Size(136, 54);
            this.btnThi.TabIndex = 13;
            this.btnThi.Text = "THI";
            this.btnThi.UseVisualStyleBackColor = false;
            this.btnThi.Visible = false;
            this.btnThi.Click += new System.EventHandler(this.btnThi_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblWelcome.Location = new System.Drawing.Point(448, 12);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(98, 13);
            this.lblWelcome.TabIndex = 14;
            this.lblWelcome.Text = "Xin chào username";
            // 
            // btnLichSuThi
            // 
            this.btnLichSuThi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLichSuThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLichSuThi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichSuThi.Location = new System.Drawing.Point(311, 129);
            this.btnLichSuThi.Name = "btnLichSuThi";
            this.btnLichSuThi.Size = new System.Drawing.Size(136, 54);
            this.btnLichSuThi.TabIndex = 20;
            this.btnLichSuThi.Text = "LỊCH SỬ THI";
            this.btnLichSuThi.UseVisualStyleBackColor = false;
            this.btnLichSuThi.Visible = false;
            this.btnLichSuThi.Click += new System.EventHandler(this.btnLichSuThi_Click);
            // 
            // btnUser
            // 
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(90, 200);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(137, 54);
            this.btnUser.TabIndex = 21;
            this.btnUser.Text = "QUẢN LÝ NGƯỜI DÙNG";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Visible = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnChangePW
            // 
            this.btnChangePW.BackColor = System.Drawing.SystemColors.Control;
            this.btnChangePW.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePW.Image")));
            this.btnChangePW.Location = new System.Drawing.Point(451, 42);
            this.btnChangePW.Name = "btnChangePW";
            this.btnChangePW.Size = new System.Drawing.Size(42, 34);
            this.btnChangePW.TabIndex = 19;
            this.btnChangePW.UseVisualStyleBackColor = false;
            this.btnChangePW.Click += new System.EventHandler(this.btnChangePW_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(504, 42);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(42, 34);
            this.btnLogout.TabIndex = 18;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSubject
            // 
            this.btnSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSubject.Location = new System.Drawing.Point(91, 129);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Size = new System.Drawing.Size(136, 54);
            this.btnSubject.TabIndex = 22;
            this.btnSubject.Text = "MÔN HỌC";
            this.btnSubject.UseVisualStyleBackColor = true;
            this.btnSubject.Click += new System.EventHandler(this.btnSubject_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 315);
            this.Controls.Add(this.btnSubject);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnLichSuThi);
            this.Controls.Add(this.btnChangePW);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnThi);
            this.Controls.Add(this.btnQuanTri);
            this.Controls.Add(this.label5);
            this.KeyPreview = true;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnQuanTri;
        private System.Windows.Forms.Button btnThi;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnChangePW;
        private System.Windows.Forms.Button btnLichSuThi;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnSubject;
    }
}