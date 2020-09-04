using DevExpress.XtraEditors;
using DevExpress.XtraWizard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ExcelSQLImportWizard
{
    public partial class ImportUserForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly Models.Model model = Models.Model.Informer;

        private bool pathReloaded;
        private bool mappingChanged;
        private bool importSuccessful;

        private WizardButton finishButton;

        public ImportUserForm()
        {
            InitializeComponent();
            model.bindingProperty.PropertyChanged += BindingProperty_PropertyChanged;
        }

        private void BindingProperty_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "FirstRowHasHeaders":
                case "ExcelFilePath":
                    pathReloaded = true;
                    importSuccessful = false;
                    break;
                case "ColumnMappings":
                    mappingChanged = true;
                    break;
            }
        }

        private void wizardControlImportUser_CustomizeCommandButtons(object sender, DevExpress.XtraWizard.CustomizeCommandButtonsEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(e.Page.Name))
            {
                e.FinishButton.Visible = true;
                e.FinishButton.Location = new Point(e.CancelButton.Location.X - (e.FinishButton.Size.Width + 5), e.FinishButton.Location.Y);
                e.FinishButton.Button.Enabled = importSuccessful;
                finishButton = e.FinishButton.Button;
                e.NextButton.Location = new Point(e.FinishButton.Location.X - (e.NextButton.Size.Width + 5), e.NextButton.Location.Y);
                e.PrevButton.Location = new Point(e.NextButton.Location.X - (e.PrevButton.Size.Width + 5), e.PrevButton.Location.Y);
                if (e.Page == wizardPageDataPreview)
                {
                    e.NextButton.Visible = true;
                    e.NextButton.Button.Enabled = true;
                }
                e.NextButton.Button.Focus();
            }
        }

        private void wizardControlImportUser_CancelClick(object sender, CancelEventArgs e)
        {
            if (DialogResult.Yes == XtraMessageBox.Show("Are you sure to cancel the user import process.", "User Import Wizard", MessageBoxButtons.YesNo))
            {
                this.Close();
            }
        }

        private void wizardControlImportUser_NextClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
        {
            if (e.Page == wizardPageFileSelection)
            {
                if (pathReloaded)
                {
                    model.ParseExcelFileForData();
                    if (model.bindingProperty.AllowNext)
                    {
                        repositoryItemLookUpEditColumns.DataSource = model.GetExcelDataColumns();
                        model.bindingProperty.ColumnMappings = model.GetColumnMappings();
                        pathReloaded = false;
                    }
                    else e.Handled = true;
                }
            }
            else if (e.Page == wizardPageColumnMapping)
            {
                model.bindingProperty.ColumnMappings = gridControlColumnMapping.DataSource as List<IColumnMapping>;
            }
            else if (e.Page == wizardPageDataPreview)
            {
                try
                {
                    importSuccessful = model.ImportUsersToDB();
                    if (importSuccessful)
                    {
                        XtraMessageBox.Show("Users successfuly imported to database.", "User Import Wizard");
                        wizardControlImportUser.SelectedPage = wizardPageFileSelection;
                        e.Handled = true;
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "User Import Failed");
                }
            }
        }

        private void wizardControlImportUser_SelectedPageChanged(object sender, WizardPageChangedEventArgs e)
        {
            if (e.Page == wizardPageFileSelection)
            {
                buttonEditFileSelection.Text = model.bindingProperty.ExcelFilePath;
                checkEditRowHasColumnName.Checked = model.bindingProperty.FirstRowHasHeaders;
            }
            else if (e.Page == wizardPageColumnMapping)
            {
                gridControlColumnMapping.DataSource = model.bindingProperty.ColumnMappings;
            }
            else if (e.Page == wizardPageDataPreview)
            {
                if (mappingChanged)
                {
                    model.CreateUserObjectsForDB();
                    gridControlPreviewData.DataSource = model.bindingProperty.Users;
                    gridControlPreviewData.Refresh();
                    mappingChanged = false;
                }
            }
        }

        private void buttonEditFileSelection_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Excel Files|*.xls;*.xlsx;";
            if (fileDialog.ShowDialog() != DialogResult.Cancel)
            {
                buttonEditFileSelection.Text = fileDialog.FileName;
            }
        }

        private void repositoryItemLookUpEditColumns_EditValueChanged(object sender, EventArgs e)
        {
            mappingChanged = true;
        }

        private void checkEditRowHasColumnName_CheckedChanged(object sender, EventArgs e)
        {
            model.bindingProperty.FirstRowHasHeaders = checkEditRowHasColumnName.Checked;
            finishButton.Enabled = importSuccessful;
        }

        private void buttonEditFileSelection_EditValueChanged(object sender, EventArgs e)
        {
            model.bindingProperty.ExcelFilePath = buttonEditFileSelection.Text;
            finishButton.Enabled = importSuccessful;
        }

        private void wizardControlImportUser_FinishClick(object sender, CancelEventArgs e)
        {
            this.Close();
        }
    }
}