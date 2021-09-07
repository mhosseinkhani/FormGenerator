using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using FormBuilder.ExcelImport;

namespace Gerdoo.Helper.ExcelImport
{
    public partial class ExcelImportForm : Form
    {
        private readonly List<object> _comboColumnList = new List<object>() { "عنوان", "تعداد" };
        private DataSet _extractedExcelData;
        public ExcelImportForm()
        {
            InitializeComponent();
        }
        OpenFileDialog openFileDialog;
        private void panelGrid_Paint(object sender, PaintEventArgs e)
        {
            Graphics v = e.Graphics;
            DrawRoundRect(v, Pens.LightGray, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1, 5);
            base.OnPaint(e);
        }
        public void DrawRoundRect(Graphics g, Pen p, float X, float Y, float width, float height, float radius)
        {
            GraphicsPath gp = new GraphicsPath();
            //Upper-right arc:
            gp.AddArc(X + width - (radius * 2), Y, radius * 2, radius * 2, 270, 90);
            //Lower-right arc:
            gp.AddArc(X + width - (radius * 2), Y + height - (radius * 2), radius * 2, radius * 2, 0, 90);
            //Lower-left arc:
            gp.AddArc(X, Y + height - (radius * 2), radius * 2, radius * 2, 90, 90);
            //Upper-left arc:
            gp.AddArc(X, Y, radius * 2, radius * 2, 180, 90);
            gp.CloseFigure();
            g.DrawPath(p, gp);
            gp.Dispose();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOpenExcelFile_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog()
            {
                AddExtension = true,
                Filter = @"|*.xlsx",
                Title = @"انتخاب فایل اکسل",
                CheckFileExists = true,
                CheckPathExists = true
            };
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            this.loadingControlLoad.Visible = true;
            Application.DoEvents();

            backgroundWorkerLoading.RunWorkerAsync();
        }

        private static DataSet ImportExcel(string filePath)
        {

            var validExtension = new[] { ".xlsx" };
            if (validExtension.All(a => a != new FileInfo(filePath).Extension))
                throw new Exception("فرمت فایل صحیح نمی باشد، فرمت اکسل باید xlsx باشد.‏");
            try
            {

                var workbook = new XLWorkbook(filePath);
                var workBook = workbook.Worksheets;

                return workBook.Count == 0 ? null : CreateDataSet(workBook);
            }
            catch (Exception)
            {
                MessageBox.Show("مشکلی در خواندن فایل بوجود آمده است.");
                return null;
            }
        }

        private static DataSet CreateDataSet(IXLWorksheets workBook)
        {
            var dataSetResult = new DataSet("result");
            foreach (var sheet in workBook)
            {
                var dataTable = new DataTable(sheet.Name);
                var columns = sheet.RangeUsed().ColumnsUsed().Select(a => a.Cell(1).Value.ToString()).ToArray();
                dataTable.Columns.AddRange(columns.Select(a => new DataColumn(a)).ToArray());
                var rows = sheet.RangeUsed().RowsUsed().Skip(1);
                foreach (var row in rows)
                {
                    var rowNumber = row.RowNumber();
                    dataTable.Rows.Add(row.CellsUsed().Select(cell => cell.Value).ToArray());
                }
                dataSetResult.Tables.Add(dataTable);
            }

            return dataSetResult;
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            _extractedExcelData = ImportExcel(openFileDialog.FileName);
            AddExcelSheetNameToComboBoxSheets();
        }

        private void AddExcelSheetNameToComboBoxSheets()
        {
            var addItems = new Action(() =>
            {
                this.comboBoxSheet.Items.Clear();
                if (_extractedExcelData == null) return;
                foreach (var dataTable in _extractedExcelData.Tables)
                {
                    this.comboBoxSheet.Items.Add(((DataTable)dataTable).TableName);
                }
                if (comboBoxSheet.Items.Count > 0)
                    comboBoxSheet.SelectedIndex = 0;
            });
            comboBoxSheet.Invoke(addItems);
            this.btnNextStep.Invoke(new Action(() =>
            {
                this.btnNextStep.Enabled = true;
            }));
        }

        private void ShowExcelSheetData(string selectedItem)
        {
            this.dataGridViewExcel.Invoke(new Action(() =>
            {
                dataGridViewExcel.DataSource = _extractedExcelData.Tables[selectedItem];
                dataGridViewExcel.Refresh();
            }));
        }
        private void ShowExcelSheetColumns(string selectedItem)
        {
            this.dataGridViewExcel.Invoke(new Action(() =>
            {
                var dataTable = _extractedExcelData.Tables[selectedItem];
                if (dataTable != null)
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        dataGridViewExcel.Rows.Add(column.ColumnName);
                    }

                dataGridViewExcel.Refresh();
            }));
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            this.loadingControlLoad.Visible = false;
            this.panelTop.Enabled = this.panelGrid.Enabled = true;

        }

        private void ShowMappingDialog(string selectedItem = null)
        {
            var form = new FormColumnMap(_comboColumnList.ToArray());
            if (!string.IsNullOrWhiteSpace(selectedItem))
                form.SelectedColumnTitle = selectedItem;
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.dataGridViewResult.Rows.Add(this.dataGridViewExcel.SelectedCells[0].Value.ToString(), form.SelectedColumnTitle);

                RemovedMappedColumnFromSource(form);
            }
        }

        private void RemovedMappedColumnFromSource(FormColumnMap form)
        {
            this._comboColumnList.Remove(form.SelectedColumnTitle);
            this.dataGridViewExcel.Rows.RemoveAt(this.dataGridViewExcel.CurrentCell.RowIndex);
        }

        private void comboBoxSheet_SelectedValueChanged(object sender, EventArgs e)
        {
            //   this.ShowExcelSheetData(comboBoxSheet.SelectedItem.ToString());
            this.ShowExcelSheetColumns(comboBoxSheet.SelectedItem.ToString());
        }

        private void dataGridViewExcel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowMappingDialog();
        }

        private void buttonAddToResultGrid_Click(object sender, EventArgs e)
        {
            ShowMappingDialog();
        }

        private void dataGridViewResult_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            RevertMappedColumn();
        }

        private void RevertMappedColumn()
        {
            this.dataGridViewExcel.Rows.Add(this.dataGridViewResult.Rows[this.dataGridViewResult.CurrentCell.RowIndex]
                .Cells[0].Value);
            this._comboColumnList.Add(this.dataGridViewResult.Rows[this.dataGridViewResult.CurrentCell.RowIndex]
                .Cells[1].Value);
            this.dataGridViewResult.Rows.RemoveAt(this.dataGridViewResult.CurrentCell.RowIndex);
        }

        private void btnNextStep_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage2;
        }

        private void ExcelImportForm_Load(object sender, EventArgs e)
        {
            dataGridViewMappedData.Rows.Add("1", "کالا یک", "100", "بدون مشکل", true);
            dataGridViewMappedData.Rows.Add("2", "کالا یک", "251", "بدون مشکل", false);
            dataGridViewMappedData.Rows.Add("3", "کالا یک", "200", "بدون مشکل", false);
            dataGridViewMappedData.Rows.Add("4", "کالا یک", "300", "بدون مشکل", true);
            dataGridViewMappedData.Rows.Add("5", "کالا یک", "400", "بدون مشکل", true);
            foreach (DataGridViewRow row in dataGridViewMappedData.Rows)
                if (Convert.ToBoolean(row.Cells["HaveError"].Value))
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
        }
    }
}
