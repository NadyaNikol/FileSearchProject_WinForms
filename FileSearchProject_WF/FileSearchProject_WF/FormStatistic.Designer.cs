namespace FileSearchProject_WF
{
    partial class FormStatistic
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
            this.dataGridViewStatistic = new System.Windows.Forms.DataGridView();
            this.btnTop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistic)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStatistic
            // 
            this.dataGridViewStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatistic.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewStatistic.Name = "dataGridViewStatistic";
            this.dataGridViewStatistic.RowTemplate.Height = 28;
            this.dataGridViewStatistic.Size = new System.Drawing.Size(886, 505);
            this.dataGridViewStatistic.TabIndex = 0;
            // 
            // btnTop
            // 
            this.btnTop.Location = new System.Drawing.Point(12, 532);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(344, 63);
            this.btnTop.TabIndex = 2;
            this.btnTop.Text = "Top words";
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // FormStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 608);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.dataGridViewStatistic);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormStatistic";
            this.Text = "Statistic";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStatistic;
        private System.Windows.Forms.Button btnTop;
    }
}