namespace DummyDataGenerator
{
    partial class MainForm
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
            this.chkJsonModels = new System.Windows.Forms.CheckedListBox();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabSQLExport = new System.Windows.Forms.TabPage();
            this.radioINT = new System.Windows.Forms.RadioButton();
            this.radioGUID = new System.Windows.Forms.RadioButton();
            this.chkIncludeKey = new System.Windows.Forms.CheckBox();
            this.chkIncludeInsert = new System.Windows.Forms.CheckBox();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabJSON = new System.Windows.Forms.TabPage();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.lblAmount = new System.Windows.Forms.Label();
            this.grpBox.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabSQLExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // chkJsonModels
            // 
            this.chkJsonModels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkJsonModels.FormattingEnabled = true;
            this.chkJsonModels.Location = new System.Drawing.Point(12, 31);
            this.chkJsonModels.Name = "chkJsonModels";
            this.chkJsonModels.Size = new System.Drawing.Size(989, 139);
            this.chkJsonModels.TabIndex = 0;
            // 
            // grpBox
            // 
            this.grpBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBox.Controls.Add(this.btnGenerate);
            this.grpBox.Controls.Add(this.tabControl);
            this.grpBox.Controls.Add(this.numAmount);
            this.grpBox.Controls.Add(this.lblAmount);
            this.grpBox.Location = new System.Drawing.Point(13, 177);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(988, 322);
            this.grpBox.TabIndex = 1;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Dummy Data Options";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(14, 284);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(964, 32);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabSQLExport);
            this.tabControl.Controls.Add(this.tabJSON);
            this.tabControl.Location = new System.Drawing.Point(10, 71);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(972, 206);
            this.tabControl.TabIndex = 3;
            // 
            // tabSQLExport
            // 
            this.tabSQLExport.Controls.Add(this.radioINT);
            this.tabSQLExport.Controls.Add(this.radioGUID);
            this.tabSQLExport.Controls.Add(this.chkIncludeKey);
            this.tabSQLExport.Controls.Add(this.chkIncludeInsert);
            this.tabSQLExport.Controls.Add(this.txtTableName);
            this.tabSQLExport.Controls.Add(this.label1);
            this.tabSQLExport.Location = new System.Drawing.Point(4, 22);
            this.tabSQLExport.Name = "tabSQLExport";
            this.tabSQLExport.Padding = new System.Windows.Forms.Padding(3);
            this.tabSQLExport.Size = new System.Drawing.Size(964, 180);
            this.tabSQLExport.TabIndex = global::DummyDataGenerator.Properties.Settings.Default.SQLScript;
            this.tabSQLExport.Text = "SQL Export";
            this.tabSQLExport.UseVisualStyleBackColor = true;
            // 
            // radioINT
            // 
            this.radioINT.AutoSize = true;
            this.radioINT.Location = new System.Drawing.Point(101, 78);
            this.radioINT.Name = "radioINT";
            this.radioINT.Size = new System.Drawing.Size(43, 17);
            this.radioINT.TabIndex = 5;
            this.radioINT.TabStop = true;
            this.radioINT.Text = "INT";
            this.radioINT.UseVisualStyleBackColor = true;
            // 
            // radioGUID
            // 
            this.radioGUID.AutoSize = true;
            this.radioGUID.Location = new System.Drawing.Point(10, 78);
            this.radioGUID.Name = "radioGUID";
            this.radioGUID.Size = new System.Drawing.Size(52, 17);
            this.radioGUID.TabIndex = 4;
            this.radioGUID.Text = "GUID";
            this.radioGUID.UseVisualStyleBackColor = true;
            // 
            // chkIncludeKey
            // 
            this.chkIncludeKey.AutoSize = true;
            this.chkIncludeKey.Location = new System.Drawing.Point(10, 54);
            this.chkIncludeKey.Name = "chkIncludeKey";
            this.chkIncludeKey.Size = new System.Drawing.Size(97, 17);
            this.chkIncludeKey.TabIndex = 3;
            this.chkIncludeKey.Text = "INCLUDE KEY";
            this.chkIncludeKey.UseVisualStyleBackColor = true;
            this.chkIncludeKey.CheckedChanged += new System.EventHandler(this.chkIncludeKey_CheckedChanged);
            // 
            // chkIncludeInsert
            // 
            this.chkIncludeInsert.AutoSize = true;
            this.chkIncludeInsert.Location = new System.Drawing.Point(10, 30);
            this.chkIncludeInsert.Name = "chkIncludeInsert";
            this.chkIncludeInsert.Size = new System.Drawing.Size(219, 17);
            this.chkIncludeInsert.TabIndex = 2;
            this.chkIncludeInsert.Text = "Include DROP CREATE TABLE QUERY";
            this.chkIncludeInsert.UseVisualStyleBackColor = true;
            // 
            // txtTableName
            // 
            this.txtTableName.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtTableName.Location = new System.Drawing.Point(78, 4);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(151, 20);
            this.txtTableName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table Name";
            // 
            // tabJSON
            // 
            this.tabJSON.Location = new System.Drawing.Point(4, 22);
            this.tabJSON.Name = "tabJSON";
            this.tabJSON.Padding = new System.Windows.Forms.Padding(3);
            this.tabJSON.Size = new System.Drawing.Size(964, 180);
            this.tabJSON.TabIndex = 1;
            this.tabJSON.Text = "JSON Export";
            this.tabJSON.UseVisualStyleBackColor = true;
            // 
            // numAmount
            // 
            this.numAmount.Location = new System.Drawing.Point(82, 27);
            this.numAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(110, 20);
            this.numAmount.TabIndex = 2;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(7, 29);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(69, 13);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Data Amount";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 511);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.chkJsonModels);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabSQLExport.ResumeLayout(false);
            this.tabSQLExport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkJsonModels;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabSQLExport;
        private System.Windows.Forms.TabPage tabJSON;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.CheckBox chkIncludeInsert;
        private System.Windows.Forms.CheckBox chkIncludeKey;
        private System.Windows.Forms.RadioButton radioINT;
        private System.Windows.Forms.RadioButton radioGUID;
    }
}