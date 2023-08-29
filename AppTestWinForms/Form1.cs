using System;
using System.Linq;
using System.Windows.Forms;
using AppTestWinForms.Models;
using AppTestWinForms.Models.Context;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace AppTestWinForms
{
    public partial class Form1 : Form
    {
        private readonly Context _dbContext;

        public Form1()
        {
            InitializeComponent();
            _dbContext = new Context();
            companyTable.DataSource = _dbContext.companies.ToList();
        }

        private void ImportEmployeesBtn_Click(object sender, EventArgs e)
        {
            var dialog = new CommonOpenFileDialog();
            if (companyTable.CurrentRow != null)
            {
                var company = (Company) companyTable.CurrentRow.DataBoundItem;
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    DataManagement dataManagement = new DataManagement();
                    dataManagement.ImportEmployees(dialog.FileName, company.id);
                    companyTable_CellClick(sender, null);
                }
            }
            else
            {
                MessageBox.Show("Choose or import company first!");
            }
        }

        private void importCompaniesBtn_Click(object sender, EventArgs e)
        {
            var dialog = new CommonOpenFileDialog();
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                DataManagement dataManagement = new DataManagement();
                dataManagement.ImportCompanies(dialog.FileName);
                companyTable.DataSource = _dbContext.companies.ToList();
            }
        }

        private void exportEmployeesBtn_Click(object sender, EventArgs e)
        {
            var dialog = new CommonOpenFileDialog();
            dialog.DefaultExtension = "csv";
            if (companyTable.CurrentRow != null)
            {
                var company = (Company) companyTable.CurrentRow.DataBoundItem;
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    DataManagement dataManagement = new DataManagement();
                    dataManagement.ExportEmployees(dialog.FileName, company.id);
                }
            }
        }

        private void companyTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (companyTable.CurrentRow != null)
            {
                var company = (Company)companyTable.CurrentRow.DataBoundItem;
                var data = from a in _dbContext.employees.ToList()
                           where a.companyId == company.id
                           select a;

                employeeTable.DataSource = data.ToList();
            }
        }
    }
}