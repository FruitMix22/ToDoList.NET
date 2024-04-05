using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TodoListManager
{
    public partial class Form1 : Form
    {
        //Global vars
        //last selectecd item in checkbox to delete
        private int lastSelected = -1;

        //Used to measure where computer is in the list
        private int taskIndex = -1;

        //Current save file number
        private int saveFile = 1;

        public Form1()
        {
            InitializeComponent();
        }

        //Custom Functions

        //General Update function to update text and GUI
        private void UpdateUI()
        {
            CheckForTotalTasks();
            CheckForTasksCompleted();
            SaveFileCurrentText();
        }

        //Text updater to show what file youre currently in
        private void SaveFileCurrentText()
        {
            saveFileCurrentText.Text = "File open: " + saveFile;
        }

        //Text updater to check for how many tasks have been entered
        private void CheckForTotalTasks()
        {
            int tasksAmount = ToDoList.Items.Count;
            tasksAmountText.Text = "Amount of tasks: " + tasksAmount;
        }

        //Text updater to check for how many tasks have been completed
        private void CheckForTasksCompleted()
        {
            int completedTasks = ToDoList.CheckedItems.Count;
            tasksCompletedText.Text = "Amount of tasks completed: " + completedTasks;
        }

        //Save to a file
        private void SaveToDoListToFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (object item in ToDoList.Items)
                {
                    taskIndex++;
                    if (ToDoList.GetItemChecked(taskIndex))
                    {
                        writer.WriteLine(item.ToString() + "1");
                    }
                    else
                    {
                        writer.WriteLine(item.ToString() + "0");
                    }
                }
                taskIndex = -1;
            }
        }

        //Load from a file
        private void LoadToDoListFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.EndsWith("1"))
                        {
                            line = line.Remove(line.Length - 1);
                            ToDoList.Items.Add(line, true);
                        }
                        else if (line.EndsWith("0"))
                        {
                            line = line.Remove(line.Length - 1);
                            ToDoList.Items.Add(line);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("File does not exist: " + fileName);
            }
        }

        //-------------------------------------------------------------\\

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
        private void DeleteLastSelected_Click(object sender, EventArgs e)
        {
            if (lastSelected != -1)
            {
                ToDoList.Items.RemoveAt(lastSelected);
                lastSelected = -1;
            }
            UpdateUI();
        }

        //handle what happens when the form initially loads
        private void Form1_Load(object sender, EventArgs e)
        {
            //make save files if they odnt exist
            if (!File.Exists("ToDoListSave1.txt"))
            {
                SaveToDoListToFile("ToDoListSave1.txt");
            }
            if (!File.Exists("ToDoListSave2.txt"))
            {
                SaveToDoListToFile("ToDoListSave2.txt");
            }
            if (!File.Exists("ToDoListSave3.txt"))
            {
                SaveToDoListToFile("ToDoListSave3.txt");
            }
            LoadToDoListFromFile("ToDoListSave1.txt");
            UpdateUI();

        }

        //handle what happens when the form closes
        private void Form1_FormClosing(object sender, EventArgs e)
        {
            SaveToDoListToFile("ToDoListSave" + saveFile + ".txt");
        }

        //save the to do list when the save button is pressed
        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            SaveToDoListToFile("ToDoListSave" + saveFile + ".txt");
            MessageBox.Show("File " + saveFile + " saved.");
        }

        //Load different saves
        private void LoadFile1_Click(object sender, EventArgs e)
        {
            if (saveFile == 1)
            {
                MessageBox.Show("Already in file 1");
            }
            else
            {
                SaveToDoListToFile("ToDoListSave" + saveFile + ".txt");
                ToDoList.Items.Clear();
                saveFile = 1;
                LoadToDoListFromFile("ToDoListSave1.txt");
                UpdateUI();
            }

        }
        private void LoadFile2_Click(object sender, EventArgs e)
        {
            if (saveFile == 2)
            {
                MessageBox.Show("Already in file 2");
            }
            else
            {
                SaveToDoListToFile("ToDoListSave" + saveFile + ".txt");
                ToDoList.Items.Clear();
                saveFile = 2;
                LoadToDoListFromFile("ToDoListSave2.txt");
                UpdateUI();
            }
        }
        private void LoadFile3_Click(object sender, EventArgs e)
        {
            if (saveFile == 3)
            {
                MessageBox.Show("Already in file 3");
            }
            else
            {
                SaveToDoListToFile("ToDoListSave" + saveFile + ".txt");
                ToDoList.Items.Clear();
                saveFile = 3;
                LoadToDoListFromFile("ToDoListSave3.txt");
                UpdateUI();
            }
        }

        
    }
}