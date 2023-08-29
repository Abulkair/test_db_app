using System;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic.FileIO;

namespace AppTestWinForms.Models
{
    public class DataManagement
    {
        private readonly Context.Context _dbContext = new Context.Context();
        private const string Delimiters = ",";

        public void ImportEmployees(string fileName, int companyId)
        {
            using (var tfp = new TextFieldParser(fileName))
            {
                tfp.SetDelimiters(Delimiters);
                while (!tfp.EndOfData)
                    try
                    {
                        var rowData = tfp.ReadFields();
                        var employee = new Employee
                        {
                            firstName = rowData[0],
                            lastName = rowData[1],
                            middleName = rowData[2],
                            iin = rowData[3],
                            companyId = companyId
                        };
                        _dbContext.employees.Add(employee);
                    }
                    catch (Exception e)
                    {
                        //...
                    }
            }

            _dbContext.SaveChanges();
        }

        public void ExportEmployees(string fileName, int companyId)
        {
            var csv = new StringBuilder();
            var employees = from a in _dbContext.employees.ToList()
                where a.companyId == companyId
                select a;

            foreach (var employee in employees) csv.AppendLine(employee.ToString());

            File.WriteAllText(fileName, csv.ToString());
        }

        public void ImportCompanies(string fileName)
        {
            using (var tfp = new TextFieldParser(fileName))
            {
                tfp.SetDelimiters(Delimiters);
                while (!tfp.EndOfData)
                    try
                    {
                        var rowData = tfp.ReadFields();
                        var company = new Company
                        {
                            name = rowData[0], iin = rowData[1], address = rowData[2], description = rowData[3]
                        };
                        _dbContext.companies.Add(company);
                    }
                    catch (Exception e)
                    {
                        //...
                    }
            }

            _dbContext.SaveChanges();
        }
    }
}