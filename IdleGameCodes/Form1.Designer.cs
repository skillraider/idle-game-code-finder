namespace IdleGameCodes
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
            logPathTextBox = new TextBox();
            label1 = new Label();
            chooseFolderButton = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            findSavesButton = new Button();
            searchTermComboBox = new ComboBox();
            label2 = new Label();
            savesDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)savesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // logPathTextBox
            // 
            logPathTextBox.Location = new Point(12, 27);
            logPathTextBox.Name = "logPathTextBox";
            logPathTextBox.Size = new Size(449, 23);
            logPathTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 15);
            label1.TabIndex = 5;
            label1.Text = "VRChat Log File Location";
            // 
            // chooseFolderButton
            // 
            chooseFolderButton.Location = new Point(467, 27);
            chooseFolderButton.Name = "chooseFolderButton";
            chooseFolderButton.Size = new Size(101, 23);
            chooseFolderButton.TabIndex = 6;
            chooseFolderButton.Text = "Choose Folder";
            chooseFolderButton.UseVisualStyleBackColor = true;
            chooseFolderButton.Click += chooseFolderButton_Click;
            // 
            // findSavesButton
            // 
            findSavesButton.Location = new Point(743, 27);
            findSavesButton.Name = "findSavesButton";
            findSavesButton.Size = new Size(75, 23);
            findSavesButton.TabIndex = 8;
            findSavesButton.Text = "Find Saves";
            findSavesButton.UseVisualStyleBackColor = true;
            findSavesButton.Click += findSavesButton_Click;
            // 
            // searchTermComboBox
            // 
            searchTermComboBox.FormattingEnabled = true;
            searchTermComboBox.Location = new Point(574, 27);
            searchTermComboBox.Name = "searchTermComboBox";
            searchTermComboBox.Size = new Size(163, 23);
            searchTermComboBox.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(574, 9);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 10;
            label2.Text = "Search Terms";
            // 
            // savesDataGridView
            // 
            savesDataGridView.AllowUserToAddRows = false;
            savesDataGridView.AllowUserToDeleteRows = false;
            savesDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            savesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            savesDataGridView.Location = new Point(12, 56);
            savesDataGridView.Name = "savesDataGridView";
            savesDataGridView.ReadOnly = true;
            savesDataGridView.Size = new Size(884, 661);
            savesDataGridView.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 729);
            Controls.Add(label2);
            Controls.Add(searchTermComboBox);
            Controls.Add(findSavesButton);
            Controls.Add(chooseFolderButton);
            Controls.Add(label1);
            Controls.Add(logPathTextBox);
            Controls.Add(savesDataGridView);
            Name = "Form1";
            ShowIcon = false;
            Text = "Idle Game Codes";
            ((System.ComponentModel.ISupportInitialize)savesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox logPathTextBox;
        private Label label1;
        private Button chooseFolderButton;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button findSavesButton;
        private ComboBox searchTermComboBox;
        private Label label2;
        private DataGridView savesDataGridView;
    }
}
