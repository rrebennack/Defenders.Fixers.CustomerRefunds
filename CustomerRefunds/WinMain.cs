using System;
using System.Windows.Forms;

namespace CustomerRefunds
{
    public partial class WinMain : Form
    {
        public WinMain()
        {
            InitializeComponent();
        }

        private void lbFile_Click(object sender, EventArgs e)
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
    }
}