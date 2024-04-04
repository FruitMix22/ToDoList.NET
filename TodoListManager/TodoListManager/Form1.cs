using System.Windows.Forms;

namespace TodoListManager
{
    public partial class Form1 : Form
    {
        //Global vars

        //last selectecd item in checkbox to delete
        int lastSelected = -1;

        public Form1()
        {
            InitializeComponent();
        }

        //Custom Functions
        private void UpdateUI()
        {
            CheckForTotalTasks();
            CheckForTasksCompleted();
        }

        private void CheckForTotalTasks()
        {
            int tasksAmount = ToDoList.Items.Count;
            tasksAmountText.Text = "Amount of tasks: " + tasksAmount;

        }

        private void CheckForTasksCompleted()
        {
            int completedTasks = ToDoList.CheckedItems.Count;
            tasksCompletedText.Text = "Amount of tasks completed: " + completedTasks;
        }

        private void SaveToDoListToFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (object item in ToDoList.Items)
                {
                    writer.WriteLine(item.ToString());
                }
            }
        }


        //Event functions
        //Handle enter key for entering inputs
        private void InputField_Entered(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string Input = InputField.Text;
                if (!string.IsNullOrWhiteSpace(Input) && ToDoList.Items.Count <= 9)
                {
                    ToDoList.Items.Add(Input.Trim());
                    InputField.Clear();
                    UpdateUI();
                }
                else
                {
                    InputField.Clear();
                }
            }
        }

        //Add task if add button is clicked
        private void InputButton_Click(object sender, EventArgs e)
        {
            string Input = InputField.Text;
            if (!string.IsNullOrWhiteSpace(Input) && ToDoList.Items.Count <= 9)
            {
                ToDoList.Items.Add(Input.Trim());
                InputField.Clear();
                UpdateUI();
            }
            else
            {
                InputField.Clear();
            }


        }

        //check what was last selected in the to do list
        private void ToDoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ToDoList.SelectedIndex != -1)
            {
                lastSelected = ToDoList.SelectedIndex;
            }
            ToDoList.ClearSelected();
            UpdateUI();
        }

        //delete what was last selected if delete button is clicked
        private void deleteLastSelected_Click(object sender, EventArgs e)
        {
            if (lastSelected != -1)
            {
                ToDoList.Items.RemoveAt(lastSelected);
                lastSelected = -1;
            }
            UpdateUI();
        }

        //Load list of items from custom file
        private void LoadToDoListFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        ToDoList.Items.Add(line);
                    }
                }
            }
            else
            {
                MessageBox.Show("File does not exist: " + fileName);
            }
        }

        //handle what happens when the form initially loads
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateUI();
            LoadToDoListFromFile("ToDoListSave.txt");
        }

        //handle what happens when the form closes
        private void Form1_FormClosing(object sender, EventArgs e)
        {
            SaveToDoListToFile("ToDoListSave.txt");
        }

        //save the to do list when the save button is pressed
        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveToDoListToFile("ToDoListSave.txt");
        }
    }
}
