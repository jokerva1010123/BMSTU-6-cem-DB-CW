namespace DB_CW
{
    partial class FormQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuestion));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDeleteQuestion = new System.Windows.Forms.Button();
            this.btnChangeQuestion = new System.Windows.Forms.Button();
            this.bntAddQuestion = new System.Windows.Forms.Button();
            this.dgvQuestion = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDeleteExam = new System.Windows.Forms.Button();
            this.btnChangeExam = new System.Windows.Forms.Button();
            this.bntAddExam = new System.Windows.Forms.Button();
            this.dgvExam = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestion)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExam)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 456);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDeleteQuestion);
            this.tabPage1.Controls.Add(this.btnChangeQuestion);
            this.tabPage1.Controls.Add(this.bntAddQuestion);
            this.tabPage1.Controls.Add(this.dgvQuestion);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Вопросы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDeleteQuestion
            // 
            this.btnDeleteQuestion.Enabled = false;
            this.btnDeleteQuestion.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteQuestion.Image")));
            this.btnDeleteQuestion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteQuestion.Location = new System.Drawing.Point(500, 385);
            this.btnDeleteQuestion.Name = "btnDeleteQuestion";
            this.btnDeleteQuestion.Size = new System.Drawing.Size(85, 35);
            this.btnDeleteQuestion.TabIndex = 3;
            this.btnDeleteQuestion.Text = "Удалить";
            this.btnDeleteQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteQuestion.UseVisualStyleBackColor = true;
            this.btnDeleteQuestion.Click += new System.EventHandler(this.btnDeleteQuestion_Click);
            // 
            // btnChangeQuestion
            // 
            this.btnChangeQuestion.Enabled = false;
            this.btnChangeQuestion.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeQuestion.Image")));
            this.btnChangeQuestion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeQuestion.Location = new System.Drawing.Point(310, 385);
            this.btnChangeQuestion.Name = "btnChangeQuestion";
            this.btnChangeQuestion.Size = new System.Drawing.Size(85, 35);
            this.btnChangeQuestion.TabIndex = 2;
            this.btnChangeQuestion.Text = "Изменить";
            this.btnChangeQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangeQuestion.UseVisualStyleBackColor = true;
            this.btnChangeQuestion.Click += new System.EventHandler(this.btnChangeQuestion_Click);
            // 
            // bntAddQuestion
            // 
            this.bntAddQuestion.Image = ((System.Drawing.Image)(resources.GetObject("bntAddQuestion.Image")));
            this.bntAddQuestion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntAddQuestion.Location = new System.Drawing.Point(135, 385);
            this.bntAddQuestion.Name = "bntAddQuestion";
            this.bntAddQuestion.Size = new System.Drawing.Size(85, 35);
            this.bntAddQuestion.TabIndex = 1;
            this.bntAddQuestion.Text = "Добавить";
            this.bntAddQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntAddQuestion.UseVisualStyleBackColor = true;
            this.bntAddQuestion.Click += new System.EventHandler(this.bntAddQuestion_Click);
            // 
            // dgvQuestion
            // 
            this.dgvQuestion.AllowUserToAddRows = false;
            this.dgvQuestion.AllowUserToDeleteRows = false;
            this.dgvQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvQuestion.Location = new System.Drawing.Point(5, 5);
            this.dgvQuestion.Name = "dgvQuestion";
            this.dgvQuestion.ReadOnly = true;
            this.dgvQuestion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuestion.Size = new System.Drawing.Size(780, 370);
            this.dgvQuestion.TabIndex = 0;
            this.dgvQuestion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuestion_CellContentClick);
            this.dgvQuestion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuestion_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDeleteExam);
            this.tabPage2.Controls.Add(this.btnChangeExam);
            this.tabPage2.Controls.Add(this.bntAddExam);
            this.tabPage2.Controls.Add(this.dgvExam);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 430);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Тесты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDeleteExam
            // 
            this.btnDeleteExam.Enabled = false;
            this.btnDeleteExam.Image = global::DB_CW.Properties.Resources.delete;
            this.btnDeleteExam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteExam.Location = new System.Drawing.Point(500, 385);
            this.btnDeleteExam.Name = "btnDeleteExam";
            this.btnDeleteExam.Size = new System.Drawing.Size(85, 35);
            this.btnDeleteExam.TabIndex = 3;
            this.btnDeleteExam.Text = "Удалить";
            this.btnDeleteExam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteExam.UseVisualStyleBackColor = true;
            this.btnDeleteExam.Click += new System.EventHandler(this.btnDeleteExam_Click);
            // 
            // btnChangeExam
            // 
            this.btnChangeExam.Enabled = false;
            this.btnChangeExam.Image = global::DB_CW.Properties.Resources.edit;
            this.btnChangeExam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeExam.Location = new System.Drawing.Point(310, 385);
            this.btnChangeExam.Name = "btnChangeExam";
            this.btnChangeExam.Size = new System.Drawing.Size(85, 35);
            this.btnChangeExam.TabIndex = 2;
            this.btnChangeExam.Text = "Изменить";
            this.btnChangeExam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangeExam.UseVisualStyleBackColor = true;
            this.btnChangeExam.Click += new System.EventHandler(this.btnChangeExam_Click);
            // 
            // bntAddExam
            // 
            this.bntAddExam.Image = global::DB_CW.Properties.Resources.create;
            this.bntAddExam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntAddExam.Location = new System.Drawing.Point(135, 385);
            this.bntAddExam.Name = "bntAddExam";
            this.bntAddExam.Size = new System.Drawing.Size(85, 35);
            this.bntAddExam.TabIndex = 1;
            this.bntAddExam.Text = "Добавить";
            this.bntAddExam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntAddExam.UseVisualStyleBackColor = true;
            this.bntAddExam.Click += new System.EventHandler(this.bntAddExam_Click);
            // 
            // dgvExam
            // 
            this.dgvExam.AllowUserToAddRows = false;
            this.dgvExam.AllowUserToDeleteRows = false;
            this.dgvExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExam.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvExam.Location = new System.Drawing.Point(5, 5);
            this.dgvExam.MultiSelect = false;
            this.dgvExam.Name = "dgvExam";
            this.dgvExam.ReadOnly = true;
            this.dgvExam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExam.Size = new System.Drawing.Size(780, 370);
            this.dgvExam.TabIndex = 0;
            this.dgvExam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExam_CellContentClick);
            this.dgvExam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExam_CellContentClick);
            // 
            // FormQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormQuestion";
            this.Text = "Управление тестами";
            this.Load += new System.EventHandler(this.FormQuestion_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestion)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnDeleteQuestion;
        private System.Windows.Forms.Button btnChangeQuestion;
        private System.Windows.Forms.Button bntAddQuestion;
        private System.Windows.Forms.DataGridView dgvQuestion;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvExam;
        private System.Windows.Forms.Button btnDeleteExam;
        private System.Windows.Forms.Button btnChangeExam;
        private System.Windows.Forms.Button bntAddExam;
    }
}