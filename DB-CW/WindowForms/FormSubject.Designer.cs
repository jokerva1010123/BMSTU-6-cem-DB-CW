namespace DB_CW
{
    partial class FormSubject
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
            this.bntSearch = new System.Windows.Forms.Button();
            this.bntAdd = new System.Windows.Forms.Button();
            this.bntEdit = new System.Windows.Forms.Button();
            this.bntDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grdSubject = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // bntSearch
            // 
            this.bntSearch.Location = new System.Drawing.Point(454, 18);
            this.bntSearch.Name = "bntSearch";
            this.bntSearch.Size = new System.Drawing.Size(75, 25);
            this.bntSearch.TabIndex = 0;
            this.bntSearch.Text = "Найти";
            this.bntSearch.UseVisualStyleBackColor = true;
            this.bntSearch.Click += new System.EventHandler(this.bntSearch_Click);
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(615, 86);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(75, 25);
            this.bntAdd.TabIndex = 1;
            this.bntAdd.Text = "Добавить";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // bntEdit
            // 
            this.bntEdit.Location = new System.Drawing.Point(729, 86);
            this.bntEdit.Name = "bntEdit";
            this.bntEdit.Size = new System.Drawing.Size(75, 25);
            this.bntEdit.TabIndex = 2;
            this.bntEdit.Text = "Изменить";
            this.bntEdit.UseVisualStyleBackColor = true;
            this.bntEdit.Click += new System.EventHandler(this.bntEdit_Click);
            // 
            // bntDelete
            // 
            this.bntDelete.Location = new System.Drawing.Point(847, 86);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(75, 25);
            this.bntDelete.TabIndex = 3;
            this.bntDelete.Text = "Удалить";
            this.bntDelete.UseVisualStyleBackColor = true;
            this.bntDelete.Click += new System.EventHandler(this.bntDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(635, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Предмет:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(37, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(390, 23);
            this.txtSearch.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(706, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(216, 23);
            this.txtName.TabIndex = 6;
            // 
            // grdSubject
            // 
            this.grdSubject.AllowUserToAddRows = false;
            this.grdSubject.AllowUserToDeleteRows = false;
            this.grdSubject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSubject.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdSubject.Location = new System.Drawing.Point(12, 49);
            this.grdSubject.Name = "grdSubject";
            this.grdSubject.ReadOnly = true;
            this.grdSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSubject.Size = new System.Drawing.Size(545, 425);
            this.grdSubject.TabIndex = 7;
            this.grdSubject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSubject_CellClick);
            this.grdSubject.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSubject_CellClick);
            this.grdSubject.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdSubject_RowHeaderMouseClick);
            // 
            // FormSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 486);
            this.Controls.Add(this.grdSubject);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntDelete);
            this.Controls.Add(this.bntEdit);
            this.Controls.Add(this.bntAdd);
            this.Controls.Add(this.bntSearch);
            this.Name = "FormSubject";
            this.Text = "Управление предметами";
            this.Load += new System.EventHandler(this.FormSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntSearch;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.Button bntEdit;
        private System.Windows.Forms.Button bntDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView grdSubject;
    }
}