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
            EnterTaskText = new TextBox();
            InputField = new TextBox();
            InputButton = new Button();
            ToDoList = new CheckedListBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            EnterTaskText.BackColor = SystemColors.Menu;
            EnterTaskText.BorderStyle = BorderStyle.None;
            EnterTaskText.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EnterTaskText.Location = new Point(12, 12);
            EnterTaskText.Name = "textBox1";
            EnterTaskText.Size = new Size(117, 25);
            EnterTaskText.TabIndex = 0;
            EnterTaskText.Text = "Enter a Task:";
            EnterTaskText.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
          InputField.Location = new Point(12, 43);
          InputField.Multiline = true;
          InputField.Name = "textBox2";
          InputField.Size = new Size(117, 23);
          InputField.TabIndex = 1;
          InputField.TextChanged += textBox2_TextChanged_1;
            // 
            // InputButton
            // 
            InputButton.BackColor = SystemColors.ActiveCaption;
            InputButton.Location = new Point(135, 43);
            InputButton.Name = "InputButton";
            InputButton.Size = new Size(75, 23);
            InputButton.TabIndex = 2;
            InputButton.Text = "Add Task";
            InputButton.UseVisualStyleBackColor = false;
            InputButton.Click += InputButton_Click;
            // 
            // ToDoList
            // 
            ToDoList.FormattingEnabled = true;
            ToDoList.Location = new Point(9, 90);
            ToDoList.Name = "ToDoList";
            ToDoList.Size = new Size(311, 220);
            ToDoList.TabIndex = 3;
            ToDoList.SelectedIndexChanged += ToDoList_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 527);
            Controls.Add(ToDoList);
            Controls.Add(InputButton);
            Controls.Add(InputField);
            Controls.Add(EnterTaskText);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        void TextBoxEdit()
        {
            EnterTaskText.ReadOnly = true;
        }

        private TextBox EnterTaskText;
        private TextBox InputField;
        private Button InputButton;
        private CheckedListBox ToDoList;
    }
}
