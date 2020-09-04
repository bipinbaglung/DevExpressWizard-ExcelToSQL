namespace ExcelSQLImportWizard
{
    partial class ImportUserForm
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.wizardControlImportUser = new DevExpress.XtraWizard.WizardControl();
            this.wizardPageFileSelection = new DevExpress.XtraWizard.WizardPage();
            this.groupControlFileSelection = new DevExpress.XtraEditors.GroupControl();
            this.checkEditRowHasColumnName = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.buttonEditFileSelection = new DevExpress.XtraEditors.ButtonEdit();
            this.wizardPageColumnMapping = new DevExpress.XtraWizard.WizardPage();
            this.gridControlColumnMapping = new DevExpress.XtraGrid.GridControl();
            this.gridViewColumnMapping = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnDBColumns = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnExcelColumns = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditColumns = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.wizardPageDataPreview = new DevExpress.XtraWizard.WizardPage();
            this.gridControlPreviewData = new DevExpress.XtraGrid.GridControl();
            this.gridViewPreviewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControlImportUser)).BeginInit();
            this.wizardControlImportUser.SuspendLayout();
            this.wizardPageFileSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlFileSelection)).BeginInit();
            this.groupControlFileSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditRowHasColumnName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditFileSelection.Properties)).BeginInit();
            this.wizardPageColumnMapping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlColumnMapping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewColumnMapping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditColumns)).BeginInit();
            this.wizardPageDataPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPreviewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPreviewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wizardControlImportUser
            // 
            this.wizardControlImportUser.Appearance.PageTitle.Options.UseTextOptions = true;
            this.wizardControlImportUser.Appearance.PageTitle.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.wizardControlImportUser.Controls.Add(this.wizardPageFileSelection);
            this.wizardControlImportUser.Controls.Add(this.wizardPageColumnMapping);
            this.wizardControlImportUser.Controls.Add(this.wizardPageDataPreview);
            this.wizardControlImportUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControlImportUser.FinishText = "&Finish >>|";
            this.wizardControlImportUser.Location = new System.Drawing.Point(0, 0);
            this.wizardControlImportUser.Name = "wizardControlImportUser";
            this.wizardControlImportUser.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.wizardPageFileSelection,
            this.wizardPageColumnMapping,
            this.wizardPageDataPreview});
            this.wizardControlImportUser.Size = new System.Drawing.Size(677, 432);
            this.wizardControlImportUser.Text = "";
            this.wizardControlImportUser.SelectedPageChanged += new DevExpress.XtraWizard.WizardPageChangedEventHandler(this.wizardControlImportUser_SelectedPageChanged);
            this.wizardControlImportUser.CancelClick += new System.ComponentModel.CancelEventHandler(this.wizardControlImportUser_CancelClick);
            this.wizardControlImportUser.FinishClick += new System.ComponentModel.CancelEventHandler(this.wizardControlImportUser_FinishClick);
            this.wizardControlImportUser.NextClick += new DevExpress.XtraWizard.WizardCommandButtonClickEventHandler(this.wizardControlImportUser_NextClick);
            this.wizardControlImportUser.CustomizeCommandButtons += new DevExpress.XtraWizard.WizardCustomizeCommandButtonsEventHandler(this.wizardControlImportUser_CustomizeCommandButtons);
            // 
            // wizardPageFileSelection
            // 
            this.wizardPageFileSelection.Controls.Add(this.groupControlFileSelection);
            this.wizardPageFileSelection.DescriptionText = "";
            this.wizardPageFileSelection.Name = "wizardPageFileSelection";
            this.wizardPageFileSelection.Size = new System.Drawing.Size(645, 287);
            this.wizardPageFileSelection.Text = "Select the Excel file to Import";
            // 
            // groupControlFileSelection
            // 
            this.groupControlFileSelection.Controls.Add(this.checkEditRowHasColumnName);
            this.groupControlFileSelection.Controls.Add(this.labelControl4);
            this.groupControlFileSelection.Controls.Add(this.buttonEditFileSelection);
            this.groupControlFileSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlFileSelection.Location = new System.Drawing.Point(0, 0);
            this.groupControlFileSelection.Name = "groupControlFileSelection";
            this.groupControlFileSelection.Size = new System.Drawing.Size(645, 287);
            this.groupControlFileSelection.TabIndex = 2;
            this.groupControlFileSelection.Text = "Excel connection settings";
            // 
            // checkEditRowHasColumnName
            // 
            this.checkEditRowHasColumnName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkEditRowHasColumnName.Location = new System.Drawing.Point(12, 82);
            this.checkEditRowHasColumnName.Name = "checkEditRowHasColumnName";
            this.checkEditRowHasColumnName.Properties.Caption = "First row has column names";
            this.checkEditRowHasColumnName.Size = new System.Drawing.Size(616, 19);
            this.checkEditRowHasColumnName.TabIndex = 2;
            this.checkEditRowHasColumnName.CheckedChanged += new System.EventHandler(this.checkEditRowHasColumnName_CheckedChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 37);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(71, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Excel file path:";
            // 
            // buttonEditFileSelection
            // 
            this.buttonEditFileSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditFileSelection.Location = new System.Drawing.Point(12, 56);
            this.buttonEditFileSelection.Name = "buttonEditFileSelection";
            this.buttonEditFileSelection.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, " Browse...", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.buttonEditFileSelection.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.buttonEditFileSelection.Size = new System.Drawing.Size(616, 20);
            this.buttonEditFileSelection.TabIndex = 0;
            this.buttonEditFileSelection.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEditFileSelection_ButtonClick);
            this.buttonEditFileSelection.EditValueChanged += new System.EventHandler(this.buttonEditFileSelection_EditValueChanged);
            // 
            // wizardPageColumnMapping
            // 
            this.wizardPageColumnMapping.Controls.Add(this.gridControlColumnMapping);
            this.wizardPageColumnMapping.DescriptionText = "";
            this.wizardPageColumnMapping.Name = "wizardPageColumnMapping";
            this.wizardPageColumnMapping.Size = new System.Drawing.Size(645, 287);
            this.wizardPageColumnMapping.Text = "Map Excel Columns to Data Table";
            // 
            // gridControlColumnMapping
            // 
            this.gridControlColumnMapping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlColumnMapping.Location = new System.Drawing.Point(0, 0);
            this.gridControlColumnMapping.MainView = this.gridViewColumnMapping;
            this.gridControlColumnMapping.Name = "gridControlColumnMapping";
            this.gridControlColumnMapping.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditColumns});
            this.gridControlColumnMapping.Size = new System.Drawing.Size(645, 287);
            this.gridControlColumnMapping.TabIndex = 0;
            this.gridControlColumnMapping.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewColumnMapping});
            // 
            // gridViewColumnMapping
            // 
            this.gridViewColumnMapping.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnDBColumns,
            this.gridColumnExcelColumns});
            this.gridViewColumnMapping.GridControl = this.gridControlColumnMapping;
            this.gridViewColumnMapping.Name = "gridViewColumnMapping";
            this.gridViewColumnMapping.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnDBColumns
            // 
            this.gridColumnDBColumns.Caption = "Database Columns";
            this.gridColumnDBColumns.FieldName = "DataSetColumn";
            this.gridColumnDBColumns.Name = "gridColumnDBColumns";
            this.gridColumnDBColumns.OptionsColumn.AllowFocus = false;
            this.gridColumnDBColumns.OptionsColumn.ReadOnly = true;
            this.gridColumnDBColumns.Visible = true;
            this.gridColumnDBColumns.VisibleIndex = 0;
            // 
            // gridColumnExcelColumns
            // 
            this.gridColumnExcelColumns.Caption = "Excel Columns";
            this.gridColumnExcelColumns.ColumnEdit = this.repositoryItemLookUpEditColumns;
            this.gridColumnExcelColumns.FieldName = "SourceColumn";
            this.gridColumnExcelColumns.Name = "gridColumnExcelColumns";
            this.gridColumnExcelColumns.Visible = true;
            this.gridColumnExcelColumns.VisibleIndex = 1;
            // 
            // repositoryItemLookUpEditColumns
            // 
            this.repositoryItemLookUpEditColumns.AutoHeight = false;
            this.repositoryItemLookUpEditColumns.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditColumns.DisplayMember = "ColumnName";
            this.repositoryItemLookUpEditColumns.DropDownRows = 8;
            this.repositoryItemLookUpEditColumns.Name = "repositoryItemLookUpEditColumns";
            this.repositoryItemLookUpEditColumns.ShowFooter = false;
            this.repositoryItemLookUpEditColumns.ValueMember = "ColumnName";
            this.repositoryItemLookUpEditColumns.EditValueChanged += new System.EventHandler(this.repositoryItemLookUpEditColumns_EditValueChanged);
            // 
            // wizardPageDataPreview
            // 
            this.wizardPageDataPreview.Controls.Add(this.gridControlPreviewData);
            this.wizardPageDataPreview.Controls.Add(this.panelControl1);
            this.wizardPageDataPreview.DescriptionText = "";
            this.wizardPageDataPreview.Name = "wizardPageDataPreview";
            this.wizardPageDataPreview.Size = new System.Drawing.Size(645, 287);
            this.wizardPageDataPreview.Text = "Preview Expected Result";
            // 
            // gridControlPreviewData
            // 
            this.gridControlPreviewData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPreviewData.Location = new System.Drawing.Point(0, 0);
            this.gridControlPreviewData.MainView = this.gridViewPreviewData;
            this.gridControlPreviewData.Name = "gridControlPreviewData";
            this.gridControlPreviewData.Size = new System.Drawing.Size(645, 261);
            this.gridControlPreviewData.TabIndex = 0;
            this.gridControlPreviewData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPreviewData});
            // 
            // gridViewPreviewData
            // 
            this.gridViewPreviewData.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewPreviewData.GridControl = this.gridControlPreviewData;
            this.gridViewPreviewData.Name = "gridViewPreviewData";
            this.gridViewPreviewData.OptionsBehavior.Editable = false;
            this.gridViewPreviewData.OptionsBehavior.ReadOnly = true;
            this.gridViewPreviewData.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewPreviewData.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 261);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(645, 26);
            this.panelControl1.TabIndex = 10;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(510, 6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(21, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Click";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(537, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Next";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(569, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "to Import Data";
            // 
            // ImportUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 432);
            this.Controls.Add(this.wizardControlImportUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Import Wizard";
            ((System.ComponentModel.ISupportInitialize)(this.wizardControlImportUser)).EndInit();
            this.wizardControlImportUser.ResumeLayout(false);
            this.wizardPageFileSelection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlFileSelection)).EndInit();
            this.groupControlFileSelection.ResumeLayout(false);
            this.groupControlFileSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditRowHasColumnName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditFileSelection.Properties)).EndInit();
            this.wizardPageColumnMapping.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlColumnMapping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewColumnMapping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditColumns)).EndInit();
            this.wizardPageDataPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPreviewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPreviewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControlImportUser;
        private DevExpress.XtraWizard.WizardPage wizardPageFileSelection;
        private DevExpress.XtraWizard.WizardPage wizardPageColumnMapping;
        private DevExpress.XtraWizard.WizardPage wizardPageDataPreview;
        private DevExpress.XtraGrid.GridControl gridControlColumnMapping;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewColumnMapping;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDBColumns;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnExcelColumns;
        private DevExpress.XtraGrid.GridControl gridControlPreviewData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPreviewData;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditColumns;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControlFileSelection;
        private DevExpress.XtraEditors.CheckEdit checkEditRowHasColumnName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ButtonEdit buttonEditFileSelection;
    }
}