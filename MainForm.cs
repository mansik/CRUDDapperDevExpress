using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (formType == null)
                throw new ArgumentException("Form type not found");
            return (XtraForm)Activator.CreateInstance(formType);
        }

        private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {            
            string formName = (sender as ListBoxControl).SelectedItem.ToString();
            CreateFormByName(formName).Show();
        }
    }
}