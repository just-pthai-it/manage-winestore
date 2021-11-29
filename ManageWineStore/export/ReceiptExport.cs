using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageWineStore.export
{
    class ReceiptExport
    {
        public static void Export(DataTable dataTable, string sheetName, string title, string param)
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
            Microsoft.Office.Interop.Excel.Range partner = oSheet.get_Range("A3", "A3");
            partner.Value2 = param;
            partner.ColumnWidth = 22;
            partner.Font.Size = "10";

            //Địa chỉ người mua
            Microsoft.Office.Interop.Excel.Range address = oSheet.get_Range("A4", "A4");
            address.Value2 = "Địa chỉ:";
            address.Font.Size = "10";

            //Tên NV
            Microsoft.Office.Interop.Excel.Range employee = oSheet.get_Range("A5", "A5");
            employee.Value2 = "Nhân viên lập HĐ:";
            employee.Font.Size = "10";

            //Ngày lập HĐ
            Microsoft.Office.Interop.Excel.Range createAt = oSheet.get_Range("A6", "A6");
            createAt.Value2 = "Thời gian lập HĐ:";
            createAt.Font.Size = "10";

            //Tạo tiêu đề cột
            Microsoft.Office.Interop.Excel.Range c1 = oSheet.get_Range("A7", "A7");
            c1.Value2 = "Tên SP";

            Microsoft.Office.Interop.Excel.Range c2 = oSheet.get_Range("B7", "B7");
            c2.Value2 = "Số lượng";
            c2.ColumnWidth = 9;

            Microsoft.Office.Interop.Excel.Range c3 = oSheet.get_Range("C7", "C7");
            c3.Value2 = "Đơn giá";
            c3.ColumnWidth = 9;

            Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range("D7", "D7");
            c4.Value2 = "Thanh toán";
            c4.ColumnWidth = 17;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A7", "D7");
            rowHead.Font.Bold = true;
            rowHead.Font.Size = "13";

            Microsoft.Office.Interop.Excel.Range partnetNameDetail = oSheet.get_Range("B3", "D3");
            partnetNameDetail.Font.Size = "10";
            partnetNameDetail.MergeCells = true;
            partnetNameDetail.Value2 = dataTable.Rows[0][5];

            Microsoft.Office.Interop.Excel.Range addressDetail = oSheet.get_Range("B4", "D4");
            addressDetail.Font.Size = "10";
            addressDetail.MergeCells = true;
            addressDetail.Value2 = dataTable.Rows[0][6];

            Microsoft.Office.Interop.Excel.Range employeeNameDetail = oSheet.get_Range("B5", "D5");
            employeeNameDetail.Font.Size = "10";
            employeeNameDetail.MergeCells = true;
            employeeNameDetail.Value2 = dataTable.Rows[0][4];

            Microsoft.Office.Interop.Excel.Range createAtDetail = oSheet.get_Range("B6", "D6");
            createAtDetail.Font.Size = "10";
            createAtDetail.MergeCells = true;
            createAtDetail.Value2 = dataTable.Rows[0][7].ToString();
            createAtDetail.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

            //Border
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            rowHead.Interior.ColorIndex = 6;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // tạo mảng theo datatable
            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count - 5];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng
            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];
                for (int col = 0; col < dataTable.Columns.Count - 5; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }

            //Thiết lập vùng điền dữ liệu
            int rowStart = 8;
            int columnStart = 1;
            int rowEnd = rowStart + dataTable.Rows.Count - 1;
            int columnEnd = dataTable.Columns.Count - 5;
            int cellsum = rowStart + dataTable.Rows.Count;

            Microsoft.Office.Interop.Excel.Range sum = oSheet.get_Range($"A{cellsum}", $"A{cellsum}");
            sum.Value2 = "Tổng:";
            sum.Font.Bold = true;
            sum.Font.Size = "13";

            Microsoft.Office.Interop.Excel.Range total = oSheet.get_Range($"D{cellsum}", $"D{cellsum}");
            total.Font.Size = "13";
            total.MergeCells = true;
            total.Value2 = dataTable.Rows[0][8];
            total.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;


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
