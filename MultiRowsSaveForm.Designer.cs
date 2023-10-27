
namespace CRUDDapperDevExpress
{
    partial class MultiRowsSaveForm
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiRowsSaveForm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.listBoxControl = new DevExpress.XtraEditors.ListBoxControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.deleteButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.addNewRowButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.refreshButton = new DevExpress.XtraEditors.SimpleButton();
            this.stateButton = new DevExpress.XtraEditors.SimpleButton();
            this.setRowCellValueButton = new DevExpress.XtraEditors.SimpleButton();
            this.exportButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.listBoxControl);
            this.layoutControl1.Controls.Add(this.gridControl);
            this.layoutControl1.Controls.Add(this.addNewRowButton);
            this.layoutControl1.Controls.Add(this.saveButton);
            this.layoutControl1.Controls.Add(this.refreshButton);
            this.layoutControl1.Controls.Add(this.stateButton);
            this.layoutControl1.Controls.Add(this.setRowCellValueButton);
            this.layoutControl1.Controls.Add(this.exportButton);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1270, 365, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(977, 628);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // listBoxControl
            // 
            this.listBoxControl.Location = new System.Drawing.Point(12, 511);
            this.listBoxControl.Name = "listBoxControl";
            this.listBoxControl.Size = new System.Drawing.Size(953, 105);
            this.listBoxControl.StyleController = this.layoutControl1;
            this.listBoxControl.TabIndex = 10;
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.studentBindingSource;
            this.gridControl.Location = new System.Drawing.Point(12, 38);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.deleteButton});
            this.gridControl.Size = new System.Drawing.Size(953, 469);
            this.gridControl.TabIndex = 9;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(CRUDDapperDevExpress.Models.Student);
            // 
            // gridView
            // 
            this.gridView.ActiveFilterEnabled = false;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.colDelete,
            this.gridColumn1});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView_RowCellClick);
            this.gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            this.gridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_CellValueChanged);
            this.gridView.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_CellValueChanging);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "StudentID";
            this.gridColumn2.FieldName = "StudentID";
            this.gridColumn2.MinWidth = 23;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 65;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "FullName";
            this.gridColumn3.FieldName = "FullName";
            this.gridColumn3.MinWidth = 23;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 96;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Gender";
            this.gridColumn4.FieldName = "Gender";
            this.gridColumn4.MinWidth = 23;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 53;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Age";
            this.gridColumn5.FieldName = "Age";
            this.gridColumn5.MinWidth = 23;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 31;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "E mail";
            this.gridColumn6.FieldName = "Email";
            this.gridColumn6.MinWidth = 23;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 109;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Address";
            this.gridColumn7.FieldName = "Address";
            this.gridColumn7.MinWidth = 23;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 385;
            // 
            // colDelete
            // 
            this.colDelete.AppearanceCell.Options.UseTextOptions = true;
            this.colDelete.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDelete.AppearanceHeader.Options.UseTextOptions = true;
            this.colDelete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDelete.Caption = "Delete";
            this.colDelete.ColumnEdit = this.deleteButton;
            this.colDelete.MinWidth = 23;
            this.colDelete.Name = "colDelete";
            this.colDelete.OptionsColumn.AllowEdit = false;
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 0;
            this.colDelete.Width = 49;
            // 
            // deleteButton
            // 
            this.deleteButton.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.deleteButton.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Edited";
            this.gridColumn1.FieldName = "Edited";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            // 
            // addNewRowButton
            // 
            this.addNewRowButton.Location = new System.Drawing.Point(121, 12);
            this.addNewRowButton.Name = "addNewRowButton";
            this.addNewRowButton.Size = new System.Drawing.Size(100, 22);
            this.addNewRowButton.StyleController = this.layoutControl1;
            this.addNewRowButton.TabIndex = 5;
            this.addNewRowButton.Text = "행추가";
            this.addNewRowButton.Click += new System.EventHandler(this.addNewRowButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(225, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(99, 22);
            this.saveButton.StyleController = this.layoutControl1;
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "저장";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(12, 12);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(105, 22);
            this.refreshButton.StyleController = this.layoutControl1;
            this.refreshButton.TabIndex = 7;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // stateButton
            // 
            this.stateButton.Location = new System.Drawing.Point(711, 12);
            this.stateButton.Name = "stateButton";
            this.stateButton.Size = new System.Drawing.Size(118, 22);
            this.stateButton.StyleController = this.layoutControl1;
            this.stateButton.TabIndex = 11;
            this.stateButton.Text = "State";
            this.stateButton.Click += new System.EventHandler(this.stateButton_Click);
            // 
            // setRowCellValueButton
            // 
            this.setRowCellValueButton.Location = new System.Drawing.Point(833, 12);
            this.setRowCellValueButton.Name = "setRowCellValueButton";
            this.setRowCellValueButton.Size = new System.Drawing.Size(132, 22);
            this.setRowCellValueButton.StyleController = this.layoutControl1;
            this.setRowCellValueButton.TabIndex = 12;
            this.setRowCellValueButton.Text = "SetRowCellValue";
            this.setRowCellValueButton.Click += new System.EventHandler(this.setRowCellValueButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(328, 12);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(100, 22);
            this.exportButton.StyleController = this.layoutControl1;
            this.exportButton.TabIndex = 13;
            this.exportButton.Text = "내보내기";
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.emptySpaceItem1,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem4,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem8});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(977, 628);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(957, 473);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.listBoxControl;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 499);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(957, 109);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(420, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(279, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.stateButton;
            this.layoutControlItem6.Location = new System.Drawing.Point(699, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(122, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.setRowCellValueButton;
            this.layoutControlItem7.Location = new System.Drawing.Point(821, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(136, 26);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.refreshButton;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(109, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.addNewRowButton;
            this.layoutControlItem1.Location = new System.Drawing.Point(109, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(104, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.saveButton;
            this.layoutControlItem3.Location = new System.Drawing.Point(213, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(103, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.exportButton;
            this.layoutControlItem8.Location = new System.Drawing.Point(316, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(104, 26);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // MultiRowsSaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 628);
            this.Controls.Add(this.layoutControl1);
            this.Name = "MultiRowsSaveForm";
            this.Text = "XtraForm1";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton addNewRowButton;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton refreshButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit deleteButton;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton stateButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton setRowCellValueButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.SimpleButton exportButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}