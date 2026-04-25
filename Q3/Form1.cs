using System;
using System.Windows.Forms;

namespace Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddLanguage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a language to remove.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string removed = listBox1.SelectedItem?.ToString() ?? "";
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            label2.Text = $"Removed '{removed}' at {DateTime.Now:dd MMM yyyy HH:mm:ss}";
        }

        private void AddLanguage()
        {
            string input = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please enter a programming language.", "Empty Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var item in listBox1.Items)
            {
                if (item?.ToString()?.Equals(input, StringComparison.OrdinalIgnoreCase) == true)
                {
                    MessageBox.Show($"'{input}' is already in the list.", "Duplicate Entry",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.SelectAll();
                    return;
                }
            }

            listBox1.Items.Add(input);
            label2.Text = $"Added '{input}' at {DateTime.Now:dd MMM yyyy HH:mm:ss}";
            textBox1.Clear();
            textBox1.Focus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}