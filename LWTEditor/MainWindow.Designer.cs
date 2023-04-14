namespace LWTEditor
{
    partial class mainWindow
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
            if (disposing && (components != null))
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
            label1 = new System.Windows.Forms.Label();
            filePath = new System.Windows.Forms.TextBox();
            browseBtn = new System.Windows.Forms.Button();
            editTimePicker = new System.Windows.Forms.DateTimePicker();
            label2 = new System.Windows.Forms.Label();
            editBtn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(44, 17);
            label1.TabIndex = 0;
            label1.Text = "文件：";
            // 
            // filePath
            // 
            filePath.Location = new System.Drawing.Point(12, 29);
            filePath.Name = "filePath";
            filePath.Size = new System.Drawing.Size(192, 23);
            filePath.TabIndex = 1;
            // 
            // browseBtn
            // 
            browseBtn.Location = new System.Drawing.Point(210, 29);
            browseBtn.Name = "browseBtn";
            browseBtn.Size = new System.Drawing.Size(75, 23);
            browseBtn.TabIndex = 2;
            browseBtn.Text = "浏览...";
            browseBtn.UseVisualStyleBackColor = true;
            browseBtn.Click += BrowseBtnClick;
            // 
            // editTimePicker
            // 
            editTimePicker.Location = new System.Drawing.Point(13, 75);
            editTimePicker.Name = "editTimePicker";
            editTimePicker.Size = new System.Drawing.Size(272, 23);
            editTimePicker.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(13, 55);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(44, 17);
            label2.TabIndex = 4;
            label2.Text = "时间：";
            // 
            // editBtn
            // 
            editBtn.Location = new System.Drawing.Point(210, 104);
            editBtn.Name = "editBtn";
            editBtn.Size = new System.Drawing.Size(75, 23);
            editBtn.TabIndex = 5;
            editBtn.Text = "确定";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += EditBtnClick;
            // 
            // mainWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(297, 133);
            Controls.Add(editBtn);
            Controls.Add(label2);
            Controls.Add(editTimePicker);
            Controls.Add(browseBtn);
            Controls.Add(filePath);
            Controls.Add(label1);
            Name = "mainWindow";
            Text = "“上次修改时间“编辑器";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.DateTimePicker editTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button editBtn;
    }
}
