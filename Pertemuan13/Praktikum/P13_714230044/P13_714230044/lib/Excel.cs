using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_714230044.lib
{
    internal class Excel
    {
        public void ExportToExcel(DataGridView dataGridView, string searchData)
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet =
               excelPackage.Workbook.Worksheets.Add("Sheet1");
                // Export Headers
                for (int j = 1; j <= dataGridView.ColumnCount; j++)
                {
                    if (dataGridView.Columns[j - 1].HeaderText != null)
                    {
                        worksheet.Cells[1, j].Value = dataGridView.Columns[j -
                       1].HeaderText;
                    }
                }
                // Export Data
                for (int i = 0; i < dataGridView.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView.Rows[i].Cells.Count; j++)
                    {
                        string cellValue = (dataGridView.Rows[i].Cells[j].Value != null ? dataGridView.Rows[i].Cells[j].Value.ToString() : "");
                        worksheet.Cells[i + 2, j + 1].Value = cellValue;
                    }
                }
                FileInfo excelFile = new FileInfo(searchData);
                excelPackage.SaveAs(excelFile);
            }
        }
    }
}
