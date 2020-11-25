using CustomerRefunds.Helpers;
using CustomerRefunds.Models;
using DefenderERP;
using NPOI.XSSF.UserModel;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerRefunds.Workers
{
    public class RefundProcessor : DocumentActionsHelper
    {
        public const string FileTypeCSV = ".csv";
        public const string FileTypeExcel = ".xlsx";

        private string Filename;
        private List<RefundInput> Refunds;

        public async Task DoIt(string filename)
        {
            this.Filename = filename;

            var isGood = this.LoadFile();
            if ( !isGood )
            {
                return;
            }

          //  await this.ProcessRefunds();
        }

        private bool LoadFile()
        {
            Common.AppendStatus("Loading file", true);

            if ( !File.Exists(this.Filename) )
            {
                Common.AppendStatus("File not found: " + this.Filename, true);
                return false;
            }

            var info = new FileInfo(this.Filename);

            if ( info.Extension == RefundProcessor.FileTypeCSV )
            {
                using ( var helper = new CsvHelper.CsvReader(new StreamReader(this.Filename), CultureInfo.InvariantCulture) )
                {
                    this.Refunds = helper.GetRecords<RefundInput>()
                                         .ToList();
                }
            }
            else
            {
                var book = new XSSFWorkbook(this.Filename);
                var sheet = book.GetSheetAt(0);

                this.Refunds = new List<RefundInput>();

                for ( var lp = 1; lp < sheet.PhysicalNumberOfRows; lp++ )
                {
                    var row = sheet.GetRow(lp);
                    var amt = row.GetCell(1).NumericCellValue;
                    var cust = row.GetCell(0).StringCellValue;

                    if ( Util.IsEmpty(cust) || Util.IsEmpty(amt) )
                    {
                        continue;
                    }

                    var refRec = new RefundInput()
                    {
                        Amount = (decimal)amt,
                        CustomerID = cust
                    };

                    this.Refunds.Add(refRec);
                }
            }

            if ( this.Refunds.Any() )
            {
                Common.AppendStatus("Customers loaded: " + this.Refunds.Count, true);
                return true;
            }

            Common.AppendStatus("No Customers loaded", false);
            return false;
        }

        private async Task ProcessRefunds()
        {
            foreach ( var refund in this.Refunds )
            {
                var vouch = await this.DocClient.GetNextPMNumberAsync(Common.CompanyID, this.ClientLogID);

                var payTran = new PayablesTransaction()
                {
                    Distributions = new Distribution[2],
                    VoucherNumber = vouch
                };

                await this.DocClient.PushPayablesTransactionAsync(payTran, this.ClientLogID);
            }
        }
    }
}