using DevExpress.XtraEditors;
using ExcelSQLImportWizard.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace ExcelSQLImportWizard.Models
{
    public sealed class Model
    {
        public UserBaseDbContext db { get; set; }
        public BindingProperty bindingProperty { get; set; }

        private static readonly Model informer = new Model();
        public static Model Informer
        {
            get
            {
                return informer;
            }
        }
        static Model()
        {

        }
        Model()
        {
            try
            {
                db = new UserBaseDbContext();
                bindingProperty = new BindingProperty();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        internal List<IColumnMapping> GetColumnMappings()
        {
            List<IColumnMapping> columnMappings = new List<IColumnMapping>();

            var names = typeof(User).GetProperties()
                        .Select(property => property.Name);
            foreach (var name in names)
            {
                if (!name.Equals("ID") && !name.Equals("CreatedDate") && !name.Equals("UpdatedDate"))
                    columnMappings.Add(new DataColumnMapping("", name));
            }
            return columnMappings;
        }

        internal List<ExcelColumn> GetExcelDataColumns(bool validateColumnName = false)
        {
            List<ExcelColumn> columns = new List<ExcelColumn>();
            if (!validateColumnName)
                columns.Add(new ExcelColumn() { ColumnName = string.Empty });
            foreach (DataColumn column in bindingProperty.ExcelDataTable.Columns)
            {
                columns.Add(new ExcelColumn()
                {
                    ColumnName = column.ColumnName,
                    SampleData = bindingProperty.ExcelDataTable.Rows[0]?[column.ColumnName].ToString()
                });
            }
            return columns;
        }

        internal List<string> GetExcelDataColumnNames()
        {
            List<string> columnnames = new List<string>();
            foreach (DataColumn column in bindingProperty.ExcelDataTable.Columns)
            {
                columnnames.Add(column.ColumnName);
            }
            return columnnames;
        }

        internal void CreateUserObjectsForDB()
        {
            List<User> users = new List<User>();
            foreach (DataRow row in bindingProperty.ExcelDataTable.Rows)
            {
                User user = new User();
                user.ID = Guid.NewGuid();
                foreach (DataColumnMapping columnMapping in bindingProperty.ColumnMappings)
                {
                    if (!string.IsNullOrWhiteSpace(columnMapping.SourceColumn))
                    {
                        switch (columnMapping.DataSetColumn)
                        {
                            case "FirstName":
                                user.FirstName = row[columnMapping.SourceColumn].ToString();
                                break;
                            case "LastName":
                                user.LastName = row[columnMapping.SourceColumn].ToString();
                                break;
                            case "UserName":
                                user.UserName = row[columnMapping.SourceColumn].ToString();
                                break;
                            case "Password":
                                user.Password = row[columnMapping.SourceColumn].ToString();
                                break;
                            case "IsActive":
                                user.IsActive = ParseBoolean(row[columnMapping.SourceColumn]?.ToString());
                                break;
                            case "RequireToChangePassword":
                                user.RequireToChangePassword = ParseBoolean(row[columnMapping.SourceColumn]?.ToString());
                                break;
                            case "Email":
                                user.Email = row[columnMapping.SourceColumn].ToString();
                                break;
                            case "PhoneNumber":
                                user.PhoneNumber = row[columnMapping.SourceColumn].ToString();
                                break;
                        }
                    }
                }
                users.Add(user);
            }
            bindingProperty.Users = users;
        }

        internal void ParseExcelFileForData()
        {
            ExcelFileParser fileParser = new ExcelFileParser();
            fileParser.ParseExcelFileForData();
        }

        internal bool ImportUsersToDB()
        {
            db.Users.AddRange(bindingProperty.Users);
            db.SaveChanges();
            CleanUpBindings();
            return true;
        }

        internal void CleanUpBindings()
        {
            bindingProperty.ExcelFilePath = string.Empty;
            bindingProperty.FirstRowHasHeaders = false;
            bindingProperty.ExcelDataTable = null;
            bindingProperty.ColumnMappings = null;
            bindingProperty.Users = null;
        }

        internal bool? ParseBoolean(string value)
        {
            switch (value.ToLower())
            {
                case "1":
                case "true":
                case "yes":
                    return true;

                case "0":
                case "false":
                case "no":
                    return false;
                default:
                    return null;
            }
        }
    }

    public class ExcelColumn
    {
        public string ColumnName { get; set; }
        public string SampleData { get; set; }
    }
}
