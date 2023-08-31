namespace DB_CW
{
    partial class FormTakeExam
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
            this.components = new System.ComponentModel.Container();
            this.dgvQuestion = new System.Windows.Forms.DataGridView();
            this.gbAnswer = new System.Windows.Forms.GroupBox();
            this.rAns4 = new System.Windows.Forms.RadioButton();
            this.rAns3 = new System.Windows.Forms.RadioButton();
            this.rAns2 = new System.Windows.Forms.RadioButton();
            this.rAns1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestion)).BeginInit();
            this.gbAnswer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvQuestion
            // 
            this.dgvQuestion.AllowUserToAddRows = false;
            this.dgvQuestion.AllowUserToDeleteRows = false;
            this.dgvQuestion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvQuestion.Location = new System.Drawing.Point(5, 53);
            this.dgvQuestion.Name = "dgvQuestion";
            this.dgvQuestion.ReadOnly = true;
            this.dgvQuestion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuestion.Size = new System.Drawing.Size(880, 402);
            this.dgvQuestion.TabIndex = 0;
            this.dgvQuestion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuestion_CellClick);
            this.dgvQuestion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuestion_CellClick);
            // 
            // gbAnswer
            // 
            this.gbAnswer.Controls.Add(this.rAns4);
            this.gbAnswer.Controls.Add(this.rAns3);
            this.gbAnswer.Controls.Add(this.rAns2);
            this.gbAnswer.Controls.Add(this.rAns1);
            this.gbAnswer.Enabled = false;
            this.gbAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.gbAnswer.Location = new System.Drawing.Point(22, 477);
            this.gbAnswer.Name = "gbAnswer";
            this.gbAnswer.Size = new System.Drawing.Size(850, 193);
            this.gbAnswer.TabIndex = 1;
            this.gbAnswer.TabStop = false;
            this.gbAnswer.Text = "Выберите ответ";
            // 
            // rAns4
            // 
            this.rAns4.AutoSize = true;
            this.rAns4.Location = new System.Drawing.Point(21, 157);
            this.rAns4.Name = "rAns4";
            this.rAns4.Size = new System.Drawing.Size(38, 21);
            this.rAns4.TabIndex = 3;
            this.rAns4.TabStop = true;
            this.rAns4.Text = "Г.";
            this.rAns4.UseVisualStyleBackColor = true;
            this.rAns4.CheckedChanged += new System.EventHandler(this.rAns4_CheckedChanged);
            // 
            // rAns3
            // 
            this.rAns3.AutoSize = true;
            this.rAns3.Location = new System.Drawing.Point(21, 117);
            this.rAns3.Name = "rAns3";
            this.rAns3.Size = new System.Drawing.Size(39, 21);
            this.rAns3.TabIndex = 2;
            this.rAns3.TabStop = true;
            this.rAns3.Text = "В.";
            this.rAns3.UseVisualStyleBackColor = true;
            this.rAns3.CheckedChanged += new System.EventHandler(this.rAns3_CheckedChanged);
            // 
            // rAns2
            // 
            this.rAns2.AutoSize = true;
            this.rAns2.Location = new System.Drawing.Point(21, 71);
            this.rAns2.Name = "rAns2";
            this.rAns2.Size = new System.Drawing.Size(39, 21);
            this.rAns2.TabIndex = 1;
            this.rAns2.TabStop = true;
            this.rAns2.Text = "Б.";
            this.rAns2.UseVisualStyleBackColor = true;
            this.rAns2.CheckedChanged += new System.EventHandler(this.rAns2_CheckedChanged);
            // 
            // rAns1
            // 
            this.rAns1.AutoSize = true;
            this.rAns1.Location = new System.Drawing.Point(21, 27);
            this.rAns1.Name = "rAns1";
            this.rAns1.Size = new System.Drawing.Size(39, 21);
            this.rAns1.TabIndex = 0;
            this.rAns1.TabStop = true;
            this.rAns1.Text = "A.";
            this.rAns1.UseVisualStyleBackColor = true;
            this.rAns1.CheckedChanged += new System.EventHandler(this.rAns1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button1.Location = new System.Drawing.Point(401, 676);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Завершить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Времени осталось:";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.time.Location = new System.Drawing.Point(152, 17);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(51, 20);
            this.time.TabIndex = 4;
            this.time.Text = "label2";
            // 
            // FormTakeExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 723);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbAnswer);
            this.Controls.Add(this.dgvQuestion);
            this.Name = "FormTakeExam";
            this.Text = "Тест";
            this.Load += new System.EventHandler(this.FormTakeExam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestion)).EndInit();
            this.gbAnswer.ResumeLayout(false);
            this.gbAnswer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQuestion;
        private System.Windows.Forms.GroupBox gbAnswer;
        private System.Windows.Forms.RadioButton rAns4;
        private System.Windows.Forms.RadioButton rAns3;
        private System.Windows.Forms.RadioButton rAns2;
        private System.Windows.Forms.RadioButton rAns1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label time;
    }
}