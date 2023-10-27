using CRUDDapperDevExpress.Models;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDDapperDevExpress
{
    public partial class MultiRowsSaveForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly StudentRepository _studentRepository = new StudentRepository();
        public MultiRowsSaveForm()
        {
            InitializeComponent();
        }
        void LoadDataToGridView()
        {
            studentBindingSource.DataSource = _studentRepository.GetAll().ToList();
            gridControl.DataSource = studentBindingSource;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }

        private void addNewRowButton_Click(object sender, EventArgs e)
        {
            gridView.AddNewRow();

            // DataRowCount를 갱신시키기 위해서 사용함.
            // 없으면 DataRowCount가 추가된 행을 인식하지 못함.
            // 포커스를 이동해야만 갱신된다.
            gridView.UpdateCurrentRow();
        }

        private void gridView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column == colDelete)
            {
                var student = gridView.GetFocusedRow() as Student;
                var dialogResult = XtraMessageBox.Show($"Are you sure Delete Student {student.FullName}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {                    
                    _studentRepository.Delete(student.StudentID);
                    // 또는
                    //if (int.TryParse(gridView.GetFocusedRowCellValue("StudentID").ToString(), out int Id))
                    //    _studentRepository.Delete(Id);

                    //gridView.DeleteRow(gridView.FocusedRowHandle);
                    gridView.DeleteSelectedRows();

                    listBoxControl.Items.Add($"RowCount: {gridView.RowCount}, DataRowCount: {gridView.DataRowCount}");
                }
            }
        }

        
        private void saveButton_Click(object sender, EventArgs e)
        {
            listBoxControl.Items.Clear();
            listBoxControl.Items.Add($"RowCount: {gridView.RowCount}, DataRowCount: {gridView.DataRowCount}");
            listBoxControl.Items.Add("==== Save ====");

            // DataRowCount를 갱신시키기 위해서 사용함.
            // 없으면 DataRowCount가 추가된 행을 인식하지 못함.
            // 포커스를 이동해야만 갱신된다.
            gridView.UpdateCurrentRow();

            for (int rowIndex = 0; rowIndex < gridView.DataRowCount; rowIndex++)
            {
                if (gridView.GetRow(rowIndex) is Student row)
                {
                    //listBoxControl.Items.Add($"rowIndex: {rowIndex}, Id: {row.StudentID}");

                    var student = new Student()
                    {
                        StudentID = Convert.ToInt32(row.StudentID),
                        FullName = row.FullName,
                        Gender = row.Gender,
                        Age = row.Age,
                        Email = row.Email,
                        Address = row.Address
                    };
                    
                    if (row.StudentID == 0)
                    {
                        _studentRepository.Insert(student);
                        listBoxControl.Items.Add($"Insert - rowIndex: {rowIndex}, Id: {row.FullName}");
                    }
                    else
                    {
                        if (row.Edited) //FocusedRowChanged 에서 셋팅
                        {
                            _studentRepository.Update(student);
                            listBoxControl.Items.Add($"update - rowIndex: {rowIndex}, Id: {row.FullName}");
                        }
                    }
                }
            }
            refreshButton.PerformClick();
        }
        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            gridView.SetRowCellValue(e.FocusedRowHandle, "Edited", true); // unboundcell일 경우는 안먹힘.
        }

        private void stateButton_Click(object sender, EventArgs e)
        {
            listBoxControl.Items.Clear();
            listBoxControl.Items.Add($"RowCount: {gridView.RowCount}, DataRowCount: {gridView.DataRowCount}");
            listBoxControl.Items.Add("==== state ====");


            for (int rowIndex = 0; rowIndex < gridView.DataRowCount; rowIndex++)
            {
                var row = gridView.GetRow(rowIndex) as Student;
                if (row != null)
                    listBoxControl.Items.Add($"rowIndex: {rowIndex}, Id: {row.StudentID}");
            }
        }

        private void setRowCellValueButton_Click(object sender, EventArgs e)
        {
            listBoxControl.Items.Clear();
            listBoxControl.Items.Add("==== Get/Set RowCellValue ====");

            GridColumn idCol = gridView.Columns.ColumnByFieldName("StudentID");
            GridColumn addressCol = gridView.Columns.ColumnByFieldName("Address");

            for (int row = 0; row < gridView.DataRowCount; row++)
            {
                listBoxControl.Items.Add(gridView.GetRowCellValue(row, "StudentID"));


                object cellValue = gridView.GetRowCellValue(row, idCol);
                object newValue = gridView.GetRowCellValue(row, addressCol) + ", Id: " + cellValue;
                gridView.SetRowCellValue(row, addressCol, newValue);
                gridView.SetRowCellValue(row, "Email", "a");
                //gridView.SetRowCellValue(row, "Edited", true); // unboundcell일 경우는 안먹힘.
                //listBoxControl.Items.Add($"rowState: {gridView.GetFocusedDataRow().RowState}");
            }
        }

        private void gridControl_Click(object sender, EventArgs e)
        {

        }

        private void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            //GridView view = sender as GridView;
            //if (view == null) return;
            //if (e.Column.Caption != "FirstName") return;
            //string cellValue = e.Value.ToString() + " " + view.GetRowCellValue(e.RowHandle, view.Columns["LastName"]).ToString();
            //view.SetRowCellValue(e.RowHandle, view.Columns["FullName"], cellValue);

            // 컬럼이 수정된 것이지 상태 셋팅                       
            // 이것이 안 먹혀서 FocusedRowChanged이벤트에서 작업함.
            //gridView.SetRowCellValue(e.RowHandle, "Edited", 1);


            if (e.Column.FieldName == "FullName")
            {
                if (e.Value?.ToString().Length > 0)
                {
                    //int rowHandle = gridView.LocateByValue(e.Column.FieldName, e.Value);
                    var searched = (studentBindingSource.DataSource as List<Student>).Where(x => x.FullName == e.Value.ToString());
                    if (searched.Count() > 1)
                    {
                        XtraMessageBox.Show($"{e.Value.ToString()}은 이미 등록되어 있습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        gridView.SetRowCellValue(e.RowHandle, e.Column.FieldName, gridView.ActiveEditor.OldEditValue);
                    }
                }
            }
        }

        private void gridView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            string leftColumn = "Pages: [Page # of Pages #]";
            string middleColumn = "User: [User Name]";
            string rightColumn = "Date: [Date Printed]";

            var printLink = new PrintableComponentLink(new PrintingSystem());
            printLink.Component = gridView.GridControl;
            var headerFooter = printLink.PageHeaderFooter as PageHeaderFooter;

            headerFooter.Header.Content.Clear();
            headerFooter.Header.Content.AddRange(new string[] { leftColumn, middleColumn, rightColumn });
            //headerFooter.Header.Font = new Font("맑은 고딕", 16, FontStyle.Bold);
            headerFooter.Header.LineAlignment = BrickAlignment.Far;
            
            printLink.Margins.Top = 80;
            printLink.Margins.Bottom = 30;
            printLink.Margins.Left = 35;
            printLink.Margins.Right = 35;
            printLink.Landscape = false;
            printLink.PaperKind = System.Drawing.Printing.PaperKind.A4;

            printLink.ShowPreview();
        }
    }
}