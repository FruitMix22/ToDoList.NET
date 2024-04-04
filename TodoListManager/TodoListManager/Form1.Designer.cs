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
            InputField = new TextBox();
            InputButton = new Button();
            ToDoList = new CheckedListBox();
            tasksAmountText = new Label();
            tasksCompletedText = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            EnterTaskText = new Label();
            deleteLastSelected = new Button();
            saveButton = new Button();
            descriptionBox = new TextBox();
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
            ToDoList.FormattingEnabled = true;
            ToDoList.Location = new Point(12, 194);
            ToDoList.Name = "ToDoList";
            ToDoList.Size = new Size(311, 220);
            ToDoList.TabIndex = 3;
            ToDoList.SelectedIndexChanged += ToDoList_SelectedIndexChanged;
            // 
            // tasksAmountText
            // 
            tasksAmountText.AutoSize = true;
            tasksAmountText.Location = new Point(12, 138);
            tasksAmountText.Name = "tasksAmountText";
            tasksAmountText.Size = new Size(97, 15);
            tasksAmountText.TabIndex = 4;
            tasksAmountText.Text = "Amount of tasks:";
            // 
            // tasksCompletedText
            // 
            tasksCompletedText.AutoSize = true;
            tasksCompletedText.Location = new Point(12, 163);
            tasksCompletedText.Name = "tasksCompletedText";
            tasksCompletedText.Size = new Size(160, 15);
            tasksCompletedText.TabIndex = 5;
            tasksCompletedText.Text = "Amount of tasks completed: ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 128);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 50);
            panel1.TabIndex = 6;
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
            EnterTaskText.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            EnterTaskText.Location = new Point(12, 61);
            EnterTaskText.Name = "EnterTaskText";
            EnterTaskText.Size = new Size(158, 28);
            EnterTaskText.TabIndex = 8;
            EnterTaskText.Text = "Enter a task:";
            // 
            // deleteLastSelected
            // 
            deleteLastSelected.BackColor = SystemColors.MenuHighlight;
            deleteLastSelected.Location = new Point(343, 194);
            deleteLastSelected.Name = "deleteLastSelected";
            deleteLastSelected.Size = new Size(75, 23);
            deleteLastSelected.TabIndex = 9;
            deleteLastSelected.Text = "Delete";
            deleteLastSelected.UseVisualStyleBackColor = false;
            deleteLastSelected.Click += deleteLastSelected_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(783, 492);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 10;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // descriptionBox
            // 
            descriptionBox.Location = new Point(607, 194);
            descriptionBox.Multiline = true;
            descriptionBox.Name = "descriptionBox";
            descriptionBox.PlaceholderText = "Description";
            descriptionBox.Size = new Size(240, 220);
            descriptionBox.TabIndex = 11;
            descriptionBox.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(912, 527);
            Controls.Add(descriptionBox);
            Controls.Add(saveButton);
            Controls.Add(deleteLastSelected);
            Controls.Add(EnterTaskText);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(tasksCompletedText);
            Controls.Add(tasksAmountText);
            Controls.Add(ToDoList);
            Controls.Add(InputButton);
            Controls.Add(InputField);
            Name = "Form1";
            Text = "To do list";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
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

        //Save
        private Button saveButton;
        private TextBox descriptionBox;
    }
}
