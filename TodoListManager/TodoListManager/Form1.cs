namespace TodoListManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TextBoxEdit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            string Input = InputField.Text;

            ToDoList.Items.Add(Input);

        }

        private void ToDoList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
