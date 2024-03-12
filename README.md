# CRUDDapperDevExpress

[DEVEXPRESS How to Add, Edit, Delete CRUD SQLSERVER C# Laptrinhvb net](https://youtu.be/JQcE67VhiEY?si=h0RzKq43ol2d2SQt)

## 설명: CRUD Dapper with DevExpress(테이블 클래스, DB연동 클래스, DB Connection 분리)


## About
* C#, WinForm, MSSQL 2022, DevExpress(Report), Dapper, Repository 패턴
* CRUD Dapper with DevExpress(테이블 클래스, DB연동 클래스, DB Connection 분리)

## Environment
* IDE: Visual Studio 2022
* Language: C#
* Applied Project Template: .NET Framework 4.8.1
* NuGet  
    * Dapper
* Third Party Libraries
    * DevExpress 23.2

* DataBase: MS SQL 2022

## 작업
* Gender control은 디자인-> column을 추가하고, EditValue를 name로 설정
* Grid Control을 삭제버튼 표시 방법
    * => 디자인 모드에서 Name = colDelete
    * => Column -> 컬럼선택-> ColumnEdit -> Buttons -> kind= Glyph, TextEditStyle = HideTextEditor
    * => OptionColumns-> AllowEdit = False
* Grid Control의 이벤트는 gridView에서 선택한다. 
    * => row 선택됨 -> gridView1_FocusedRowChanged()
    * => row 클릭 -> gridView1_RowCellClick()
* Grid Control의 gridView의 속성 
    * => Editable = False, ShowGroupPanel = False;
