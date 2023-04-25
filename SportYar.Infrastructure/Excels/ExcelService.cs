using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportYar.Infrastructure.Excels
{
    public static class ExcelService
    {
        public static void TrimLastEmptyRows(this ExcelWorksheet worksheet)
        {
            while (worksheet.IsLastRowEmpty())
                worksheet.DeleteRow(worksheet.Dimension.End.Row);
        }
        public static bool IsLastRowEmpty(this ExcelWorksheet worksheet)
        {
            var empties = new List<bool>();

            for (int i = 1; i <= worksheet.Dimension.End.Column; i++)
            {
                var rowEmpty = worksheet.Cells[worksheet.Dimension.End.Row, i].Value == null ? true : false;
                empties.Add(rowEmpty);
            }

            return empties.All(e => e);
        }
    }
}
