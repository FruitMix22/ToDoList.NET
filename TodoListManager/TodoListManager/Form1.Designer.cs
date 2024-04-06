namespace TodoListManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            InputField = new TextBox();
            InputButton = new Button();
            ToDoList = new CheckedListBox();
            tasksAmountText = new Label();
            tasksCompletedText = new Label();
            panel1 = new Panel();
            ProgressBarTasks = new ProgressBar();
            SaveFileButton = new PictureBox();
            saveFileCurrentText = new Label();
            LoadFile3 = new Button();
            LoadFile2 = new Button();
            LoadFile1 = new Button();
            panel2 = new Panel();
            EnterTaskText = new Label();
            deleteLastSelected = new Button();
            ClearListButton = new Button();
            RevertChangesButton = new Button();
            DescriptionTextBox = new TextBox();
            DescriptionLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SaveFileButton).BeginInit();
            SuspendLayout();
            // 
            // InputField
            // 
            InputField.Location = new Point(12, 92);
            InputField.Name = "InputField";
            InputField.Size = new Size(117, 23);
            InputField.TabIndex = 1;
            InputField.KeyDown += InputField_Entered;
            // 
            // InputButton
            // 
            InputButton.BackColor = SystemColors.ActiveCaption;
            InputButton.Font = new Font("Century Gothic", 9F);
            InputButton.Location = new Point(135, 92);
            InputButton.Name = "InputButton";
            InputButton.Size = new Size(75, 23);
            InputButton.TabIndex = 2;
            InputButton.Text = "Add Task";
            InputButton.UseVisualStyleBackColor = false;
            InputButton.Click += InputButton_Click;
            // 
            // ToDoList
            // 
            ToDoList.CheckOnClick = true;
            ToDoList.Font = new Font("Century Gothic", 9F);
            ToDoList.ForeColor = SystemColors.InfoText;
            ToDoList.FormattingEnabled = true;
            ToDoList.Location = new Point(12, 194);
            ToDoList.Name = "ToDoList";
            ToDoList.Size = new Size(311, 208);
            ToDoList.TabIndex = 3;
            ToDoList.SelectedIndexChanged += ToDoList_SelectedIndexChanged;
            // 
            // tasksAmountText
            // 
            tasksAmountText.AutoSize = true;
            tasksAmountText.Font = new Font("Century Gothic", 9F);
            tasksAmountText.Location = new Point(12, 138);
            tasksAmountText.Name = "tasksAmountText";
            tasksAmountText.Size = new Size(105, 17);
            tasksAmountText.TabIndex = 4;
            tasksAmountText.Text = "Amount of tasks:";
            // 
            // tasksCompletedText
            // 
            tasksCompletedText.AutoSize = true;
            tasksCompletedText.Font = new Font("Century Gothic", 9F);
            tasksCompletedText.Location = new Point(12, 163);
            tasksCompletedText.Name = "tasksCompletedText";
            tasksCompletedText.Size = new Size(178, 17);
            tasksCompletedText.TabIndex = 5;
            tasksCompletedText.Text = "Amount of tasks completed: ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 128);
            panel1.Controls.Add(ProgressBarTasks);
            panel1.Controls.Add(SaveFileButton);
            panel1.Controls.Add(saveFileCurrentText);
            panel1.Controls.Add(LoadFile3);
            panel1.Controls.Add(LoadFile2);
            panel1.Controls.Add(LoadFile1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 50);
            panel1.TabIndex = 6;
            // 
            // ProgressBarTasks
            // 
            ProgressBarTasks.Location = new Point(200, 16);
            ProgressBarTasks.Name = "ProgressBarTasks";
            ProgressBarTasks.Size = new Size(100, 23);
            ProgressBarTasks.TabIndex = 12;
            // 
            // SaveFileButton
            // 
            SaveFileButton.Image = (Image)resources.GetObject("SaveFileButton.Image");
            SaveFileButton.Location = new Point(601, 8);
            SaveFileButton.Name = "SaveFileButton";
            SaveFileButton.Size = new Size(30, 31);
            SaveFileButton.SizeMode = PictureBoxSizeMode.StretchImage;
            SaveFileButton.TabIndex = 15;
            SaveFileButton.TabStop = false;
            SaveFileButton.Click += SaveFileButton_Click;
            // 
            // saveFileCurrentText
            // 
            saveFileCurrentText.AutoSize = true;
            saveFileCurrentText.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveFileCurrentText.Location = new Point(12, 9);
            saveFileCurrentText.Name = "saveFileCurrentText";
            saveFileCurrentText.Size = new Size(171, 30);
            saveFileCurrentText.TabIndex = 14;
            saveFileCurrentText.Text = "Current file: 1";
            // 
            // LoadFile3
            // 
            LoadFile3.Font = new Font("Century Gothic", 9F);
            LoadFile3.Location = new Point(814, 12);
            LoadFile3.Name = "LoadFile3";
            LoadFile3.Size = new Size(86, 23);
            LoadFile3.TabIndex = 13;
            LoadFile3.Text = "Load File 3";
            LoadFile3.UseVisualStyleBackColor = true;
            LoadFile3.Click += LoadFile3_Click;
            // 
            // LoadFile2
            // 
            LoadFile2.Font = new Font("Century Gothic", 9F);
            LoadFile2.Location = new Point(724, 12);
            LoadFile2.Name = "LoadFile2";
            LoadFile2.Size = new Size(84, 23);
            LoadFile2.TabIndex = 12;
            LoadFile2.Text = "Load File 2";
            LoadFile2.UseVisualStyleBackColor = true;
            LoadFile2.Click += LoadFile2_Click;
            // 
            // LoadFile1
            // 
            LoadFile1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoadFile1.Location = new Point(637, 12);
            LoadFile1.Name = "LoadFile1";
            LoadFile1.Size = new Size(81, 23);
            LoadFile1.TabIndex = 11;
            LoadFile1.Text = "Load File 1";
            LoadFile1.UseVisualStyleBackColor = true;
            LoadFile1.Click += LoadFile1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 255, 128);
            panel2.Location = new Point(864, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(50, 528);
            panel2.TabIndex = 7;
            // 
            // EnterTaskText
            // 
            EnterTaskText.AutoSize = true;
            EnterTaskText.Font = new Font("Century Gothic", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            EnterTaskText.Location = new Point(12, 61);
            EnterTaskText.Name = "EnterTaskText";
            EnterTaskText.Size = new Size(155, 30);
            EnterTaskText.TabIndex = 8;
            EnterTaskText.Text = "Enter a task:";
            // 
            // deleteLastSelected
            // 
            deleteLastSelected.BackColor = SystemColors.MenuHighlight;
            deleteLastSelected.Font = new Font("Century Gothic", 9F);
            deleteLastSelected.Location = new Point(343, 194);
            deleteLastSelected.Name = "deleteLastSelected";
            deleteLastSelected.Size = new Size(75, 23);
            deleteLastSelected.TabIndex = 9;
            deleteLastSelected.Text = "Delete";
            deleteLastSelected.UseVisualStyleBackColor = false;
            deleteLastSelected.Click += DeleteLastSelected_Click;
            // 
            // ClearListButton
            // 
            ClearListButton.BackColor = Color.Red;
            ClearListButton.Location = new Point(343, 379);
            ClearListButton.Name = "ClearListButton";
            ClearListButton.Size = new Size(75, 23);
            ClearListButton.TabIndex = 10;
            ClearListButton.Text = "Delete All";
            ClearListButton.UseVisualStyleBackColor = false;
            ClearListButton.Click += ClearListButton_Click;
            // 
            // RevertChangesButton
            // 
            RevertChangesButton.BackColor = Color.Lime;
            RevertChangesButton.Location = new Point(329, 283);
            RevertChangesButton.Name = "RevertChangesButton";
            RevertChangesButton.Size = new Size(97, 23);
            RevertChangesButton.TabIndex = 11;
            RevertChangesButton.Text = "Revert Changes";
            RevertChangesButton.UseVisualStyleBackColor = false;
            RevertChangesButton.Click += RevertChangesButton_Click;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(497, 194);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(311, 208);
            DescriptionTextBox.TabIndex = 12;
            DescriptionTextBox.Visible = false;
            DescriptionTextBox.TextChanged += DescriptionTextBox_TextChanged;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DescriptionLabel.Location = new Point(499, 173);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(79, 17);
            DescriptionLabel.TabIndex = 13;
            DescriptionLabel.Text = "Description:";
            DescriptionLabel.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(912, 527);
            Controls.Add(DescriptionLabel);
            Controls.Add(DescriptionTextBox);
            Controls.Add(RevertChangesButton);
            Controls.Add(ClearListButton);
            Controls.Add(deleteLastSelected);
            Controls.Add(EnterTaskText);
            Controls.Add(panel1);
            Controls.Add(tasksCompletedText);
            Controls.Add(tasksAmountText);
            Controls.Add(ToDoList);
            Controls.Add(InputButton);
            Controls.Add(InputField);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "To do list";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SaveFileButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion



        //Input areas
        private Label EnterTaskText;
        private TextBox InputField;
        private Button InputButton;

        //To do list
        private CheckedListBox ToDoList;
        private Button deleteLastSelected;

        //Description of tasks
        private Label tasksAmountText;
        private Label tasksCompletedText;
        
        //Coloured boxes for design
        private Panel panel1;
        private Panel panel2;
        private Button LoadFile1;
        private Button LoadFile3;
        private Button LoadFile2;
        private Label saveFileCurrentText;
        private PictureBox SaveFileButton;
        private Button ClearListButton;
        private Button RevertChangesButton;
        private ProgressBar ProgressBarTasks;
        private TextBox DescriptionTextBox;
        private Label DescriptionLabel;
    }
}
