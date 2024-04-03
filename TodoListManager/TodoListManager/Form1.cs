namespace TodoListManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputField_Entered(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string Input = InputField.Text;
                if (!string.IsNullOrWhiteSpace(Input))
                {
                    ToDoList.Items.Add(Input.Trim());
                    InputField.Clear();
                }
            }
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            string Input = InputField.Text;
            if(!string.IsNullOrWhiteSpace(Input))
            {
                ToDoList.Items.Add(Input.Trim());
                InputField.Clear();
            }
            

        }

        private void ToDoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToDoList.ClearSelected();
        }
    }
}
