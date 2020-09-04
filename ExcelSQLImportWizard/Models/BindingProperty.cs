using ExcelSQLImportWizard.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;

namespace ExcelSQLImportWizard.Models
{

    public class BindingProperty : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private bool _allowNext;
        public bool AllowNext
        {
            get { return _allowNext; }
            set
            {
                if (value != _allowNext)
                {
                    _allowNext = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string excelFilePath;
        public string ExcelFilePath {
            get { return excelFilePath; }
            set
            {
                if (value != excelFilePath)
                {
                    excelFilePath = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool _firstRowHasHeaders;
        public bool FirstRowHasHeaders
        {
            get { return _firstRowHasHeaders; }
            set
            {
                if (value != _firstRowHasHeaders)
                {
                    _firstRowHasHeaders = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private DataTable _excelDataTable;
        public DataTable ExcelDataTable {
            get { return _excelDataTable; }
            set
            {
                if (value != _excelDataTable)
                {
                    _excelDataTable = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private List<IColumnMapping> _columnMappings;
        public List<IColumnMapping> ColumnMappings {
            get { return _columnMappings; }
            set
            {
                if (value != _columnMappings)
                {
                    _columnMappings = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private List<User> _users;
        public List<User> Users {
            get { return _users;
            }
            set
            {
                if (value != _users)
                {
                    _users = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
