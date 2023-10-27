using CRUDDapperDevExpress.Models;
using Dapper;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CRUDDapperDevExpress
{
    public partial class GridButtonForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly StudentRepository _studentRepository = new StudentRepository();
        public GridButtonForm()
        {
            InitializeComponent();
        }

        void ClearInput()
        {
            studentIDTextEdit.Text = string.Empty;
            fullNameTextEdit.Text = string.Empty;
            genderComboBoxEdit.EditValue = null;
            ageSpinEdit.EditValue = 0;
            emailTextEdit.Text = string.Empty;
            addressTextEdit.Text = string.Empty;
        }

        void LoadDataToGridView()
        {
            gridControl.DataSource = _studentRepository.GetAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (IDbConnection connection = AppConnection.GetConnection())
            {
                // 작업 => genderComboBoxEdit의 Design View에서 Gender Column 추가, FieldName = Name (대소문자 구분) 
                // select 구분의 필드명을 Gender 클래스와 같이 대소문자 일치 할 것.(FieldName 및 DisplayMember 에서 대소문자 구분)
                //var gender = connection.Query<Gender>(@"select ID, name from gender");
                var gender = connection.Query(@"select ID, Name from gender").AsList();
                //Query()의 결과가 이미 List 개체이므로 ToList()는 불필요하게 복사본을 만든다. AsList()는 단순히 List 객체를 List로 캐스팅한다.
                genderComboBoxEdit.Properties.DataSource = gender;
                genderComboBoxEdit.Properties.ValueMember = "ID";
                genderComboBoxEdit.Properties.DisplayMember = "Name";                
                //Query<Gender>일 경우 Gender.Name의 Name으로 대소문자 구분하며, Query("select ID, Name)일 경우의 대소문자 구분 안함

                LoadDataToGridView();                
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //var studentID = studentIDTextEdit.Text;
            var fullName = fullNameTextEdit.Text;
            var gender = genderComboBoxEdit.EditValue.ToString() == "1";
            var age = Convert.ToInt32(ageSpinEdit.EditValue);
            var email = emailTextEdit.Text;
            var address = addressTextEdit.Text;

            //if (string.IsNullOrEmpty(studentID))
            //{
            //    XtraMessageBox.Show("Enter StudentID", "Information");
            //    studentIDTextEdit.Focus();
            //    return;
            //}

            // check id is exists
            //var isExists = _studentRepository.IsExists(Convert.ToInt32(studentID));
            //if (isExists)
            //{
            //    XtraMessageBox.Show($"StudentId {studentID} is existed!", "Information");
            //    studentIDTextEdit.Focus();
            //    studentIDTextEdit.SelectAll();
            //    return;
            //}

            if (string.IsNullOrEmpty(fullName))
            {
                XtraMessageBox.Show("Enter FullName", "Information");
                fullNameTextEdit.Focus();
                return;
            }
            if (genderComboBoxEdit.EditValue == null)
            {
                genderComboBoxEdit.ShowPopup();
                return;
            }
            if (age < 1)
            {
                XtraMessageBox.Show("Enter Age", "Information");
                ageSpinEdit.Focus();
                return;
            }

            var student = new Student()
            {
                //StudentID = Convert.ToInt32(studentID),
                FullName = fullName,
                Gender = gender,
                Age = age,
                Email = email,
                Address = address
            };


            var result = _studentRepository.Insert(student);
            if (result)
            {
                ClearInput();
                LoadDataToGridView();
            }
            else
            {
                XtraMessageBox.Show("Insert Student Fail!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            var studentID = studentIDTextEdit.Text;
            var fullName = fullNameTextEdit.Text;
            var gender = genderComboBoxEdit.EditValue.ToString() != "1";
            var age = Convert.ToInt32(ageSpinEdit.EditValue);
            var email = emailTextEdit.Text;
            var address = addressTextEdit.Text;

            if (string.IsNullOrEmpty(fullName))
            {
                XtraMessageBox.Show("Enter FullName", "Information");
                fullNameTextEdit.Focus();
                return;
            }
            if (genderComboBoxEdit.EditValue == null)
            {
                genderComboBoxEdit.ShowPopup();
                return;
            }
            if (age < 1)
            {
                XtraMessageBox.Show("Enter Age", "Information");
                ageSpinEdit.Focus();
                return;
            }

            var student = new Student()
            {
                StudentID = Convert.ToInt32(studentID),
                FullName = fullName,
                Gender = gender,
                Age = age,
                Email = email,
                Address = address
            };

            var result = _studentRepository.Update(student);
            if (result)
            {
                ClearInput();
                LoadDataToGridView();
            }
            else
            {
                XtraMessageBox.Show("Update Student Fail!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var gridView = sender as GridView;
            if (gridView.IsDataRow(e.FocusedRowHandle))
            {
                var student = gridView.GetFocusedRow() as Student;
                studentIDTextEdit.EditValue = student.StudentID;
                fullNameTextEdit.EditValue = student.FullName;
                genderComboBoxEdit.EditValue = student.Gender;
                ageSpinEdit.EditValue = student.Age;
                emailTextEdit.EditValue = student.Email;
                addressTextEdit.EditValue = student.Address;
            }
        }

        private void gridView_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            if (e.Column == colDelete)
            {
                var student = gridView.GetFocusedRow() as Student;
                var dialogResult = XtraMessageBox.Show($"Are you sure Delete Student {student.FullName}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    _studentRepository.Delete(student.StudentID);
                    gridView.DeleteSelectedRows();
                }
            }
        }
    }
}
