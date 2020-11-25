using NPOI.XSSF.UserModel;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace CustomerRefunds.Helpers
{
    public class TemplateMaker
    {
        public const string TemplateName = "CustomerRefund.xlsx";
        public const string TemplateSheet = "Refunds";

        public void Create(string filename)
        {
            var name = Path.Combine(Path.GetTempPath(), TemplateMaker.TemplateName);

            if ( File.Exists(name) )
            {
                try
                {
                    File.Copy(name, filename, true);
                    this.OpenFile(filename);
                }
                catch ( Exception doh )
                {
                    this.WriteError(doh);
                }
                
                return;
            }

            var xWork = new XSSFWorkbook();
            var xSheet = xWork.CreateSheet(TemplateMaker.TemplateSheet);

            var rowOne = xSheet.CreateRow(0);
            var cellAmt = rowOne.CreateCell(1);
            var cellCust = rowOne.CreateCell(0);

            cellAmt.SetCellValue("Amount");
            cellCust.SetCellValue("Customer ID");

            try
            {
                using ( var smWrite = new FileStream(name, FileMode.Create) )
                {
                    xWork.Write(smWrite);
                }

                File.Copy(name, filename);
                this.OpenFile(filename);
            }
            catch ( Exception gotsError )
            {
                this.WriteError(gotsError);
            }
        }

        private void OpenFile(string filename)
        {
            var proc = new Process();

            proc.StartInfo = new ProcessStartInfo(filename)
            {
                UseShellExecute = true
            };

            proc.Start();
        }

        private void WriteError(Exception except)
        {
            File.WriteAllText(Path.GetTempFileName(), except.StackTrace);

            MessageBox.Show(except.Message);
        }
    }
}