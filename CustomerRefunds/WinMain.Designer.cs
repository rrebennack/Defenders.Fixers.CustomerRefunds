namespace CustomerRefunds
{
    partial class WinMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if ( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.inFile = new System.Windows.Forms.TextBox();
            this.lbFile = new System.Windows.Forms.Label();
            this.dgFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "File:";
            // 
            // inFile
            // 
            this.inFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inFile.Location = new System.Drawing.Point(68, 13);
            this.inFile.Name = "inFile";
            this.inFile.Size = new System.Drawing.Size(277, 23);
            this.inFile.TabIndex = 1;
            // 
            // lbFile
            // 
            this.lbFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFile.AutoSize = true;
            this.lbFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbFile.Font = new System.Drawing.Font("Wingdings 2", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFile.Location = new System.Drawing.Point(351, 9);
            this.lbFile.Name = "lbFile";
            this.lbFile.Size = new System.Drawing.Size(36, 32);
            this.lbFile.TabIndex = 3;
            this.lbFile.Text = ",";
            this.lbFile.Click += new System.EventHandler(this.lbFile_Click);
            // 
            // dgFile
            // 
            this.dgFile.Filter = "Excel (*.xlsx)|*.xlsx|All files(*.*)|*.*";
            this.dgFile.Title = "Customer File";
            // 
            // WinMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 450);
            this.Controls.Add(this.lbFile);
            this.Controls.Add(this.inFile);
            this.Controls.Add(this.label1);
            this.Name = "WinMain";
            this.Text = "Customer Refunds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inFile;
        private System.Windows.Forms.Label lbFile;
        private System.Windows.Forms.OpenFileDialog dgFile;
    }
}

