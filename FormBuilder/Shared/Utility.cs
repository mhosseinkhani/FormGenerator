using System;
using System.Text;
using System.Windows.Forms;

namespace FormBuilder.Shared
{
    public static class Utility
    {
        private static DataGridView CopyDataGridView(DataGridView dgv_org)
        {
            DataGridView dgv_copy = new DataGridView();
            try
            {
                if (dgv_copy.Columns.Count == 0)
                {
                    foreach (DataGridViewColumn dgvc in dgv_org.Columns)
                    {
                        dgv_copy.Columns.Add(dgvc.Clone() as DataGridViewColumn);
                    }
                }

                DataGridViewRow row = new DataGridViewRow();

                for (int i = 0; i < dgv_org.Rows.Count; i++)
                {
                    row = (DataGridViewRow)dgv_org.Rows[i].Clone();
                    int intColIndex = 0;
                    foreach (DataGridViewCell cell in dgv_org.Rows[i].Cells)
                    {
                        row.Cells[intColIndex].Value = cell.Value;
                        intColIndex++;
                    }
                    dgv_copy.Rows.Add(row);
                }
                dgv_copy.AllowUserToAddRows = false;
                dgv_copy.Refresh();

            }
            catch (Exception ex)
            {
            }
            return dgv_copy;
        }
        public static string EncodeBase64(this string text, Encoding encoding = null)
        {
            if (text == null) return null;

            encoding ??= Encoding.UTF8;
            var bytes = encoding.GetBytes(text);
            return Convert.ToBase64String(bytes);
        }

        public static string DecodeBase64(this string encodedText, Encoding encoding = null)
        {
            if (encodedText == null) return null;

            encoding ??= Encoding.UTF8;
            var bytes = Convert.FromBase64String(encodedText);
            return encoding.GetString(bytes);
        }
    }

    public class ApplicationSaveFile
    {
        public string StepOne { get; set; }
        public ListBox.ObjectCollection StepTwo { get; set; }
        public DataGridView StepThree { get; set; }
    }
}