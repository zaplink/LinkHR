using System;
using System.Data;
using System.IO;
using OfficeOpenXml;  // Add the EPPlus namespace
using iTextSharp.text;
using iTextSharp.text.pdf;

public class ReportHelper
{
    // This method simulates generating a report, return the sample data.
    public object GenerateReport(string reportType, DateTime fromDate, DateTime toDate)
    {
        var dt = new DataTable();
        dt.Columns.Add("ID");
        dt.Columns.Add("Name");
        dt.Columns.Add("Amount");

        // Sample data for demonstration purposes
        dt.Rows.Add(1, "John Doe", 1000);
        dt.Rows.Add(2, "Jane Smith", 1500);

        return dt;
    }

    // Method to export to Excel using EPPlus
    public void ExportToExcel(DataGridView dgv, string filename)
    {
        using (var package = new ExcelPackage())
        {
            var worksheet = package.Workbook.Worksheets.Add("Report");

            // Write header row
            for (int col = 0; col < dgv.Columns.Count; col++)
            {
                worksheet.Cells[1, col + 1].Value = dgv.Columns[col].HeaderText;
            }

            // Write data rows
            for (int row = 0; row < dgv.Rows.Count; row++)
            {
                for (int col = 0; col < dgv.Columns.Count; col++)
                {
                    worksheet.Cells[row + 2, col + 1].Value = dgv.Rows[row].Cells[col].Value?.ToString();
                }
            }

            // Save the Excel file
            var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), $"{filename}.xlsx");
            FileInfo fi = new FileInfo(filePath);
            package.SaveAs(fi);
        }
    }

    // Method to export to PDF using iTextSharp
    public void ExportToPdf(DataGridView dgv, string filename)
    {
        Document doc = new Document();
        PdfWriter.GetInstance(doc, new FileStream(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), $"{filename}.pdf"), FileMode.Create));

        doc.Open();

        PdfPTable pdfTable = new PdfPTable(dgv.Columns.Count);

        // Add headers
        foreach (DataGridViewColumn column in dgv.Columns)
        {
            pdfTable.AddCell(column.HeaderText);
        }

        // Add data rows
        foreach (DataGridViewRow row in dgv.Rows)
        {
            foreach (DataGridViewCell cell in row.Cells)
            {
                pdfTable.AddCell(cell.Value?.ToString());
            }
        }

        doc.Add(pdfTable);
        doc.Close();
    }
}
