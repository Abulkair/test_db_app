namespace AppTestWinForms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyTable = new System.Windows.Forms.DataGridView();
            this.employeeTable = new System.Windows.Forms.DataGridView();
            this.importEmployeesBtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog4 = new System.Windows.Forms.OpenFileDialog();
            this.importCompaniesBtn = new System.Windows.Forms.Button();
            this.exportEmployeesBtn = new System.Windows.Forms.Button();
            this.companyLbl = new System.Windows.Forms.Label();
            this.employeesLbl = new System.Windows.Forms.Label();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // companyTable
            // 
            this.companyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companyTable.Location = new System.Drawing.Point(12, 151);
            this.companyTable.Name = "companyTable";
            this.companyTable.RowHeadersWidth = 62;
            this.companyTable.RowTemplate.Height = 28;
            this.companyTable.Size = new System.Drawing.Size(1051, 579);
            this.companyTable.TabIndex = 3;
            this.companyTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.companyTable_CellClick);
            // 
            // employeeTable
            // 
            this.employeeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeTable.Location = new System.Drawing.Point(1069, 151);
            this.employeeTable.Name = "employeeTable";
            this.employeeTable.RowHeadersWidth = 62;
            this.employeeTable.RowTemplate.Height = 28;
            this.employeeTable.Size = new System.Drawing.Size(1002, 579);
            this.employeeTable.TabIndex = 4;
            // 
            // importEmployeesBtn
            // 
            this.importEmployeesBtn.Location = new System.Drawing.Point(1069, 12);
            this.importEmployeesBtn.Name = "importEmployeesBtn";
            this.importEmployeesBtn.Size = new System.Drawing.Size(191, 72);
            this.importEmployeesBtn.TabIndex = 6;
            this.importEmployeesBtn.Text = "Import employees";
            this.importEmployeesBtn.UseVisualStyleBackColor = true;
            this.importEmployeesBtn.Click += new System.EventHandler(this.ImportEmployeesBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "filedialog";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // openFileDialog4
            // 
            this.openFileDialog4.FileName = "openFileDialog4";
            // 
            // importCompaniesBtn
            // 
            this.importCompaniesBtn.Location = new System.Drawing.Point(12, 12);
            this.importCompaniesBtn.Name = "importCompaniesBtn";
            this.importCompaniesBtn.Size = new System.Drawing.Size(191, 72);
            this.importCompaniesBtn.TabIndex = 7;
            this.importCompaniesBtn.Text = "Import companies";
            this.importCompaniesBtn.UseVisualStyleBackColor = true;
            this.importCompaniesBtn.Click += new System.EventHandler(this.importCompaniesBtn_Click);
            // 
            // exportEmployeesBtn
            // 
            this.exportEmployeesBtn.Location = new System.Drawing.Point(1266, 12);
            this.exportEmployeesBtn.Name = "exportEmployeesBtn";
            this.exportEmployeesBtn.Size = new System.Drawing.Size(191, 72);
            this.exportEmployeesBtn.TabIndex = 8;
            this.exportEmployeesBtn.Text = "Export employees";
            this.exportEmployeesBtn.UseVisualStyleBackColor = true;
            this.exportEmployeesBtn.Click += new System.EventHandler(this.exportEmployeesBtn_Click);
            // 
            // companyLbl
            // 
            this.companyLbl.AutoSize = true;
            this.companyLbl.Location = new System.Drawing.Point(12, 108);
            this.companyLbl.Name = "companyLbl";
            this.companyLbl.Size = new System.Drawing.Size(89, 20);
            this.companyLbl.TabIndex = 9;
            this.companyLbl.Text = "Companies";
            // 
            // employeesLbl
            // 
            this.employeesLbl.AutoSize = true;
            this.employeesLbl.Location = new System.Drawing.Point(1065, 108);
            this.employeesLbl.Name = "employeesLbl";
            this.employeesLbl.Size = new System.Drawing.Size(87, 20);
            this.employeesLbl.TabIndex = 10;
            this.employeesLbl.Text = "Employees";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataSource = typeof(AppTestWinForms.Models.Employee);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2083, 743);
            this.Controls.Add(this.employeesLbl);
            this.Controls.Add(this.companyLbl);
            this.Controls.Add(this.exportEmployeesBtn);
            this.Controls.Add(this.importCompaniesBtn);
            this.Controls.Add(this.importEmployeesBtn);
            this.Controls.Add(this.employeeTable);
            this.Controls.Add(this.companyTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private System.Windows.Forms.DataGridView companyTable;
        private System.Windows.Forms.DataGridView employeeTable;
        private System.Windows.Forms.Button importEmployeesBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog4;
        private System.Windows.Forms.Button exportEmployeesBtn;
        private System.Windows.Forms.Button importCompaniesBtn;
        private System.Windows.Forms.Label employeesLbl;
        private System.Windows.Forms.Label companyLbl;
    }
}

