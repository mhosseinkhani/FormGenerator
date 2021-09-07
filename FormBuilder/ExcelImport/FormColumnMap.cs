using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBuilder.ExcelImport
{
    public partial class FormColumnMap : Form
    {
        public string SelectedColumnTitle { get; set; }
        public int SelectedColumnIndex { get; set; }
        public FormColumnMap(object[] comboColumnList)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.cmbColumns.Items.AddRange(comboColumnList);
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(cmbColumns.SelectedItem==null)
            {
                MessageBox.Show("لطفا ورودی ها را کنترل نمایید");
                return;
            }

            this.SelectedColumnIndex = cmbColumns.SelectedIndex;
            this.SelectedColumnTitle = cmbColumns.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FormColumnMap_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(SelectedColumnTitle))
                this.cmbColumns.SelectedItem = SelectedColumnTitle;
        }
    }
}
