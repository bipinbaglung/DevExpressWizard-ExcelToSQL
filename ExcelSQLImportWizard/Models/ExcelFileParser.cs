using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Export;
using DevExpress.XtraEditors;
using System;
using System.Data;
namespace ExcelSQLImportWizard.Models
{
    public class ExcelFileParser
    {
        private readonly Models.Model model = Models.Model.Informer;
        
        public void ParseExcelFileForData()
        {
            if (string.IsNullOrWhiteSpace(model.bindingProperty.ExcelFilePath))
            {
                XtraMessageBox.Show("Please provide the file path.", "Excel Parse Error");
                model.bindingProperty.AllowNext = false;
            }
            else
            {
                try
                {
                    using (Workbook workbook = new Workbook())
                    {
                        workbook.LoadDocument(model.bindingProperty.ExcelFilePath);
                        Worksheet worksheet = workbook.Worksheets[0];
                        Range range = worksheet.GetDataRange();
                        DataTable exportDataTable = worksheet.CreateDataTable(range, model.bindingProperty.FirstRowHasHeaders);
                        DataTableExporter exporter = worksheet.CreateDataTableExporter(range, exportDataTable, model.bindingProperty.FirstRowHasHeaders);
                        exporter.Options.DefaultCellValueToColumnTypeConverter.SkipErrorValues = false;
                        exporter.Options.ConvertEmptyCells = true;
                        exporter.Export();

                        model.bindingProperty.ExcelDataTable = exportDataTable;
                        model.bindingProperty.AllowNext = true;
                    }

                    var columnNames = model.GetExcelDataColumnNames();
                    if (columnNames.Contains(string.Empty))
                    {
                        XtraMessageBox.Show("One or more column does not contains column name.", "Excel Parse Error");
                        model.bindingProperty.AllowNext = false;
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Excel Parse Error");
                    model.bindingProperty.AllowNext = false;
                }
            }
        }
    }
}
