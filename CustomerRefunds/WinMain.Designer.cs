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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.inFile = new System.Windows.Forms.TextBox();
            this.dgFile = new System.Windows.Forms.OpenFileDialog();
            this.lkTemplate = new System.Windows.Forms.LinkLabel();
            this.ttMain = new System.Windows.Forms.ToolTip(this.components);
            this.btGo = new System.Windows.Forms.Button();
            this.btFile = new System.Windows.Forms.Button();
            this.dgSave = new System.Windows.Forms.SaveFileDialog();
            this.inResults = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.gbInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File:";
            // 
            // inFile
            // 
            this.inFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inFile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inFile.Location = new System.Drawing.Point(42, 33);
            this.inFile.Name = "inFile";
            this.inFile.Size = new System.Drawing.Size(496, 22);
            this.inFile.TabIndex = 0;
            // 
            // dgFile
            // 
            this.dgFile.Filter = "Excel (*.xlsx)|*.xlsx|CSV (*.csv)|*.csv|All files(*.*)|*.*";
            this.dgFile.Title = "Customer File";
            // 
            // lkTemplate
            // 
            this.lkTemplate.AutoSize = true;
            this.lkTemplate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lkTemplate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lkTemplate.Location = new System.Drawing.Point(42, 18);
            this.lkTemplate.Name = "lkTemplate";
            this.lkTemplate.Size = new System.Drawing.Size(85, 13);
            this.lkTemplate.TabIndex = 5;
            this.lkTemplate.TabStop = true;
            this.lkTemplate.Text = "Open Template";
            this.ttMain.SetToolTip(this.lkTemplate, "Open the Refund template");
            this.lkTemplate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkTemplate_LinkClicked);
            // 
            // btGo
            // 
            this.btGo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGo.Location = new System.Drawing.Point(42, 61);
            this.btGo.Name = "btGo";
            this.btGo.Size = new System.Drawing.Size(89, 23);
            this.btGo.TabIndex = 7;
            this.btGo.Text = "Process File";
            this.ttMain.SetToolTip(this.btGo, "Process the selected file");
            this.btGo.UseVisualStyleBackColor = true;
            this.btGo.Click += async (sender, evt) => await this.btGo_Click(sender, evt);
            // 
            // btFile
            // 
            this.btFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btFile.Location = new System.Drawing.Point(544, 31);
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(50, 23);
            this.btFile.TabIndex = 2;
            this.btFile.Text = "File";
            this.ttMain.SetToolTip(this.btFile, "Select an input file");
            this.btFile.UseVisualStyleBackColor = true;
            this.btFile.Click += new System.EventHandler(this.btFile_Click);
            // 
            // dgSave
            // 
            this.dgSave.FileName = "Excel file (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            this.dgSave.Title = "Save as";
            // 
            // inResults
            // 
            this.inResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inResults.BackColor = System.Drawing.Color.Black;
            this.inResults.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inResults.ForeColor = System.Drawing.Color.Lime;
            this.inResults.Location = new System.Drawing.Point(67, 114);
            this.inResults.Margin = new System.Windows.Forms.Padding(5);
            this.inResults.Multiline = true;
            this.inResults.Name = "inResults";
            this.inResults.ReadOnly = true;
            this.inResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.inResults.Size = new System.Drawing.Size(545, 335);
            this.inResults.TabIndex = 9;
            this.inResults.TabStop = false;
            this.inResults.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Results:";
            // 
            // gbInput
            // 
            this.gbInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInput.Controls.Add(this.btFile);
            this.gbInput.Controls.Add(this.btGo);
            this.gbInput.Controls.Add(this.inFile);
            this.gbInput.Controls.Add(this.label1);
            this.gbInput.Controls.Add(this.lkTemplate);
            this.gbInput.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbInput.Location = new System.Drawing.Point(12, 12);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(600, 94);
            this.gbInput.TabIndex = 8;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "Input";
            // 
            // WinMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 463);
            this.Controls.Add(this.gbInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inResults);
            this.Name = "WinMain";
            this.Text = "Customer Refunds";
            this.gbInput.ResumeLayout(false);
            this.gbInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inFile;
        private System.Windows.Forms.OpenFileDialog dgFile;
        private System.Windows.Forms.ToolTip ttMain;
        private System.Windows.Forms.LinkLabel lkTemplate;
        private System.Windows.Forms.SaveFileDialog dgSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btGo;
        private System.Windows.Forms.GroupBox gbInput;
        private System.Windows.Forms.Button btFile;
    }
}

