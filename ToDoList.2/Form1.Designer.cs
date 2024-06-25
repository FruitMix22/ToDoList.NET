namespace ToDoList._2
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
            TopPanel = new Panel();
            RightPanel = new Panel();
            EnterTaskText = new Label();
            InputButton = new Button();
            InputField = new TextBox();
            ToDoList = new CheckedListBox();
            button1 = new Button();
            TopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TopPanel.BackColor = Color.FromArgb(255, 255, 128);
            TopPanel.Controls.Add(button1);
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(803, 55);
            TopPanel.TabIndex = 0;
            // 
            // RightPanel
            // 
            RightPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RightPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RightPanel.BackColor = Color.FromArgb(255, 255, 128);
            RightPanel.Location = new Point(741, 0);
            RightPanel.Name = "RightPanel";
            RightPanel.Size = new Size(62, 454);
            RightPanel.TabIndex = 1;
            // 
            // EnterTaskText
            // 
            EnterTaskText.AutoSize = true;
            EnterTaskText.Font = new Font("Century Gothic", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            EnterTaskText.Location = new Point(12, 72);
            EnterTaskText.Name = "EnterTaskText";
            EnterTaskText.Size = new Size(155, 30);
            EnterTaskText.TabIndex = 9;
            EnterTaskText.Text = "Enter a task:";
            // 
            // InputButton
            // 
            InputButton.BackColor = Color.LemonChiffon;
            InputButton.Font = new Font("Century Gothic", 9F);
            InputButton.Location = new Point(135, 105);
            InputButton.Name = "InputButton";
            InputButton.Size = new Size(75, 23);
            InputButton.TabIndex = 11;
            InputButton.Text = "Add Task";
            InputButton.UseVisualStyleBackColor = false;
            InputButton.Click += InputButton_Click;
            // 
            // InputField
            // 
            InputField.Location = new Point(12, 105);
            InputField.MaxLength = 12;
            InputField.Name = "InputField";
            InputField.PlaceholderText = "Enter Task Here";
            InputField.Size = new Size(117, 23);
            InputField.TabIndex = 10;
            InputField.KeyDown += InputField_Entered;
            // 
            // ToDoList
            // 
            ToDoList.CheckOnClick = true;
            ToDoList.Font = new Font("Century Gothic", 9F);
            ToDoList.ForeColor = SystemColors.InfoText;
            ToDoList.FormattingEnabled = true;
            ToDoList.Location = new Point(12, 151);
            ToDoList.Name = "ToDoList";
            ToDoList.Size = new Size(311, 208);
            ToDoList.TabIndex = 12;
            ToDoList.SelectedIndexChanged += ToDoList_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(538, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ToDoList);
            Controls.Add(InputButton);
            Controls.Add(InputField);
            Controls.Add(EnterTaskText);
            Controls.Add(RightPanel);
            Controls.Add(TopPanel);
            FormClosing += Form1_FormClosing;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            TopPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TopPanel;
        private Panel RightPanel;
        private Label EnterTaskText;
        private Button InputButton;
        private TextBox InputField;
        private CheckedListBox ToDoList;
        private Button button1;
    }
}
