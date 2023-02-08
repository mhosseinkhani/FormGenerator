using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormBuilder.Shared;

namespace FormBuilder
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }



        private void buttonStepOne_Click(object sender, EventArgs e)
        {
            listBoxItems.Items.Clear();
            var stepOne = txtBoxInput.Text
                 .Replace(",", ";")
                 .Replace("\"", "")
                 .Replace("'", "")
                 .Replace(Environment.NewLine,"")
                 .Split(";").ToArray();
            listBoxItems.Items.AddRange(stepOne);

        }


        private void buttonStepTwo_Click(object sender, EventArgs e)
        {
            var selectedItems = listBoxItems.Items;
            dataGridViewControls.Rows.Clear();
            var row = 1;
            const int col = 4;
            var colCount = 1;
            var i = 1;
            foreach (var item in selectedItems)
            {
                if (string.IsNullOrEmpty(item.ToString())) continue;

                var value = new string[] { 
                    (i++).ToString(),
                    item.ToString()?.Split(":")[0].Replace("\r\n", "").Trim(' '),
                    item.ToString()?.Split(":")[0].Replace("\r\n", "").Trim(' '), 
                    item.ToString()?.Split(":")[1].Replace("\r\n", "").Trim(' ').GetControlType().ToString(), 
                    col.ToString(), 
                    row.ToString(),
                    false.ToString(),
                };
                dataGridViewControls.Rows.Add(value);
                if (colCount >= 12 / col)
                {
                    row++;
                    colCount = 0;
                }

                colCount++;
            }
            dataGridViewControls.Refresh();
        }

        private void btnCommand_Click(object sender, EventArgs e)
        {
            textBoxOutPutForm.Text = "";
            var formControls = new List<FormControlsMaker.FormControl>();

            foreach (DataGridViewRow row in dataGridViewControls.Rows)
            {
                if (row.Cells[0].Value == null) continue;

                Enum.TryParse(row.Cells["type"].Value.ToString(), out ControlType myStatus);
                var formControl = new FormControlsMaker.FormControl
                {
                    Order =Convert.ToInt32( row.Cells["order"].Value),
                    Type = myStatus,
                    Title = row.Cells["title"].Value.ToString(),
                    Col = Convert.ToByte(row.Cells["cssCol"].Value),
                    Name = row.Cells["name"].Value.ToString(),
                    Row = Convert.ToByte(row.Cells["inRow"].Value),
                    HavePlaceHolder = Convert.ToBoolean(row.Cells["placeHolder"].Value)
                };
                formControls.Add(formControl);
            }

            txtBoxOutPutUi.Text = "";
            formControls.OrderBy(a=>a.Order).GroupBy(a => a.Row).ToList().ForEach(p =>
              {
                  txtBoxOutPutUi.Text += @"<div class=""form-group row"">";
                  txtBoxOutPutUi.Text += string.Join(System.Environment.NewLine, FormControlsMaker.MakeControls(p.ToArray()));
                  txtBoxOutPutUi.Text += @"</div>";
                  txtBoxOutPutUi.Text += System.Environment.NewLine;
              });


            var resultForm = new List<string>();
            formControls.ForEach(p =>
            {
                var item =
                    $"{p.Name}:[this.model.{p.Name}]";
                resultForm.Add(item);
            });
            textBoxOutPutForm.Text = string.Join("," + System.Environment.NewLine, resultForm);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var applicationSaveFile = new ApplicationSaveFile
            {
                StepOne = txtBoxInput.Text,
                StepTwo = listBoxItems.Items,
                StepThree = dataGridViewControls
            };

            var serialize = JsonSerializer.Serialize(applicationSaveFile);
            var base64 = serialize.EncodeBase64();
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = @"ذخیره فایل کانفیگ",
                Filter = @"|*.afg",
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, base64);
            }

            MessageBox.Show("Done! Saved On " + saveFileDialog.FileName);
        }
    }
}
