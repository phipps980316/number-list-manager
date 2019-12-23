namespace EventCW1
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.grpSort = new System.Windows.Forms.GroupBox();
            this.optUnsorted = new System.Windows.Forms.RadioButton();
            this.optSorted = new System.Windows.Forms.RadioButton();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.optBinary = new System.Windows.Forms.RadioButton();
            this.optLinear = new System.Windows.Forms.RadioButton();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.btnInitialise = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblMinimum = new System.Windows.Forms.Label();
            this.lblMaximum = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblCountValue = new System.Windows.Forms.Label();
            this.lblMinimumValue = new System.Windows.Forms.Label();
            this.lblMaximumValue = new System.Windows.Forms.Label();
            this.lblFirstValue = new System.Windows.Forms.Label();
            this.lblLastValue = new System.Windows.Forms.Label();
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.lblEntriesRemainingValue = new System.Windows.Forms.Label();
            this.lblEntriesRemaining = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picBin = new System.Windows.Forms.PictureBox();
            this.lblMaximumEntries = new System.Windows.Forms.Label();
            this.lblMaximumEntriesValue = new System.Windows.Forms.Label();
            this.grpSort.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.grpStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBin)).BeginInit();
            this.SuspendLayout();
            // 
            // lstNumbers
            // 
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.Location = new System.Drawing.Point(13, 13);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(114, 277);
            this.lstNumbers.TabIndex = 0;
            this.lstNumbers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstNumbers_MouseDown);
            // 
            // grpSort
            // 
            this.grpSort.Controls.Add(this.optUnsorted);
            this.grpSort.Controls.Add(this.optSorted);
            this.grpSort.Location = new System.Drawing.Point(295, 13);
            this.grpSort.Name = "grpSort";
            this.grpSort.Size = new System.Drawing.Size(145, 66);
            this.grpSort.TabIndex = 1;
            this.grpSort.TabStop = false;
            this.grpSort.Text = "Sort Option";
            // 
            // optUnsorted
            // 
            this.optUnsorted.AutoSize = true;
            this.optUnsorted.Checked = true;
            this.optUnsorted.Location = new System.Drawing.Point(6, 19);
            this.optUnsorted.Name = "optUnsorted";
            this.optUnsorted.Size = new System.Drawing.Size(68, 17);
            this.optUnsorted.TabIndex = 1;
            this.optUnsorted.TabStop = true;
            this.optUnsorted.Text = "Unsorted";
            this.optUnsorted.UseVisualStyleBackColor = true;
            this.optUnsorted.Click += new System.EventHandler(this.optUnsorted_Click);
            // 
            // optSorted
            // 
            this.optSorted.AutoSize = true;
            this.optSorted.Location = new System.Drawing.Point(6, 42);
            this.optSorted.Name = "optSorted";
            this.optSorted.Size = new System.Drawing.Size(56, 17);
            this.optSorted.TabIndex = 0;
            this.optSorted.Text = "Sorted";
            this.optSorted.UseVisualStyleBackColor = true;
            this.optSorted.Click += new System.EventHandler(this.optSorted_Click);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.optBinary);
            this.grpSearch.Controls.Add(this.optLinear);
            this.grpSearch.Enabled = false;
            this.grpSearch.Location = new System.Drawing.Point(295, 85);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(145, 68);
            this.grpSearch.TabIndex = 2;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Option";
            // 
            // optBinary
            // 
            this.optBinary.AutoSize = true;
            this.optBinary.Enabled = false;
            this.optBinary.Location = new System.Drawing.Point(7, 43);
            this.optBinary.Name = "optBinary";
            this.optBinary.Size = new System.Drawing.Size(54, 17);
            this.optBinary.TabIndex = 1;
            this.optBinary.Text = "Binary";
            this.optBinary.UseVisualStyleBackColor = true;
            // 
            // optLinear
            // 
            this.optLinear.AutoSize = true;
            this.optLinear.Checked = true;
            this.optLinear.Location = new System.Drawing.Point(7, 20);
            this.optLinear.Name = "optLinear";
            this.optLinear.Size = new System.Drawing.Size(54, 17);
            this.optLinear.TabIndex = 0;
            this.optLinear.TabStop = true;
            this.optLinear.Text = "Linear";
            this.optLinear.UseVisualStyleBackColor = true;
            // 
            // txtUserInput
            // 
            this.txtUserInput.Location = new System.Drawing.Point(133, 29);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(156, 20);
            this.txtUserInput.TabIndex = 3;
            // 
            // btnInitialise
            // 
            this.btnInitialise.Location = new System.Drawing.Point(133, 72);
            this.btnInitialise.Name = "btnInitialise";
            this.btnInitialise.Size = new System.Drawing.Size(75, 23);
            this.btnInitialise.TabIndex = 2;
            this.btnInitialise.Text = "Initialise";
            this.btnInitialise.UseVisualStyleBackColor = true;
            this.btnInitialise.Click += new System.EventHandler(this.btnInitialise_Click);
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(214, 101);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Enabled = false;
            this.btnShuffle.Location = new System.Drawing.Point(133, 130);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(75, 23);
            this.btnShuffle.TabIndex = 5;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(133, 101);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(214, 72);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(214, 130);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AllowDrop = true;
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(133, 159);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(156, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(62, 14);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(41, 13);
            this.lblCount.TabIndex = 15;
            this.lblCount.Text = "Count: ";
            // 
            // lblMinimum
            // 
            this.lblMinimum.AutoSize = true;
            this.lblMinimum.Location = new System.Drawing.Point(19, 27);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(81, 13);
            this.lblMinimum.TabIndex = 16;
            this.lblMinimum.Text = "Minimum Value:";
            // 
            // lblMaximum
            // 
            this.lblMaximum.AutoSize = true;
            this.lblMaximum.Location = new System.Drawing.Point(16, 40);
            this.lblMaximum.Name = "lblMaximum";
            this.lblMaximum.Size = new System.Drawing.Size(84, 13);
            this.lblMaximum.TabIndex = 17;
            this.lblMaximum.Text = "Maximum Value:";
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(41, 53);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(62, 13);
            this.lblFirst.TabIndex = 18;
            this.lblFirst.Text = "First Value: ";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(41, 66);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(63, 13);
            this.lblLast.TabIndex = 19;
            this.lblLast.Text = "Last Value: ";
            // 
            // lblCountValue
            // 
            this.lblCountValue.AutoSize = true;
            this.lblCountValue.Location = new System.Drawing.Point(106, 14);
            this.lblCountValue.Name = "lblCountValue";
            this.lblCountValue.Size = new System.Drawing.Size(13, 13);
            this.lblCountValue.TabIndex = 23;
            this.lblCountValue.Text = "0";
            // 
            // lblMinimumValue
            // 
            this.lblMinimumValue.AutoSize = true;
            this.lblMinimumValue.Location = new System.Drawing.Point(106, 27);
            this.lblMinimumValue.Name = "lblMinimumValue";
            this.lblMinimumValue.Size = new System.Drawing.Size(10, 13);
            this.lblMinimumValue.TabIndex = 24;
            this.lblMinimumValue.Text = "-";
            // 
            // lblMaximumValue
            // 
            this.lblMaximumValue.AutoSize = true;
            this.lblMaximumValue.Location = new System.Drawing.Point(106, 40);
            this.lblMaximumValue.Name = "lblMaximumValue";
            this.lblMaximumValue.Size = new System.Drawing.Size(10, 13);
            this.lblMaximumValue.TabIndex = 25;
            this.lblMaximumValue.Text = "-";
            // 
            // lblFirstValue
            // 
            this.lblFirstValue.AutoSize = true;
            this.lblFirstValue.Location = new System.Drawing.Point(106, 53);
            this.lblFirstValue.Name = "lblFirstValue";
            this.lblFirstValue.Size = new System.Drawing.Size(10, 13);
            this.lblFirstValue.TabIndex = 26;
            this.lblFirstValue.Text = "-";
            // 
            // lblLastValue
            // 
            this.lblLastValue.AutoSize = true;
            this.lblLastValue.Location = new System.Drawing.Point(106, 66);
            this.lblLastValue.Name = "lblLastValue";
            this.lblLastValue.Size = new System.Drawing.Size(10, 13);
            this.lblLastValue.TabIndex = 27;
            this.lblLastValue.Text = "-";
            // 
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.lblMaximumEntriesValue);
            this.grpStatus.Controls.Add(this.lblMaximumEntries);
            this.grpStatus.Controls.Add(this.lblEntriesRemainingValue);
            this.grpStatus.Controls.Add(this.lblEntriesRemaining);
            this.grpStatus.Controls.Add(this.lblLast);
            this.grpStatus.Controls.Add(this.lblLastValue);
            this.grpStatus.Controls.Add(this.lblFirstValue);
            this.grpStatus.Controls.Add(this.lblMaximumValue);
            this.grpStatus.Controls.Add(this.lblMinimumValue);
            this.grpStatus.Controls.Add(this.lblCount);
            this.grpStatus.Controls.Add(this.lblCountValue);
            this.grpStatus.Controls.Add(this.lblMinimum);
            this.grpStatus.Controls.Add(this.lblMaximum);
            this.grpStatus.Controls.Add(this.lblFirst);
            this.grpStatus.Location = new System.Drawing.Point(295, 159);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(145, 116);
            this.grpStatus.TabIndex = 28;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Status";
            // 
            // lblEntriesRemainingValue
            // 
            this.lblEntriesRemainingValue.AutoSize = true;
            this.lblEntriesRemainingValue.Location = new System.Drawing.Point(106, 79);
            this.lblEntriesRemainingValue.Name = "lblEntriesRemainingValue";
            this.lblEntriesRemainingValue.Size = new System.Drawing.Size(10, 13);
            this.lblEntriesRemainingValue.TabIndex = 29;
            this.lblEntriesRemainingValue.Text = "-";
            // 
            // lblEntriesRemaining
            // 
            this.lblEntriesRemaining.AutoSize = true;
            this.lblEntriesRemaining.Location = new System.Drawing.Point(5, 79);
            this.lblEntriesRemaining.Name = "lblEntriesRemaining";
            this.lblEntriesRemaining.Size = new System.Drawing.Size(95, 13);
            this.lblEntriesRemaining.TabIndex = 28;
            this.lblEntriesRemaining.Text = "Entries Remaining:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "User Input :";
            // 
            // picBin
            // 
            this.picBin.Enabled = false;
            this.picBin.Image = ((System.Drawing.Image)(resources.GetObject("picBin.Image")));
            this.picBin.Location = new System.Drawing.Point(173, 191);
            this.picBin.Name = "picBin";
            this.picBin.Size = new System.Drawing.Size(75, 75);
            this.picBin.TabIndex = 30;
            this.picBin.TabStop = false;
            this.picBin.DragDrop += new System.Windows.Forms.DragEventHandler(this.picBin_DragDrop);
            this.picBin.DragEnter += new System.Windows.Forms.DragEventHandler(this.picBin_DragEnter);
            // 
            // lblMaximumEntries
            // 
            this.lblMaximumEntries.AutoSize = true;
            this.lblMaximumEntries.Location = new System.Drawing.Point(11, 92);
            this.lblMaximumEntries.Name = "lblMaximumEntries";
            this.lblMaximumEntries.Size = new System.Drawing.Size(89, 13);
            this.lblMaximumEntries.TabIndex = 30;
            this.lblMaximumEntries.Text = "Maximum Entries:";
            // 
            // lblMaximumEntriesValue
            // 
            this.lblMaximumEntriesValue.AutoSize = true;
            this.lblMaximumEntriesValue.Location = new System.Drawing.Point(106, 92);
            this.lblMaximumEntriesValue.Name = "lblMaximumEntriesValue";
            this.lblMaximumEntriesValue.Size = new System.Drawing.Size(10, 13);
            this.lblMaximumEntriesValue.TabIndex = 31;
            this.lblMaximumEntriesValue.Text = "-";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 300);
            this.Controls.Add(this.picBin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpStatus);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnInitialise);
            this.Controls.Add(this.txtUserInput);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpSort);
            this.Controls.Add(this.lstNumbers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.Text = "Number List Manager";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpSort.ResumeLayout(false);
            this.grpSort.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpStatus.ResumeLayout(false);
            this.grpStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.GroupBox grpSort;
        private System.Windows.Forms.RadioButton optUnsorted;
        private System.Windows.Forms.RadioButton optSorted;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.RadioButton optBinary;
        private System.Windows.Forms.RadioButton optLinear;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.Button btnInitialise;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblMinimum;
        private System.Windows.Forms.Label lblMaximum;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblCountValue;
        private System.Windows.Forms.Label lblMinimumValue;
        private System.Windows.Forms.Label lblMaximumValue;
        private System.Windows.Forms.Label lblFirstValue;
        private System.Windows.Forms.Label lblLastValue;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBin;
        private System.Windows.Forms.Label lblEntriesRemainingValue;
        private System.Windows.Forms.Label lblEntriesRemaining;
        private System.Windows.Forms.Label lblMaximumEntriesValue;
        private System.Windows.Forms.Label lblMaximumEntries;
    }
}

