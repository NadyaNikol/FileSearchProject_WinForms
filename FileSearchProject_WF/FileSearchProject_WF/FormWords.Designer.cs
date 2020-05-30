namespace FileSearchProject_WF
{
    partial class FormWords
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
            this.txtbWord = new System.Windows.Forms.TextBox();
            this.listBoxWords = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFromFile = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbWord
            // 
            this.txtbWord.Location = new System.Drawing.Point(18, 89);
            this.txtbWord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbWord.Name = "txtbWord";
            this.txtbWord.Size = new System.Drawing.Size(372, 26);
            this.txtbWord.TabIndex = 0;
            // 
            // listBoxWords
            // 
            this.listBoxWords.FormattingEnabled = true;
            this.listBoxWords.ItemHeight = 20;
            this.listBoxWords.Location = new System.Drawing.Point(18, 152);
            this.listBoxWords.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxWords.Name = "listBoxWords";
            this.listBoxWords.Size = new System.Drawing.Size(372, 444);
            this.listBoxWords.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter forbidden word";
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::FileSearchProject_WF.Properties.Resources.delete1;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(416, 152);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(57, 49);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFromFile
            // 
            this.btnFromFile.BackgroundImage = global::FileSearchProject_WF.Properties.Resources.fromfile;
            this.btnFromFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFromFile.Location = new System.Drawing.Point(416, 290);
            this.btnFromFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFromFile.Name = "btnFromFile";
            this.btnFromFile.Size = new System.Drawing.Size(86, 108);
            this.btnFromFile.TabIndex = 4;
            this.btnFromFile.UseVisualStyleBackColor = true;
            this.btnFromFile.Click += new System.EventHandler(this.btnFromFile_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::FileSearchProject_WF.Properties.Resources.add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Location = new System.Drawing.Point(416, 78);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(57, 49);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(528, 611);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnFromFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxWords);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtbWord);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormWords";
            this.Text = "Words";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbWord;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listBoxWords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFromFile;
        private System.Windows.Forms.Button btnDelete;
    }
}