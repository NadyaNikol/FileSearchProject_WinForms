namespace FileSearchProject_WF
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.treeViewDirections = new System.Windows.Forms.TreeView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnWords = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.progressBarSearch = new System.Windows.Forms.ProgressBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.lblFiles = new System.Windows.Forms.Label();
            this.lblNameFiles = new System.Windows.Forms.Label();
            this.lblPathSave = new System.Windows.Forms.Label();
            this.btnShowStatistics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeViewDirections
            // 
            this.treeViewDirections.Location = new System.Drawing.Point(14, 68);
            this.treeViewDirections.Name = "treeViewDirections";
            this.treeViewDirections.Size = new System.Drawing.Size(378, 444);
            this.treeViewDirections.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1196, 68);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(212, 105);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save in ...";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // btnWords
            // 
            this.btnWords.Location = new System.Drawing.Point(1196, 202);
            this.btnWords.Name = "btnWords";
            this.btnWords.Size = new System.Drawing.Size(212, 105);
            this.btnWords.TabIndex = 3;
            this.btnWords.Text = "Choose words";
            this.btnWords.UseVisualStyleBackColor = true;
            this.btnWords.Click += new System.EventHandler(this.btnWords_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1196, 409);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(212, 105);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // progressBarSearch
            // 
            this.progressBarSearch.Location = new System.Drawing.Point(12, 565);
            this.progressBarSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBarSearch.Name = "progressBarSearch";
            this.progressBarSearch.Size = new System.Drawing.Size(1176, 38);
            this.progressBarSearch.TabIndex = 5;
            this.progressBarSearch.Visible = false;
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 20;
            this.listBoxFiles.Location = new System.Drawing.Point(432, 68);
            this.listBoxFiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(756, 444);
            this.listBoxFiles.TabIndex = 6;
            // 
            // lblFiles
            // 
            this.lblFiles.AccessibleDescription = "progressBarSearch.Value";
            this.lblFiles.AutoSize = true;
            this.lblFiles.Location = new System.Drawing.Point(12, 528);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(46, 20);
            this.lblFiles.TabIndex = 7;
            this.lblFiles.Text = "Files:";
            this.lblFiles.Visible = false;
            // 
            // lblNameFiles
            // 
            this.lblNameFiles.AccessibleDescription = "progressBarSearch.Value";
            this.lblNameFiles.AutoSize = true;
            this.lblNameFiles.Location = new System.Drawing.Point(64, 528);
            this.lblNameFiles.Name = "lblNameFiles";
            this.lblNameFiles.Size = new System.Drawing.Size(0, 20);
            this.lblNameFiles.TabIndex = 8;
            // 
            // lblPathSave
            // 
            this.lblPathSave.AutoSize = true;
            this.lblPathSave.Location = new System.Drawing.Point(1204, 162);
            this.lblPathSave.Name = "lblPathSave";
            this.lblPathSave.Size = new System.Drawing.Size(0, 20);
            this.lblPathSave.TabIndex = 9;
            // 
            // btnShowStatistics
            // 
            this.btnShowStatistics.Location = new System.Drawing.Point(759, 509);
            this.btnShowStatistics.Name = "btnShowStatistics";
            this.btnShowStatistics.Size = new System.Drawing.Size(430, 48);
            this.btnShowStatistics.TabIndex = 10;
            this.btnShowStatistics.Text = "Show statistics";
            this.btnShowStatistics.UseVisualStyleBackColor = true;
            this.btnShowStatistics.Visible = false;
            this.btnShowStatistics.Click += new System.EventHandler(this.btnShowStatistics_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1444, 611);
            this.Controls.Add(this.btnShowStatistics);
            this.Controls.Add(this.lblPathSave);
            this.Controls.Add(this.lblNameFiles);
            this.Controls.Add(this.lblFiles);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.progressBarSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnWords);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.treeViewDirections);
            this.Name = "FormMain";
            this.Text = "Search system";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewDirections;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnWords;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ProgressBar progressBarSearch;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.Label lblNameFiles;
        private System.Windows.Forms.Label lblPathSave;
        private System.Windows.Forms.Button btnShowStatistics;
    }
}

