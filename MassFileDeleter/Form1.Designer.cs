namespace MassFileDeleter
{
    partial class Form1
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
            folderTextBox = new TextBox();
            extensionTextBox = new TextBox();
            deleteButton = new Button();
            fileTypelabel1 = new Label();
            dir_label2 = new Label();
            recursiveCheckBox1 = new CheckBox();
            SuspendLayout();
            // 
            // folderTextBox
            // 
            folderTextBox.Location = new Point(104, 12);
            folderTextBox.Name = "folderTextBox";
            folderTextBox.Size = new Size(498, 23);
            folderTextBox.TabIndex = 0;
            // 
            // extensionTextBox
            // 
            extensionTextBox.Location = new Point(191, 42);
            extensionTextBox.Name = "extensionTextBox";
            extensionTextBox.Size = new Size(93, 23);
            extensionTextBox.TabIndex = 1;
            extensionTextBox.KeyPress += extensionTextBox_KeyPress;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(12, 41);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Delete Files";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // fileTypelabel1
            // 
            fileTypelabel1.AutoSize = true;
            fileTypelabel1.Location = new Point(104, 45);
            fileTypelabel1.Name = "fileTypelabel1";
            fileTypelabel1.Size = new Size(81, 15);
            fileTypelabel1.TabIndex = 3;
            fileTypelabel1.Text = "File Extension:";
            // 
            // dir_label2
            // 
            dir_label2.AutoSize = true;
            dir_label2.Location = new Point(12, 15);
            dir_label2.Name = "dir_label2";
            dir_label2.Size = new Size(85, 15);
            dir_label2.TabIndex = 4;
            dir_label2.Text = "Directory Path:";
            // 
            // recursiveCheckBox1
            // 
            recursiveCheckBox1.AutoSize = true;
            recursiveCheckBox1.Location = new Point(15, 70);
            recursiveCheckBox1.Name = "recursiveCheckBox1";
            recursiveCheckBox1.Size = new Size(76, 19);
            recursiveCheckBox1.TabIndex = 5;
            recursiveCheckBox1.Text = "Recursive";
            recursiveCheckBox1.UseVisualStyleBackColor = true;
            recursiveCheckBox1.CheckedChanged += recursiveCheckBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 99);
            Controls.Add(recursiveCheckBox1);
            Controls.Add(dir_label2);
            Controls.Add(fileTypelabel1);
            Controls.Add(deleteButton);
            Controls.Add(extensionTextBox);
            Controls.Add(folderTextBox);
            Name = "Form1";
            Text = "Mass File Deleter";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox folderTextBox;
        private TextBox extensionTextBox;
        private Button deleteButton;
        private Label fileTypelabel1;
        private Label dir_label2;
        private CheckBox recursiveCheckBox1;
    }
}
