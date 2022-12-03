namespace ForditoprogBead
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.convertedInputText_TB = new System.Windows.Forms.TextBox();
            this.table_DGW = new System.Windows.Forms.DataGridView();
            this.outputWindow = new System.Windows.Forms.RichTextBox();
            this.ok_BT = new System.Windows.Forms.Button();
            this.InputText_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.convert_BT = new System.Windows.Forms.Button();
            this.okStepByStep_BT = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.importTbl_BT = new System.Windows.Forms.Button();
            this.deleteTbl_BT = new System.Windows.Forms.Button();
            this.saveOutput_BT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table_DGW)).BeginInit();
            this.SuspendLayout();
            // 
            // convertedInputText_TB
            // 
            this.convertedInputText_TB.Location = new System.Drawing.Point(321, 460);
            this.convertedInputText_TB.Name = "convertedInputText_TB";
            this.convertedInputText_TB.Size = new System.Drawing.Size(242, 20);
            this.convertedInputText_TB.TabIndex = 0;
            this.convertedInputText_TB.TextChanged += new System.EventHandler(this.convertedInputText_TB_TextChanged);
            // 
            // table_DGW
            // 
            this.table_DGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_DGW.Location = new System.Drawing.Point(13, 13);
            this.table_DGW.Name = "table_DGW";
            this.table_DGW.Size = new System.Drawing.Size(747, 322);
            this.table_DGW.TabIndex = 1;
            // 
            // outputWindow
            // 
            this.outputWindow.Location = new System.Drawing.Point(13, 355);
            this.outputWindow.Name = "outputWindow";
            this.outputWindow.Size = new System.Drawing.Size(302, 198);
            this.outputWindow.TabIndex = 2;
            this.outputWindow.Text = "";
            // 
            // ok_BT
            // 
            this.ok_BT.Location = new System.Drawing.Point(321, 486);
            this.ok_BT.Name = "ok_BT";
            this.ok_BT.Size = new System.Drawing.Size(242, 23);
            this.ok_BT.TabIndex = 3;
            this.ok_BT.Text = "OK";
            this.ok_BT.UseVisualStyleBackColor = true;
            this.ok_BT.Click += new System.EventHandler(this.ok_BT_Click);
            // 
            // InputText_TB
            // 
            this.InputText_TB.Location = new System.Drawing.Point(321, 368);
            this.InputText_TB.Name = "InputText_TB";
            this.InputText_TB.Size = new System.Drawing.Size(242, 20);
            this.InputText_TB.TabIndex = 4;
            this.InputText_TB.TextChanged += new System.EventHandler(this.InputText_TB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(318, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Converted Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(321, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Input";
            // 
            // convert_BT
            // 
            this.convert_BT.Location = new System.Drawing.Point(321, 394);
            this.convert_BT.Name = "convert_BT";
            this.convert_BT.Size = new System.Drawing.Size(242, 23);
            this.convert_BT.TabIndex = 7;
            this.convert_BT.Text = "Convert";
            this.convert_BT.UseVisualStyleBackColor = true;
            this.convert_BT.Click += new System.EventHandler(this.convert_BT_Click);
            // 
            // okStepByStep_BT
            // 
            this.okStepByStep_BT.Location = new System.Drawing.Point(321, 515);
            this.okStepByStep_BT.Name = "okStepByStep_BT";
            this.okStepByStep_BT.Size = new System.Drawing.Size(242, 23);
            this.okStepByStep_BT.TabIndex = 8;
            this.okStepByStep_BT.Text = "OK ( Step By Step )";
            this.okStepByStep_BT.UseVisualStyleBackColor = true;
            this.okStepByStep_BT.Click += new System.EventHandler(this.okStepByStep_BT_Click);
            // 
            // importTbl_BT
            // 
            this.importTbl_BT.Location = new System.Drawing.Point(610, 368);
            this.importTbl_BT.Name = "importTbl_BT";
            this.importTbl_BT.Size = new System.Drawing.Size(111, 23);
            this.importTbl_BT.TabIndex = 9;
            this.importTbl_BT.Text = "Import table";
            this.importTbl_BT.UseVisualStyleBackColor = true;
            this.importTbl_BT.Click += new System.EventHandler(this.importTbl_BT_Click);
            // 
            // deleteTbl_BT
            // 
            this.deleteTbl_BT.Location = new System.Drawing.Point(610, 397);
            this.deleteTbl_BT.Name = "deleteTbl_BT";
            this.deleteTbl_BT.Size = new System.Drawing.Size(111, 23);
            this.deleteTbl_BT.TabIndex = 10;
            this.deleteTbl_BT.Text = "Delete table";
            this.deleteTbl_BT.UseVisualStyleBackColor = true;
            this.deleteTbl_BT.Click += new System.EventHandler(this.deleteTbl_BT_Click);
            // 
            // saveOutput_BT
            // 
            this.saveOutput_BT.Location = new System.Drawing.Point(610, 515);
            this.saveOutput_BT.Name = "saveOutput_BT";
            this.saveOutput_BT.Size = new System.Drawing.Size(111, 23);
            this.saveOutput_BT.TabIndex = 11;
            this.saveOutput_BT.Text = "Save Output (.txt)";
            this.saveOutput_BT.UseVisualStyleBackColor = true;
            this.saveOutput_BT.Click += new System.EventHandler(this.saveOutput_BT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(763, 579);
            this.Controls.Add(this.saveOutput_BT);
            this.Controls.Add(this.deleteTbl_BT);
            this.Controls.Add(this.importTbl_BT);
            this.Controls.Add(this.okStepByStep_BT);
            this.Controls.Add(this.convert_BT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputText_TB);
            this.Controls.Add(this.ok_BT);
            this.Controls.Add(this.outputWindow);
            this.Controls.Add(this.table_DGW);
            this.Controls.Add(this.convertedInputText_TB);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.table_DGW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox convertedInputText_TB;
        private System.Windows.Forms.DataGridView table_DGW;
        private System.Windows.Forms.RichTextBox outputWindow;
        private System.Windows.Forms.Button ok_BT;
        private System.Windows.Forms.TextBox InputText_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button convert_BT;
        private System.Windows.Forms.Button okStepByStep_BT;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button importTbl_BT;
        private System.Windows.Forms.Button deleteTbl_BT;
        private System.Windows.Forms.Button saveOutput_BT;
    }
}

