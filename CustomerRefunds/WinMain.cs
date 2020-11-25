using CustomerRefunds.Helpers;
using CustomerRefunds.Workers;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerRefunds
{
    public partial class WinMain : Form
    {
        public WinMain()
        {
            InitializeComponent();

            Common.AppendStatus = new Action<string, bool>(this.AppendResult);
        }

        private void lkTemplate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgSave.FileName = TemplateMaker.TemplateName;

            var retRes = dgSave.ShowDialog();

            if ( retRes != DialogResult.OK )
            {
                return;
            }

            var maker = new TemplateMaker();

            maker.Create(dgSave.FileName);
        }

        private void btFile_Click(object sender, EventArgs e)
        {
            var retRes = this.dgFile.ShowDialog(this);

            if ( retRes == DialogResult.OK )
            {
                inFile.Text = this.dgFile.FileName;
            }
            else
            {
                inFile.Text = string.Empty;
            }
        }

        private async Task btGo_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            this.inResults.Clear();

            Common.AppendStatus("Initializing", false);

            using ( var proc = new RefundProcessor() )
            {
                var retRes = await proc.InitSoap(Environment.UserName);

                if ( retRes.Status != ResultSetStatus.Good )
                {
                    Cursor.Current = Cursors.Default;
                    return;
                }

                Common.AppendStatus("GP Client ID: " + proc.ClientLogID, true);

                await proc.DoIt(inFile.Text);

                Common.AppendStatus("Done", true);
            }

            Cursor.Current = Cursors.Default;
        }

        private void AbleAll(bool enabled)
        {
            this.btFile.Enabled = enabled;
            this.inFile.Enabled = enabled;
            this.lkTemplate.Enabled = enabled;
        }

        private void AppendResult(string message, bool indent = false)
        {
            if ( !indent )
            {
                inResults.AppendText("\r\n");
            }

            inResults.AppendText(string.Format("{0} - {1}{2}\r\n", DateTime.Now.ToString("HH:mm:ss"), (indent ? "\t" : ""), message));

            Application.DoEvents();
        }
    }
}