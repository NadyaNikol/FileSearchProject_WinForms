namespace FileSearchProject_WF
{
    partial class FormTopWords
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
            this.dataGridViewAbridgedStatistic = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbridgedStatistic)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAbridgedStatistic
            // 
            this.dataGridViewAbridgedStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAbridgedStatistic.Location = new System.Drawing.Point(4, 3);
            this.dataGridViewAbridgedStatistic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewAbridgedStatistic.Name = "dataGridViewAbridgedStatistic";
            this.dataGridViewAbridgedStatistic.Size = new System.Drawing.Size(430, 610);
            this.dataGridViewAbridgedStatistic.TabIndex = 0;
            // 
            // FormTopWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 612);
            this.Controls.Add(this.dataGridViewAbridgedStatistic);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormTopWords";
            this.Text = "Top Words";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbridgedStatistic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAbridgedStatistic;
    }
}