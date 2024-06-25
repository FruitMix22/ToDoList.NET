using System;
using System.Windows.Forms;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ToDoList._2
{
    public partial class Form1 : Form
    {
        //Global Vars

        string filePath1 = "SaveFile1.csv";

        //Default

        public Form1()
        {
            InitializeComponent();
        }     //Initialise Form

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadFromFile(filePath1);
        }   //Manage what happens during loading  

        private void Form1_FormClosing(object sender, EventArgs e)
        {
            SaveToFile(filePath1);
        }   //Manage what happens when closing

        //Custom Functions

        private void UpdateUI()
        {

        }   //Update UI , Progress bar, amount of tasks etc...

        private void AddTextToList(string text)
        {
            try
            {
                if (ToDoList.Items.Count >= 10) { throw new InvalidOperationException("Cannot add more than 10 Items to the List"); }
                if (string.IsNullOrWhiteSpace(text)) { throw new ArgumentException("Field entered is empty"); }

                ToDoList.Items.Add(text.Trim());
                InputField.Clear();
                UpdateUI();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }   //Add the entered text into the list

        private void SaveToFile(string filePath)
        {
            try
            {
                if (ToDoList.Items.Count == 0)
                {
                    throw new InvalidOperationException("There is nothing to save");
                }

                using (StreamWriter writer = new StreamWriter(filePath)) { };
                

                for (int i = 0; i < ToDoList.Items.Count; i++)
                {

                    using (StreamWriter writer = new StreamWriter(filePath, append : true))
                    {
                        // Write data
                        writer.WriteLine(ToDoList.Items[i]);
                    }
                }
            }
            catch (InvalidOperationException ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            catch (Exception ex) { throw new Exception("Error while saving data to CSV file: " + ex.Message, ex); }
        }   //Saves to file path specified

        private void LoadFromFile(string filePath) 
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException("The file save at path: " + filePath + " does not exist.");
                }

                if (new FileInfo(filePath).Length <= 0)
                {
                   throw new ArgumentNullException("The file is empty!");
                }

                    using (StreamReader writer = new StreamReader(filePath))
                    {
                        while (!writer.EndOfStream)
                         {
                             string line = writer.ReadLine();
                             ToDoList.Items.Add(line);
                         }
                    }
            }
            catch (FileNotFoundException ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (ArgumentNullException ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            catch (Exception ex) { throw new Exception("Error while loading data to List: " + ex.Message, ex); }
        }

        //Form functions

        private void InputButton_Click(object sender, EventArgs e)
        {
            string InputFieldText = InputField.Text;
            AddTextToList(InputFieldText);
        }   //What happens when the button is clicked next to input field

        private void InputField_Entered(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string InputFieldText = InputField.Text;
                AddTextToList(InputFieldText);
            }
        }   //What happens when enter is clicked when in input field

        private void ToDoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToDoList.ClearSelected();
        }   //What happens when the selected index is changed

        private void button1_Click(object sender, EventArgs e)
        {
            SaveToFile(filePath1);
        }
    }
}
