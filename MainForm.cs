﻿using DevExpress.XtraEditors;
using System;
using System.Reflection;

namespace CRUDDapperDevExpress
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static XtraForm CreateFormByName(string formName)
        {
            var namespacePrefix = "CRUDDapperDevExpress.";
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Type formType = myAssembly.GetType(namespacePrefix + formName);
            return formType == null ? throw new ArgumentException("Form type not found") : (XtraForm)Activator.CreateInstance(formType);
        }

        private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string formName = (sender as ListBoxControl).SelectedItem.ToString();
            CreateFormByName(formName).Show();
        }
    }
}