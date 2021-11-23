using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageWineStore.export
{
    class SaleReceiptExport
    {
        public static void SaleExport(DataTable dataTable, string sheetName, string title)
        {
            // Tạo các đối tượng Excel
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            // Tạo mới một Excel WorkBook

            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            //Tạo phần tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "D2");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = "20";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //Người mua
            Microsoft.Office.Interop.Excel.Range customer = oSheet.get_Range("A3", "A3");
            customer.Value2 = "Họ tên khách hàng";
            customer.ColumnWidth = 22;
            customer.Font.Size = "10";

            //Địa chỉ người mua
            Microsoft.Office.Interop.Excel.Range address = oSheet.get_Range("A4", "A4");
            address.Value2 = "Địa chỉ";
            address.Font.Size = "10";

            //Tạo tiêu đề cột
            Microsoft.Office.Interop.Excel.Range c1 = oSheet.get_Range("A5", "A5");
            c1.Value2 = "Tên hàng";
            
            Microsoft.Office.Interop.Excel.Range c2 = oSheet.get_Range("B5", "B5");
            c2.Value2 = "Số lượng";
            c2.ColumnWidth = 9;

            Microsoft.Office.Interop.Excel.Range c3 = oSheet.get_Range("C5", "C5");
            c3.Value2 = "Đơn giá";
            c3.ColumnWidth = 9;

            Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range("D5", "D5");
            c4.Value2 = "Thanh toán";
            c4.ColumnWidth = 17;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A5", "D5");
            rowHead.Font.Bold = true;
            rowHead.Font.Size = "13";

            Microsoft.Office.Interop.Excel.Range nameDetail = oSheet.get_Range("B3", "D3");
            nameDetail.Font.Size = "10";
            nameDetail.MergeCells = true;
            nameDetail.Value2 = "Tiến Đạt";

            Microsoft.Office.Interop.Excel.Range addressDetail = oSheet.get_Range("B4", "D4");
            addressDetail.Font.Size = "10";
            addressDetail.MergeCells = true;
            addressDetail.Value2 = "huyện Đông Anh";

            //Border
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            rowHead.Interior.ColorIndex = 6;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // tạo mảng theo datatable
            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng
            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];
                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }

            //int i = 0;
            //foreach (DataRow datarow in dataTable.Rows)
            //{
            //    int j = 0;
            //    foreach (DataColumn dc in dataTable.Columns)
            //    {
            //        arr[i, j] = datarow[dc];
            //        MessageBox.Show(datarow[dc].ToString());
            //        j++;
            //    }
            //    i++;
            //}

            //Thiết lập vùng điền dữ liệu
            int rowStart = 6;
            int columnStart = 1;
            int rowEnd = rowStart + dataTable.Rows.Count - 1;
            int columnEnd = dataTable.Columns.Count;
            int cellsum = rowStart + dataTable.Rows.Count;

            Microsoft.Office.Interop.Excel.Range sum = oSheet.get_Range($"A{cellsum}", $"A{cellsum}");
            sum.Value2 = "Tổng";
            sum.Font.Bold = true;
            sum.Font.Size = "13";

            Microsoft.Office.Interop.Excel.Range total = oSheet.get_Range($"B{cellsum}", $"D{cellsum}");
            total.Font.Size = "13";
            total.MergeCells = true;
            total.Value2 = "10";

            // Ô bắt đầu điền dữ liệu
            Microsoft.Office.Interop.Excel.Range col1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc dữ liệu
            Microsoft.Office.Interop.Excel.Range col2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(col1, col2);

            // Điền dữ liệu vào vùng đã thiết lập
            range.Value2 = arr;

            // kẻ viền
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // căn giữa cả hàng
            range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }
    }
}
